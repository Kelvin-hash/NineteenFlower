<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.Master" AutoEventWireup="true" CodeBehind="ManageMember.aspx.cs" Inherits="NeinteenFlower.View.ManageMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <asp:LinkButton ID="btnInsertMember" runat="server" OnClick="btnInsertMember_Click">INSERT MEMBER</asp:LinkButton>
            <asp:GridView ID="gvMemberList" runat="server">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnUpdateMember" runat="server" Text="UPDATE MEMBER" onclick="btnUpdateMember_Click" CommandArgument='<%# Eval("MemberID") %>'/>
                             <asp:Button ID="btnDeleteMember" runat="server" Text="DELETE MEMBER" onclick="btnDeleteMember_Click" CommandArgument='<%# Eval("MemberID") %>'/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
</asp:Content>
