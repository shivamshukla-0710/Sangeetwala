<%@ Page Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="Category.aspx.cs" Inherits="Admin_Category" Title="Add Category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
.Gridview
{
font-family:Verdana;
font-size:10pt;
font-weight:normal;
color:black;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <div style="font-size:15px; color:Blue"> Add Category</div><br /><br />

<div align="center">
    <asp:GridView ID="gvDetails" DataKeyNames="id" runat="server" Width="300px"
AutoGenerateColumns="false" CssClass="Gridview" HeaderStyle-BackColor="#61A6F8"
ShowFooter="true" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White"
onrowcancelingedit="gvDetails_RowCancelingEdit"
onrowdeleting="gvDetails_RowDeleting" onrowediting="gvDetails_RowEditing"
onrowupdating="gvDetails_RowUpdating"
onrowcommand="gvDetails_RowCommand" 
        onselectedindexchanged="gvDetails_SelectedIndexChanged">
<Columns>
<asp:TemplateField>
<EditItemTemplate>
<asp:ImageButton ID="imgbtnUpdate" CommandName="Update" runat="server" ImageUrl="~/Admin/img/editicon.png" ToolTip="Update" Height="20px" Width="20px" />
<asp:ImageButton ID="imgbtnCancel" runat="server" CommandName="Cancel" ImageUrl="~/Admin/img/cancel.png" ToolTip="Cancel" Height="20px" Width="20px" />
</EditItemTemplate>
<ItemTemplate >
<asp:ImageButton ID="imgbtnEdit" CommandName="Edit" runat="server" 
        ImageUrl="~/Admin/img/editicon.png" ToolTip="Edit" Height="20px" Width="20px" />
<asp:ImageButton ID="imgbtnDelete" CommandName="Delete" Text="Edit" runat="server" ImageUrl="~/Admin/img/deleteicon.png" ToolTip="Delete" Height="20px" Width="20px" />
</ItemTemplate>
<FooterTemplate>
<asp:ImageButton ID="imgbtnAdd" runat="server" ImageUrl="~/Admin/img/new.png" CommandName="AddNew" Width="30px" Height="30px" ToolTip="Add New Category" ValidationGroup="validaiton" />
</FooterTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="Category" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="200px">
<EditItemTemplate>
<asp:Label ID="lbleditusr" runat="server" Text='<%#Eval("category") %>'/>
</EditItemTemplate>
<ItemTemplate>
<asp:Label ID="lblitemUsr" runat="server" Text='<%#Eval("category") %>'/>
</ItemTemplate>
<FooterTemplate>
<asp:TextBox ID="txtftrusrname" runat="server"/>
<asp:RequiredFieldValidator ID="rfvusername" Display="Dynamic" runat="server" ControlToValidate="txtftrusrname" Text="Please Enter Category" ValidationGroup="validaiton"/>
</FooterTemplate>

<ItemStyle HorizontalAlign="Center" Width="200px"></ItemStyle>
</asp:TemplateField>


</Columns>

<HeaderStyle BackColor="#61A6F8" Font-Bold="True" ForeColor="White"></HeaderStyle>
</asp:GridView>
</div>
<asp:Label ID="lblresult" runat="server"></asp:Label>

</div>
</asp:Content>

