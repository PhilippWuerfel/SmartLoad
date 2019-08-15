using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.IO;
using WebService.Modelle;

namespace WebService.Controllers
{
    [Route("api/Photoupload")]

    public class PhotoUploadController : Controller
    {
        
      [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            try
            {
               
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", file.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    await file.CopyToAsync(stream);
                    stream.Close(); 
                    return Ok(new { length = file.Length, name = file.FileName });

                    

                }
               
            }
            catch
            {
                return BadRequest();
            }


        }
        
            
        
    }
}