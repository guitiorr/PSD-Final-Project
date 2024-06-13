using FinalProjectPSD.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.Views
{
    public partial class InsertMakeupTypePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private int generateMakeupTypeID()
        {
            MakeupTypeController MTC = new MakeupTypeController();


            int newId = 200;
            int lastId = MTC.getLastId();

            if (lastId == 0)
            {
                return 200;
            }
            else
            {
                newId = lastId + 1;
                return newId;
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeupPage.aspx");
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            MakeupTypeController MTC = new MakeupTypeController();
            int pass = 0;
            int ID = generateMakeupTypeID();

            string typeName = MakeupTypeNameTB.Text;

            if (string.IsNullOrEmpty(typeName))
            {
                MakeupTypeNameErrorLbl.Text = "Field Must not be empty";
                pass = 0;
            }
            else if (typeName.Length < 1 || typeName.Length > 99)
            {
                MakeupTypeNameErrorLbl.Text = "Invalid length! (Must be between 1 and 99 characters)";
                pass = 0;
            }
            else
            {
                MakeupTypeNameErrorLbl.Text = "";
                pass = 1;
            }

            if(pass == 1)
            {
                MTC.insertMakeupType(ID, typeName);
                Response.Redirect("~/Views/ManageMakeupPage.aspx");
            }


        }
    }
}