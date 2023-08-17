using Npgsql;

class Program
{
    static void Main(string[] args)
    {
        string connString = "Host=db;Port=5432;Username=user;Password=pass;Database=mydatabase;";

        using var conn = new NpgsqlConnection(connString);
        conn.Open();

        using var createTableCmd = new NpgsqlCommand(
            "CREATE TABLE IF NOT EXISTS Person (Id SERIAL PRIMARY KEY, Name TEXT, Age INT)",
            conn);
        createTableCmd.ExecuteNonQuery();

        using var insertCmd = new NpgsqlCommand(
            "INSERT INTO Person (Name, Age) VALUES (@name, @age)",
            conn);
        insertCmd.Parameters.AddWithValue("name", "John Doe");
        insertCmd.Parameters.AddWithValue("age", 30);
        insertCmd.ExecuteNonQuery();

        using var selectCmd = new NpgsqlCommand(
            "SELECT Id, Name, Age FROM Person",
            conn);

        using var reader = selectCmd.ExecuteReader();
        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string name = reader.GetString(1);
            int age = reader.GetInt32(2);
            Console.WriteLine($"Person ID: {id}, Name: {name}, Age: {age}");
        }
    }
}
