<%@ Page Language="C#"  AutoEventWireup="true" CodeFile="FORGET_PASS.aspx.cs" Inherits="Admin_FORGET_PASS" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Admin Login</title>
</head>
<body bgcolor="#99CCFF">
    <form id="form1" runat="server">
    <div align="center" 
        style="margin: 80px 250px 250px 450px; border: thin inset #800000; padding-top:260px; border-radius:8px; width: 550px; height: 140px;">
        
&nbsp;<table 
            style="width: 434px; margin-top: -200px;" >
    <tr>
    <td>&nbsp;</td><td>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/admin.png" 
            Width="20%" />
        </td>
    
    </tr>
    <tr>
    <td>&nbsp;</td><td>
        &nbsp;</td>
    
    </tr>
    <tr>
    <td>User id</td><td>
        <asp:TextBox ID="txtuserid" runat="server" Height="27px" Width="212px"></asp:TextBox></td>
    
    </tr>
    <tr>
    <td>Email_Id</td><td>
        <asp:TextBox ID="txtpwd" runat="server" Height="27px" TextMode="Password" Width="212px"></asp:TextBox></td>
    
    </tr>
    <tr><td></td><td>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td></tr>
        <td><td>
            <asp:Button ID="Button1" runat="server" Text="Re-Send-Password" BackColor="#0033CC" 
                    ForeColor="White" Height="33px" onclick="Button1_Click" 
                Width="120px" />&nbsp;</td><td>
                    &nbsp;</td></td>
    </table>
    </div>
    </form>
</body>
</html>

