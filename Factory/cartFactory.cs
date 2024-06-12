using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Factory
{
    public class cartFactory
    {

        public static Cart create(int CartID, int UserID, int MakeupID, int Quantity)
        {
            Cart carts = new Cart();
            carts.CartID = CartID;
            carts.UserID = UserID;
            carts.MakeupID = MakeupID;
            carts.Quantity = Quantity;
            return carts;
        }


    }
}