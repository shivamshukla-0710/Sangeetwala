<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CS.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        input[type=text]
        {
            margin-right:5px;
            position:relative;
            top:-2px;
            left: 0px;
        }
    </style>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.6/jquery.min.js" type="text/javascript"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js" type="text/javascript"></script>
    <link href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css" rel="Stylesheet" type="text/css" />
    <script type="text/javascript">
        $(function () {
            $("[id*=txtDate]").datepicker({
                showOn: 'button',
                buttonImageOnly: true,
                buttonImage: 'images/calendar.png'
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">

    <table style=" width:100% ; margin-left: 10%;" align="center">
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Name</td><td width="45%">
                <asp:TextBox ID="TextBox1" runat="server" 
                    BackColor="#0066FF" Width="250px" Height="30px" ForeColor="White"></asp:TextBox></td></tr>
                    <tr><td>&nbsp;</td><td width="35%" 
                            style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Father Name</td><td width="45%">
                <asp:TextBox ID="TextBox2" 
                    runat="server" BackColor="#0066FF" Width="250px" Height="30px" 
                        ForeColor="White"></asp:TextBox></td></tr>
                    <tr><td>&nbsp;</td><td width="35%" 
                            style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Mother Name</td><td width="45%">
                <asp:TextBox ID="TextBox3" 
                    runat="server" BackColor="#0066FF" Width="250px" Height="30px" 
                        ForeColor="White"></asp:TextBox></td></tr>
           <tr><td>&nbsp;</td><td width="35%" 
                   style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
                       <tr><td>&nbsp;</td><td width="35%" 
                               style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Date of Birth</td><td width="45%">
    <asp:TextBox ID="txtDate" runat="server" ReadOnly = "true" Width="250px"></asp:TextBox>
                                
                                           
                               
                               </td>
                               
                               </tr>
                               <tr><td>&nbsp;</td><td width="35%" 
                                       style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Address</td><td width="45%">
                <asp:TextBox ID="TextBox5" runat="server" 
                    BackColor="#0066FF" Width="250px" Height="30px" ForeColor="White"></asp:TextBox></td></tr>
                    <tr><td>&nbsp;</td><td width="35%" 
                            style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">City</td><td width="45%">
                <asp:TextBox ID="TextBox6" runat="server" 
                    BackColor="#0066FF" Width="250px" Height="30px" ForeColor="White"></asp:TextBox></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
                        <tr><td>&nbsp;</td><td width="35%" 
                                style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Contact</td><td width="45%">
                            <asp:TextBox ID="TextBox7" runat="server" 
                                BackColor="#0066FF" Width="250px" Height="30px" ForeColor="White"></asp:TextBox></td></tr>
                                <tr><td>&nbsp;</td><td width="35%" 
                                        style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Email Id</td><td width="45%">
                <asp:TextBox ID="TextBox8" runat="server" 
                    BackColor="#0066FF" Width="250px" Height="30px" ForeColor="White"></asp:TextBox></td></tr>
                    <tr><td>&nbsp;</td><td width="35%" 
                            style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Gender</td><td width="45%">
                    <asp:DropDownList ID="DropDownList2" 
                    runat="server" BackColor="#3366FF" Height="30px" Width="250px" 
                        ForeColor="White">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
                </asp:DropDownList></td></tr>
                    <tr><td>&nbsp;</td><td width="35%" 
                            style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
             <tr><td>&nbsp;</td><td width="35%" 
                     style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Upload Video</td><td width="45%"><asp:FileUpload ID="FileUpload1" 
                     runat="server" Width="250px"></asp:FileUpload>
                   
                 </td></tr>
                     <tr><td>&nbsp;</td><td width="35%" 
                             style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"></td></tr>
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">Types Of Video</td><td width="45%"><asp:DropDownList ID="DropDownList1" 
                    runat="server" BackColor="#3366FF" Height="30px" Width="250px" 
                        ForeColor="White">
                <asp:ListItem>VOCAL</asp:ListItem>
                <asp:ListItem>DANCE</asp:ListItem>
                <asp:ListItem>INSTRUMENT</asp:ListItem>
                </asp:DropDownList></td></tr>
                   
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">
                &nbsp;</td><td width="45%">&nbsp;</td></tr>
                   
            <tr><td>&nbsp;</td><td width="35%" 
                    style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">
                Video Category</td><td width="45%">
                    <asp:DropDownList ID="DropDownList3" 
                    runat="server" BackColor="#3366FF" Height="30px" Width="250px" 
                        ForeColor="White">
                <asp:ListItem>Classical</asp:ListItem>
                <asp:ListItem>Filmy</asp:ListItem>
                <asp:ListItem>Folk</asp:ListItem>
                </asp:DropDownList></td></tr>
                   
                     <tr><td></td><td width="5%"></td><td width="55%">
                                                          <asp:CheckBox ID="CheckBox1" runat="server" 
                                            oncheckedchanged="CheckBox1_CheckedChanged" 
                                            Text="I read the Terms and Conditions" />
                                        <label class="checkbox" style="font-size:large;">
                                            Please read the
                                            <a href="#" id="myBtn">Terms and Conditions</a>
                                        </label>
                                </tr>
                    <tr><td>&nbsp;</td><td width="35%" 
                            style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';"></td><td width="45%"> 


           <br />
           <br />
           <br />
           <br />
         </td></tr>
           <tr><td>&nbsp;</td><td width="35%" 
                   style="color: #000099; font-size: medium; font-weight: bold; font-family: 'Bookman Old Style';">&nbsp;</td><td width="45%">
               <asp:ImageButton ID="ImageButton1" runat="server" 
                   ImageUrl="~/img/Submit-Button-PNG-Clipart.png" Width="25%" 
                       onclick="ImageButton1_Click" />
               </td></tr>
           
             </table>
    <hr />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
        onclick="btnSubmit_Click" />
    </form>
</body>
</html>
