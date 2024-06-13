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
                LoginBtn.Visible = false;
                RegisterBtn.Visible = false;


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
            else if(Request.Cookies["userCookie"] == null)
            {
                OrderMakeupBtn.Visible = false;
                HistoryBtn.Visible = false;

                HomeBtn.Visible = false;
                ManageMakeupBtn.Visible = false;
                OrderQueueBtn.Visible = false;
                TransactionReportBtn.Visible = false;

                LoginBtn.Visible = true;
                RegisterBtn.Visible = true;
            }
        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        protected void ManageMakeupBtn_Click(object sender, EventArgs e)
        {

        }

        protected void OrderQueueBtn_Click(object sender, EventArgs e)
        {

        }

        protected void TransactionReportBtn_Click(object sender, EventArgs e)
        {

        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ProfilePage.aspx");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["userCookie"] != null)
            {
                HttpCookie authCookie = new HttpCookie("userCookie");
                authCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(authCookie);
            }

            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void OrderMakeupBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/OrderMakeupPage.aspx");
        }

        protected void HistoryBtn_Click(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LoginPage.aspx");
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegisterPage.aspx");
        }
    }
}