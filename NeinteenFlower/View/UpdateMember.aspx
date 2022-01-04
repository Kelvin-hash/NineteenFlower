<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateMember.aspx.cs" Inherits="NeinteenFlower.View.UpdateMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>MEMBER INFORMATION </h1>
          <div>
            <asp:Label runat="server" Text="Member Email : "></asp:Label>
            <asp:Label ID="lblEmail" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Member Password : "></asp:Label>
            <asp:Label ID="lblPassword" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Member Name : "></asp:Label>
            <asp:Label ID="lblName" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Member Date Of Birth : "></asp:Label>
            <asp:Label ID="lblDOB" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Member Gender : "></asp:Label>
            <asp:Label ID="lblGender" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Member Phone Number : "></asp:Label>
            <asp:Label ID="lblPhone" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Member Address : "></asp:Label>
            <asp:Label ID="lblAddress" runat="server"></asp:Label>
            <br />
        </div>
        <hr />
        <div>
            <h1>UPDATE MEMBER INFORMATION </h1>
            <asp:Label runat="server" Text="New Member Email : "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="New Member Password : "></asp:Label>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="New Member Name : "></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="New Member Date Of Birth : "></asp:Label>
            <asp:TextBox ID="txtDOB" TextMode="Date" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="New Member Gender : "></asp:Label>
            <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="New Member Phone Number : "></asp:Label>
            <asp:TextBox ID="txtphone" TextMode="Number" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="New Member Address : "></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" onclick="btnUpdate_Click"/>
</asp:Content>
