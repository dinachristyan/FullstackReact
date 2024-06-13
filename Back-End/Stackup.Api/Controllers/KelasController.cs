using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;

[Route("api/[controller]")]
[ApiController]

public class KelasController : ControllerBase
{
    private readonly DbManager _dbManager;
    Response response = new Response();
    public KelasController(IConfiguration configuration)
    {
        _dbManager = new DbManager(configuration);
    }

    //GET: api/Kelas
    [HttpGet]
    public IActionResult GetKelass()
    {
        try 
        {
            response.status = 200;
            response.message = "Success";
            response.data = _dbManager.GetAllKelas();
        } catch (Exception ex)
        {
            response.status = 500;
            response.message = ex.Message;
        }
        return Ok(response);
    }
}