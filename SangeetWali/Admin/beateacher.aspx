<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="beateacher.aspx.cs" Inherits="Admin_beateacher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AllowSorting="True" AutoGenerateColumns="False" BackColor="White" 
        BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        DataKeyNames="id" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="name" HeaderText="NAME" SortExpression="name" />
            <asp:BoundField DataField="gender" HeaderText="GENDER" 
                SortExpression="gender" />
            <asp:BoundField DataField="contact" HeaderText="CONTACT" 
                SortExpression="contact" />
            <asp:BoundField DataField="addresscoree" HeaderText="ADDRESS" 
                SortExpression="addresscoree" />
            <asp:BoundField DataField="emailid" HeaderText="EMAIL" 
                SortExpression="emailid" />
            <asp:BoundField DataField="education" HeaderText="QUALIFICATION" 
                SortExpression="education" />
            <asp:BoundField DataField="teachupto" HeaderText="UP TO" 
                SortExpression="teachupto" />
            <asp:BoundField DataField="exper" HeaderText="exper" SortExpression="EXPERIENCE" />

            <asp:BoundField DataField="areaofteach" HeaderText="AREA OF TEACH" 
                SortExpression="areaofteach" />

        </Columns>
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#007DBB" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#00547E" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:myconnectionstring %>" 
        DeleteCommand="DELETE FROM [ghar_contact1] WHERE [id] = @id" 
        InsertCommand="INSERT INTO [ghar_contact1] ([name], [gender], [contact], [addresscoree], [emailid], [education], [teachupto], [exper], [address_perma], [areaofteach], [status]) VALUES (@name, @gender, @contact, @addresscoree, @emailid, @education, @teachupto, @exper, @address_perma, @areaofteach, @status)" 
        SelectCommand="SELECT * FROM [ghar_contact1]" 
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

