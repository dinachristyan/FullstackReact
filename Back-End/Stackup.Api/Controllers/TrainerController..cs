// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Configuration;
// using System.Data;

// [Route("api/[controller]")]
// [ApiController]

// public class TrainerController : ControllerBase
// {
//     private readonly DbManager _dbManager;
//     Response response = new Response();
//     public TrainerController(IConfiguration configuration)
//     {
//         _dbManager = new DbManager(configuration);
//     }

//     //GET: api/Trainer
//     [HttpGet]
//     public IActionResult GetTrainers()
//     {
//         try 
//         {
//             response.status = 200;
//             response.message = "Success";
//             response.data = _dbManager.GetAllTrainer();
//         } catch (Exception ex)
//         {
//             response.status = 500;
//             response.message = ex.Message;
//         }
//         return Ok(response);
//     }
// [HttpGet("Trainer-by-Id")]
//     public IActionResult GetIndeksTrainerById(int id)
//     {
//         var indeksTrainerList = _dbManager.GetIndeksTrainerById(id);
//         if (indeksTrainerList == null)
//         {
//             return NotFound();
//         }
//         return Ok(indeksTrainerList);
//     }
// [HttpPost]
//     public IActionResult CreateTrainer([FromBody] Trainer trainer)
//     {
//         try {
//             response.status = 200;
//             response.message = "Success";
//             _dbManager.CreateTrainer(trainer);
//         } catch (Exception ex)
//         {
//             response.status = 500;
//             response.message = ex.Message;
//         }
//         return Ok(response);
//     }
//     [HttpPut("Update-trainer")]
// public IActionResult UpdateTrainer(int id, Trainer trainer)
// {
    
//     try {
       
//         response.status = 200;
//         response.message = "Success";
//         _dbManager.UpdateTrainer(id, trainer);
//     } catch (Exception ex) {
//         response.status = 500;
//         response.message = ex.Message;
//     }
//     return Ok(response);
// }
// [HttpDelete("Delete-Trainer")]
// public IActionResult DeleteTrainer(int id)
// {
    
//     try {
//         _dbManager.DeleteTrainer(id);
//         response.status = 200;
//         response.message = "Success";
//     } catch (Exception ex) {
//         response.status = 500;
//         response.message = ex.Message;
//     }
//     return Ok(response);
// }
// }