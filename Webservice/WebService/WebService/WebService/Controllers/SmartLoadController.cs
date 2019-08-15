using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webservice.databaseac;
using WebService.databaseac;
using WebService.Modelle;

namespace WebService.Controllers
{
    [Route("api/FreightOrders")]
    [ApiController]
    public class SmartLoadController : ControllerBase
    {
        // GET: api/FreightOrders
        //declare sql connection and command objects there

        private SqlConnection _conn;
        private SqlDataAdapter _adapter;

        [HttpGet]
        public IEnumerable<UserData> Get()
        {
            _conn = new SqlConnection("data source=bsspublic.database.windows.net; Initial catalog=HTW; user id=HTW; Password=u3Q9##X6&I;");
           // _conn = new SqlConnection("Server = tcp:bsspublic.database.windows.net, 1433; Initial Catalog = HTW; Persist Security Info = False; User ID = { HTW }; Password ={ u3Q9##X6&I};");
            DataTable _dt = new DataTable();
            var query = "select * from SmartLoadAppData";
            _adapter = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand(query, _conn)
            };
            _adapter.Fill(_dt);

            List<UserData> users = new List<Modelle.UserData>(_dt.Rows.Count);
            if (_dt.Rows.Count > 0)
            {
                foreach(DataRow userrecord in _dt.Rows)
                {
                    users.Add(new readUserData(userrecord));
                }
            }
            return users;
        }

       

      

     
        // POST: api/...
        [HttpPost]
        public string Post([FromBody] string value)
        {
           
                return "Not implemented method";
           

        }

       
        // PUT: api/SmartLoad/5
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
