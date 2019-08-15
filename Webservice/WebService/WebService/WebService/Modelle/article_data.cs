using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Modelle
{
    public class article_data
    {
        public string articleId { get; set; }
        public string articleName { get; set; }
        public string articleAmount { get; set; }
        public string articleUnitOfMeasure { get; set; }
        public string articleLocation { get; set; }
        public string articleShelfNumber { get; set; }
        public string freightOrderId { get; set; }
    }

    public class createarticledata : article_data
    {

    }
    public class readarticle_data : article_data
    {
   
        
            public readarticle_data()
            {
            }

            public readarticle_data(DataRow row)
            {
                // to convert for reading 

                articleId = row["articleId"].ToString();
                articleName = row["articleName"].ToString();
                articleAmount = row["articleAmount"].ToString();
                articleUnitOfMeasure = row["articleUnitOfMeasure"].ToString();
                articleLocation = row["articleLocation"].ToString();
                articleShelfNumber = row["articleShelfNumber"].ToString();
                freightOrderId = row["freightOrderId"].ToString();
               



            }
            //        public int Id { get; set; }

            public string articleId { get; set; }
            public string articleName { get; set; }
            public string articleAmount { get; set; }
            public string articleUnitOfMeasure { get; set; }
            public string articleLocation { get; set; }
            public string articleShelfNumber { get; set; }
            public string freightOrderId { get; set; }
        }
    
}
