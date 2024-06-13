using FinalProjectPSD.Factory;
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

        public static int getLastId()
        {
            return (from x in db.MakeupTypes select x.MakeupTypeID).ToList().LastOrDefault();
        }

        public static void insertMakeupType(int makeupTypeID, string MakeupTypeName)
        {
            MakeupType makeupType = MakeupTypeFactory.create(makeupTypeID, MakeupTypeName);
            db.MakeupTypes.Add(makeupType);
            db.SaveChanges();
        }

        public static MakeupType getMakeupTypeFromID(int id)
        {
            return (from x in db.MakeupTypes where x.MakeupTypeID.Equals(id) select x).FirstOrDefault();
        }

        public static void deleteMakeupFromID(int makeupID)
        {
            MakeupType makeupType = getMakeupTypeFromID(makeupID);
            db.MakeupTypes.Remove(makeupType);
            db.SaveChanges();
        }

        public static void updateMakeupType(int makeupID, string newMakeupTypeName)
        {
            MakeupType makeupType = getMakeupTypeFromID(makeupID);
            makeupType.MakeupTypeName = newMakeupTypeName;
            db.SaveChanges();
        }


    }
}