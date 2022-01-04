using NeinteenFlower.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class ManageEmployee : System.Web.UI.Page
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
            gvEmployeeList.DataSource = EmployeeController.GetAllEmployees();
            gvEmployeeList.DataBind();
        }

        protected void btnInsertEmployee_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertEmployee.aspx");
        }

        protected void btnUpdateEmployee_Click(object sender, EventArgs e)
        {

            var id = (sender as Button).CommandArgument;
            Response.Redirect("UpdateEmployee.aspx?id=" + id);

        }

        protected void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            var id = (sender as Button).CommandArgument;
            EmployeeController.DeleteEmployeeID(int.Parse(id));
            FetchData();
        }
    }
}