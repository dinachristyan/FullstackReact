// using System.Security.Cryptography.X509Certificates;
// using Microsoft.AspNetCore.Mvc;
// [Route("api[controller]")]
// [ApiController]
// public class MahasiswaController : ControllerBase
// {
//     private readonly DbManager  _dbManager;
//     Response response = new Response();
//     public MahasiswaController(IConfiguration configuration)
//     {
//         _dbManager = new DbManager(configuration);
//     }

//      //GET: API/mahasiswa 
//     [HttpGet]
//     public IActionResult GetMahasiswas()
//     {
//         try{
//             response.status = 200;
//            response.message = "Success";
//             response.data = _dbManager.GetAllMahasiswas();
//         } catch (Exception ex)
//         {
//             response.status = 500;
//             response.message = ex.Message;
//         } return Ok(response);
//     }
//     [HttpGet("Mahasiswa-By-Nim")]
//     public IActionResult GetIndeksMahasiswaByNim(string mhs_nim)
//     {
//         var IndeksMahasiswaInfo = _dbManager.GetIndeksMahasiswaByNim(mhs_nim);
//         if (IndeksMahasiswaInfo == null)
//         {
//             return NotFound();
//         }
//         return Ok(IndeksMahasiswaInfo);
//     }
//       [HttpPost]
//     public IActionResult CreatePeserta([FromBody] Mahasiswa mahasiswa)
//     {
//         try {
//             response.status = 200;
//             response.message = "Success";
//             _dbManager.CreateMahasiswa(mahasiswa);
//         } catch (Exception ex)
//         {
//             response.status = 500;
//             response.message = ex.Message;
//         }
//         return Ok(response);
//     }
//     [HttpPut("Update-mahasiswa")]
// public IActionResult UpdateMahasiswa(string mhs_nim, Mahasiswa mahasiswa)
// {
    
//     try {
       
//         response.status = 200;
//         response.message = "Success";
//         _dbManager.UpdateMahasiswa(mhs_nim, mahasiswa);
//     } catch (Exception ex) {
//         response.status = 500;
//         response.message = ex.Message;
//     }
//     return Ok(response);
// }
// [HttpDelete("Delete-Mahasiswa")]
// public IActionResult DeletePeserta(string mhs_nim)
// {
    
//     try {
//         _dbManager.DeleteMahasiswa(mhs_nim);
//         response.status = 200;
//         response.message = "Success";
//     } catch (Exception ex) {
//         response.status = 500;
//         response.message = ex.Message;
//     }
//     return Ok(response);
// }
// }