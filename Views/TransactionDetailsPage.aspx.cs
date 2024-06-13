using FinalProjectPSD.Controller;
using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.Views
{
    public partial class TransactionDetailsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userController userCont = new userController();
            transactionDetailController transactionDetailController = new transactionDetailController();

            if (!IsPostBack)
            {

                if (Request.Cookies["userCookie"] != null)
                {
                    int transactionID = Convert.ToInt32(Request.QueryString["TransactionID"]);

                    // Assuming makeupCont.getMakeupList() returns IQueryable<Makeup>
                    IQueryable<TransactionDetail> makeupQuery = transactionDetailController.getTransactionDetailsListFromID(transactionID).AsQueryable();

                    // Now you can use the Include method
                    List<TransactionDetail> transDetailList = makeupQuery
                        .Include(m => m.Makeup.MakeupName)
                        .ToList();

                    TransactionDetailsGV.DataSource = transDetailList;
                    TransactionDetailsGV.DataBind();
                }



            }

        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionHistoryPage.aspx");
        }
    }
}