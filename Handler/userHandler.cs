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

        public static string checkEmail(string email)
        {
            return userRepository.checkEmail(email);
        }

        public static void insertUser(int userId, string Username, DateTime UserDOB, string UserGender, string UserRole, string UserPassword)
        {
            userRepository.insertUser(userId, Username, UserDOB, UserGender, UserRole, UserPassword);
        }

        public static int getLastId()
        {
            return userRepository.getLastId();
        }

    }
}