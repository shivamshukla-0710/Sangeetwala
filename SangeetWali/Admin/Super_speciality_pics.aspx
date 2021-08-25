<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="Super_speciality_pics.aspx.cs" Inherits="Admin_Super_speciality_pics" %>

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
    <div style="font-size:15px; color:Blue"> Add Photo To Gallery</div><br /><br />
<div align="center" style="height:500px;">
    <asp:GridView ID="GridView1"  runat="server" Width="50%"
AutoGenerateColumns="False" CssClass="Gridview" HeaderStyle-BackColor="#61A6F8"
ShowFooter="True" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White"
 HorizontalAlign="Center" OnRowCommand="GridView1_RowCommand" AllowPaging="True" 
        PagerSettings-Mode="Numeric"   PageSize="4" 
        OnPageIndexChanging="PageIndexChanging" 
        onselectedindexchanged="GridView1_SelectedIndexChanged">
<Columns>
 <asp:TemplateField HeaderText="Delete" ItemStyle-HorizontalAlign="Center">
     <ItemTemplate>
     <asp:LinkButton ID="tree1" runat="server" CommandArgument='<%#Eval("id") %>' ForeColor="Red" CommandName="Delkey" ><img src="img/deleteicon.png" width="15px" height="15px" /></asp:LinkButton>
     </ItemTemplate>     

<ItemStyle HorizontalAlign="Center"></ItemStyle>
     </asp:TemplateField>
<asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" Visible="false" />
<asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" 
        Visible="true" ItemStyle-HorizontalAlign="Center" >
<ItemStyle HorizontalAlign="Center"></ItemStyle>
    </asp:BoundField>
    <asp:BoundField DataField="categ" HeaderText="Category" />
<asp:ImageField DataImageUrlField="Image" HeaderText="Image" Visible="true" ItemStyle-HorizontalAlign="Center">
<ItemStyle Height="50px" Width="50px"></ItemStyle>
    </asp:ImageField>
</Columns>
<HeaderStyle BackColor="#61A6F8" Font-Bold="True" ForeColor="White"></HeaderStyle>
</asp:GridView>
<br />
<table>
<tr><td>Title&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td><td>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="TextBox1" ErrorMessage="*" ValidationGroup="submit"></asp:RequiredFieldValidator>
    </td></tr>
<tr><td>Photo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td><td>
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="FileUpload1" ErrorMessage="*" ValidationGroup="submit"></asp:RequiredFieldValidator>
    </td></tr>
<tr><td>Category&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td><td>
    <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Orthognathic</asp:ListItem>
                <asp:ListItem>Cosmetic</asp:ListItem>
                <asp:ListItem>Hair transplant</asp:ListItem>
                <asp:ListItem>Botox</asp:ListItem>
                <asp:ListItem>Oral Cancer</asp:ListItem>
                <asp:ListItem>Flap</asp:ListItem>
                <asp:ListItem>Microvascular</asp:ListItem>
                <asp:ListItem>Cleft Lip</asp:ListItem>
                <asp:ListItem>Distruction</asp:ListItem>
                <asp:ListItem>Trauma</asp:ListItem>
            </asp:DropDownList>
        <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Upload" onclick="Button1_Click" 
       ValidationGroup="submit" /></td></tr>
</table>
</div>
</asp:Content>

