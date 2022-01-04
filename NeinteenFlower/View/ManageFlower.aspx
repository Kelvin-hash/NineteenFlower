<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="ManageFlower.aspx.cs" Inherits="NeinteenFlower.View.ManageFlower" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:HyperLink ID="InsertHyperLink" runat="server" NavigateUrl="~/View/InsertFlower.aspx">Insert Flower</asp:HyperLink>
    </div>
    <br />
    <div>
          <table>
            <asp:repeater id="FlowerRepeat" runat="server" OnItemCommand="FlowerRepeat_ItemCommand">
                <HeaderTemplate>
                    <tr>
                        <th><p>Image</p></th>
                        <th><p>Name</p></th>
                        <th><p>Type</p></th>
                        <th><p>Description</p></th>
                        <th><p>Price</p></th>
                        <th><p>Update</p></th>
                        <th><p>Delete</p></th>
                    </tr>
                </HeaderTemplate>
                <itemtemplate>
                    <tr>
                        <td><asp:Image runat="server" imageurl='<%# Eval("FlowerImage") %>' style="height:50px;"></asp:Image></td>
                        <td><asp:label id="lblName" runat="server" text='<%# Eval("FlowerName") %>'></asp:label></td>
                        <td><asp:label id="lblType" runat="server" text='<%# Eval("FlowerType") %>'></asp:label></td>
                        <td><asp:label id="lblDes" runat="server" text='<%# Eval("FlowerDescription") %>'></asp:label></td>
                        <td><asp:label id="lblPrice" runat="server" text='<%# Eval("FlowerPrice") %>'></asp:label></td>
                        <td><asp:Button ID="UdpateBtn" runat="server" CommandName="Update" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"FlowerID") %>' Text="UPDATE FLOWER"/></td>
                        <td><asp:Button ID="DeleteBtn" runat="server" CommandName="Delete" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"FlowerID") %>' Text="DELETE FLOWER"/></td>
                    </tr>
                </itemtemplate>
            </asp:repeater>
          </table>
        </div>
</asp:Content>
