using FinalProjectPSD.Controller;
using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.Views
{
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                if (Request.Cookies["userCookie"] != null)
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

        protected void TransHeaderGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ViewDetails")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                GridViewRow row = TransHeaderGV.Rows[rowIndex];
                string transactionID = row.Cells[0].Text;

                // Perform your custom logic here
                // Example: redirect to a details page or show a modal with the details
                Response.Redirect($"TransactionDetailsPage.aspx?TransactionID={transactionID}");
            }
        }
    }
}