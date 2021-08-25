<%@ Page Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="testimonial.aspx.cs" Inherits="Admin_testimonial" Title="Approve Testimonial" %>

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
<div style="font-size:15px; color:Blue"> Testimonial</div><br /><br />
<div align="center" style="height:300px;">
    <asp:GridView ID="GridView1" DataKeyNames="id" runat="server" Width="100%"
AutoGenerateColumns="true" CssClass="Gridview" HeaderStyle-BackColor="#61A6F8"
ShowFooter="true" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White"
AllowPaging="True" PagerSettings-Mode="Numeric"   PageSize="4" OnPageIndexChanging="PageIndexChanging">
<Columns>

<asp:TemplateField HeaderText="Approve" FooterStyle-HorizontalAlign="Center" FooterStyle-CssClass="center">
     <ItemTemplate>
     
<asp:CheckBox ID="chkStatus"  runat="server" 
                            AutoPostBack="true" OnCheckedChanged="chkStatus_OnCheckedChanged"
                            Checked='<%# Convert.ToBoolean(Eval("Approve")) %>'
                            />
     </ItemTemplate>
     
     </asp:TemplateField>


</Columns>

<HeaderStyle BackColor="#61A6F8" Font-Bold="True" ForeColor="White"></HeaderStyle>
</asp:GridView>
</div>
</asp:Content>

