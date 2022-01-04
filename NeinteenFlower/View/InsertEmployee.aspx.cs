using NeinteenFlower.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class InsertEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserRole"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if(int.Parse(Session["UserRole"].ToString()) < 3)
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            DateTime dob = DateTime.Parse(txtDOB.Text);
            string gender = txtGender.Text;
            string phonenumber = txtphone.Text;
            string address = txtAddress.Text;
            int salary = int.Parse(txtSalary.Text);
            string message = EmployeeController.InsertEmployee(name, dob, gender, address, phonenumber, email, password, salary);
            if (message.Equals(""))
            {
                lblMessage.Text = "INSERT EMPLOYEE SUCCESS!!";
            }
            else
            {
                lblMessage.Text = message;
            }
        }
    }
}