using FinalProjectPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.Views
{
    public partial class UpdateMakeupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userCookie"]["Role"] == "Customer")
            {

                Response.Redirect("~/Views/HomePage.aspx");

            }
            else
            {




            }

        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeupPage.aspx");
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            makeupsController MC = new makeupsController();

            int pass = 0;
            string MakeupName = MakeupNameTB.Text;

            //MAKEUPNAME
            if (string.IsNullOrEmpty(MakeupNameTB.Text))
            {
                MakeupNameErrorLbl.Text = "Field Must not be Empty";
                pass = 0;
            }
            else if (MakeupName.Length < 1 || MakeupName.Length > 99)
            {
                MakeupNameErrorLbl.Text = "Invalid length! (Must be between 1 and 99 characters)";
                pass = 0;
            }
            else
            {
                MakeupNameErrorLbl.Text = "";
                pass = 1;
            }

            int price = 0;

            //MAKEUP PRICE
            if (string.IsNullOrEmpty(MakeupPriceTB.Text))
            {
                MakeupPriceErrorLbl.Text = "Field Must not be Empty";
                pass = 0;
            }
            else if (!(int.TryParse(MakeupPriceTB.Text, out int prices)))
            {
                MakeupPriceErrorLbl.Text = "Input must be a number!";
                pass = 0;
            }
            else if (prices < 1)
            {
                MakeupPriceErrorLbl.Text = "Price must 1 or more!";
                pass = 0;
            }
            else
            {
                price = Convert.ToInt32(MakeupPriceTB.Text);
                MakeupPriceErrorLbl.Text = "";
                pass = 1;
            }

            int weights = 0;

            //MAKEUP WEIGHT
            if (string.IsNullOrEmpty(MakeupWeightTB.Text))
            {
                MakeupWeightErrorLbl.Text = "Field Must not be Empty";
                pass = 0;
            }
            else if (!(int.TryParse(MakeupWeightTB.Text, out int weight)))
            {
                MakeupWeightErrorLbl.Text = "Input must be a number!";
                pass = 0;
            }
            else if (weight < 1500)
            {
                MakeupWeightErrorLbl.Text = "Weight must be 1500 or more !";
                pass = 0;
            }
            else
            {
                weights = Convert.ToInt32(MakeupWeightTB.Text);
                MakeupWeightErrorLbl.Text = "";
                pass = 1;
            }


            int typeIDS = 0;
            //TYPE ID
            if (string.IsNullOrEmpty(MakeupTypeIDTB.Text))
            {
                MakeupTypeIDErrorLbl.Text = "Field Must not be Empty";
                pass = 0;
            }
            else if (!(int.TryParse(MakeupTypeIDTB.Text, out int TypeID)))
            {
                MakeupTypeIDErrorLbl.Text = "Input must be a number!";
                pass = 0;
            }
            else
            {
                typeIDS = Convert.ToInt32(MakeupTypeIDTB.Text);
                MakeupTypeIDErrorLbl.Text = "";
                pass = 1;
            }

            int brandIDS = 0;
            //BRAND ID
            if (string.IsNullOrEmpty(MakeupBrandIDTB.Text))
            {
                MakeupBrandIDErrorLbl.Text = "Field Must not be Empty";
                pass = 0;
            }
            else if (!(int.TryParse(MakeupBrandIDTB.Text, out int BrandID)))
            {
                MakeupBrandIDErrorLbl.Text = "Input must be a number!";
                pass = 0;
            }
            else
            {
                brandIDS = Convert.ToInt32(MakeupBrandIDTB.Text);
                MakeupBrandIDErrorLbl.Text = "";
                pass = 1;
            }

            int makeupID = Convert.ToInt32(Request.QueryString["MakeupID"]);

            if (pass == 1)
            {
                MC.updateMakeupData(makeupID, MakeupName, weights, typeIDS, brandIDS, price);
                Response.Redirect("~/Views/ManageMakeupPage.aspx");
            }
        }
    }
}