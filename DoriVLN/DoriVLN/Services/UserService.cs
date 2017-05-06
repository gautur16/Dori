using DoriVLN.Database;
using DoriVLN.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoriVLN.Services
{
    public class UserService
    {
        private UserDatabase _uDB;

        public UserService()
        {
            _uDB = new UserDatabase();
        }
        public void addUser(User user)
        {
            _uDB.addUserToDB(user);
        }

        public bool usernameExists(User user)
        {
            
            return false;
        }

        public bool emailExists(User user)
        {
            return false;
        }

        public void resetPassword(User user)
        {
            //TODO: Implement
        }
    }
}