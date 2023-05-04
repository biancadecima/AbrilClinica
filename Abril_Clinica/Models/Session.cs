using Abril_Clinica.Models;
using AbrilClinica.Entities.Database;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Models
{
    public class Session
    {
        public static bool IsAnAdminSession(User user)
        {
            return user.IsAdmin == true;
        }

        public static bool UserExits(string username, List<User> users, out User user)
        {
            user = null!;
            foreach(var u in users)
            {
                if(u.Username == username)
                {
                    user = u;
                    return true;

                }
            }
            return false;
        }

        public static bool IsCorrectPassword(List<User> users, string username, string password)
        {
            foreach (var u in users)
            {
                if (u.Username == username)
                {
                    if (u.Password == password) return true;
                }
            }
            return false;
        }

    }
}
