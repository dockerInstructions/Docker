using Npgsql;

string connString = "Host=db;Port=5432;Username=user;Password=pass;Database=mydatabase;";

using var conn = new NpgsqlConnection(connString);
conn.Open();

using var cmd = new NpgsqlCommand("SELECT version()", conn);
var version = cmd.ExecuteScalar().ToString();
Console.WriteLine($"Connected to PostgreSQL: {version}");