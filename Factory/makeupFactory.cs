using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class makeupFactory
    {

        public static Makeup create(int MakeupID, string MakeupName, int MakeupWeight, int MakeupTypeID, int MakeupBrandID, int MakeupPrice)
        {
            Makeup makeup = new Makeup();
            makeup.MakeupID = MakeupID;
            makeup.MakeupName = MakeupName;
            makeup.MakeupWeight = MakeupWeight;
            makeup.MakeupTypeID = MakeupTypeID;
            makeup.MakeupBrandID = MakeupBrandID;
            makeup.MakeupPrice = MakeupPrice;

            return makeup;
        }

    }
}