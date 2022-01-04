using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Factory
{
    public class TransactionFactory
    {
        public static TrHeader CreateHeader(int memberid, DateTime currentdate, decimal discount, TrDetail detail)
        {
            TrHeader header = new TrHeader()
            {
                MemberID = memberid,
                TransactionDate = currentdate,
                DiscountPercentage = discount,
                TrDetail = detail
            };
            return header;
        }

        public static TrDetail CreateDetail(int flowerid, int quantity)
        {
            TrDetail detail = new TrDetail()
            {
                FlowerID = flowerid,
                Quantity = quantity
            };
            return detail;
        }
    }
}