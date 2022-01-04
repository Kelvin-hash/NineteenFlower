using NeinteenFlower.Factory;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeinteenFlower.Repository
{
    public class TransactionRepository
    {
        public static void PreOrder(int memberid, DateTime currentdate, decimal discount, TrDetail detail)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            db.TrHeaders.Add(TransactionFactory.CreateHeader(memberid, currentdate, discount, detail));
            db.SaveChanges();
        }

        public static List<TrHeader> GetTransaction(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return (from x in db.TrHeaders where x.MemberID == id select x).ToList();
        }

        public static List<TrHeader> GetTransaction()
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return db.TrHeaders.ToList();
        }
    }
}