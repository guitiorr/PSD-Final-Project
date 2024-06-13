using FinalProjectPSD.Handler;
using FinalProjectPSD.Models;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Controller
{
    public class MakeupBrandController
    {
        public List<MakeupBrand> getMakeupBrandList()
        {
            return MakeupBrandHandler.getMakeupBrandList();
        }
    }
}