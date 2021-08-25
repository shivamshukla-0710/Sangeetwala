<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="uservideo.aspx.cs" Inherits="Admin_uservideo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:DataList ID="DataList1" Visible="true" runat="server" AutoGenerateColumns="false"
        RepeatColumns="3" CellSpacing="5" BorderStyle="Inset" Width="950px">
        <ItemTemplate>
            <u>
               Name  :- <%# Eval("name")%></u> 
                <br/><u> 
              Video Name :- <%# Eval("Status")%></u>
            <hr />
<%--            <a class="player" style="height: 300px; width: 300px; display: block" href='<%# Eval("ID", "VideoHandler.ashx?ID={0}") %>'>
--%>           
<video width="320" height="240" controls="controls"> 
            <source src='<%# Eval("ID", "VideoHandler.ashx?ID={0}") %>' type="video/mp4"> <object data="" width="320" height="240"> 
            <embed width="320" height="240" src='<%# Eval("ID", "VideoHandler.ashx?ID={0}") %>'> 
            </object> 
            </video> </a>
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

