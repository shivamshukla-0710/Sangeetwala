<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="Admin_news" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .style1
        {
            width: 100%;
        }
        .style2
        {
            color: #99CCFF;
            text-decoration: underline;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="border-style: solid; border-color: inherit; border-width: 1px; margin-left: 0px; height: 204px; width: 556px; float: left;">
        <table class="style1">
            <tr>
                <td class="style2" colspan="3">
                    <em>Post Comment Here.....</em></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" ForeColor="#660033" Text="Comment Here.."></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="60px" TextMode="MultiLine" 
                        Width="265px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TextBox3" ErrorMessage="Required !" ForeColor="#FF6699"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Date :</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" ontextchanged="TextBox4_TextChanged" 
                        placeholder="  dd/mm/yyyy" Width="130px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" onclick="Button1_Click" Text="Submit" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>

            <tr>
            <td>
            
            </td>
            <td>
            </td>
            </tr>
            <tr>
            <td>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" 
                    BorderWidth="1px" CellPadding="2" DataKeyNames="id" 
                    DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="None" Height="111px" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" Width="555px">
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" />
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                            ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="post" HeaderText="post" SortExpression="post" />
                        <asp:BoundField DataField="dt" HeaderText="dt" SortExpression="dt" />
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
                    ConnectionString="<%$ ConnectionStrings:myConnectionString %>" 
                    DeleteCommand="DELETE FROM [post_t] WHERE [id] = @id" 
                    InsertCommand="INSERT INTO [post_t] ([post], [dt]) VALUES (@post, @dt)" 
                    SelectCommand="SELECT * FROM [post_t]" 
                    UpdateCommand="UPDATE [post_t] SET [post] = @post, [dt] = @dt WHERE [id] = @id">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="post" Type="String" />
                        <asp:Parameter DbType="Date" Name="dt" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="post" Type="String" />
                        <asp:Parameter DbType="Date" Name="dt" />
                        <asp:Parameter Name="id" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </td>
            </tr>
        </table>
    </div>
   
</asp:Content>

