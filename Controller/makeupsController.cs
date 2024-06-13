using FinalProjectPSD.Handler;
using FinalProjectPSD.Models;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static FinalProjectPSD.Repository.MakeupsRepository;

namespace FinalProjectPSD.Controller
{
    public class makeupsController
    {
        public  List<Makeup> getMakeupList()
        {
            return makeupsHandler.getMakeupList();
        }
        public string getBrandNameFromBrandID(int ID)
        {
            return makeupsHandler.getBrandNameFromBrandID(ID);
        }

        public string getMakeupTypeFromTypeID(int ID)
        {
            return makeupsHandler.getMakeupTypeFromTypeID(ID);
        }

        public Makeup getMakeupFromID(int makeupID)
        {
            return makeupsHandler.getMakeupFromID(makeupID);
        }

        public void updateMakeupData(int makeupID, string newMakeupName, int newMakeupWeight, int newMakeupTypeID, int newMakeupBrandID, int MakeupPrice)
        {
            makeupsHandler.updateMakeupData(makeupID, newMakeupName, newMakeupWeight, newMakeupTypeID, newMakeupBrandID, MakeupPrice);
        }

        public void deleteMakeupFromID(int makeupID)
        {
            makeupsHandler.deleteMakeupFromID(makeupID);
        }

        public void insertMakeup(int MakeupID, string MakeupName, int MakeupWeight, int MakeupTypeID, int MakeupBrandID, int MakeupPrice)
        {
            makeupsHandler.insertMakeup(MakeupID, MakeupName, MakeupWeight, MakeupTypeID, MakeupBrandID, MakeupWeight);
        }

        public int getLastId()
        {
            return makeupsHandler.getLastId();
        }

    }
}