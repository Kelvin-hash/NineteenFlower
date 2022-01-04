using NeinteenFlower.Controller;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class Preorder : System.Web.UI.Page
    {
        public static MsFlower flowers;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string strid = Request.QueryString["id"];
                int id = int.Parse(strid);

                flowers = FlowerController.GetFlowerID(id);
                if (flowers != null)
                {
                    imageFlower.ImageUrl = flowers.FlowerImage;
                    lblName.Text = flowers.FlowerName;
                    lblType.Text = flowers.FlowerType;
                    lblDesc.Text = flowers.FlowerDescription;
                    lblPrice.Text = flowers.FlowerPrice.ToString();
                }
                else
                {
                    Server.Transfer("./Home.aspx");
                }
            }
        }

        protected void btnPreorder_Click(object sender, EventArgs e)
        {
            
            string strquantity = txtQuantity.Text;
            int quantity = int.Parse(strquantity);
            DateTime currentdate = DateTime.Now;
            string message = TransactionController.PreOrder((int)Session["UserID"], flowers.FlowerID, quantity, currentdate);
            if (message.Equals(""))
            {
                lblMessage.Text = "PREORDER SUCCESS!!";
            }
            else
            {
                lblMessage.Text = message;
            }
        }
    }
}