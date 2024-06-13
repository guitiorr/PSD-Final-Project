﻿using FinalProjectPSD.Controller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.Views
{
    public partial class InsertMakeupBrandPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["userCookie"]["Role"] == "Customer")
            {

                Response.Redirect("~/Views/HomePage.aspx");

            }



        }

        private int generateMakeupBrandID()
        {
            MakeupBrandController MBC = new MakeupBrandController();


            int newId = 300;
            int lastId = MBC.getLastId();

            if (lastId == 0)
            {
                return 300;
            }
            else
            {
                newId = lastId + 1;
                return newId;
            }
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            MakeupBrandController MBC = new MakeupBrandController();

            int pass = 0;
            int MBCID = generateMakeupBrandID();

            //MCB NAME
            string MBCName = MakeupBrandNameTB.Text;

            if (string.IsNullOrEmpty(MakeupBrandNameTB.Text))
            {
                MakeupBrandNameErrorLbl.Text = "Field must not be empty";
                pass = 0;
            }
            else if (MBCName.Length < 1 || MBCName.Length > 99)
            {
                MakeupBrandNameErrorLbl.Text = "Invalid length! (Must be between 1 and 99 characters)";
                pass = 0;
            }
            else
            {
                MakeupBrandNameErrorLbl.Text = "";
                pass = 1;
            }

            //MCB RATING
            int rating = 0;
            if (string.IsNullOrEmpty(MakeupBrandRatingTB.Text))
            {
                MakeupBrandRatingErrorLbl.Text = "Field Must not be Empty";
                pass = 0;
            }
            else if (!(int.TryParse(MakeupBrandRatingTB.Text, out int ratings)))
            {
                MakeupBrandRatingErrorLbl.Text = "Input must be a number!";
                pass = 0;
            }
            else if (ratings < 0 || ratings > 100)
            {
                MakeupBrandRatingErrorLbl.Text = "Rating must 0 - 100";
                pass = 0;
            }
            else
            {
                rating = Convert.ToInt32(MakeupBrandRatingTB.Text);
                MakeupBrandRatingErrorLbl.Text = "";
                pass = 1;
            }

            if(pass == 1)
            {
                MBC.insertMakeupBrand(MBCID, MBCName, rating);
                Response.Redirect("~/Views/ManageMakeupPage.aspx");
            }

        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeupPage.aspx");
        }
    }
}