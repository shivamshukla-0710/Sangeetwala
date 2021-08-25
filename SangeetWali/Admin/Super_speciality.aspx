<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="Super_speciality.aspx.cs" Inherits="Admin_Super_speciality" %>

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
    <table class="style1" width="750px">
    <tr>
        <td class="style1">
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </td>
        <td class="style1">
            </td>
    </tr>
    <tr>
        <td>
            Category&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
        </td>
        <td width="50%">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
    <asp:GridView ID="GridView1"  runat="server" Width="100%"
AutoGenerateColumns="false" AllowPaging="True" PagerSettings-Mode="Numeric"   
        PageSize="4" OnPageIndexChanging="PageIndexChanging"  CssClass="Gridview" HeaderStyle-BackColor="#61A6F8"
ShowFooter="true" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White"
 HorizontalAlign="Center" OnRowCommand="GridView1_RowCommand" 
        onselectedindexchanged="GridView1_SelectedIndexChanged">
<Columns>
 <asp:TemplateField HeaderText="Delete" ItemStyle-HorizontalAlign="Center">
     <ItemTemplate>
     <asp:LinkButton ID="tree1" runat="server" CommandArgument='<%#Eval("id") %>' ForeColor="Red" CommandName="Delkey" ><img src="img/deleteicon.png" width="15px" height="15px" /></asp:LinkButton>
     </ItemTemplate>     
     </asp:TemplateField>
<asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" Visible="false" />
<asp:BoundField DataField="ServiceName" HeaderText="Service Name" SortExpression="ServiceName" Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="Detail" HeaderText="Detail" SortExpression="Detail" Visible="true" ItemStyle-HorizontalAlign="Center" />

</Columns>
<HeaderStyle BackColor="#61A6F8" Font-Bold="True" ForeColor="White"></HeaderStyle>
</asp:GridView>
            <br />
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonUpload" runat="server" onclick="ButtonUpload_Click" 
                Text="Upload" />
        </td>
        <td width="50%">
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td width="50%">
            &nbsp;</td>
    </tr>
    </table>
    </div>
       <asp:DataList ID="DataList1" Visible="true" runat="server" AutoGenerateColumns="false"
        RepeatColumns="5" CellSpacing="5" Width="750px" BorderStyle="Inset" 
        BorderWidth="1px" Font-Bold="True" ForeColor="#006600">
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

