using NeinteenFlower.Controller;
using NeinteenFlower.Model;
using System;
using System.Web.UI;

namespace NeinteenFlower.View
{
    public partial class UpdateMember : System.Web.UI.Page
    {
        static MsMember members;
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
                string strid = Request.QueryString["id"];
                int id = int.Parse(strid);

                members = MemberController.GetMemberID(id);
                if (members != null)
                {
                    lblEmail.Text = members.MemberEmail;
                    lblPassword.Text = members.MemberPassword;
                    lblName.Text = members.MemberName;
                    lblDOB.Text = members.MemberDOB.ToString();
                    lblGender.Text = members.MemberGender;
                    lblPhone.Text = members.MemberPhone;
                    lblAddress.Text = members.MemberAddress;
                }
                else
                {
                    Server.Transfer(".ManageMember.aspx");
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            DateTime dob = DateTime.Parse(txtDOB.Text);
            string gender = txtGender.Text;
            string phonenumber = txtphone.Text;
            string address = txtAddress.Text;
            string message = MemberController.Update(members.MemberID, name, dob, gender, address, phonenumber, email, password);
            if (message.Equals(""))
            {
                lblMessage.Text = "UPDATE SUCCESS!!";
            }
            else
            {
                lblMessage.Text = message;
            }
        }
    }
}