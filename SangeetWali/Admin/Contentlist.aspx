<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contentlist.aspx.cs" Inherits="Contentlist" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .gbrdr
        {
            border: 5px solid #16940B;
            padding: 10px;
            -webkit-box-shadow: rgba(0, 0, 0, 0.1) 0px 0px 8px;
            width: 61%;
            background-color: #95AA6E;
            margin-left: 279px;
            margin-top: 70px;
        }
        .style1
        {
            color: #CC3300;
        }
    </style>
</head>
<body style="background-image: url('../img/cd.jpg')">
    <form id="form1" runat="server">
    <div style="z-index: 1; left: 29px; top: 39px; position: absolute; height: 19px; width: 956px; bottom: 465px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <span class="style1"><strong>All Contents and Letter</strong></span></div>
    <div id="gg" class="gbrdr" 
        style="background-image: url('../img/background.png')">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            DataKeyNames="id" DataSourceID="SqlDataSource1" CellPadding="3" 
            CellSpacing="10" Width="566px" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <EmptyDataRowStyle BackColor="#0099FF" />
            <HeaderStyle BackColor="#232d42" Font-Italic="false" ForeColor="#80D5E6" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" 
                    InsertVisible="False" ReadOnly="True" />
                <asp:BoundField DataField="fileName" HeaderText="fileName" 
                    SortExpression="fileName" />
                <asp:BoundField DataField="Description" HeaderText="Description" 
                    SortExpression="Description" />
                    <asp:HyperLinkField DataNavigateUrlFields="fileName" DataNavigateUrlFormatString="fileName/{0}"
                    HeaderText="DownloadFile" Text="See" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:myConnectionString %>"
            
            SelectCommand="SELECT * FROM [uploadFiles]" 
            DeleteCommand="DELETE FROM [uploadFiles] WHERE [id] = @id" 
            InsertCommand="INSERT INTO [uploadFiles] ([fileName], [Description]) VALUES (@fileName, @Description)" 
            
            
            
            UpdateCommand="UPDATE [uploadFiles] SET [fileName] = @fileName, [Description] = @Description WHERE [id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="fileName" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="fileName" Type="String" />
                <asp:Parameter Name="Description" Type="String" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </div>
    <a href="../Default.aspx"><img alt="" src="../img/mainlogo.png" 
        style="z-index: 1; left: 63px; top: 30px; position: absolute" /></a></form>
</body>
</html>

