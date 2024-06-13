// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Configuration;
// using System.Data;

// [Route("api/[controller]")]
// [ApiController]

// public class PesertaController : ControllerBase
// {
//     private readonly DbManager _dbManager;
//     Response response = new Response();
//     public PesertaController(IConfiguration configuration)
//     {
//         _dbManager = new DbManager(configuration);
//     }

//     //GET: api/Peserta
//     [HttpGet]
//     public IActionResult GetPesertas()
//     {
//         try 
//         {
//             response.status = 200;
//             response.message = "Success";
//             response.data = _dbManager.GetAllPesertas();
//         } catch (Exception ex)
//         {
//             response.status = 500;
//             response.message = ex.Message;
//         }
//         return Ok(response);
//     }
//     [HttpPost]
//     public IActionResult CreatePeserta([FromBody] Peserta Peserta)
//     {
//         try {
//             response.status = 200;
//             response.message = "Success";
//             _dbManager.CreatePeserta(Peserta);
//         } catch (Exception ex)
//         {
//             response.status = 500;
//             response.message = ex.Message;
//         }
//         return Ok(response);
//     }

  

// [HttpPut("{id}")]
// public IActionResult UpdatePeserta(int id, [FromBody] Peserta Peserta)
// {
    
//     try {
       
//         response.status = 200;
//         response.message = "Success";
//         _dbManager.UpdatePeserta(id, Peserta);
//     } catch (Exception ex) {
//         response.status = 500;
//         response.message = ex.Message;
//     }
//     return Ok(response);
// }

// [HttpDelete("{id}")]
// public IActionResult DeletePeserta(int id)
// {
    
//     try {
//         _dbManager.DeletePeserta(id);
//         response.status = 200;
//         response.message = "Success";
//     } catch (Exception ex) {
//         response.status = 500;
//         response.message = ex.Message;
//     }
//     return Ok(response);
// }

// }