<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="ManageEmployee.aspx.cs" Inherits="NeinteenFlower.View.ManageEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:LinkButton ID="btnInsertEmployee" runat="server" OnClick="btnInsertEmployee_Click">INSERT MEMBER</asp:LinkButton>
        <asp:GridView ID="gvEmployeeList" runat="server">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnUpdateEmployee" runat="server" Text="UPDATE MEMBER" OnClick="btnUpdateEmployee_Click" CommandArgument='<%# Eval("EmployeeID") %>' />
                        <asp:Button ID="btnDeleteEmployee" runat="server" Text="DELETE MEMBER" OnClick="btnDeleteEmployee_Click" CommandArgument='<%# Eval("EmployeeID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
