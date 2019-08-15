using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Modelle
{
    public class Customer
    {
        public string CustNo { get; set; }
        public string CustomerName { get; set; }
        public string Adress { get; set; }

      
    }
    public class readCustomer : Customer
    {
        public readCustomer(DataRow row)
        {
            CustNo= row["CustNo"].ToString();

        }
    }
}
