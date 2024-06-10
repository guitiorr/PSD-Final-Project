using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class DatabaseSingleton
    {
        public static MakeMeUpzzDatabaseEntities db = null;

        public static MakeMeUpzzDatabaseEntities getInstance()
        {
            if (db == null)
            {
                db = new MakeMeUpzzDatabaseEntities ();
            }

            return db;
        }

    }
}