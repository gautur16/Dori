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
        /*
        public bool usernameExists(RegisterViewModel user)
        {
            User checkUser = new User();

            checkUser.username = user.Username;
            
            return _uDB.usernameExistsInDB(checkUser);
        }

        public bool emailExists(RegisterViewModel user)
        {
            User checkUser = new User();

            checkUser.email = user.Email;
            return _uDB.emailExistsInDB(checkUser);
        }

        
        public bool wrongPassword(LoginViewModel user)
        {
            User checkUser = new User();
            checkUser.username = user.Username;
            checkUser.password = user.Password;

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
        */

        public string getUserName(string email)
        {
            return _uDB.getLoggedInUserName(email);
        }
    }


}