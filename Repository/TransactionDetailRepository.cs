using FinalProjectPSD.Factory;
using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class TransactionDetailRepository
    {
        public static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.getInstance();


        public static void insertTransactionDetail(int TransactionID, int MakeupID, int Quantity)
        {
            TransactionDetail transDetail = TransactionDetailFactory.create(TransactionID, MakeupID, Quantity);

            db.TransactionDetails.Add(transDetail);
            db.SaveChanges();

        }

        public static int getLastId()
        {
            return (from x in db.TransactionDetails select x.TransactionID).ToList().LastOrDefault();
        }


        public static List<TransactionDetail> getTransactionDetailsListFromID(int TransactionID)
        {
            return (from x in db.TransactionDetails where x.TransactionID.Equals(TransactionID) select x).ToList();
        }



    }
}