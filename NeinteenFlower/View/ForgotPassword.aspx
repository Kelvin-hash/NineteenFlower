<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="NeinteenFlower.View.ForgetPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Email : "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Captcha : "></asp:Label>
        <asp:Label ID="lblCaptcha" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="New Password : "></asp:Label>
        <asp:TextBox ID="txtCaptcha" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnChangePassword" runat="server" Text="CHANGE PASSWORD" OnClick="btnChangePassword_Click" />
    </div>
</asp:Content>
