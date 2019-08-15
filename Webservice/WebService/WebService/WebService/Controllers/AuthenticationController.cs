using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebService.Modelle;
using Webservice.databaseac;
using WebService.databaseac;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        // GET: api/Authentication
       /* [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Authentication/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST: api/Authentication
        [HttpPost]
        public string Post([FromBody] Login lgn)
        {
            auth a_run = new auth();

            try
            {
                return a_run.Auth_Add(lgn);
                //return "Success";
            }

            catch
            {
                return "Error";
            }
        }

    }
}
