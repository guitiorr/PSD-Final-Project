using FinalProjectPSD.Factory;
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

        public static Makeup getMakeupFromID(int makeupID)
        {
            return (from x in db.Makeups where x.MakeupID.Equals(makeupID) select x).ToList().FirstOrDefault();
        }

        public static void updateMakeupData(int makeupID, string newMakeupName, int newMakeupWeight, int newMakeupTypeID, int newMakeupBrandID, int MakeupPrice)
        {
            Makeup makeup = getMakeupFromID(makeupID);
            makeup.MakeupName = newMakeupName;
            makeup.MakeupWeight = newMakeupWeight;
            makeup.MakeupTypeID = newMakeupTypeID;
            makeup.MakeupBrandID = newMakeupBrandID;
            makeup.MakeupPrice = MakeupPrice;
            db.SaveChanges();
        }

        public static void deleteMakeupFromID(int makeupID)
        {
            Makeup makeup = getMakeupFromID(makeupID);
            db.Makeups.Remove(makeup);
            db.SaveChanges();
        }

        public static void insertMakeup(int MakeupID, string MakeupName, int MakeupWeight, int MakeupTypeID, int MakeupBrandID, int MakeupPrice)
        {
            Makeup makeup = makeupFactory.create(MakeupID, MakeupName, MakeupWeight, MakeupTypeID, MakeupBrandID, MakeupWeight);
            db.Makeups.Add(makeup);
            db.SaveChanges();
        }

        public static int getLastId()
        {
            return (from x in db.Makeups select x.MakeupID).ToList().LastOrDefault();
        }


    }
}