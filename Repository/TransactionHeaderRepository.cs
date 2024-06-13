using FinalProjectPSD.Controller;
using FinalProjectPSD.Factory;
using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private static int generateTransactionHeaderID()
        {

            transactionHeaderController transHeadCont = new transactionHeaderController();

            int newId = 0;
            int lastId = transHeadCont.getLastId();

            if (lastId == 0)
            {
                return 600;
            }
            else
            {
                newId = lastId + 1;
                return newId;
            }
        }

        public static void Checkout(int userId)
        {
            var cartItems = db.Carts.Where(c => c.UserID == userId).ToList();
            if (cartItems.Any())
            {
                var transactionHeader = new TransactionHeader
                {
                    TransactionID = generateTransactionHeaderID(),
                    UserID = userId,
                    TransactionDate = DateTime.Now,
                    Status = "Unhandled"
                };
                db.TransactionHeaders.Add(transactionHeader);
                db.SaveChanges();

                foreach (var c in cartItems)
                {
                    var transactionDetail = new TransactionDetail
                    {
                        TransactionID = transactionHeader.TransactionID,
                        MakeupID = c.MakeupID,
                        Quantity = c.Quantity
                    };
                    db.TransactionDetails.Add(transactionDetail);
                }

                db.Carts.RemoveRange(cartItems);
                db.SaveChanges();
            }
        }

        public static List<TransactionHeader> getTransactionHeaderListFilterUserID(int UserID)
        {
            return (from x in db.TransactionHeaders where x.UserID.Equals(UserID) select x).ToList();
        }

    }
}