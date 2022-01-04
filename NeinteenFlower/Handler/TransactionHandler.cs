using NeinteenFlower.Factory;
using NeinteenFlower.Model;
using NeinteenFlower.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Handler
{
    public class TransactionHandler
    {
        public static string PreOrder(int memberid, int flowerid, int quantity, decimal discount, DateTime currentdate)
        {

            TrDetail detail = TransactionFactory.CreateDetail(flowerid, quantity);
            TransactionRepository.PreOrder(memberid,currentdate,discount, detail);
            return "";
        }

        public static List<TrHeader> GetTransactions(int id)
        {
            return TransactionRepository.GetTransaction(id);
        }
    }
}