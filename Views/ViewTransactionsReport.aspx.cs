using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI;
using System.Web.Util;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Web;
using FinalProjectPSD.Controller;
using FinalProjectPSD.Dataset;
using FinalProjectPSD.Models;

namespace FinalProjectPSD.Views
{
    public partial class ViewTransactionsReport : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            transactionHeaderController THC = new transactionHeaderController();

            if (Request.Cookies["userCookie"]["Role"].Equals("Customer")){
                Response.Redirect("~/Views/HomePage.aspx");
            }
            else
            {
                CrystalReport1 report = new CrystalReport1();
                CrystalReportViewer1.ReportSource = report;
                transactionDataset data = GetData(THC.getTransactionHeaderList());
                report.SetDataSource(data);
            }

        }

        private transactionDataset GetData(List<TransactionHeader> transactions)
        {
            transactionDataset data = new transactionDataset();
            var headertable = data.TransactionHeaders;
            var detailtable = data.TransactionDetails;

            foreach(TransactionHeader th in transactions)
            {
                var hrow = headertable.NewRow();
                hrow["TransactionID"] = th.TransactionID;
                hrow["UserID"] = th.UserID;
                hrow["TransactionDate"] = th.TransactionDate;
                hrow["Status"] = th.Status;
                hrow["Grand_Total"] = th.TransactionDetails.Sum(td => td.Quantity * td.Makeup.MakeupPrice);
                headertable.Rows.Add(hrow);

                foreach(TransactionDetail td in th.TransactionDetails)
                {
                    var drow = detailtable.NewRow();
                    drow["TransactionID"] = td.TransactionID;
                    drow["MakeupID"] = td.TransactionID;
                    drow["Quantity"] = td.Quantity;
                    drow["Sub_Total"] = td.Quantity * td.Makeup.MakeupPrice;
                    detailtable.Rows.Add(drow);
                }

            }

            return data;
        }

    }
}
