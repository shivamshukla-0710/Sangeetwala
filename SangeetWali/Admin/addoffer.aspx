<%@ Page Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="addoffer.aspx.cs" Inherits="Admin_addoffer" Title="Add Offer" %>

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
<div style="font-size:15px; color:Blue"> Add Offer</div><br /><br />
<div align="center" style="height:500px;">
    <asp:GridView ID="GridView1"  runat="server" Width="100%"
AutoGenerateColumns="false" AllowPaging="True" PagerSettings-Mode="Numeric"   PageSize="4" OnPageIndexChanging="PageIndexChanging"  CssClass="Gridview" HeaderStyle-BackColor="#61A6F8"
ShowFooter="true" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White"
 HorizontalAlign="Center" OnRowCommand="GridView1_RowCommand">
<Columns>
 <asp:TemplateField HeaderText="Delete" ItemStyle-HorizontalAlign="Center">
     <ItemTemplate>
     <asp:LinkButton ID="tree1" runat="server" CommandArgument='<%#Eval("id") %>' ForeColor="Red" CommandName="Delkey" ><img src="img/deleteicon.png" width="15px" height="15px" /></asp:LinkButton>
     </ItemTemplate>     
     </asp:TemplateField>
<asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" Visible="false" />
<asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="Detail" HeaderText="Detail" SortExpression="Detail" Visible="true" ItemStyle-HorizontalAlign="Center" />

<asp:ImageField DataImageUrlField="Image" HeaderText="Image" ItemStyle-Height="60px" ItemStyle-Width="60px"></asp:ImageField>
</Columns>
<HeaderStyle BackColor="#61A6F8" Font-Bold="True" ForeColor="White"></HeaderStyle>
</asp:GridView>
<br />
<table>
    <tr><td>Service</td><td>
    <asp:DropDownList ID="ddlservices" runat="server" ></asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ControlToValidate="txttitle" ErrorMessage="*" ValidationGroup="submit"></asp:RequiredFieldValidator>
    </td></tr>

<tr><td>Title</td><td>
    <asp:TextBox ID="txttitle" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ControlToValidate="txttitle" ErrorMessage="*" ValidationGroup="submit"></asp:RequiredFieldValidator>
    </td></tr>

    <tr><td>Discount (Numeric Only)</td><td>
    <asp:TextBox ID="txtdiscount" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
        ControlToValidate="txtdiscount" ErrorMessage="*" ValidationGroup="submit"></asp:RequiredFieldValidator>
    </td></tr>


<tr><td>Detail</td><td>
    <asp:TextBox ID="txtdetail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txtdetail" ErrorMessage="*" ValidationGroup="submit"></asp:RequiredFieldValidator>
    </td></tr>
<tr><td>Photo</td><td>
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="FileUpload1" ErrorMessage="*" ValidationGroup="submit"></asp:RequiredFieldValidator>
    </td></tr>
<tr><td></td><td><br />
    <asp:Button ID="Button1" runat="server" Text="Add"  
       ValidationGroup="submit" OnClick="Button1_Click" /></td></tr>
</table>

</div>
</asp:Content>

