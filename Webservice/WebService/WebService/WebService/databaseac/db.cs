using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WebService.Modelle;

namespace Webservice.databaseac
{
    public class db
    {
        SqlConnection con = new SqlConnection("data source=bsspublic.database.windows.net; Initial catalog=HTW; user id=HTW; Password=u3Q9##X6&I;");
        public void AddFeedback(feedbackPackerModel cs)
        {
           // var query = "insert into *  feedback";
             SqlCommand com = new SqlCommand("f_Cus_Add", con);
      
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@feedbackPacker", cs.feedbackPacker); 
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            
        }
    }
}
