using DatabaseApp.Interfaces;

public class SqlDatabaseConnection : IDatabaseConnection
{
    public void Connect()
    {
        Console.WriteLine("Подключение к SQL базе данных...");
    }

    public void Disconnect()
    {
        Console.WriteLine("Отключение от SQL базы данных...");
    }

    public string ExecuteQuery(string query)
    {
        return $"SQL Query executed: {query}";
    }
}
