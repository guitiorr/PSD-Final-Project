using FinalProjectPSD.Controller;
using FinalProjectPSD.Models;
using log4net;
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
            MakeupBrandController MBC = new MakeupBrandController();
            MakeupTypeController MTC = new MakeupTypeController();

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

                        List<MakeupBrand> makeupBrandList = MBC.getMakeupBrandList();

                        MakeupBrandGV.DataSource = makeupBrandList;
                        MakeupBrandGV.DataBind();

                        List<MakeupType> makeupTypeList = MTC.getMakeupTypeList();

                        MakeupTypeGV.DataSource = makeupTypeList;
                        MakeupTypeGV.DataBind();
                    }





                }


            }


        }

        private void BindGridView()
        {

            MakeupBrandController MBC = new MakeupBrandController();
            MakeupTypeController MTC = new MakeupTypeController();
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

            List<MakeupBrand> makeupBrandList = MBC.getMakeupBrandList();

            MakeupBrandGV.DataSource = makeupBrandList;
            MakeupBrandGV.DataBind();

            List<MakeupType> makeupTypeList = MTC.getMakeupTypeList();

            MakeupTypeGV.DataSource = makeupTypeList;
            MakeupTypeGV.DataBind();
        }

        protected void MakeupDataGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            MakeupDataGV.EditIndex = e.NewEditIndex;
            BindGridView();
        }

        protected void MakeupDataGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            /*int makeupID = Convert.ToInt32(MakeupDataGV.DataKeys[e.RowIndex].Value);
            makeupsController makeupCont = new makeupsController();

            string newMakeupName = ((TextBox)MakeupDataGV.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            int newMakeupWeight = Convert.ToInt32(((TextBox)MakeupDataGV.Rows[e.RowIndex].Cells[2].Controls[0]).Text);
            int newMakeupTypeID = Convert.ToInt32(((TextBox)MakeupDataGV.Rows[e.RowIndex].Cells[3].Controls[0]).Text);
            int newMakeupBrandID = Convert.ToInt32(((TextBox)MakeupDataGV.Rows[e.RowIndex].Cells[5].Controls[0]).Text);

            makeupCont.updateMakeupData(makeupID, newMakeupName, newMakeupWeight, newMakeupTypeID, newMakeupBrandID);

            MakeupDataGV.EditIndex = -1;
            BindGridView();*/
        }

        protected void MakeupDataGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            makeupsController makeupCont = new makeupsController();
            int makeupID = Convert.ToInt32(MakeupDataGV.DataKeys[e.RowIndex].Value);

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
            Response.Redirect("~/Views/InsertMakeupTypePage.aspx");
        }

        protected void InsertMakeupBrandBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertMakeupBrandPage.aspx");
        }

        protected void MakeupDataGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditMakeup" && e.CommandArgument != null)
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                int makeupID = Convert.ToInt32(MakeupDataGV.DataKeys[rowIndex].Values["MakeupID"]);
                Response.Redirect("UpdateMakeupPage.aspx?MakeupID=" + makeupID);
            }
        }

        protected void MakeupTypeGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditMakeupType" && e.CommandArgument != null)
            {
                int makeupIDType = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("UpdateMakeupTypePage.aspx?makeupIDType=" + makeupIDType);
            }
        }

        protected void MakeupTypeGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            MakeupTypeController MTC = new MakeupTypeController();
            int makeupIDType = Convert.ToInt32(MakeupTypeGV.DataKeys[e.RowIndex].Value);

            MTC.deleteMakeupFromID(makeupIDType);

            BindGridView();
        }

        protected void MakeupBrandGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditMakeupBrand" && e.CommandArgument != null)
            {
                int makeupIDBrand = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("UpdateMakeupBrandPage.aspx?makeupIDBrand=" + makeupIDBrand);
            }
        }

        protected void MakeupBrandGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            MakeupBrandController MBC = new MakeupBrandController();
            int makeupIDType = Convert.ToInt32(MakeupBrandGV.DataKeys[e.RowIndex].Value);

            MBC.deleteMakeupBrandFromID(makeupIDType);

            BindGridView();
        }

        protected void MakeupTypeGV_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            /*if (e.CommandName == "EditMakeup" && e.CommandArgument != null)
            {
                int makeupID = Convert.ToInt32(e.CommandArgument);
                // Redirect or do something with the makeupID
            }*/
        }

        protected void EditBtnMakeup_Click(object sender, EventArgs e)
        {
            Button btnOrder = (Button)sender;
            GridViewRow row = (GridViewRow)btnOrder.NamingContainer;
            int makeupID = Convert.ToInt32(btnOrder.CommandArgument);
            Response.Redirect("UpdateMakeupPage.aspx?MakeupID=" + makeupID);
        }

        protected void EditBtnMakeupType_Click(object sender, EventArgs e)
        {
            Button btnOrder = (Button)sender;
            GridViewRow row = (GridViewRow)btnOrder.NamingContainer;
            int MakeupTypeID = Convert.ToInt32(btnOrder.CommandArgument);
            Response.Redirect("UpdateMakeupPage.aspx?MakeupTypeID=" + MakeupTypeID);
        }

        protected void EditBtnMakeupBrand_Click(object sender, EventArgs e)
        {
            Button btnOrder = (Button)sender;
            GridViewRow row = (GridViewRow)btnOrder.NamingContainer;
            int MakeupBrandID = Convert.ToInt32(btnOrder.CommandArgument);
            Response.Redirect("UpdateMakeupPage.aspx?MakeupBrandID=" + MakeupBrandID);
        }

        protected void DeleteBtnMakeup_Click(object sender, EventArgs e)
        {

            makeupsController makeupCont = new makeupsController();
            Button btnOrder = (Button)sender;
            GridViewRow row = (GridViewRow)btnOrder.NamingContainer;
            int makeupID = Convert.ToInt32(btnOrder.CommandArgument);

            makeupCont.deleteMakeupFromID(makeupID);

            BindGridView();
            Response.Redirect("~/Views/ManageMakeupPage.aspx");
        }

        protected void DeleteBtnMakeupType_Click(object sender, EventArgs e)
        {
            MakeupTypeController MTC = new MakeupTypeController();
            Button btnOrder = (Button)sender;
            GridViewRow row = (GridViewRow)btnOrder.NamingContainer;
            int MakeupTypeID = Convert.ToInt32(btnOrder.CommandArgument);

            MTC.deleteMakeupFromID(MakeupTypeID);

            BindGridView();
            Response.Redirect("~/Views/ManageMakeupPage.aspx");
        }

        protected void DeleteMakeupBrand_Click(object sender, EventArgs e)
        {
            MakeupBrandController MBC = new MakeupBrandController();
            Button btnOrder = (Button)sender;
            GridViewRow row = (GridViewRow)btnOrder.NamingContainer;
            int MakeupBrandID = Convert.ToInt32(btnOrder.CommandArgument);

            MBC.deleteMakeupBrandFromID(MakeupBrandID);

            BindGridView();
            Response.Redirect("~/Views/ManageMakeupPage.aspx");
        }
    }
}