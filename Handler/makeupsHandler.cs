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
        


    }
}
