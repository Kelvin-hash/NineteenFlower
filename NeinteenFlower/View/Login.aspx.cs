using NeinteenFlower.Controller;
using NeinteenFlower.Handler;
using System;
using System.Web;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] != null)
            {
                Response.Redirect("Home.aspx");
            }

            if (!(Request.Cookies["user_cookie"] == null || Request.Cookies["user_cookie"].Expires >= DateTime.Now))
            {
                txtEmail.Text = Request.Cookies["user_cookie"].Values.Get("email");
                txtPassword.Attributes["value"] = Request.Cookies["user_cookie"].Values.Get("password");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            bool isRemember = cbRemember.Checked;

            bool isAdmin = false;
            bool isEmployee = false;
            bool isMember = false;
            string message = "";

            //Check Member & Admin
            message = MemberController.Login(email, password);
            isMember = message == "";
            isAdmin = message == "ADMIN";
            message = "";

            //Check Employee
            if (!isMember && !isAdmin)
            {
                message = EmployeeController.Login(email, password);
                isEmployee = message == "";
            }

            if (message.Equals(""))
            {
                Session["UserName"] = isAdmin ? "Admin"
                    : isMember ? MemberHandler.Login(email, password).MemberName
                    : EmployeeHandler.Login(email, password).EmployeeName;
                Session["UserRole"] = isAdmin ? 3 : isEmployee ? 2 : 1;
                if (isMember)
                {
                    Session["UserID"] = MemberHandler.Login(email, password).MemberID;
                }

                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Values.Add("email", email);
                    cookie.Values.Add("password", password);
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);
                }
                lblMessage.Text = "Login Success";
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblMessage.Text = message;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnForgot_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgotPassword.aspx");
        }
    }
}