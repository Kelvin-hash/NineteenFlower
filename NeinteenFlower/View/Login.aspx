<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NeinteenFlower.View.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <asp:Label runat="server" Text="Email : "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:CheckBox ID="cbRemember" runat="server" text="Remember Me"/>
        </div>

        <div>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Button ID="btnLogin" runat="server" Text="LOGIN" OnClick="btnLogin_Click" />
        </div>

        <div>
            <asp:LinkButton ID="btnRegister" runat="server" OnClick="btnRegister_Click">REGISTER</asp:LinkButton>
        </div>

        <div>
            <asp:LinkButton ID="btnForgot" runat="server" OnClick="btnForgot_Click">FORGOT PASSWORD</asp:LinkButton>
        </div>
    </div>
</asp:Content>
