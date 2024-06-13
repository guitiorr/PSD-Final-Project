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

    }
}