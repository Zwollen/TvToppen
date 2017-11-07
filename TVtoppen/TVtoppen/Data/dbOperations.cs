using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TVtoppen.Models.db;

namespace TVtoppen.Data
{
    public class dbOperations
    {
        private TVtoppenEntities db = new TVtoppenEntities();

        public bool CheckUserCredentials(string username, string password)
        {
            var user = db.Person
                .Where(p => p.Username.Equals(username) && p.Password.Equals(password));

            if (user.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsUserInRole(string userName, string roleName)
        {
            var role = db.Person
                 .Where(x => x.Username.Equals(userName))
                 .Include(x => x.Roles).Where(x => x.Roles.Role.Equals(roleName));

            return role.Any();
        }
    }
}