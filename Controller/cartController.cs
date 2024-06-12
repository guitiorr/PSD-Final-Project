using FinalProjectPSD.Handler;
using FinalProjectPSD.Models;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Controller
{
    public class cartController
    {

        public void insertCart(int CartID, int UserID, int MakeupID, int Quantity)
        {
            cartHandler.insertCart(CartID, UserID, MakeupID, Quantity);
        }

        public int getLastId()
        {
            return cartHandler.getLastId();
        }

        public List<Cart> getCartList()
        {
            return cartHandler.getCartList();
        }

        public void clearCart()
        {
            cartHandler.clearCart();
        }

        public List<Cart> getCartListFilterUserID(int UserID)
        {
            return cartHandler.getCartListFilterUserID(UserID);
        }

    }
}