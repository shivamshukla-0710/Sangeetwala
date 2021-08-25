<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="cutomer.aspx.cs" Inherits="Admin_cutomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        DataSourceID="SqlDataSource1" Width="80%" AllowSorting="True" 
        DataKeyNames="id" GridLines="Vertical">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="id" HeaderText="SL.NO." 
                SortExpression="id" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
        
            <asp:BoundField DataField="contact" HeaderText="Contact" 
                SortExpression="contact" />
           
            <asp:BoundField DataField="addresscoree" HeaderText="DOB" 
                SortExpression="addresscoree" />
            <asp:BoundField DataField="emailid" HeaderText="Email" 
                SortExpression="emailid" />
            <asp:BoundField DataField="guru_master" HeaderText="Master" 
                SortExpression="guru_master" />
 
           
            <asp:BoundField DataField="education" HeaderText="City" 
                SortExpression="education" />
           
            <asp:BoundField DataField="exper" HeaderText="Gender" SortExpression="exper" />
            <asp:BoundField DataField="address_perma" HeaderText="Address" 
                SortExpression="address_perma" />
            <asp:BoundField DataField="areaofteach" HeaderText="Type" 
                SortExpression="areaofteach" />
            <asp:BoundField DataField="status" HeaderText="Video Name" 
                SortExpression="status" />
             <asp:BoundField DataField="url" HeaderText="You Tube  Url" 
                SortExpression="url" />
               <asp:BoundField DataField="Staus_app" HeaderText="Status" 
                SortExpression="Staus_app" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle ForeColor="Black" BackColor="#EEEEEE" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:myConnectionString %>" 
        
        SelectCommand="SELECT * FROM [ghar_contact1]" 
        DeleteCommand="DELETE FROM [ghar_contact1] WHERE [id] = @id" 
        InsertCommand="INSERT INTO [ghar_contact1] ([name], [gender], [contact], [addresscoree], [emailid], [education], [teachupto], [exper], [address_perma], [areaofteach], [status]) VALUES (@name, @gender, @contact, @addresscoree, @emailid, @education, @teachupto, @exper, @address_perma, @areaofteach, @status)" 
        
        UpdateCommand="UPDATE [ghar_contact1] SET [name] = @name, [gender] = @gender, [contact] = @contact, [addresscoree] = @addresscoree, [emailid] = @emailid, [education] = @education, [teachupto] = @teachupto, [exper] = @exper, [address_perma] = @address_perma, [areaofteach] = @areaofteach, [status] = @status WHERE [id] = @id">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="gender" Type="String" />
            <asp:Parameter Name="contact" Type="String" />
            <asp:Parameter Name="addresscoree" Type="String" />
            <asp:Parameter Name="emailid" Type="String" />
    <%--        <asp:Parameter Name="approval" Type="Int64" />
            <asp:Parameter Name="pricedetails" Type="String" />--%>
            <asp:Parameter Name="education" Type="String" />
            <asp:Parameter Name="teachupto" Type="String" />
            <asp:Parameter Name="exper" Type="String" />
            <asp:Parameter Name="address_perma" Type="String" />
            <asp:Parameter Name="areaofteach" Type="String" />
            <asp:Parameter Name="status" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="name" Type="String" />
            <asp:Parameter Name="gender" Type="String" />
            <asp:Parameter Name="contact" Type="String" />
            <asp:Parameter Name="addresscoree" Type="String" />
            <asp:Parameter Name="emailid" Type="String" />
       <%--     <asp:Parameter Name="approval" Type="Int64" />
            <asp:Parameter Name="pricedetails" Type="String" />--%>
            <asp:Parameter Name="education" Type="String" />
            <asp:Parameter Name="teachupto" Type="String" />
            <asp:Parameter Name="exper" Type="String" />
            <asp:Parameter Name="address_perma" Type="String" />
            <asp:Parameter Name="areaofteach" Type="String" />
            <asp:Parameter Name="status" Type="String" />
            <asp:Parameter Name="id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>


</asp:Content>

