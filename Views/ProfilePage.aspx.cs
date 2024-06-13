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
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userController userCont = new userController();
            int UserID = userCont.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);
            string Username = Request.Cookies["userCookie"]["Username"];
            if (!IsPostBack)
            {
                UsernameTB.Text = Username;
                EmailInput.Value = userCont.getEmailFromId(UserID);
                GenderDropDown.SelectedValue = userCont.getGenderFromID(UserID);
                DateTime dob = userCont.getDOBFromID(UserID);
                DOBInput.Value = dob.ToString("yyyy-MM-dd");


                    
            }
        }

        protected void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            userController userCont = new userController();
            int UserID = userCont.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);
            string Username = UsernameTB.Text;
            string Email = EmailInput.Value;
            string Gender = GenderDropDown.SelectedValue;
            string DOB = DOBInput.Value;
            int pass = 0;

            pass = validateUsername(Username);
            pass = validateEmail(Email);
            pass = validateGender(Gender);
            pass = validateDOB(DOB);

            if(pass == 1)
            {
                DateTime UserDOB = Convert.ToDateTime(DOB);
                userCont.updateUser(UserID, Username, Email, Gender, UserDOB);
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }

        private int validateDOB(string DOB)
        {
            if (string.IsNullOrEmpty(DOB))
            {
                DOBErrorLbl.Text = "Please fill Date of Birth";
                return 0;
            }
            else
            {
                DOBErrorLbl.Text = "";
                return 1;
            }
        }

        private int validateGender(string Gender)
        {
            if (Gender == "")
            {
                GenderErrorLbl.Text = "Gender must not be empty";
                return 0;
            }
            else if (Gender == "Male" || Gender == "Female")
            {
                GenderErrorLbl.Text = "";
                return 1;
            }
            else
            {
                GenderErrorLbl.Text = "Invalid choice";
                return 0;
            }
        }

        private int validateEmail(string Email)
        {
            userController userCont = new userController();

            if (!(Email.EndsWith("Email must end with '.com'")))
            {
                EmailErrorLbl.Text = "";
                return 0;
            }
            else if (Email == "")
            {
                EmailErrorLbl.Text = "Email must not be empty";
                return 0;
            }
            else if (userCont.checkEmail(Email) != null)
            {
                EmailErrorLbl.Text = "Email already registered";
                return 0;
            }
            else
            {
                EmailErrorLbl.Text = "";
                return 1;
            }

        }

        private int validateUsername(string Username)
        {
            userController userCont = new userController();

            if (userCont.checkUsername(Username) != null)
            {
                UsernameErrorLbl.Text = "Username already exists";
                return 0;
            }
            else if (Username.Length < 5 || Username.Length > 15)
            {
                UsernameErrorLbl.Text = "Username length must be between 5 - 15 characters";
                return 0;
            }
            else if (Username == "")
            {
                UsernameErrorLbl.Text = "Username must not be empty!";
                return 0;
            }
            else
            {
                UsernameErrorLbl.Text = "";
                return 1;
            }
        }

        protected void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            userController userCont = new userController();
            int UserID = userCont.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);
            int pass = 0;

            string realPass = userCont.getPasswordFromUserID(UserID);
            string oldpass = oldPasswordInput.Value;
            string newPass = newPasswordInput.Value;
            string confirmNewPass = confirmNewPasswordInput.Value;

            if (oldpass.Equals(realPass))
            {
                oldPasswordErrorLbl.Text = "";
                pass = 1;
            }
            else
            {
                oldPasswordErrorLbl.Text = "Wrong Password!";
                pass = 0;
            }

            if (oldpass.Equals(newPass))
            {
                PasswordErrorLbl.Text = "New Password must not be the same as old password!";
                pass = 0;
            }
            else
            {
                PasswordErrorLbl.Text = "";
                pass = 1;
            }

            pass = validatePassword(newPass);
            pass = validateConfirmPassword(newPass, confirmNewPass);

            if(pass == 1)
            {
                userCont.updatePasswordFilterUserID(UserID, newPass);
                Response.Redirect("~/Views/HomePage.aspx");
            }

        }


        private int validatePassword(string Password)
        {
            if (Password == "")
            {
                PasswordErrorLbl.Text = "Password must not be empty";
                return 0;
            }
            else
            {
                PasswordErrorLbl.Text = "";
                return 1;
            }

        }

        private int validateConfirmPassword(string Password, string ConfirmPassword)
        {
            if (Password.Equals(ConfirmPassword))
            {
                ConfirmPasswordErrorLbl.Text = "";
                return 1;
            }
            else
            {
                ConfirmPasswordErrorLbl.Text = "Password doesn't match!";
                return 0;
            }
        }


    }
}