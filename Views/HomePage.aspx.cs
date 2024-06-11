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
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userController userCont = new userController();

            if (!IsPostBack)
            {
                string userRole = Request.Cookies["userCookie"]["Role"];
                int id = userCont.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);

                RoleLbl.Text = "Role: " + userRole;
                NameLbl.Text = Request.Cookies["userCookie"]["Username"];

                if (userRole.Equals("Customer")){
                    CustomerGV.Visible = false;
                }
                else
                {
                    List<User> userList = userCont.getUserList();
                    CustomerGV.Visible = true;

                    CustomerGV.DataSource = userList;
                    CustomerGV.DataBind();
                }



            }

        }
    }
}