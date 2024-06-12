using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class TransactionHeadersFactory
    {

        public static TransactionHeader create(int TransactionID, DateTime transactionDate, string status, int userId)
        {
            TransactionHeader transDetail = new TransactionHeader();
            transDetail.TransactionID = TransactionID;
            transDetail.TransactionDate = transactionDate;
            transDetail.Status = status;
            transDetail.UserID = userId;

            return transDetail;
        }

    }
}