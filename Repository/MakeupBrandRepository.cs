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

    }
}