using FinalProjectPSD.Factory;
using FinalProjectPSD.Models;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Handler
{
    public class transactionDetailHandler
    {

        public static void insertTransactionDetail(int TransactionID, int MakeupID, int Quantity)
        {
            TransactionDetailRepository.insertTransactionDetail(TransactionID, MakeupID, Quantity);

        }

        public static int getLastId()
        {
            return TransactionDetailRepository.getLastId();
        }

        public static List<TransactionDetail> getTransactionDetailsListFromID(int TransactionID)
        {
            return TransactionDetailRepository.getTransactionDetailsListFromID(TransactionID);
        }

    }
}