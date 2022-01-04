using NeinteenFlower.Factory;
using NeinteenFlower.Model;
using NeinteenFlower.Repository;
using System.Collections.Generic;

namespace NeinteenFlower.Handler
{
    public class FlowerHandler
    {
        public static string InsertFlower(string name, string Path, string Desc, string Type, int Price)
        {

            MsFlower flower = FlowerFactory.CreateFlower(name, Path, Desc, Type, Price);
            FlowerRepository.InsertFlower(flower);
            return "";
        }

        public static string UpdateFlower(int id, string name, string Path, string Desc, string Type, int Price)
        {
            FlowerRepository.UpdateFlower(id, name, Path, Desc, Type, Price);
            return "";
        }

        public static MsFlower GetFlowerID(int id)
        {
            return FlowerRepository.GetFlowerID(id);
        }

        public static MsFlower GetFlowers(int id)
        {
            return FlowerRepository.GetFlowers(id);
        }

        public static List<MsFlower> GetAllFlowers()
        {
            return FlowerRepository.GetAllFlowers();
        }
    }
}