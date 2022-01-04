using NeinteenFlower.Model;
using System.Collections.Generic;
using System.Linq;

namespace NeinteenFlower.Repository
{
    public class FlowerRepository
    {
        public static List<MsFlower> GetallFlower()
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return db.MsFlowers.ToList();
        }

        public static Model.MsFlower GetFlowerByID(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return db.MsFlowers.Find(id);
        }

        public static void DeleteFlower(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsFlower Flower = db.MsFlowers.Find(id);

            db.MsFlowers.Remove(Flower);
            db.SaveChanges();

        }

        public static void InsertFlower(MsFlower Flower)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();

            db.MsFlowers.Add(Flower);
            db.SaveChanges();
        }
        public static void UpdateFlower(int id, string name, string Path, string Desc, string Type, int Price)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsFlower flower = (from x in db.MsFlowers where x.FlowerID == id select x).FirstOrDefault();
            flower.FlowerName = name;
            flower.FlowerImage = Path;
            flower.FlowerDescription = Desc;
            flower.FlowerPrice = Price;
            flower.FlowerType = Type;
            db.SaveChanges();
        }

        public static MsFlower GetFlowerID(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            MsFlower flowers = (from x in db.MsFlowers where x.FlowerID == id select x).FirstOrDefault();
            return flowers;
        }

        public static List<MsFlower> GetAllFlowers()
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return (from x in db.MsFlowers select x).ToList();
        }
        public static MsFlower GetFlowers(int id)
        {
            NeinteenFlowerDBEntities db = new NeinteenFlowerDBEntities();
            return (from x in db.MsFlowers where x.FlowerID == id select x).FirstOrDefault();
        }
    }
}