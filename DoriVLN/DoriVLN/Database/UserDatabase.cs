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

        public bool emailExistsInDB(User user)
        {
            var retUser = _db.Users.SingleOrDefault(u => u.email == user.email);
            if(retUser != null)
            {
                return true;
            }
            return false;
        }

        public bool usernameExistsInDB(User user)
        {
            var retUser = _db.Users.SingleOrDefault(u => u.username == user.username);

            if(retUser != null)
            {
                return true;
            } 
            return false;
        }

        public void resetPasswordInDB(User user, string newPassword)
        {
            var retUser = _db.Users.SingleOrDefault(u => u.ID == user.ID);
            if(retUser != null)
            {
                retUser.password = newPassword;
                _db.SaveChanges();
            }

        }

        public bool wrongPassword(User user)
        {
            var retUser = _db.Users.SingleOrDefault(u => u.username == user.username);
            if(retUser != null)
            {
                if(retUser.password != user.password)
                {
                    return true;
                }

                return false;
            }

            return true;

        }
    }
}