<%@ Page Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="addservices.aspx.cs" Inherits="Admin_addservices" Title="Add Services" %>

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
    <div style="font-size:15px; color:Blue"> Add Services</div><br /><br />
<div align="center" style="height:500px;">
    <asp:GridView ID="GridView1"  runat="server" Width="100%"
AutoGenerateColumns="false" AllowPaging="True" PagerSettings-Mode="Numeric"   
        PageSize="4" OnPageIndexChanging="PageIndexChanging"  CssClass="Gridview" HeaderStyle-BackColor="#61A6F8"
ShowFooter="true" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White"
 HorizontalAlign="Center" OnRowCommand="GridView1_RowCommand" 
        onselectedindexchanged="GridView1_SelectedIndexChanged">
<Columns>
 <asp:TemplateField HeaderText="Delete" ItemStyle-HorizontalAlign="Center">
     <ItemTemplate>
     <asp:LinkButton ID="tree1" runat="server" CommandArgument='<%#Eval("id") %>' ForeColor="Red" CommandName="Delkey" ><img src="img/deleteicon.png" width="15px" height="15px" /></asp:LinkButton>
     </ItemTemplate>     
     </asp:TemplateField>
<asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" Visible="false" />
<asp:BoundField DataField="ServiceName" HeaderText="Service Name" SortExpression="ServiceName" Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="Detail" HeaderText="Detail" SortExpression="Detail" Visible="true" ItemStyle-HorizontalAlign="Center" />

</Columns>
<HeaderStyle BackColor="#61A6F8" Font-Bold="True" ForeColor="White"></HeaderStyle>
</asp:GridView>
<br />
<table>
<tr><td>Service Name</td><td>
    <asp:TextBox ID="txtservicename" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ControlToValidate="txtservicename" ErrorMessage="*" 
        ValidationGroup="submit"></asp:RequiredFieldValidator>
    </td></tr>
    <tr><td>Category</td><td>
                                            <asp:DropDownList ID="ddcategory" runat="server">
                                            </asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="ddcategory" ErrorMessage="*" 
        ValidationGroup="submit" InitialValue="Select"></asp:RequiredFieldValidator>
    </td></tr>
    <tr><td>Time</td><td>
    <asp:TextBox ID="txttime" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ControlToValidate="txttime" ErrorMessage="*" 
        ValidationGroup="submit"></asp:RequiredFieldValidator>
    </td></tr>
    <tr><td>Price</td><td>
    <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
        ControlToValidate="txtprice" ErrorMessage="*" 
        ValidationGroup="submit"></asp:RequiredFieldValidator>
    </td></tr>
<tr><td>Detail</td><td>
    <asp:TextBox ID="txtdetail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txtdetail" ErrorMessage="*" ValidationGroup="submit"></asp:RequiredFieldValidator>
    </td></tr>
<tr><td>&nbsp;</td><td>
    &nbsp;</td></tr>
<tr><td></td><td><br />
    <asp:Button ID="Button1" runat="server" Text="Add"  
       ValidationGroup="submit" onclick="Button1_Click" /></td></tr>
</table>
</div>
</asp:Content>