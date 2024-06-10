using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class userFactory
    {

        public static User create(int userId, string Username, DateTime UserDOB, string UserGender, string UserRole, string UserPassword)
        {
            User users = new User();
            users.UserID = userId;
            users.Username = Username;
            users.UserDOB = UserDOB;
            users.UserGender = UserGender;
            users.UserRole = UserRole;
            users.UserPassword = UserPassword;
            return users;
        }


    }
}