using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebService.Modelle;

namespace WebService.databaseac
{
    public class auth
    {
        public string Auth_Add(Login lgn) //anpassen
        {
            SqlConnection con = new SqlConnection("data source=bsspublic.database.windows.net; Initial catalog=HTW; user id=HTW; Password=u3Q9##X6&I;");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from SL_Login where userID='"+ lgn.userID+  "' and userPassword='" + lgn.userPassword +"'", con);
            //cmd.Parameters.AddWithValue("@userID", lgn.userID);
            //cmd.Parameters.AddWithValue("@userPassword", lgn.userPassword);


            SqlDataReader sdr = cmd.ExecuteReader();

           string result="";
                  
           if (sdr.HasRows)
           {
                while(sdr.Read())
                {
                    result = sdr["userrole"].ToString();
                }
                // Auth_Add(lgn);
                return result;
           }
           else
           {
                return "Error";
           }

           

        }
    }
}
