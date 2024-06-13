using FinalProjectPSD.Factory;
using FinalProjectPSD.Models;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Handler
{
    public class MakeupTypeHandler
    {

        public static List<MakeupType> getMakeupTypeList()
        {
            return MakeupTypesRepository.getMakeupTypeList();
        }

        public static int getLastId()
        {
            return MakeupTypesRepository.getLastId();
        }

        public static void insertMakeupType(int makeupTypeID, string MakeupTypeName)
        {
            MakeupTypesRepository.insertMakeupType(makeupTypeID, MakeupTypeName);
        }

        public static MakeupType getMakeupTypeFromID(int id)
        {
            return MakeupTypesRepository.getMakeupTypeFromID(id);
        }

        public static void deleteMakeupFromID(int makeupID)
        {
            MakeupTypesRepository.deleteMakeupFromID(makeupID);
        }

        public static void updateMakeupType(int makeupID, string newMakeupTypeName)
        {
            MakeupTypesRepository.updateMakeupType(makeupID, newMakeupTypeName);
        }


    }
}