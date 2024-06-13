using FinalProjectPSD.Factory;
using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class userRepository
    {
        public static List<User> users = null;
        public static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.getInstance();


        public static string checkUsername(string username)
        {
            return (from x in db.Users where x.Username.Equals(username) select x.Username).FirstOrDefault();
        }

        public static string getPasswordFromUsername(string username)
        {
            return (from x in db.Users where x.Username.Equals(username) select x.UserPassword).FirstOrDefault();
        }

        public static string getPasswordFromUserID(int userID)
        {
            return (from x in db.Users where x.UserID.Equals(userID) select x.UserPassword).FirstOrDefault();
        }

        public static string checkEmail(string email)
        {
            return (from x in db.Users where x.UserEmail.Equals(email) select x.Username).FirstOrDefault();
        }

        public static void insertUser(int userId, string Username, DateTime UserDOB, string UserGender, string UserRole, string UserPassword, string userEmail)
        {
            try
            {
                UserDOB = UserDOB.Date;
                User user = userFactory.create(userId, Username, UserDOB, UserGender, UserRole, UserPassword, userEmail);
                db.Users.Add(user);
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Debug.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public static int getIdFromUsername(string username)
        {
            return (from x in db.Users where x.Username.Equals(username) select x.UserID).FirstOrDefault();
        }

        public static string getRoleFromId(int id)
        {
            return (from x in db.Users where x.UserID.Equals(id) select x.UserRole).FirstOrDefault();
        }

        public static string getEmailFromId(int id)
        {
            return (from x in db.Users where x.UserID.Equals(id) select x.UserEmail).FirstOrDefault();
        }

        public static string getGenderFromID(int id)
        {
            return (from x in db.Users where x.UserID.Equals(id) select x.UserGender).FirstOrDefault();
        }

        public static DateTime getDOBFromID(int id)
        {
            return (from x in db.Users where x.UserID.Equals(id) select x.UserDOB).FirstOrDefault();
        }

        public static List<User> getUserList()
        {
            return (from x in db.Users select x).ToList();
        }

        public static User getUserFromID(int userID)
        {
            return (from x in db.Users where x.UserID.Equals(userID) select x).ToList().FirstOrDefault();
        }

        public static void updateUser(int UserID, String Username, String Email, String Gender, DateTime UserDOB)
        {
            User user = getUserFromID(UserID);
            user.Username = Username;
            user.UserEmail = Email;
            user.UserGender = Gender;
            user.UserDOB = UserDOB.Date;
            db.SaveChanges();
        }

        public static void updatePasswordFilterUserID(int UserID, string Password)
        {
            User user = getUserFromID(UserID);
            user.UserPassword = Password;
            db.SaveChanges();
        }


        public static int getLastId()
        {
            return (from x in db.Users select x.UserID).ToList().LastOrDefault();
        }

    }
}