using FinalProjectPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.Views
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LoginPage.aspx");
        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            userController userCont = new userController();
            int pass = 0;

            string Username = UsernameTB.Text;
            string Email = EmailInput.Value;
            string Gender = GenderDropDown.SelectedValue;
            string Password = passwordInput.Value;
            string ConfirmPassword = confirmPasswordInput.Value;
            string DOB = DOBInput.Value;

            pass = validateUsername(Username);
            pass = validateEmail(Email);
            pass = validateGender(Gender);
            pass = validatePassword(Password);
            pass = validateConfirmPassword(Password, ConfirmPassword);
            pass = validateDOB(DOB);

            int userId = generateUserID();

            if (pass == 1)
            {
                DateTime UserDOB = Convert.ToDateTime(DOB);
                userCont.insertUser(userId, Username, UserDOB, Gender, "Customer", Password, Email);
                Response.Redirect("~/Views/LoginPage.aspx");
            }
        }


        private int generateUserID()
        {
            userController userCont = new userController();

            int newId = 0;
            int lastId = userCont.getLastId();

            if (lastId == 0)
            {
                return 1;
            }
            else
            {
                newId = lastId + 1;
                return newId;
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

        private int validatePassword(string Password)
        {
            if(Password == "")
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

        private int validateGender(string Gender)
        {
            if(Gender == "")
            {
                GenderErrorLbl.Text = "Gender must not be empty";
                return 0;
            }
            else if(Gender == "Male" || Gender == "Female")
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

            if (!(Email.EndsWith("Email must end with '.com'"))){
                EmailErrorLbl.Text = "";
                return 0;
            }
            else if(Email == "")
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

            if(userCont.checkUsername(Username) != null)
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


    }
}