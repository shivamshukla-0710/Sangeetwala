<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="video.aspx.cs" Inherits="Admin_video" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
    .style1
    {
        height: 34px;
    }
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <div>
    <table class="style1" width="550px">
    <tr>
        <td class="style1">
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </td>
        <td class="style1">
            </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="ButtonUpload" runat="server" onclick="ButtonUpload_Click" 
                Text="Upload" />
        </td>
        <td width="50%">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
        </td>
    </tr>
    </table>
    </div>
       <asp:DataList ID="DataList1" Visible="true" runat="server" AutoGenerateColumns="false"
        RepeatColumns="5" CellSpacing="5" Width="550px">
        <ItemTemplate>
            <u>
                <%# Eval("Video_Name") %></u>
            <hr />
           
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
   
</asp:Content>

