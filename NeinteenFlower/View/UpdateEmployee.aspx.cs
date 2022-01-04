using NeinteenFlower.Controller;
using NeinteenFlower.Model;
using System;
using System.Web.UI;

namespace NeinteenFlower.View
{
    public partial class UpdateEmployee : System.Web.UI.Page
    {
        static MsEmployee employees;
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

                employees = EmployeeController.GetEmployeeID(id);
                if (employees != null)
                {
                    lblEmail.Text = employees.EmployeeEmail;
                    lblPassword.Text = employees.EmployeePassword;
                    lblName.Text = employees.EmployeeName;
                    lblDOB.Text = employees.EmployeeDOB.ToString();
                    lblGender.Text = employees.EmployeeGender;
                    lblPhone.Text = employees.EmployeePhone;
                    lblAddress.Text = employees.EmployeeAddress;
                    lblSalary.Text = employees.EmployeeSalary.ToString();
                }
                else
                {
                    Server.Transfer("./ManageEmployee.aspx");
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
            int salary = int.Parse(txtSalary.Text);
            string message = EmployeeController.Update(employees.EmployeeID, name, dob, gender, address, phonenumber, email, password, salary);
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