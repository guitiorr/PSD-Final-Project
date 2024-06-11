using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.Layouts
{
    public partial class NavBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userCookie"] != null)
            {
                string userRole = Request.Cookies["userCookie"]["Role"];
                ProfileBtn.Visible = true;
                LogoutBtn.Visible = true;


                if (userRole.Equals("Customer"))
                {
                    OrderMakeupBtn.Visible = true;
                    HistoryBtn.Visible = true;

                    HomeBtn.Visible = false;
                    ManageMakeupBtn.Visible = false;
                    OrderQueueBtn.Visible = false;
                    TransactionReportBtn.Visible = false;
                }
                else
                {
                    OrderMakeupBtn.Visible = false;
                    HistoryBtn.Visible = false;

                    HomeBtn.Visible = true;
                    ManageMakeupBtn.Visible = true;
                    OrderQueueBtn.Visible = true;
                    TransactionReportBtn.Visible = true;

                }


            }
        }
    }
}