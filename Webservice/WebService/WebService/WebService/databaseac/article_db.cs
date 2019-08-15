using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebService.Modelle;

namespace WebService.databaseac
{
    public class article_db
    {

        public IEnumerable<article_data> articleAdd(article_db a_data)
        {
            SqlConnection connection = new SqlConnection("data source=bsspublic.database.windows.net; Initial catalog=HTW; user id=HTW; Password=u3Q9##X6&I;");
            DataTable _dt = new DataTable();
            string query = "select * from ArticleOverview";
            SqlDataAdapter adapter2 = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand(query, connection)
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

        }
    }
}
