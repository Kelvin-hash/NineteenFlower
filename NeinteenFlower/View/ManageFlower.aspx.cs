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
    public partial class ManageFlower : System.Web.UI.Page
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

            if (!Page.IsPostBack)
            {
                List<Model.MsFlower> Flowers = FlowerRepository.GetallFlower();
                FlowerRepeat.DataSource = Flowers;
                FlowerRepeat.DataBind();
            }
        }

        protected void FlowerRepeat_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                int ID = Convert.ToInt32(e.CommandArgument);

                //Remove Image
                MsFlower Flower = FlowerRepository.GetFlowerByID(ID);
                string path = Server.MapPath("~/Asset/" + Flower.FlowerImage);
                FileInfo file = new FileInfo(path);
                if (file.Exists)
                {
                    file.Delete();
                }

                FlowerRepository.DeleteFlower(ID);
                Response.Redirect("ManageFlower.aspx");
            }

            if (e.CommandName == "Update")
            {
                int ID = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("UpdateFlower.aspx?id=" + ID);
            }
        }
    }
}