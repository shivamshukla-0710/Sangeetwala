<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="Uploadcontent.aspx.cs" Inherits="Admin_Uploadcontent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        #dfdf
        {
            z-index: 1;
            left: 778px;
            top: 412px;
            position: absolute;
            height: 19px;
            width: 319px;
        }
        #Div1
        {
            z-index: 1;
            left: 68px;
            top: 263px;
            position: absolute;
            height: 211px;
            width: 304px;
        }
        .style1
        {
            width: 6px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="main" 
    style="margin-top: 24px; background-color: rgb(250, 245, 210); height: 501px;margin-left: 5px; margin-right: 5px; -webkit-box-shadow: 0px 9px 20px rgb(104, 95, 70);padding-left: 775px;">
          
       <asp:Panel ID="Panel1" runat="server">
        <div id="Div1" style="margin-left: 250px" >
         <br /><br />
         <div>
          <table align="center" border="1px" >
            <tr width="20px">
                <td colspan="2" style="font-weight: 700; color: #0000FF">
                   File Uploads Here...
                </td>
            </tr>
            <tr  >
                <td >
                    Upload File:
                </td>
                <td >
                    <asp:FileUpload ID="fileuploadimages" runat="server" placeholder="Browse image" class="txt"/>
                    
                </td>
            </tr>
            <tr  width="13%">
                <td >
                    File's Desc:
                </td>
                <td  >
                    <asp:TextBox ID="TextBox1" runat="server"  Height="58px" class="txt" TextMode="MultiLine" width=" 199px" placeholder="Description"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                </td>
                <td  >
                    <asp:Button ID="Button1_upload" runat="server" Text="Upload" 
                        OnClick="Button1_upload_Click" class="bt" ValidationGroup="0"/>
                   
                </td>
            </tr>
            <%--<tr>
                <td colspan="2">
                </td>
            </tr>--%>
        </table>
         </div>
        </div>

        <DIV>
           <table border="1px" style="margin-right: 350px" >
            <tr width="20px">
                <td colspan="2" style="font-weight: 700; color: #0000FF">
                    .
                </td>
            </tr>
            
            <tr  width="13%">
                <td >
                    &nbsp;</td>
                <td class="style1"  >
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" />
                            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                                ReadOnly="True" SortExpression="id" />
                            <asp:BoundField DataField="fileName" HeaderText="fileName" 
                                SortExpression="fileName" />
                            <asp:BoundField DataField="Description" HeaderText="Description" 
                                SortExpression="Description" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:myConnectionString %>" 
                        DeleteCommand="DELETE FROM [uploadFiles] WHERE [id] = @id" 
                        InsertCommand="INSERT INTO [uploadFiles] ([fileName], [Description]) VALUES (@fileName, @Description)" 
                        SelectCommand="SELECT * FROM [uploadFiles]" 
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
                </td>
                <td class="style1"  >
                    &nbsp;</td>
            </tr>
            <%--<tr>
                <td colspan="2">
                </td>
            </tr>--%>
        </table>
        </DIV>
       </asp:Panel>
          
        
</asp:Content>

