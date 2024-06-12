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

    }
}