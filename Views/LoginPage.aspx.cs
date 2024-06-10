using FinalProjectPSD.Controller;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            userController userCont = new userController();
            int pass = 0;

            string username = UsernameTB.Text;
            string password = PasswordTB.Text;


            username = userCont.checkUsername(username);

            if(username == null)
            {
                UsernameErrorLbl.Text = "Username not found";
                pass = 0;
            }
            else
            {
                UsernameErrorLbl.Text = "";
                pass = 1;
            }

            string realPass = userCont.getPasswordFromUsername(username);

            if(password.Equals(realPass))
            {
                pass = 1;
                PasswordErrorLbl.Text = "";
            }
            else
            {
                pass = 0;
                PasswordErrorLbl.Text = "Wrong password!";
            }

            if (RememberCB.Checked)
            {
                HttpCookie userCookie = new HttpCookie("userCookie");
                userCookie["Username"] = username;
                userCookie["Password"] = password;
                userCookie.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Add(userCookie);
            }
            else
            {
                HttpCookie userCookie = new HttpCookie("userCookie");
                userCookie["Username"] = username;
                userCookie["Password"] = password;
                userCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(userCookie);
            }


            if(pass == 1)
            {

            }


        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegisterPage.aspx");
        }
    }
}