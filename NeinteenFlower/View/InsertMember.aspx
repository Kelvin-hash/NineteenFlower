<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertMember.aspx.cs" Inherits="NeinteenFlower.View.InsertMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <h1>INSERT NEW MEMBER</h1>
            <hr />
            <asp:Label runat="server" Text="Email : "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label runat="server" Text="Name : "></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label runat="server" Text="Date Of Birth : "></asp:Label>
            <asp:TextBox ID="txtDOB" TextMode="Date" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label runat="server" Text="Gender : "></asp:Label>
            <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label runat="server" Text="Phone Number : "></asp:Label>
            <asp:TextBox ID="txtphone" TextMode="Number" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label runat="server" Text="Address : "></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnInsert" runat="server" Text="INSERT" OnClick="btnInsert_Click" />
        </div>
</asp:Content>
