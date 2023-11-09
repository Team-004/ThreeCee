using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace ThreeCee.Infrastructure;

internal class Db : IDisposable
{
    // Create a connection string
    public readonly SQLiteConnection Connection;


    public void Execute(string sqlCommand)
    {
        //Console.WriteLine(sqlCommand);
        new SQLiteCommand(sqlCommand, Connection).ExecuteNonQuery();
    }

    public Db(string path)
    {
        Connection = new SQLiteConnection(path);
        Connection.Open();

    }
        
    public List<T> GetAllEntries<T>(string tableName, Func<SQLiteDataReader, T> entryFunc)
    {
        using var command = new SQLiteCommand(
            $"SELECT * FROM {tableName}",
            Connection);

        using var reader = command.ExecuteReader();

        var result = new List<T>();
        while (reader.Read())
        {
            result.Add(entryFunc(reader));
        }

        return result;
    }

    public T GetById<T>(
        string tableName,
        int rowId,
        Func<SQLiteDataReader, T> entryFunc
    )
    {
        using var command = new SQLiteCommand(
            $"SELECT * FROM {tableName} WHERE Id = @Id",
            Connection
        );
        command.Parameters.AddWithValue("@Id", rowId);

        using var reader = command.ExecuteReader();
        return entryFunc(reader);
    }

    public void DeleteEntry(string tableName, int rowId)
    {
        using var command = new SQLiteCommand(
            $"DELETE FROM {tableName} WHERE Id = @Id", Connection
        );
        command.Parameters.AddWithValue("@Id", rowId);
        command.ExecuteNonQuery();
    }

    public void DeleteAllEntries(string tableName)
    {
        using var command = new SQLiteCommand($"DELETE FROM {tableName}", Connection);
        command.ExecuteNonQuery();
    }

    public void Dispose()
    {
        Connection.Dispose();
    }
}