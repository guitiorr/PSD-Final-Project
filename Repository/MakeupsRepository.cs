using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using static FinalProjectPSD.Repository.MakeupsRepository;

namespace FinalProjectPSD.Repository
{
    public class MakeupsRepository
    {
        public static List<Makeup> makeups = null;
        public static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.getInstance();

        public static List<Makeup> getMakeupList()
        {
            return (from x in db.Makeups select x).ToList();
        }

        public static string getBrandNameFromBrandID(int ID)
        {
            return (from x in db.Makeups where x.MakeupBrandID.Equals(ID) select x.MakeupBrand.MakeupBrandName).FirstOrDefault();
        }

        public static string getMakeupTypeFromTypeID(int ID)
        {
            return (from x in db.Makeups where x.MakeupTypeID.Equals(ID) select x.MakeupType.MakeupTypeName).FirstOrDefault();
        }




    }
}