using Microsoft.AspNetCore.Mvc;



[Route("api/database")]
[ApiController]
public class DatabaseController : ControllerBase
{
    private readonly DataManager _dataManager;

    public DatabaseController(DataManager dataManager)
    {
        _dataManager = dataManager;
    }

    [HttpGet("execute")]
    public IActionResult ExecuteQuery([FromQuery] string query)
    {
        _dataManager.ExecuteDatabaseQuery(query);
        return Ok("Запрос выполнен.");
    }
}