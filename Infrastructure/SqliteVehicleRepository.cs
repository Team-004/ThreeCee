using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SQLite;
using ThreeCee.Models;
using System.Diagnostics;

namespace ThreeCee.Infrastructure;

internal class SqliteVehicleRepository : IRepository<Vehicle>
{
    private readonly Db _db;
    private readonly string _dbName;

    private readonly Action? _onUpdate;

    public SqliteVehicleRepository(string dbName, Action? onUpdate = null)
    {
        _onUpdate = onUpdate;
        _dbName = "vehicles";
        CreateDirectoryIfNotExists(dbName);
        _db = new Db(dbName);
        CreateDatabaseIfNotExists();
    }


    private static void CreateDirectoryIfNotExists(string dbName)
    {
        Directory.CreateDirectory(dbName
            .Replace(";", "")
            .Split('=')[1]
            .Split('/')
            .SkipLast(1)
            .JoinToString("/")
        );
    }

    private void CreateDatabaseIfNotExists()
    {
        _db.Execute(
            $@"CREATE TABLE IF NOT EXISTS {_dbName} (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Model TEXT NOT NULL,
                    Name TEXT NOT NULL,
                    Status TEXT NOT NULL,
                    FuelType TEXT NOT NULL,
                    Function TEXT NOT NULL,
                    FuelConsumptionLPerKm REAL NOT NULL,
                    KilometersDriven REAL NOT NULL
                )"
        );
    }

    public int Add(Vehicle vehicle)
    {
        var result = Convert.ToInt32(
            vehicle.ToSqliteInsertCommand(
                _db.Connection,
                _dbName
            ).ExecuteScalar()
        );
        _onUpdate?.Invoke();
        return result;
    }

    public List<Vehicle> GetAll() => _db.GetAllEntries(
        tableName: _dbName,
        entryFunc: Vehicle.FromSqliteReader
    );

    public Vehicle GetById(int id)
    {
        return _db.GetById(_dbName, id, Vehicle.FromSqliteReader);
    }

    public void Update(Vehicle updatedVehicle)
    {
        using var command = new SQLiteCommand(
            @$"UPDATE {_dbName} 
                    SET Name = @Name,
                                Model = @Model,
                                Status = @Status,
                                FuelType = @FuelType,
                                Function = @Function,
                                FuelConsumptionLPerKm = @FuelConsumptionLPerKm,
                                KilometersDriven = @KilometersDriven
                    WHERE Id = @Id",
            _db.Connection);
        command.Parameters.AddWithValue("@Name", updatedVehicle.Name);
        command.Parameters.AddWithValue("@Model", updatedVehicle.Model);
        command.Parameters.AddWithValue("@Status", updatedVehicle.Status);
        command.Parameters.AddWithValue("@FuelType", updatedVehicle.FuelType);
        command.Parameters.AddWithValue("@Function", updatedVehicle.Function);
        command.Parameters.AddWithValue("@FuelConsumptionLPerKm", updatedVehicle.FuelConsumptionLPerKm);
        command.Parameters.AddWithValue("@KilometersDriven", updatedVehicle.KilometersDriven);
        command.Parameters.AddWithValue("@Id", updatedVehicle.Id);

        Debug.WriteLine(command.CommandText);

        command.ExecuteNonQuery();
        _onUpdate?.Invoke();
    }

    public void Delete(int vehicleId)
    {
        _db.DeleteEntry(_dbName, vehicleId);
        _onUpdate?.Invoke();
    }

    public void DeleteAll()
    {
        _db.DeleteAllEntries(tableName: _dbName);
        _onUpdate?.Invoke();
    }
}