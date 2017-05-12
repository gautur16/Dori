using DoriVLN.Database;
using DoriVLN.Models.Entity;
using DoriVLN.Models;
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
            newUser.email = user.Email;
            newUser.password = user.Password;
            newUser.username = user.Username;

            _uDB.addUserToDB(newUser);
        }

        public string getUserName(string email)
        {
            return _uDB.getLoggedInUserName(email);
        } 
    }
}