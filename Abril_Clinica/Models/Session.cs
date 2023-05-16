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

        public static bool UserExists(string username, List<User> users, out User user)
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

        public static bool IsCorrectPassword(User user, string password)
        {
             if (user.Password == password) return true;
            return false;
        }

    }
}
