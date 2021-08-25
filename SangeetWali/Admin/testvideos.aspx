<%@ Page Language="C#" AutoEventWireup="true" CodeFile="testvideos.aspx.cs" Inherits="Admin_testvideos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="margin-left:150px; height:546px">
  <tr class="tr">
      <td colspan="3">
          <asp:Label ID="Label1" runat="server" 
              Font-Size="15pt" ForeColor="#0099FF" Text="Add New Video"></asp:Label>



          &nbsp;<br />
          <asp:Label ID="Label2" runat="server" Font-Names="MS Reference Sans Serif" 
            Font-Size="7pt" Text="Make Sure Video in MP4 format"></asp:Label>
      </td>

  </tr>
  <tr class="tr">
   <td class="style1"> Video Name&nbsp; :</td>
   <td><asp:TextBox ID="txtideoname"  Height="24px" Width="270px" runat="server"></asp:TextBox></td>
    <td>
      &nbsp;</td>
  </tr>
  <tr class="tr">
   <td class="style1">Video type :</td>
   <td><asp:TextBox ID="txtvideotype"  Height="24px" Width="270px" runat="server"></asp:TextBox></td>
    <td>
      &nbsp;</td>
  </tr>

  <tr class="tr">
   <td  class="style1">video:</td>
   <td>
     <asp:FileUpload ID="FileUpload1" runat="server" /></td>
    <td>
      &nbsp;</td>
  </tr>
  <tr class="tr">
   <td>&nbsp;</td>
   <td><asp:Button ID="btnupload" runat="server" Text="Upload" Width="132px" Height="34px" BackColor="Red" BorderStyle="None" Font-Bold="True" ForeColor="White" onclick="btnupload_Click"/><br />
       <asp:Label ID="lblMsg" runat="server"/></td>
    <td>
      &nbsp;</td>
  </tr>
  <tr class="tr">
      <td>
          &nbsp;</td>
      <td>
          &nbsp;</td>
      <td>
        &nbsp;</td>
  </tr>
  </table>
    </div>
    </form>
</body>
</html>
