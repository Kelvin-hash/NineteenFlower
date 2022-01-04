using NeinteenFlower.Handler;
using NeinteenFlower.Model;
using System.Collections.Generic;

namespace NeinteenFlower.Controller
{
    public class FlowerController
    {
        public static string InsertFlower(string name, bool Path, string Desc, string Type, int Price, string imagePath)
        {
            if (name.Length < 5)
            {
                return "Minimal 5 Character";
            }

            if (!Path)
            {
                return "Please Choose a Picture";
            }
            else
            {
                if (!imagePath.Contains(".jpg"))
                {
                    return "Extension must be .JPG";
                }
            }

            if (Desc.Length <= 50)
            {
                return "Description must be longer than 50 character";
            }

            if (Type == "Select Type")
            {
                return "Please Choose the Type";
            }

            if (!(Price >= 20 && Price <= 100))
            {
                return "Price must be between 20 and 100";
            }

            return FlowerHandler.InsertFlower(name, imagePath, Desc, Type, Price);
        }

        public static string UpdateFlower(int id, string name, bool Path, string Desc, string Type, int Price, string imagePath)
        {
            if (name.Length < 5)
            {
                return "Minimal 5 Character";
            }

            if (!Path)
            {
                return "Please Choose  a Picture";
            }
            else
            {
                if (!imagePath.Contains(".jpg"))
                {
                    return "Extension must be .JPG";
                }
            }

            if (Desc.Length <= 50)
            {
                return "Description must be longer than 50 character";
            }

            if (Type == "Select Type")
            {
                return "Please Choose the Type";
            }

            if (!(Price >= 20 && Price <= 100))
            {
                return "Price must be between 20 and 100";
            }

            return FlowerHandler.UpdateFlower(id, name, imagePath, Desc, Type, Price);
        }

        public static MsFlower GetFlowerID(int id)
        {
            return FlowerHandler.GetFlowerID(id);
        }

        public static MsFlower GetFlowers(int id)
        {
            return FlowerHandler.GetFlowers(id);
        }
        public static List<MsFlower> GetAllFlowers()
        {
            return FlowerHandler.GetAllFlowers();
        }
    }
}
