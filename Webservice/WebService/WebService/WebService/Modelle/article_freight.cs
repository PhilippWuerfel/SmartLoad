using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Modelle
{
    public class article_freight
    {
        public static IEnumerable<article_data> articleAddd(readarticle_data f_data) //anpassen
        {
            SqlConnection con = new SqlConnection("data source=bsspublic.database.windows.net; Initial catalog=HTW; user id=HTW; Password=u3Q9##X6&I;");
            con.Open();
            DataTable _dt = new DataTable();
            //SqlCommand cmd = new SqlCommand("select * from ArticleOverview where freightOrderId='" + f_data.freightOrderId + "'", con);
            //cmd.Parameters.AddWithValue("@userID", lgn.userID);
            //cmd.Parameters.AddWithValue("@userPassword", lgn.userPassword);
            string cmd = "select * from ArticleOverview where freightOrderId='" + f_data.freightOrderId + "'";
            SqlDataAdapter adapter2 = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand(cmd, con)
            };
            adapter2.Fill(_dt);

            List<article_data> aa_data = new List<article_data>(_dt.Rows.Count);
            if (_dt.Rows.Count > 0)
            {
                foreach (DataRow articlerecord in _dt.Rows)
                {
                    aa_data.Add(new readarticle_data(articlerecord));
                }
            }
            return aa_data;


            /* SqlDataReader sdr = cmd.ExecuteReader();

             string result = "";

             if (sdr.HasRows)
             {
                 while (sdr.Read())
                 {
                     result = sdr["freightOrderId"].ToString();
                 }
                 // Auth_Add(lgn);
                 return result;
             }
             else
             {
                 return "Error";
             }
             */
        }
    }
}
