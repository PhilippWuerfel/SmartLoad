using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebService.Modelle;

namespace WebService.databaseac
{
    public class freightOrderStatus
    {
        public string statusAdd(readUserData status)
        {
            SqlConnection con = new SqlConnection("data source=bsspublic.database.windows.net; Initial catalog=HTW; user id=HTW; Password=u3Q9##X6&I;");
            con.Open();

            string Query = "update dbo.SmartLoadAppData set freightOrderId='" + status.freightOrderId + "',freightOrderStatus='" + status.freightOrderStatus + "',userId='" + status.userId + "',timestamp='" + status.timestamp + "' where freightOrderId='" + status.freightOrderId + "';";

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




        }
    }
}
