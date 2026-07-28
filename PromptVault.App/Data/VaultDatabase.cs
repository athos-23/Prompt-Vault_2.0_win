using Microsoft.Data.Sqlite;
using PromptVault.App.Models;

namespace PromptVault.App.Data;

public class VaultDatabase
{
    private readonly string connectionString =
        "Data Source=vault.db";


    public VaultDatabase()
    {
        CreateDatabase();
    }


    private void CreateDatabase()
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        var command = connection.CreateCommand();

        command.CommandText =
        """
        CREATE TABLE IF NOT EXISTS Prompts
        (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Title TEXT,
            Project TEXT,
            Tags TEXT,
            Content TEXT,
            Color TEXT,
            CreatedAt TEXT,
            UpdatedAt TEXT
        );
        """;

        command.ExecuteNonQuery();
    }
}
