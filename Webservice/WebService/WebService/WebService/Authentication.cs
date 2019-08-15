
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auth;

namespace WebService
{
    public class Authentication
    {
        public static bool Login(string userId, string userPw)
        {
            using (AppDataEntities entities =new AppDataEntities())
            {
                return entities.UData2.Any(u => u.UserId.Equals(userId) && u.Passwrd == userPw);
            }
        }
    }
}
