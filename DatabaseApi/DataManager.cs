using DatabaseApp.Interfaces;

public class DataManager
{
    private readonly IDatabaseConnection _databaseConnection;
    private readonly ILogger<DataManager> _logger;

    public DataManager(IDatabaseConnection databaseConnection, ILogger<DataManager> logger)
    {
        _databaseConnection = databaseConnection;
        _logger = logger;
    }

    public void ExecuteDatabaseQuery(string query)
    {
        _logger.LogInformation("Начало выполнения запроса...");
        _databaseConnection.Connect();
        _logger.LogInformation(_databaseConnection.ExecuteQuery(query));
        _databaseConnection.Disconnect();
        _logger.LogInformation("Запрос выполнен.");
    }
}
