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

        public void updateMakeupData(int makeupID, string newMakeupName, int newMakeupWeight, int newMakeupTypeID, int newMakeupBrandID)
        {
            makeupsHandler.updateMakeupData(makeupID, newMakeupName, newMakeupWeight, newMakeupTypeID, newMakeupBrandID);
        }

        public void deleteMakeupFromID(int makeupID)
        {
            makeupsHandler.deleteMakeupFromID(makeupID);
        }

    }
}