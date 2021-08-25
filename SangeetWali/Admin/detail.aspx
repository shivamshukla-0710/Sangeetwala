<%@ Page Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="detail.aspx.cs" Inherits="Admin_detail" Title="Detail" %>

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
<div style="font-size:15px; color:Blue"> Booking  Detail</div><br /><br />
<div>
    <table style="width: 100%;" border="1px">
        <tr>
            <td style="font-weight: bold">
                &nbsp;
                Full Name</td>
            <td>
                &nbsp;
                <asp:Label ID="lblfullname" runat="server" Text=""></asp:Label>
            </td>
            <td style="font-weight: bold">
                &nbsp;
                Date</td>
             <td>
                &nbsp;
                 <asp:Label ID="lbldate" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="font-weight: bold">
                &nbsp;
                Address</td>
            <td>
                &nbsp;
                <asp:Label ID="lbladress" runat="server" Text=""></asp:Label>
            </td>
            <td style="font-weight: bold">
                &nbsp;
                Time From</td>
             <td >
                &nbsp;
                 <asp:Label ID="lbltimefrom" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="font-weight: bold">
                &nbsp; Mobile</td>
            <td>
                &nbsp;
                <asp:Label ID="lblmobile" runat="server" Text=""></asp:Label>
            </td>
            <td style="font-weight: bold">
                &nbsp;
                Time To</td>
             <td>
                &nbsp;
                 <asp:Label ID="lbltimeto" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
    <br />
    <p style="font-weight: bold">Service Detail</p></div>

<div align="center" style="height:auto;">
    <asp:GridView ID="GridView1" DataKeyNames="id" runat="server" Width="100%"
AutoGenerateColumns="true" CssClass="Gridview" HeaderStyle-BackColor="#61A6F8"
ShowFooter="true" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White"
AllowPaging="True" PagerSettings-Mode="Numeric"   PageSize="4" RowStyle-HorizontalAlign="Center" >

<HeaderStyle BackColor="#61A6F8" Font-Bold="True" ForeColor="White"></HeaderStyle>
</asp:GridView>
   
</div>
<div align="right">
    <a href="bookingrequest.aspx">Back</a>
</div>
</asp:Content>
