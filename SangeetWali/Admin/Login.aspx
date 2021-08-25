<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Admin_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Admin/admin-icon.png" 
            Width="20%" />
        </td>
    
    </tr>
    <tr>
    <td>&nbsp;</td><td>
        &nbsp;</td>
    
    </tr>
    <tr>
    <td>Userid</td><td>
        <asp:TextBox ID="txtuserid" runat="server" Height="27px" Width="212px"></asp:TextBox></td>
    
    </tr>
    <tr>
    <td>Password</td><td>
        <asp:TextBox ID="txtpwd" runat="server" Height="27px" TextMode="Password" Width="212px"></asp:TextBox></td>
    
    </tr>
    <tr><td></td><td>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td></tr>
        <td><td>
            <asp:Button ID="Button1" runat="server" Text="Login" BackColor="#0033CC" 
                    ForeColor="White" Height="33px" onclick="Button1_Click" Width="90px" />&nbsp;<asp:HyperLink 
                ID="HyperLink1" runat="server" NavigateUrl="~/Admin/FORGET_PASS.aspx">FORGET PASSWORD</asp:HyperLink>
            </td><td>
                    &nbsp;</td></td>
    </table>
    </div>
    </form>
</body>
</html>
