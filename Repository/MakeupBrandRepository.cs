using FinalProjectPSD.Factory;
using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class MakeupBrandRepository
    {

        public static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.getInstance();

        public static List<MakeupBrand> getMakeupBrandList()
        {
            return (from x in db.MakeupBrands select x).ToList();
        }

        public static int getLastId()
        {
            return (from x in db.MakeupBrands select x.MakeupBrandID).ToList().LastOrDefault();
        }

        public static void insertMakeupBrand(int MakeupBrandID, string MakeupBrandName, int Rating)
        {
            MakeupBrand makeupBrand = makeupBrandFactory.create(MakeupBrandID, MakeupBrandName, Rating);
            db.MakeupBrands.Add(makeupBrand);
            db.SaveChanges();
        }

        public static MakeupBrand getMakeupBrandFromID(int id)
        {
            return (from x in db.MakeupBrands where x.MakeupBrandID.Equals(id) select x).FirstOrDefault();
        }

        public static void deleteMakeupBrandFromID(int makeupID)
        {
            MakeupBrand makeupBrand = getMakeupBrandFromID(makeupID);
            db.MakeupBrands.Remove(makeupBrand);
            db.SaveChanges();
        }

        public static void updateMakeupBrand(int makeupID, string makeupBrandName, int makeupBrandRating)
        {
            MakeupBrand makeupBrand = getMakeupBrandFromID(makeupID);
            makeupBrand.MakeupBrandName = makeupBrandName;
            makeupBrand.MakeupBrandRating = makeupBrandRating;
            db.SaveChanges();
        }

    }
}