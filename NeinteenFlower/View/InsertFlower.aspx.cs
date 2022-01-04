using NeinteenFlower.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class InsertFlower : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (int.Parse(Session["UserRole"].ToString()) < 2)
            {
                Response.Redirect("Home.aspx");
            }

            if (!IsPostBack)
            {
                setTypeDropdown();
            }
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
            var newFilename = new Guid().ToString();
            var path = HttpContext.Current.Server.MapPath("~/Asset/" + file.FileName);
            string imagePath = "../Asset/" + file.FileName;

            var folder = Server.MapPath("~/Asset");
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            string Valid = FlowerController.InsertFlower(name, imagePath1, Description, Type, price, imagePath);

            

            if (Valid.Equals(""))
            {
                file.SaveAs(path);
                Response.Redirect("ManageFlower.aspx");
            }
            else
            {
                Message.Text = Valid;
            }
        }
    }
}