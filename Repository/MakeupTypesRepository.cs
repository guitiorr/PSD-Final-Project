using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class MakeupTypesRepository
    {
        public static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.getInstance();

        public static List<MakeupType> getMakeupTypeList()
        {
            return (from x in db.MakeupTypes select x).ToList();
        }

    }
}