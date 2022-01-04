<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateEmployee.aspx.cs" Inherits="NeinteenFlower.View.UpdateEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>EMPLOYEE INFORMATION </h1>
          <div>
            <asp:Label runat="server" Text="Employee Email : "></asp:Label>
            <asp:Label ID="lblEmail" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Employee Password : "></asp:Label>
            <asp:Label ID="lblPassword" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Employee Name : "></asp:Label>
            <asp:Label ID="lblName" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Employee Date Of Birth : "></asp:Label>
            <asp:Label ID="lblDOB" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Employee Gender : "></asp:Label>
            <asp:Label ID="lblGender" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Employee Phone Number : "></asp:Label>
            <asp:Label ID="lblPhone" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Employee Address : "></asp:Label>
            <asp:Label ID="lblAddress" runat="server"></asp:Label>
            <br />
              <asp:Label runat="server" Text="Employee Salary : "></asp:Label>
            <asp:Label ID="lblSalary" runat="server"></asp:Label>
            <br />
        </div>
        <hr />
        <div>
            <h1>UPDATE EMPLOYEE INFORMATION </h1>
            <asp:Label runat="server" Text="New Employee Email : "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="New Employee Password : "></asp:Label>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="New Employee Name : "></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="New Employee Date Of Birth : "></asp:Label>
            <asp:TextBox ID="txtDOB" TextMode="Date" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="New Employee Gender : "></asp:Label>
            <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="New Employee Phone Number : "></asp:Label>
            <asp:TextBox ID="txtphone" TextMode="Number" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="New Employee Address : "></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="New Employee Salary : "></asp:Label>
            <asp:TextBox ID="txtSalary" TextMode="Number" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" onclick="btnUpdate_Click"/>
</asp:Content>
