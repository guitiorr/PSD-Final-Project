using FinalProjectPSD.Controller;
using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD.Views
{
    public partial class ManageMakeupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            makeupsController makeupCont = new makeupsController();

            if (!IsPostBack)
            {

                if (Request.Cookies["userCookie"] != null)
                {
                    string Role = Request.Cookies["userCookie"]["Role"];

                    if (Role.Equals("Admin"))
                    {

                        // Assuming makeupCont.getMakeupList() returns IQueryable<Makeup>
                        IQueryable<Makeup> makeupQuery = makeupCont.getMakeupList().AsQueryable();

                        // Now you can use the Include method
                        List<Makeup> makeupList = makeupQuery
                            .Include(m => m.MakeupType.MakeupTypeName)
                            .Include(m => m.MakeupBrand.MakeupBrandName)
                            .Include(m => m.MakeupBrand.MakeupBrandRating)
                            .ToList();

                        MakeupDataGV.DataSource = makeupList;
                        MakeupDataGV.DataBind();
                    }





                }


            }


        }

        private void BindGridView()
        {
            makeupsController makeupCont = new makeupsController();
            IQueryable<Makeup> makeupQuery = makeupCont.getMakeupList().AsQueryable();

            List<Makeup> makeupList = makeupQuery
                .Include(m => m.MakeupType.MakeupTypeName)
                .Include(m => m.MakeupBrand.MakeupBrandName)
                .Include(m => m.MakeupBrand.MakeupBrandRating)
                .ToList();

            MakeupDataGV.DataSource = makeupList;
            MakeupDataGV.DataBind();

            MakeupDataGV.DataSource = makeupList;
            MakeupDataGV.DataBind();
        }

        protected void MakeupDataGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            MakeupDataGV.EditIndex = e.NewEditIndex;
            BindGridView();
        }

        protected void MakeupDataGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int makeupID = Convert.ToInt32(MakeupDataGV.DataKeys[e.RowIndex].Value);
            makeupsController makeupCont = new makeupsController();

            string newMakeupName = ((TextBox)MakeupDataGV.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            int newMakeupWeight = Convert.ToInt32(((TextBox)MakeupDataGV.Rows[e.RowIndex].Cells[2].Controls[0]).Text);
            int newMakeupTypeID = Convert.ToInt32(((TextBox)MakeupDataGV.Rows[e.RowIndex].Cells[3].Controls[0]).Text);
            int newMakeupBrandID = Convert.ToInt32(((TextBox)MakeupDataGV.Rows[e.RowIndex].Cells[5].Controls[0]).Text);

            makeupCont.updateMakeupData(makeupID, newMakeupName, newMakeupWeight, newMakeupTypeID, newMakeupBrandID);

            MakeupDataGV.EditIndex = -1;
            BindGridView();
        }

        protected void MakeupDataGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            makeupsController makeupCont = new makeupsController();
            int makeupID = Convert.ToInt32(MakeupDataGV.DataKeys[e.RowIndex].Value);

            // Delete the record from the data source
            makeupCont.deleteMakeupFromID(makeupID);

            BindGridView();
        }

        protected void MakeupDataGV_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            MakeupDataGV.EditIndex = -1;
            BindGridView();
        }

        protected void InsertMakeupBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertMakeupPage.aspx");
        }

        protected void InsertMakeupTypeBtn_Click(object sender, EventArgs e)
        {

        }

        protected void InsertMakeupBrandBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertMakeupBrandPage.aspx");
        }
    }
}