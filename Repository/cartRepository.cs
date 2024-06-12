using FinalProjectPSD.Factory;
using FinalProjectPSD.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace FinalProjectPSD.Repository
{
    public class cartRepository
    {
        public static List<Cart> carts = null;
        public static MakeMeUpzzDatabaseEntities db = DatabaseSingleton.getInstance();


        public static void insertCart(int CartID, int UserID, int MakeupID, int Quantity)
        {
            Cart cart = cartFactory.create(CartID, UserID, MakeupID, Quantity);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static List<Cart> getCartList()
        {
            return (from x in db.Carts select x).ToList();
        }

        public static int getLastId()
        {
            return (from x in db.Carts select x.CartID).ToList().LastOrDefault();
        }

        public static void clearCart()
        {
            // Retrieve all cart items
            var cartItems = getCartList();

            // Remove each cart item from the database
            foreach (var cartItem in cartItems)
            {
                db.Carts.Remove(cartItem);
            }

            // Save changes to commit the deletion
            db.SaveChanges();
        }

        public static List<Cart> getCartListFilterUserID(int UserID)
        {
            return (from x in db.Carts where x.UserID.Equals(UserID) select x).ToList();
        }


    }
}