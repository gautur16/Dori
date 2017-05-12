using DoriVLN.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoriVLN.Database
{
    public class UserDatabase: BaseDatabase
    {
        public void addUserToDB(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public string getLoggedInUserName(string email)
        {
            var result = _db.Users.SingleOrDefault(u => u.email == email);

            return result.username;
        } 
    }
}