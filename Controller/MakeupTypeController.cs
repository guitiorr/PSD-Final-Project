﻿using FinalProjectPSD.Handler;
using FinalProjectPSD.Models;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Controller
{
    public class MakeupTypeController
    {

        public List<MakeupType> getMakeupTypeList()
        {
            return MakeupTypeHandler.getMakeupTypeList();
        }

        public int getLastId()
        {
            return MakeupTypeHandler.getLastId();
        }

        public void insertMakeupType(int makeupTypeID, string MakeupTypeName)
        {
            MakeupTypeHandler.insertMakeupType(makeupTypeID, MakeupTypeName);
        }

    }
}