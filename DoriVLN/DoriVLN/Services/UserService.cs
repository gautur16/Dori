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
            
            return _uDB.usernameExistsInDB(user);
        }

        public bool emailExists(User user)
        {
            return _uDB.emailExistsInDB(user);
        }

        public void resetPassword(User user)
        {
            //TODO: Implement
        }
    }
}