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
        /// <summary>
        /// Verify that the user is an administrator
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool IsAnAdminSession(User user)
        {
            return user.IsAdmin == true;
        }

        /// <summary>
        /// Verify that the user exists
        /// </summary>
        /// <param name="username"></param>
        /// <param name="users"></param>
        /// <param name="user"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Verifies that the user agrees with the password entered
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsCorrectPassword(User user, string password)
        {
             if (user.Password == password) return true;
            return false;
        }

    }
}
