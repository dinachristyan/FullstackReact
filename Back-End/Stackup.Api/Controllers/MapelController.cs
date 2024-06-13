using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;

[Route("api/[controller]")]
[ApiController]

public class MapelController : ControllerBase
{
    private readonly DbManager _dbManager;
    Response response = new Response();
    public MapelController(IConfiguration configuration)
    {
        _dbManager = new DbManager(configuration);
    }

    //GET: api/Mapel
    [HttpGet]
    public IActionResult GetMapels()
    {
        try 
        {
            response.status = 200;
            response.message = "Success";
            response.data = _dbManager.GetAllMapel();
        } catch (Exception ex)
        {
            response.status = 500;
            response.message = ex.Message;
        }
        return Ok(response);
    }
}