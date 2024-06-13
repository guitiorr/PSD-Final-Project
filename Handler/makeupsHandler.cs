using FinalProjectPSD.Factory;
using FinalProjectPSD.Models;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static FinalProjectPSD.Repository.MakeupsRepository;

namespace FinalProjectPSD.Handler
{
    public class makeupsHandler
    {
        public static List<Makeup> getMakeupList()
        {
            return MakeupsRepository.getMakeupList();
        }

        public static string getBrandNameFromBrandID(int ID)
        {
            return MakeupsRepository.getBrandNameFromBrandID(ID);
        }

        public static string getMakeupTypeFromTypeID(int ID)
        {
            return MakeupsRepository.getMakeupTypeFromTypeID(ID);
        }

        public static Makeup getMakeupFromID(int makeupID)
        {
            return MakeupsRepository.getMakeupFromID(makeupID);
        }

        public static void updateMakeupData(int makeupID, string newMakeupName, int newMakeupWeight, int newMakeupTypeID, int newMakeupBrandID)
        {
            MakeupsRepository.updateMakeupData(makeupID, newMakeupName, newMakeupWeight, newMakeupTypeID, newMakeupBrandID);
        }

        public static void deleteMakeupFromID(int makeupID)
        {
            MakeupsRepository.deleteMakeupFromID(makeupID);
        }

        public static void insertMakeup(int MakeupID, string MakeupName, int MakeupWeight, int MakeupTypeID, int MakeupBrandID, int MakeupPrice)
        {
            MakeupsRepository.insertMakeup(MakeupID, MakeupName, MakeupWeight, MakeupTypeID, MakeupBrandID, MakeupWeight);
        }

        public static int getLastId()
        {
            return MakeupsRepository.getLastId();
        }
    }
}
