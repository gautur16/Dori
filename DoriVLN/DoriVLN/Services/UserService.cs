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

        public bool usernameExists(RegisterViewModel user)
        {
            User checkUser = new User();

            checkUser.username = user.username;
            
            return _uDB.usernameExistsInDB(checkUser);
        }

        public bool emailExists(RegisterViewModel user)
        {
            User checkUser = new User();

            checkUser.email = user.email;
            return _uDB.emailExistsInDB(checkUser);
        }

        public bool wrongPassword(LoginViewModel user)
        {
            User checkUser = new User();
            checkUser.username = user.username;
            checkUser.password = user.password;

            return _uDB.wrongPassword(checkUser);
        }

        public void resetPassword(User user)
        {
            //TODO: Implement
        }

        public void setLoginStatus(bool login, int userID)
        {
            _uDB.setLoginStatus(login, userID);
        } 

        public int getUserID(string userName)
        {
            return _uDB.getUserIDByUsername(userName);
        }
    }
}