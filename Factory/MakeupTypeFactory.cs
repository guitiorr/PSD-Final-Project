using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class MakeupTypeFactory
    {

        public static MakeupType create(int makeupTypeID, string MakeupTypeName)
        {
            MakeupType makeupType = new MakeupType();
            makeupType.MakeupTypeID = makeupTypeID;
            makeupType.MakeupTypeName = MakeupTypeName;

            return makeupType;
        }



    }
}