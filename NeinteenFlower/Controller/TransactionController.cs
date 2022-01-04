using NeinteenFlower.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Controller
{
    public class TransactionController
    {
        public static string PreOrder(int memberid, int flowerid, int quantity, DateTime currentdate)
        {
            decimal discount = 0;
            if (quantity < 1 && quantity > 100)
            {
                return "Quantity must be between 1 to 100";
            }
            return TransactionHandler.PreOrder(memberid, flowerid, quantity, discount, currentdate);
        }
    }
}