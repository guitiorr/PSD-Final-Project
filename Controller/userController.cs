using FinalProjectPSD.Handler;
using FinalProjectPSD.Models;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Controller
{
    public class userController
    {

        public string checkUsername(string username)
        {
            return userHandler.checkUsername(username);
        }

        public string getPasswordFromUsername(string username)
        {
            return userHandler.getPasswordFromUsername(username);
        }

        public string getPasswordFromUserID(int userID)
        {
            return userHandler.getPasswordFromUserID(userID);
        }
        public string checkEmail(string email)
        {
            return userHandler.checkEmail(email);
        }

        public void insertUser(int userId, string Username, DateTime UserDOB, string UserGender, string UserRole, string UserPassword, string userEmail)
        {
            userHandler.insertUser(userId, Username, UserDOB, UserGender, UserRole, UserPassword, userEmail);
        }

        public int getLastId()
        {
            return userHandler.getLastId();
        }


        public int getIdFromUsername(string username)
        {
            return userHandler.getIdFromUsername(username);
        }

        public string getRoleFromId(int id)
        {
            return userHandler.getRoleFromId(id);
        }

        public string getEmailFromId(int id)
        {
            return userHandler.getEmailFromId(id);
        }

        public string getGenderFromID(int id)
        {
            return userHandler.getGenderFromID(id);
        }

        public DateTime getDOBFromID(int id)
        {
            return userRepository.getDOBFromID(id);
        }

        public void updateUser(int UserID, String Username, String Email, String Gender, DateTime UserDOB)
        {
            userHandler.updateUser(UserID, Username, Email, Gender, UserDOB);
        }

        public  List<User> getUserList()
        {
            return userHandler.getUserList();
        }

        public void updatePasswordFilterUserID(int UserID, string Password)
        {
            userHandler.updatePasswordFilterUserID(UserID, Password);
        }

    }
}