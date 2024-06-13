// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Configuration;
// using System.Data;

// [Route("api/[controller]")]
// [ApiController]

// public class MateriController : ControllerBase
// {
//     private readonly DbManager _dbManager;
//     Response response = new Response();
//     public MateriController(IConfiguration configuration)
//     {
//         _dbManager = new DbManager(configuration);
//     }

//     //GET: api/Materi
//     [HttpGet]
//     public IActionResult GetMateris()
//     {
//         try 
//         {
//             response.status = 200;
//             response.message = "Success";
//             response.data = _dbManager.GetAllMateris();
//         } catch (Exception ex)
//         {
//             response.status = 500;
//             response.message = ex.Message;
//         }
//         return Ok(response);
//     }
//     [HttpPost]
//     public IActionResult CreateMateri([FromBody] Materi Materi)
//     {
//         try {
//             response.status = 200;
//             response.message = "Success";
//             _dbManager.CreateMateris(Materi);
//         } catch (Exception ex)
//         {
//             response.status = 500;
//             response.message = ex.Message;
//         }
//         return Ok(response);
//     }

  

// [HttpPut("{id}")]
// public IActionResult UpdateMateri(int id, [FromBody] Materi Materi)
// {
    
//     try {
       
//         response.status = 200;
//         response.message = "Success";
//         _dbManager.UpdateMateri(id, Materi);
//     } catch (Exception ex) {
//         response.status = 500;
//         response.message = ex.Message;
//     }
//     return Ok(response);
// }

// [HttpDelete("{id}")]
// public IActionResult DeleteMateri(int id)
// {
    
//     try {
//         _dbManager.DeleteMateri(id);
//         response.status = 200;
//         response.message = "Success";
//     } catch (Exception ex) {
//         response.status = 500;
//         response.message = ex.Message;
//     }
//     return Ok(response);
// }

// }