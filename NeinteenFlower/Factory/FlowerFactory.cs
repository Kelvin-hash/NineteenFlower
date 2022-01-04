using NeinteenFlower.Model;

namespace NeinteenFlower.Factory
{
    public class FlowerFactory
    {
        public static MsFlower CreateFlower(string name, string Image,
           string Description, string Type, int price)
        {
            MsFlower Flower = new MsFlower()
            {
                FlowerName = name,
                FlowerImage = Image,
                FlowerDescription = Description,
                FlowerType = Type,
                FlowerPrice = price
            };

            return Flower;
        }
    }
}