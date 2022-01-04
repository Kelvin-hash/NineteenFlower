using NeinteenFlower.Controller;
using NeinteenFlower.Model;
using NeinteenFlower.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class UpdateFlower : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (int.Parse(Session["UserRole"].ToString()) != 2)
            {
                Response.Redirect("Home.aspx");
            }

            setTypeDropdown();
            string idTxt = Request.QueryString["id"];
            if (idTxt == null)
            {
                Response.Redirect("ManageFlower.aspx");
            }

            id = int.Parse(idTxt);
            Model.MsFlower Flower = FlowerRepository.GetFlowerByID(id);

            if (Flower == null)
            {
                Response.Redirect("ManageFlower.aspx");
            }

            TextName.Attributes["value"] = Flower.FlowerName;
            TextDes.Attributes["value"] = Flower.FlowerDescription;
            TextPrice.Attributes["value"] = Flower.FlowerPrice.ToString();

        }

        private void setTypeDropdown()
        {
            TypeDropDown.Items.Add("Select Type");
            TypeDropDown.Items.Add("Daisies");
            TypeDropDown.Items.Add("Lilies");
            TypeDropDown.Items.Add("Roses");
        }

        protected void ValidBTN_Click(object sender, EventArgs e)
        {
            string name = TextName.Text;
            bool imagePath1 = ImageUpload.HasFiles;
            string Description = TextDes.Text;
            string Type = TypeDropDown.SelectedValue;
            int price = int.Parse(TextPrice.Text);
            var file = ImageUpload.PostedFile;
            var extension = System.IO.Path.GetExtension(file.FileName);

            var path = HttpContext.Current.Server.MapPath("~/Asset/" + file.FileName);
            var folder = Server.MapPath("~/Asset");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            //Remove Image
            MsFlower Flower = FlowerRepository.GetFlowerByID(id);
            string oldPath = Server.MapPath("~/Asset/" + Flower.FlowerImage);
            FileInfo oldFile = new FileInfo(oldPath);
            if (oldFile.Exists)
            {
                oldFile.Delete();
            }

            string imagePath = "../Asset/" + file.FileName;
            string Valid = FlowerController.UpdateFlower(id, name, imagePath1, Description, Type, price, imagePath);
            

            if (Valid.Equals(""))
            {
                if (path.Length == 0)
                {
                    Response.Redirect("ManageFlower.aspx");
                }
                else
                {
                    file.SaveAs(path);
                    Response.Redirect("ManageFlower.aspx");
                }

            }
            else
            {
                Message.Text = Valid;
            }
        }
    }
}