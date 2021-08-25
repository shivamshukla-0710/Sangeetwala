<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="client_entry.aspx.cs" Inherits="Admin_client_entry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel CssClass="pnlContainer" ID="pnlMain" runat="server">
<asp:Label ID="lblHeading1" runat="server" Text="Client"></asp:Label>
    <asp:TextBox ID="txtHeading" runat="server" Visible="True"></asp:TextBox>
<div class="cleaner h10"></div>
<asp:Label ID="Label2" runat="server" Text="News Details" Visible="True"></asp:Label>
<asp:TextBox ID="txtPara1" CssClass="txtBox" runat="server" TextMode="MultiLine" 
        Enabled="true" Height="97px" Width="781px"></asp:TextBox>
</asp:Panel>
<div class="cleaner h10"></div>
<div class="cleaner"></div>
<asp:Button ID="btnSave" runat="server" Text="Save" CssClass="addNewBtn"   
        onclick="btnSave_Click" />
 <asp:Label runat="server" ID="lblmsg"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" CellPadding="4" DataKeyNames="news_id" 
        DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" 
    AllowSorting="True">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="news_id" HeaderText="news_id" InsertVisible="False" 
                ReadOnly="True" SortExpression="news_id" />
            <asp:BoundField DataField="news_title" 
            
            HeaderText="news_title" 
                SortExpression="news_title" />
            <asp:BoundField DataField="news_desc" HeaderText="news_desc" 
                SortExpression="news_desc" />
            <asp:BoundField DataField="news_date" HeaderText="news_date" 
                SortExpression="news_date" />
          
          
            <asp:BoundField DataField="news_entry_date" HeaderText="news_entry_date" 
                SortExpression="news_entry_date" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:myconnectionstring %>" 
        DeleteCommand="DELETE FROM [client] WHERE [news_id] = @news_id" 
        InsertCommand="INSERT INTO [client] ([news_title], [news_desc], [news_date], [news_entry_date]) VALUES (@news_title, @news_desc, @news_date, @news_entry_date)" 
        SelectCommand="SELECT * FROM [client]" 
        
        
    UpdateCommand="UPDATE [client] SET [news_title] = @news_title, [news_desc] = @news_desc, [news_date] = @news_date, [news_entry_date] = @news_entry_date WHERE [news_id] = @news_id">
        <DeleteParameters>
            <asp:Parameter Name="news_id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="news_title" Type="String" />
            <asp:Parameter Name="news_desc" Type="String" />
            <asp:Parameter Name="news_date" DbType="Date" />
            <asp:Parameter DbType="Date" Name="news_entry_date" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="news_title" Type="String" />
            <asp:Parameter Name="news_desc" Type="String" />
            <asp:Parameter Name="news_date" DbType="Date" />
            <asp:Parameter DbType="Date" Name="news_entry_date" />
            <asp:Parameter Name="news_id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

