<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="Preorder.aspx.cs" Inherits="NeinteenFlower.View.Preorder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>FLOWER INFORMATION </h1>
          <div>
             <asp:Label runat="server" Text="Flower Image : "></asp:Label>
              <asp:Image ID="imageFlower" runat="server" Width="100px" Height="100px" />
            <br />
            <asp:Label runat="server" Text="Flower Name : "></asp:Label>
            <asp:Label ID="lblName" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Flower Type : "></asp:Label>
            <asp:Label ID="lblType" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Flower Desc : "></asp:Label>
            <asp:Label ID="lblDesc" runat="server"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Flower Price : "></asp:Label>
            <asp:Label ID="lblPrice" runat="server"></asp:Label>
            <br />
        </div>
        <hr />
        <div>
            <asp:Label ID="LabelQuantity" runat="server" Text="Quantity :"></asp:Label>
            <br />
            <asp:TextBox ID="txtQuantity" runat="server" TextMode="Number"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnPreorder" runat="server" Text="PREORDER FLOWER" onclick="btnPreorder_Click"/>
        </div>
</asp:Content>
