<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="jackpot.aspx.cs" Inherits="Admin_jackpot" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <style type="text/css">
.Gridview
{
font-family:Verdana;
font-size:10pt;
font-weight:normal;
color:black;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="font-size:15px; color:Blue"> Add Services</div><br /><br />
<div align="center" style="height:500px;">
    <asp:GridView ID="GridView1"  runat="server" Width="100%"
AutoGenerateColumns="False" AllowPaging="True" PagerSettings-Mode="Numeric"   
        PageSize="4" OnPageIndexChanging="PageIndexChanging"  CssClass="Gridview" HeaderStyle-BackColor="#61A6F8"
ShowFooter="True" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White"
 HorizontalAlign="Center" OnRowCommand="GridView1_RowCommand" AllowSorting="True" 
        DataKeyNames="Id" DataSourceID="SqlDataSource1">
<Columns>
    <asp:CommandField ShowDeleteButton="True" />
<asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" 
        InsertVisible="False" ReadOnly="True" />
<asp:BoundField DataField="Title1" HeaderText="Title1" SortExpression="Title1" 
        Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="Detail1" HeaderText="Detail1" SortExpression="Detail1" 
        Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="serviceid" HeaderText="serviceid" 
        SortExpression="serviceid" Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="Title2" HeaderText="Title2" SortExpression="Title2" 
        Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="Detail2" HeaderText="Detail2" SortExpression="Detail2" 
        Visible="true" ItemStyle-HorizontalAlign="Center" />

<asp:BoundField DataField="Title3" HeaderText="Title3" SortExpression="Title3" 
        Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="Detail3" HeaderText="Detail3" SortExpression="Detail3" 
        Visible="true" ItemStyle-HorizontalAlign="Center" />
<asp:BoundField DataField="time" HeaderText="time" SortExpression="time" 
        Visible="true" ItemStyle-HorizontalAlign="Center" />

</Columns>
<HeaderStyle BackColor="#61A6F8" Font-Bold="True" ForeColor="White"></HeaderStyle>
</asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:myConnectionString %>" 
        DeleteCommand="DELETE FROM [game] WHERE [Id] = @Id" 
        InsertCommand="INSERT INTO [game] ([Title1], [Detail1], [serviceid], [Title2], [Detail2], [Title3], [Detail3], [time]) VALUES (@Title1, @Detail1, @serviceid, @Title2, @Detail2, @Title3, @Detail3, @time)" 
        SelectCommand="SELECT * FROM [game]" 
        UpdateCommand="UPDATE [game] SET [Title1] = @Title1, [Detail1] = @Detail1, [serviceid] = @serviceid, [Title2] = @Title2, [Detail2] = @Detail2, [Title3] = @Title3, [Detail3] = @Detail3, [time] = @time WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int64" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Title1" Type="String" />
            <asp:Parameter Name="Detail1" Type="String" />
            <asp:Parameter Name="serviceid" Type="Int64" />
            <asp:Parameter Name="Title2" Type="String" />
            <asp:Parameter Name="Detail2" Type="String" />
            <asp:Parameter Name="Title3" Type="String" />
            <asp:Parameter Name="Detail3" Type="String" />
            <asp:Parameter Name="time" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="Title1" Type="String" />
            <asp:Parameter Name="Detail1" Type="String" />
            <asp:Parameter Name="serviceid" Type="Int64" />
            <asp:Parameter Name="Title2" Type="String" />
            <asp:Parameter Name="Detail2" Type="String" />
            <asp:Parameter Name="Title3" Type="String" />
            <asp:Parameter Name="Detail3" Type="String" />
            <asp:Parameter Name="time" Type="String" />
            <asp:Parameter Name="Id" Type="Int64" />
        </UpdateParameters>
    </asp:SqlDataSource>
<br />
<table>
<tr><td>No. Title</td><td>
    <asp:TextBox ID="txtservicename0" runat="server"></asp:TextBox>
    </td></tr>
<tr><td>Option Detail</td><td>
    <asp:TextBox ID="txtservicename" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
        ControlToValidate="txtservicename" ErrorMessage="*" 
        ValidationGroup="submit"></asp:RequiredFieldValidator>
    </td></tr>
    <tr><td>Category</td><td>
                                            <asp:DropDownList ID="ddcategory" runat="server">
                                                <asp:ListItem>New Game</asp:ListItem>
                                                <asp:ListItem>Old Game</asp:ListItem>
                                            </asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="ddcategory" ErrorMessage="*" 
        ValidationGroup="submit" InitialValue="Select"></asp:RequiredFieldValidator>
    </td></tr>
    <tr><td>&nbsp;</td><td>
        &nbsp;</td></tr>
    <tr><td>No. Title</td><td>
    <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
        ControlToValidate="txtprice" ErrorMessage="*" 
        ValidationGroup="submit"></asp:RequiredFieldValidator>
    </td></tr>
<tr><td>Bhagya Wonder Quiz</td><td>
    <asp:TextBox ID="txtdetail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txtdetail" ErrorMessage="*" ValidationGroup="submit"></asp:RequiredFieldValidator>
    </td></tr>
    <tr>
        <td>No. Title</td><td>
    <asp:TextBox ID="txtdetail0" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Bhagya Quiz</td><td>
    <asp:TextBox ID="txtdetail1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Time</td><td>
    <asp:TextBox ID="txttime" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
        ControlToValidate="txttime" ErrorMessage="*" 
        ValidationGroup="submit"></asp:RequiredFieldValidator>
        </td>
    </tr>
<tr><td>&nbsp;</td><td>
    &nbsp;</td></tr>
<tr><td></td><td><br />
    <asp:Button ID="Button1" runat="server" Text="Add"  
       ValidationGroup="submit" onclick="Button1_Click" /></td></tr>
</table>
</div></asp:Content>

