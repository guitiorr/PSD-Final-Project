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
    public partial class HandleTransactionPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userCookie"]["Role"] == "Customer")
            {

                Response.Redirect("~/Views/HomePage.aspx");

            }
            else
            {
                if (!IsPostBack)
                {
                    transactionHeaderController transHCont = new transactionHeaderController();
                    userController userCont = new userController();
                    int userId = userCont.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);

                    List<TransactionHeader> transHeadList = transHCont.getTransactionHeaderListFilterUserID(userId);

                    TransHeaderGV.DataSource = transHeadList;
                    TransHeaderGV.DataBind();
                }
            }
        }

        protected void btnHandleTransaction_Click(object sender, EventArgs e)
        {
            transactionHeaderController THC = new transactionHeaderController();

            Button btn = (Button)sender;
            int transactionID = Convert.ToInt32(btn.CommandArgument);

            THC.updateToHandled(transactionID);
        }


    }
}