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


    }
}