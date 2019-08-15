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
    public class FreightOrderStatusController : ControllerBase
    {
       

        // POST: api/FreightOrderStatus
        [HttpPost]
        public string Post([FromBody] readUserData status)
        {
            freightOrderStatus e_status = new freightOrderStatus();

            try
            {
                return e_status.statusAdd(status);
                //return "Success";
            }

            catch
            {
                return "Error";
            }
        }

     
    }
}
