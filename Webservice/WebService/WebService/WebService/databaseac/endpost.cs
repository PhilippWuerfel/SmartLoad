using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebService.Modelle;

namespace WebService.databaseac
{
    public class endpost
    {
        public string endpost_Add(readUserData enddata)
        {
            SqlConnection con = new SqlConnection("data source=bsspublic.database.windows.net; Initial catalog=HTW; user id=HTW; Password=u3Q9##X6&I;");
            con.Open();

            string Query = "update dbo.SmartLoadAppData set companyName='" + enddata.companyName + "',description='" + enddata.description + "',freightOrderStatus='" + enddata.freightOrderStatus + "',timestamp='" + enddata.timestamp + "', postalCode='"+enddata.postalCode+"', country='"+enddata.country+"',city='"+enddata.city+"',streetName='"+enddata.streetName+"',streetNumber='"+enddata.streetNumber+"',signatureTagPacker='"+enddata.signatureTagPacker+"',feedbackPacker='"+enddata.feedbackPacker+"',photoTagsPacker='"+enddata.photoTagsPacker+"',signatureTagDriver='"+enddata.signatureTagDriver+"',feedbackDriver='"+enddata.feedbackDriver+"',photoTagsDriver='"+enddata.photoTagsDriver+"',userId='"+enddata.userId+ "' where freightOrderId='" + enddata.freightOrderId + "';";

            try
            {
              
                SqlCommand com = new SqlCommand(Query, con);
                com.ExecuteNonQuery();
                return "Success";
            }


            catch
            {
                return "Error";
            }


           // return "s";
        }
    }
}
