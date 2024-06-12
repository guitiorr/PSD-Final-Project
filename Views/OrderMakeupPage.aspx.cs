using FinalProjectPSD.Controller;
using FinalProjectPSD.Handler;
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

    public partial class OrderMakeupPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userRole = Request.Cookies["userCookie"]["Role"];
            userController userCont = new userController();
            makeupsController makeupCont = new makeupsController();
            if (userRole.Equals("Customer"))
            {
                if (!IsPostBack)
                {
                    MakeupDataGV.Visible = true;

                    // Assuming makeupCont.getMakeupList() returns IQueryable<Makeup>
                    IQueryable<Makeup> makeupQuery = makeupCont.getMakeupList().AsQueryable();

                    // Now you can use the Include method
                    List<Makeup> makeupList = makeupQuery
                        .Include(m => m.MakeupType.MakeupTypeName)
                        .Include(m => m.MakeupBrand.MakeupBrandName)
                        .ToList();



                    MakeupDataGV.DataSource = makeupList ;
                    MakeupDataGV.DataBind();
                }
            }
        }


    }
}
