using DoriVLN.Database;
using DoriVLN.Models.Entity;
using DoriVLN.Models.ViewModels;
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
        public void addUser(RegisterViewModel user)
        {
            User newUser = new User();
            newUser.name = user.name;
            newUser.email = user.email;
            newUser.password = user.password;
            newUser.username = user.username;

            _uDB.addUserToDB(newUser);
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