using FinalProjectPSD.Factory;
using FinalProjectPSD.Models;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Handler
{
    public class userHandler
    {

        public static string checkUsername(string username)
        {
            return userRepository.checkUsername(username);
        }

        public static string getPasswordFromUsername(string username)
        {
            return userRepository.getPasswordFromUsername(username);
        }

        public static string getPasswordFromUserID(int userID)
        {
            return userRepository.getPasswordFromUserID(userID);
        }

        public static string checkEmail(string email)
        {
            return userRepository.checkEmail(email);
        }

        public static void insertUser(int userId, string Username, DateTime UserDOB, string UserGender, string UserRole, string UserPassword, string userEmail)
        {
            userRepository.insertUser(userId, Username, UserDOB, UserGender, UserRole, UserPassword, userEmail);
        }

        public static int getLastId()
        {
            return userRepository.getLastId();
        }

        public static int getIdFromUsername(string username)
        {
            return userRepository.getIdFromUsername(username);
        }

        public static string getRoleFromId(int id)
        {
            return userRepository.getRoleFromId(id);
        }
        public static string getEmailFromId(int id)
        {
            return userRepository.getEmailFromId(id);
        }

        public static string getGenderFromID(int id)
        {
            return userRepository.getGenderFromID(id);
        }

        public static DateTime getDOBFromID(int id)
        {
            return userRepository.getDOBFromID(id);
        }

        public static void updateUser(int UserID, String Username, String Email, String Gender, DateTime UserDOB)
        {
            userRepository.updateUser(UserID, Username, Email, Gender, UserDOB);
        }

        public static List<User> getUserList()
        {
            return userRepository.getUserList();
        }
        public static void updatePasswordFilterUserID(int UserID, string Password)
        {
            userRepository.updatePasswordFilterUserID(UserID, Password);
        }
    }
}