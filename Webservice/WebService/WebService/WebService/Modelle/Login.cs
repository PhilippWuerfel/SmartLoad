using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Modelle
{
    public class Login
    {
     public enum Userrole
     {
            DRIVER,
            PACKER,
            NONE
     }

        public string userID { get; set; }
        public string userPassword { get; set; }

        public string userrole { get; set; }


    }
}
