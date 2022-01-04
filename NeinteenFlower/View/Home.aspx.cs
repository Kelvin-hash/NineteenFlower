using NeinteenFlower.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null)
            {
                Response.Redirect("Login.aspx");
            }


            int userRole = int.Parse(Session["UserRole"].ToString());

            if (!Page.IsPostBack)
            {
                lblName.Text = lblName.Text + Session["UserName"].ToString();
                FlowerRepeat.Visible = false;
                btnView.Visible = false;
                btnManageMember.Visible = false;
                btnManageEmployee.Visible = false;
                btnManageFlower.Visible = false;
                switch (userRole)
                {
                    case 1:
                        FlowerRepeat.Visible = true;
                        btnView.Visible = true;
                        FetchFlower();
                        break;
                    case 2:
                        btnManageFlower.Visible = true;
                        break;
                    case 3:
                        btnManageMember.Visible = true;
                        btnManageEmployee.Visible = true;
                        break;
                }
            }
        }

        private void FetchFlower()
        {
            List<Model.MsFlower> Flowers = FlowerRepository.GetallFlower();
            FlowerRepeat.DataSource = Flowers;
            FlowerRepeat.DataBind();
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransaction.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            String[] cookies = Request.Cookies.AllKeys;
            foreach (string cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }
            Session.Remove("UserRole");
            Session.Remove("UserName");
            Session.Remove("UserID");
            Response.Redirect("Login.aspx");
        }

        protected void btnManageEmployee_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageEmployee.aspx");
        }

        protected void btnManageMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageMember.aspx");
        }

        protected void btnManageFlower_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageFlower.aspx");
        }

        protected void btnpreorder_Click(object sender, EventArgs e)
        {
            var id = (sender as Button).CommandArgument;
            Response.Redirect("Preorder.aspx?id=" + id);
        }
    }
}