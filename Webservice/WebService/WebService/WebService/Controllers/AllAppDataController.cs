using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebService.databaseac;
using WebService.Modelle;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllAppDataController : ControllerBase
    {
      

        // POST: api/AllAppData
        [HttpPost]
        public string Post([FromBody] readUserData enddata)
        {

            endpost e_endpost = new endpost();

            try
            {
                return e_endpost.endpost_Add(enddata);
                //return "Success";
            }

            catch
            {
                return "Error";
            }
        }

     
    }
}
