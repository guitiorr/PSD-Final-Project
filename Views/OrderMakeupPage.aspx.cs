using FinalProjectPSD.Controller;
using FinalProjectPSD.Handler;
using FinalProjectPSD.Models;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
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
            cartController cartCont = new cartController();
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


                    CartGV.Visible = true;

                    int userId = userCont.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);

                    IQueryable<Cart> cartQuery = cartCont.getCartListFilterUserID(userId).AsQueryable();

                    List<Cart> cartList = cartQuery
                        .Include(c => c.Makeup.MakeupName)
                        .ToList();

                    CartGV.DataSource = cartList;
                    CartGV.DataBind();




                }
            }
        }

        protected void OrderBtn_Click(object sender, EventArgs e)
        {
            userController userCont = new userController();
            cartController cartCont = new cartController();
            transactionDetailController transCont = new transactionDetailController();

            Button btnOrder = (Button)sender;
            GridViewRow row = (GridViewRow)btnOrder.NamingContainer;
            TextBox QuantityTB = (TextBox)row.FindControl("QuantityTB");
            Label QuantityErrorLbl = (Label)row.FindControl("QuantityErrorLbl");
            int makeupID = Convert.ToInt32(btnOrder.CommandArgument);
            int quantity = Convert.ToInt32(QuantityTB.Text);
            int pass = 0;


            if (string.IsNullOrWhiteSpace(QuantityTB.Text))
            {
                QuantityErrorLbl.Text = "Quantity cannot be empty";
                pass = 0;
            }
            else if (!int.TryParse(QuantityTB.Text, out quantity))
            {
                QuantityErrorLbl.Text = "Quantity must be a valid number";
                pass = 0;
            }
            else if (quantity <= 0)
            {
                QuantityErrorLbl.Text = "Quantity must be larger than 0";
                pass = 0;
            }
            else
            {
                QuantityErrorLbl.Text = "";
                pass = 1;
            }


            if (pass == 1)
            {
                int CartID = generateCartID();
                //int transactionDetailID = generateTransactionDetailID();
                int UserID = userCont.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);

                cartCont.insertCart(CartID, UserID, makeupID, quantity);
                //transCont.insertTransactionDetail(transactionDetailID, makeupID, quantity);

                Response.Redirect("~/Views/OrderMakeupPage.aspx");
            }



        }

        private int generateCartID()
        {

            cartController cartCont = new cartController();

            int newId = 0;
            int lastId = cartCont.getLastId();

            if (lastId == 0)
            {
                return 500;
            }
            else
            {
                newId = lastId + 1;
                return newId;
            }
        }

        private int generateTransactionHeaderID()
        {

            transactionHeaderController transHeadCont = new transactionHeaderController();

            int newId = 0;
            int lastId = transHeadCont.getLastId();

            if (lastId == 0)
            {
                return 600;
            }
            else
            {
                newId = lastId + 1;
                return newId;
            }
        }


        protected void CartGV_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int itemNumber = e.Row.RowIndex + 1;
                e.Row.Cells[0].Text = itemNumber.ToString();
            }
        }

        protected void clearCartBtn_Click(object sender, EventArgs e)
        {
            cartController cartCont = new cartController();

            cartCont.clearCart();
            Response.Redirect("~/Views/OrderMakeupPage.aspx");
        }

        protected void CheckoutBtn_Click(object sender, EventArgs e)
        {
            
            transactionHeaderController transHeadCont = new transactionHeaderController();
            transactionDetailController transDetailCont = new transactionDetailController();
            userController userCont = new userController();
            cartController cartCont = new cartController();
            int userId = userCont.getIdFromUsername(Request.Cookies["userCookie"]["Username"]);

            transHeadCont.Checkout(userId);
            cartCont.clearCart();
            Response.Redirect("~/Views/OrderMakeupPage.aspx");
        }



    }
}
