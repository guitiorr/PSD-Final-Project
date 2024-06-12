using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class TransactionDetailFactory
    {

        public static TransactionDetail create(int TransactionID, int MakeupID, int Quantity)
        {
            TransactionDetail transDetail = new TransactionDetail();
            return transDetail;
        }




    }
}