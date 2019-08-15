using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webservice.databaseac;
using WebService.Modelle;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedBackController : ControllerBase
    {
       

        // POST: api/FeedBack
        [HttpPost]
        public string Post([FromBody] feedbackPackerModel cs)
        {

           db dblyer = new db();


            
            try
            {

                dblyer.AddFeedback(cs);
                return "Success";
            }
            catch (Exception)
            {
                return "Something went wrong";
            }

        }

        // PUT: api/FeedBack/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
