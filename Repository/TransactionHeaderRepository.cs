using FinalProjectPSD.Factory;
using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class TransactionHeaderRepository
    {
        public static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.getInstance();


        public static void insertTransactionHeader(int TransactionID, DateTime transactionDate, string status, int userId)
        {
            TransactionHeader transFactor = TransactionHeadersFactory.create(TransactionID, transactionDate, status, userId);

            db.TransactionHeaders.Add(transFactor);
            db.SaveChanges();

        }

        public async static Task insertTransactionHeaderAsync(int TransactionID, DateTime transactionDate, string status, int userId)
        {
            TransactionHeader transFactor = TransactionHeadersFactory.create(TransactionID, transactionDate, status, userId);

            db.TransactionHeaders.Add(transFactor);
            await db.SaveChangesAsync();
        }


        public static int getLastId()
        {
            return (from x in db.TransactionHeaders select x.TransactionID).ToList().LastOrDefault();
        }

        public static int findId(int TransactionID)
        {
            return (from x in db.TransactionHeaders where x.TransactionID.Equals(TransactionID) select x.TransactionID).FirstOrDefault();
        }

    }
}