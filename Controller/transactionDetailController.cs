using FinalProjectPSD.Handler;
using FinalProjectPSD.Models;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Controller
{
    public class transactionDetailController
    {

        public void insertTransactionDetail(int TransactionID, int MakeupID, int Quantity)
        {
            transactionDetailHandler.insertTransactionDetail(TransactionID, MakeupID, Quantity);

        }

        public int getLastId()
        {
            return transactionDetailHandler.getLastId();
        }

        public static List<TransactionDetail> getTransactionDetailsListFromID(int TransactionID)
        {
            return transactionDetailHandler.getTransactionDetailsListFromID(TransactionID);
        }


    }
}