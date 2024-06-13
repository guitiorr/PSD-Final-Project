using FinalProjectPSD.Factory;
using FinalProjectPSD.Models;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FinalProjectPSD.Handler
{
    public class transactionHeaderHandler
    {

        public static void insertTransactionHeader(int TransactionID, DateTime transactionDate, string status, int userId)
        {
            TransactionHeaderRepository.insertTransactionHeader(TransactionID, transactionDate, status, userId);
        }

        public static int getLastId()
        {
            return TransactionHeaderRepository.getLastId();
        }

        public async static Task insertTransactionHeaderAsync(int TransactionID, DateTime transactionDate, string status, int userId)
        {
            await TransactionHeaderRepository.insertTransactionHeaderAsync(TransactionID, transactionDate, status, userId);
        }

        public static int findId(int TransactionID)
        {
            return TransactionHeaderRepository.findId(TransactionID);
        }

        public static void Checkout(int userId)
        {
            TransactionHeaderRepository.Checkout(userId);
        }

        public static List<TransactionHeader> getTransactionHeaderListFilterUserID(int UserID)
        {
            return TransactionHeaderRepository.getTransactionHeaderListFilterUserID(UserID);
        }

    }
}