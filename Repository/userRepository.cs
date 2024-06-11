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







        public static int getLastId()
        {
            return (from x in db.Users select x.UserID).ToList().LastOrDefault();
        }

    }
}