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


    public List<Prompt> GetPrompts()
    {
        var prompts = new List<Prompt>();

        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        var command = connection.CreateCommand();

        command.CommandText =
        "SELECT * FROM Prompts ORDER BY UpdatedAt DESC";


        using var reader = command.ExecuteReader();


        while (reader.Read())
        {
            prompts.Add(new Prompt
            {
                Id = reader.GetInt32(0),
                Title = reader.GetString(1),
                Project = reader.GetString(2),
                Tags = reader.GetString(3),
                Content = reader.GetString(4),
                Color = reader.GetString(5),
                CreatedAt = DateTime.Parse(reader.GetString(6)),
                UpdatedAt = DateTime.Parse(reader.GetString(7))
            });
        }


        return prompts;
    }


    public void AddPrompt(Prompt prompt)
    {
        using var connection = new SqliteConnection(connectionString);
        connection.Open();

        var command = connection.CreateCommand();

        command.CommandText =
        """
        INSERT INTO Prompts
        (Title, Project, Tags, Content, Color, CreatedAt, UpdatedAt)
        VALUES
        ($title,$project,$tags,$content,$color,$created,$updated);
        """;


        command.Parameters.AddWithValue("$title", prompt.Title);
        command.Parameters.AddWithValue("$project", prompt.Project);
        command.Parameters.AddWithValue("$tags", prompt.Tags);
        command.Parameters.AddWithValue("$content", prompt.Content);
        command.Parameters.AddWithValue("$color", prompt.Color);
        command.Parameters.AddWithValue("$created", prompt.CreatedAt);
        command.Parameters.AddWithValue("$updated", prompt.UpdatedAt);


        command.ExecuteNonQuery();
    }
}
