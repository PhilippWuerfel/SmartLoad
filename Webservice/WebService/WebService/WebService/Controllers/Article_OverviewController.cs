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
    public class Article_OverviewController : ControllerBase
    {
        
      

        // POST: api/Article_Overview
        [HttpPost]
        public IEnumerable<article_data> Post([FromBody] /*readarticle_data f_data*/ readarticle_data aa_data)
        {
            article_freight o_data = new article_freight();
            try
            {
                return article_freight.articleAddd(aa_data);
            }
        
            catch
            {
                return null;
            }
        }

     
    }
}
