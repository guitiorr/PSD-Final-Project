using FinalProjectPSD.Handler;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FinalProjectPSD.Controller
{
    public class transactionHeaderController
    {

        public void insertTransactionHeader(int TransactionID, DateTime transactionDate, string status, int userId)
        {
            transactionHeaderHandler.insertTransactionHeader(TransactionID, transactionDate, status, userId);
        }

        public int getLastId()
        {
            return transactionHeaderHandler.getLastId();
        }

        public async Task insertTransactionHeaderAsync(int TransactionID, DateTime transactionDate, string status, int userId)
        {
            await transactionHeaderHandler.insertTransactionHeaderAsync(TransactionID, transactionDate, status, userId);
        }

        public int findId(int TransactionID)
        {
            return transactionHeaderHandler.findId(TransactionID);
        }

    }
}