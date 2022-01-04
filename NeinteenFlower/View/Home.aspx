<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NeinteenFlower.View.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="lblName" runat="server" Text="Welcome to Neinteen Flower, "></asp:Label>
    </div>
    <div>
        <asp:Button ID="btnView" runat="server" Text="VIEW TRANSACTION HISTORY" OnClick="btnView_Click" />
        <table id="TableFlower">
            <asp:repeater id="FlowerRepeat" runat="server">
                <HeaderTemplate>
                    <tr>
                        <th><p>Image</p></th>
                        <th><p>Name</p></th>
                        <th><p>Type</p></th>
                        <th><p>Description</p></th>
                        <th><p>Price</p></th>
                        <th><p>Preorder</p></th>
                    </tr>
                </HeaderTemplate>
                <itemtemplate>
                    <tr>
                        <td><asp:Image runat="server" imageurl='<%# Eval("FlowerImage") %>' style="height:100px;"></asp:Image></td>
                        <td><asp:label id="lblName" runat="server" text='<%# Eval("FlowerName") %>'></asp:label></td>
                        <td><asp:label id="lblType" runat="server" text='<%# Eval("FlowerType") %>'></asp:label></td>
                        <td><asp:label id="lblDes" runat="server" text='<%# Eval("FlowerDescription") %>'></asp:label></td>
                        <td><asp:label id="lblPrice" runat="server" text='<%# Eval("FlowerPrice") %>'></asp:label></td>
                        <td><asp:Button ID="btnpreorder" runat="server" text="PREORDER" CommandName="preorder" CommandArgument='<%# Eval("FlowerID") %>' onclick="btnpreorder_Click"/></td>
                    </tr>
                </itemtemplate>
            </asp:repeater>
          </table>
    </div>
    <div>
        <asp:Button ID="btnManageFlower" runat="server" Text="MANAGE FLOWER" OnClick="btnManageFlower_Click" />
    </div>
    <div>
        <asp:Button ID="btnManageMember" runat="server" Text="MANAGE MEMBER" OnClick="btnManageMember_Click" />
        <asp:Button ID="btnManageEmployee" runat="server" Text="MANAGE EMPLOYEE" OnClick="btnManageEmployee_Click" />
    </div>
    <div>
        <asp:Button ID="btnHome" runat="server" Text="HOME" OnClick="btnHome_Click" />
        <asp:Button ID="btnLogout" runat="server" Text="LOGOUT" OnClick="btnLogout_Click" />
    </div>
</asp:Content>
