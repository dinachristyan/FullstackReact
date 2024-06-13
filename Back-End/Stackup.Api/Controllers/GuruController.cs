using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;

[Route("api/[controller]")]
[ApiController]

public class GuruController : ControllerBase
{
    private readonly DbManager _dbManager;
    Response response = new Response();
    public GuruController(IConfiguration configuration)
    {
        _dbManager = new DbManager(configuration);
    }

    //GET: api/Guru
    [HttpGet]
    public IActionResult GetGurus()
    {
        try 
        {
            response.status = 200;
            response.message = "Success";
            response.data = _dbManager.GetAllgurus();
        } catch (Exception ex)
        {
            response.status = 500;
            response.message = ex.Message;
        }
        return Ok(response);
    }
}