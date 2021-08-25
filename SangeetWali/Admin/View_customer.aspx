<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="View_customer.aspx.cs" Inherits="Admin_View_customer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
            ReadOnly="True" SortExpression="id" />
        <asp:BoundField DataField="fullname" HeaderText="fullname" 
            SortExpression="fullname" />
        <asp:BoundField DataField="PRODUCT" HeaderText="PRODUCT" 
            SortExpression="PRODUCT" />
        <asp:BoundField DataField="PRICE" HeaderText="PRICE" SortExpression="PRICE" />
        <asp:BoundField DataField="CONTACT" HeaderText="CONTACT" 
            SortExpression="CONTACT" />
        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
       
        <asp:BoundField DataField="towncity" HeaderText="towncity" 
            SortExpression="towncity" />
       
       
        <asp:BoundField DataField="billcardtype" HeaderText="billcardtype" 
            SortExpression="billcardtype" />
        <asp:BoundField DataField="billnamecard" HeaderText="billnamecard" 
            SortExpression="billnamecard" />

        <asp:BoundField DataField="billnameofc" HeaderText="billnameofc" 
            SortExpression="billnameofc" />
        <asp:BoundField DataField="billcontactno" HeaderText="billcontactno" 
            SortExpression="billcontactno" />
        <asp:BoundField DataField="billadd" HeaderText="billadd" 
            SortExpression="billadd" />
    </Columns>
</asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:myconnectionstring %>" 
        DeleteCommand="DELETE FROM [payment] WHERE [id] = @id" 
        InsertCommand="INSERT INTO [payment] ([fullname], [PRODUCT], [PRICE], [CONTACT], [email], [streetno], [towncity], [state], [zipcode], [country], [billcardtype], [billnamecard], [billcardnum], [billcvv], [billexpd], [billnameofc], [billcontactno], [billadd]) VALUES (@fullname, @PRODUCT, @PRICE, @CONTACT, @email, @streetno, @towncity, @state, @zipcode, @country, @billcardtype, @billnamecard, @billcardnum, @billcvv, @billexpd, @billnameofc, @billcontactno, @billadd)" 
        SelectCommand="SELECT * FROM [payment]" 
        UpdateCommand="UPDATE [payment] SET [fullname] = @fullname, [PRODUCT] = @PRODUCT, [PRICE] = @PRICE, [CONTACT] = @CONTACT, [email] = @email, [streetno] = @streetno, [towncity] = @towncity, [state] = @state, [zipcode] = @zipcode, [country] = @country, [billcardtype] = @billcardtype, [billnamecard] = @billnamecard, [billcardnum] = @billcardnum, [billcvv] = @billcvv, [billexpd] = @billexpd, [billnameofc] = @billnameofc, [billcontactno] = @billcontactno, [billadd] = @billadd WHERE [id] = @id">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="fullname" Type="String" />
            <asp:Parameter Name="PRODUCT" Type="String" />
            <asp:Parameter Name="PRICE" Type="String" />
            <asp:Parameter Name="CONTACT" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="streetno" Type="String" />
            <asp:Parameter Name="towncity" Type="String" />
            <asp:Parameter Name="state" Type="String" />
            <asp:Parameter Name="zipcode" Type="String" />
            <asp:Parameter Name="country" Type="String" />
            <asp:Parameter Name="billcardtype" Type="String" />
            <asp:Parameter Name="billnamecard" Type="String" />
            <asp:Parameter Name="billcardnum" Type="String" />
            <asp:Parameter Name="billcvv" Type="String" />
            <asp:Parameter Name="billexpd" Type="String" />
            <asp:Parameter Name="billnameofc" Type="String" />
            <asp:Parameter Name="billcontactno" Type="String" />
            <asp:Parameter Name="billadd" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="fullname" Type="String" />
            <asp:Parameter Name="PRODUCT" Type="String" />
            <asp:Parameter Name="PRICE" Type="String" />
            <asp:Parameter Name="CONTACT" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="streetno" Type="String" />
            <asp:Parameter Name="towncity" Type="String" />
            <asp:Parameter Name="state" Type="String" />
            <asp:Parameter Name="zipcode" Type="String" />
            <asp:Parameter Name="country" Type="String" />
            <asp:Parameter Name="billcardtype" Type="String" />
            <asp:Parameter Name="billnamecard" Type="String" />
            <asp:Parameter Name="billcardnum" Type="String" />
            <asp:Parameter Name="billcvv" Type="String" />
            <asp:Parameter Name="billexpd" Type="String" />
            <asp:Parameter Name="billnameofc" Type="String" />
            <asp:Parameter Name="billcontactno" Type="String" />
            <asp:Parameter Name="billadd" Type="String" />
            <asp:Parameter Name="id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>


