using NeinteenFlower.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class ForgetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] != null)
            {
                Response.Redirect("Home.aspx");
            }

            if (!Page.IsPostBack)
            {
                Random randomNumber = new Random();
                int number = randomNumber.Next(1, 10);
                int number1 = randomNumber.Next(1, 10);
                int number2 = randomNumber.Next(1, 10);
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                var stringChars = new char[3];
                var randomString = new Random();
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[randomString.Next(chars.Length)];
                }
                var finalString = new String(stringChars);
                lblCaptcha.Text = finalString + number + number1 + number2;
            }
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            string captcha = lblCaptcha.Text;
            string email = txtEmail.Text;
            string newpassword = txtCaptcha.Text;
            string message = MemberController.ChangePassword(email, newpassword, captcha);

            if (message.Equals(""))
            {
                lblMessage.Text = "Change Password Success";
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblMessage.Text = message;
            }
        }
    }
}