using FinalProjectPSD.Factory;
using FinalProjectPSD.Models;
using FinalProjectPSD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Handler
{
    public class cartHandler
    {
        public static void insertCart(int CartID, int UserID, int MakeupID, int Quantity)
        {
            cartRepository.insertCart(CartID, UserID, MakeupID, Quantity);
        }

        public static int getLastId()
        {
            return cartRepository.getLastId();
        }

        public static List<Cart> getCartList()
        {
            return cartRepository.getCartList();
        }

        public static List<Cart> getCartListFilterUserID(int UserID)
        {
            return cartRepository.getCartListFilterUserID(UserID);
        }

        public static void clearCart()
        {
            cartRepository.clearCart();
        }


    }
}