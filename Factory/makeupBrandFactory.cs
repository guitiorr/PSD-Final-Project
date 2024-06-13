using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class makeupBrandFactory
    {


        public static MakeupBrand create(int makeupBrandID, string MakeupBrandName, int rating)
        {
            MakeupBrand makeupBrand = new MakeupBrand();
            makeupBrand.MakeupBrandID = makeupBrandID;
            makeupBrand.MakeupBrandName = MakeupBrandName;
            makeupBrand.MakeupBrandRating = rating;

            return makeupBrand;
        }

    }
}