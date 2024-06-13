// using System.Security.Cryptography.X509Certificates;
// using Microsoft.AspNetCore.Mvc;
// [Route("api[controller]")]
// [ApiController]
// public class NilaiController : ControllerBase
// {
//     private readonly DbManager  _dbManager;
//     Response response = new Response();
//     public NilaiController(IConfiguration configuration)
//     {
//         _dbManager = new DbManager(configuration);
//     }

//     //GET: API/nilai 
//     [HttpGet]
//     public IActionResult GetNilai()
//     {
//         try{
//             response.status = 200;
//            response.message = "Success";
//             response.data = _dbManager.GetAllNilai();
//         } catch (Exception ex)
//         {
//             response.status = 500;
//             response.message = ex.Message;
//         } return Ok(response);
//     }
  


//     // /POST: API/nilai
//     [HttpPost]
//     public IActionResult CreateNilai([FromBody] Nilai nilai)
//     {
//         try {
//             response.status = 200;
//             response.message = "Success";
//             if (_dbManager.GetNilai(nilai) == 1)
//             {
//                 _dbManager.UpdateNilai(nilai);
//             } else {
//                 _dbManager.CreateNilai(nilai);
//             }
           
//         } catch (Exception ex)
//         {
//             response.status = 500;
//             response.message = ex.Message;
//         } return Ok(response);
//     }
// [HttpGet("indeks-by-materi/{materiId}")]
//     public IActionResult GetIndeksNilaiByMateri(int materiId)
//     {
//         var indeksNilaiList = _dbManager.GetIndeksNilaiByMateri(materiId);
//         if (indeksNilaiList == null)
//         {
//             return NotFound();
//         }
//         return Ok(indeksNilaiList);
//     }


//    [HttpGet("indeks-by-peserta/{pesertaId}")]
//     public IActionResult GetIndeksNilaiByPeserta(int pesertaId)
//     {
//         var indeksNilaiList = _dbManager.GetIndeksNilaiByPeserta(pesertaId);
//         if (indeksNilaiList == null)
//         {
//             return NotFound();
//         }
//         return Ok(indeksNilaiList);
//     }
// }