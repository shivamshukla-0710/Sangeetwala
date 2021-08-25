
<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="hireateacher.aspx.cs" Inherits="Admin_hireateacher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" 
        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
        CellPadding="2" DataKeyNames="id" DataSourceID="SqlDataSource1" 
        ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="name" HeaderText="NAME" SortExpression="name" />
            <asp:BoundField DataField="contact" HeaderText="CONTACT" 
                SortExpression="contact" />
            <asp:BoundField DataField="product" HeaderText="CLASS" 
                SortExpression="product" />
            <asp:BoundField DataField="emailid" HeaderText="EMAIL" 
                SortExpression="emailid" />
            <asp:BoundField DataField="SCHOOL" HeaderText="SCHOOL" 
                SortExpression="SCHOOL" />
            <asp:BoundField DataField="board" HeaderText="BOARD" SortExpression="board" />
            <asp:BoundField DataField="address_m" HeaderText="ADDRESS" 
                SortExpression="address_m" />
            <asp:BoundField DataField="status" HeaderText="STATUS" 
                SortExpression="status" />
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
            HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:myconnectionstring %>" 
        DeleteCommand="DELETE FROM [ghar_contact] WHERE [id] = @id" 
        InsertCommand="INSERT INTO [ghar_contact] ([name], [contact], [product], [emailid], [SCHOOL], [board], [address_m], [status]) VALUES (@name, @contact, @product, @emailid, @SCHOOL, @board, @address_m, @status)" 
        SelectCommand="SELECT * FROM [ghar_contact]" 
        UpdateCommand="UPDATE [ghar_contact] SET [name] = @name, [contact] = @contact, [product] = @product, [emailid] = @emailid, [SCHOOL] = @SCHOOL, [board] = @board, [address_m] = @address_m, [status] = @status WHERE [id] = @id">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="contact" Type="String" />
            <asp:Parameter Name="product" Type="String" />
            <asp:Parameter Name="emailid" Type="String" />
            <asp:Parameter Name="SCHOOL" Type="String" />
            <asp:Parameter Name="board" Type="String" />
            <asp:Parameter Name="address_m" Type="String" />
            <asp:Parameter Name="status" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="contact" Type="String" />
            <asp:Parameter Name="product" Type="String" />
            <asp:Parameter Name="emailid" Type="String" />
            <asp:Parameter Name="SCHOOL" Type="String" />
            <asp:Parameter Name="board" Type="String" />
            <asp:Parameter Name="address_m" Type="String" />
            <asp:Parameter Name="status" Type="String" />
            <asp:Parameter Name="id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

