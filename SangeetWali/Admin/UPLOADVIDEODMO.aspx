<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UPLOADVIDEODMO.aspx.cs" Inherits="UPLOADVIDEODMO" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="style1">
    <tr>
        <td>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="ButtonUpload" runat="server" onclick="ButtonUpload_Click" 
                Text="Upload" />
        </td>
        <td width="50%">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    </table>
    </div>
       <asp:DataList ID="DataList1" Visible="true" runat="server" AutoGenerateColumns="false"
        RepeatColumns="2" CellSpacing="5">
        <ItemTemplate>
            <u>
                <%# Eval("Video_Name") %></u>
            <hr />
            <a class="player" style="height: 300px; width: 300px; display: block" href='<%# Eval("ID", "VideoHandler.ashx?ID={0}") %>'>
            </a>
        </ItemTemplate>
    </asp:DataList>
    <script src="FlowPlayer/flowplayer-3.2.12.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        flowplayer("a.player", "FlowPlayer/flowplayer-3.2.16.swf", {
            plugins: {
                pseudo: { url: "FlowPlayer/flowplayer.pseudostreaming-3.2.12.swf" }
            },
            clip: { provider: 'pseudo', autoPlay: false},
        });
    </script>
    </form>
</body>
</html>
