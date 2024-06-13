using FinalProjectPSD.Models;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Handler
{
    public class MakeupBrandHandler
    {

        public static List<MakeupBrand> getMakeupBrandList()
        {
            return MakeupBrandRepository.getMakeupBrandList();
        }

    }
}