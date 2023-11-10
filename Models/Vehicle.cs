using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace ThreeCee.Models;

public class Vehicle
{
    public enum EFuelType
    {
        Gasoline, // Benzin
        Diesel,
        Electric
    }

    public string FuelTypeString() => FuelType switch
    {
        EFuelType.Gasoline => "Benzin",
        EFuelType.Diesel => "Diesel",
        EFuelType.Electric => "Elektrisch",
        _ => throw new ArgumentOutOfRangeException(nameof(FuelType), FuelType, null)
    };

    public string StatusString() => Status switch
    {
        EStatus.Bought => "gekauft",
        EStatus.Leased => "geleast",
        _ => throw new ArgumentOutOfRangeException(nameof(Status), Status, null)
    };

    public enum EStatus
    {
        Bought, // gekauft
        Leased, // geleast
    }

    public int Id;
    public string Model;
    public string Name;
    public EStatus Status;
    public EFuelType FuelType;
    public string Function;
    public float FuelConsumptionLPerKm;
    public float KilometersDriven;

    // Bsp.: Volkswagen T6 Transporter, Diesel, geleast von [Leasing-Unternehmen], Lieferung
    private Vehicle(
        string model,
        string name,
        EStatus status,
        EFuelType fuelType,
        string function,
        float fuelConsumptionLPerKm,
        float kilometersDriven
    )
    {
        Model = model;
        Name = name;
        Status = status;
        FuelType = fuelType;
        Function = function;
        FuelConsumptionLPerKm = fuelConsumptionLPerKm;
        KilometersDriven = kilometersDriven;
    }

    public static List<Vehicle> GetDummyVehicles() =>
        new List<Vehicle>
        {
            new Vehicle(
                model: "VW T6 Transporter",
                name: "Lieferwagen 1",
                status: EStatus.Bought,
                function: "Lieferung",
                fuelType: EFuelType.Gasoline,
                fuelConsumptionLPerKm: 0.07f,
                kilometersDriven: 86000f
            ),
            new Vehicle(
                model: "VW T6 Transporter",
                name: "Lieferwagen 2",
                status: EStatus.Leased,
                function: "Lieferung",
                fuelType: EFuelType.Gasoline,
                fuelConsumptionLPerKm: 0.07f,
                kilometersDriven: 55000f
            )
        };


    public SQLiteCommand ToSqliteInsertCommand(
        SQLiteConnection connection,
        string dbName
        )
    {
        var command = new SQLiteCommand(
            @$"INSERT INTO {dbName} (
                    Model,
                    Name,
                    Status,
                    FuelType,
                    Function,
                    FuelConsumptionLPerKm,
                    KilometersDriven
            ) 
            VALUES (
                    @Model,
                    @Name,
                    @Status,
                    @FuelType,
                    @Function,
                    @FuelConsumptionLPerKm,
                    @KilometersDriven
            ); 
            SELECT last_insert_rowid();",
            connection
        );
        command.Parameters.AddWithValue("@Model", Model);
        command.Parameters.AddWithValue("@Name", Name);
        command.Parameters.AddWithValue("@Status", Status);
        command.Parameters.AddWithValue("@FuelType", FuelType.ToString());
        command.Parameters.AddWithValue("@Function", Function);
        command.Parameters.AddWithValue("@FuelConsumptionLPerKm", FuelConsumptionLPerKm);
        command.Parameters.AddWithValue("@KilometersDriven", KilometersDriven);

        return command;
    }

    public static Vehicle FromSqliteReader(SQLiteDataReader reader)
    {
        for (int i = 1; i < 7; i++)
        {
            Console.WriteLine(i + ": " + reader.GetValue(i));
        }
        return new Vehicle(
            name: reader.GetString(2),
            status: (EStatus)Enum.Parse(typeof(EStatus), reader.GetString(3)),
            model: reader.GetString(1),
            function: reader.GetString(5),
            fuelConsumptionLPerKm: reader.GetFloat(6),
            fuelType: (EFuelType)Enum.Parse(typeof(EFuelType), reader.GetString(4)),
            kilometersDriven: reader.GetFloat(7)
        )
        {
            Id = reader.GetInt32(0)
        };
    }
}