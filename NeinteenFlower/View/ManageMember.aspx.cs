using NeinteenFlower.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class ManageMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (int.Parse(Session["UserRole"].ToString()) < 3)
            {
                Response.Redirect("Home.aspx");
            }

            if (!Page.IsPostBack)
            {
                FetchData();
            }
        }

        private void FetchData()
        {
            gvMemberList.DataSource = MemberController.GetAllMembers();
            gvMemberList.DataBind();
        }

        protected void btnUpdateMember_Click(object sender, EventArgs e)
        {
            var id = (sender as Button).CommandArgument;
            Response.Redirect("UpdateMember.aspx?id=" + id);
        }

        protected void btnDeleteMember_Click(object sender, EventArgs e)
        {
            var id = (sender as Button).CommandArgument;
            MemberController.DeleteMemberID(int.Parse(id));
            FetchData();
        }

        protected void btnInsertMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertMember.aspx");
        }
    }
}