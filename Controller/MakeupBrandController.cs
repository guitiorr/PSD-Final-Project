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

        public int getLastId()
        {
            return MakeupBrandHandler.getLastId();
        }

        public void insertMakeupBrand(int MakeupBrandID, string MakeupBrandName, int Rating)
        {
            MakeupBrandHandler.insertMakeupBrand(MakeupBrandID, MakeupBrandName, Rating);
        }

        public MakeupBrand getMakeupBrandFromID(int id)
        {
            return MakeupBrandHandler.getMakeupBrandFromID(id);
        }

        public void deleteMakeupBrandFromID(int makeupID)
        {
            MakeupBrandHandler.deleteMakeupBrandFromID(makeupID);
        }

        public void updateMakeupBrand(int makeupID, string makeupBrandName, int makeupBrandRating)
        {
            MakeupBrandHandler.updateMakeupBrand(makeupID, makeupBrandName, makeupBrandRating);
        }

    }
}