using NeinteenFlower.Controller;
using NeinteenFlower.Dataset;
using NeinteenFlower.Handler;
using NeinteenFlower.Model;
using NeinteenFlower.Report;
using System;
using System.Collections.Generic;

namespace NeinteenFlower.View
{
    public partial class ViewTransaction : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRole"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            // Member Only
            if (int.Parse(Session["UserRole"].ToString()) != 1)
            {
                Response.Redirect("Home.aspx");
            }
            id = int.Parse(Session["UserID"].ToString());
            CrystalReport report = new CrystalReport();
            CrystalReportViewer1.ReportSource = report;
            report.SetDataSource(getData());

        }

        private DataSet getData()
        {
            DataSet data = new DataSet();
            List<TrHeader> trHeaders = TransactionHandler.GetTransactions(id);
            var headerTable = data.TrHeader;
            var detailTable = data.TrDetail;
            int total = 0;
            foreach (TrHeader t in trHeaders)
            {
                var hRow = headerTable.NewRow();
                hRow["TransactionID"] = t.TransactionID;
                hRow["MemberID"] = t.MemberID;
                hRow["MemberName"] = t.MsMember.MemberName;
                hRow["TransactionDate"] = t.TransactionDate;
                

                TrDetail td = t.TrDetail;

                var dRow = detailTable.NewRow();
                dRow["TransactionID"] = td.TransactionID;
                dRow["FlowerID"] = td.FlowerID;
                MsFlower flowers = FlowerController.GetFlowerID(td.FlowerID);
                dRow["FlowerName"] = flowers.FlowerName;
                dRow["Quantity"] = td.Quantity;
                dRow["Price"] = flowers.FlowerPrice;
                dRow["SubTotal"] = flowers.FlowerPrice * td.Quantity;
                total += flowers.FlowerPrice * td.Quantity;

                hRow["GrandTotal"] = total;
                headerTable.Rows.Add(hRow);

                detailTable.Rows.Add(dRow);
            }
            return data;
        }

    }
}
