<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


  <div id="main" style="margin-top: 74px; background-color: rgb(250, 245, 210); height: 501px;margin-left: 25px;margin-right: 25px;-webkit-box-shadow: 0px 9px 20px rgb(104, 95, 70);padding-left: 775px;">
      
      <div id="forgrid" 
          
          style="background-color:rgb(243, 241, 180); height:419px; z-index: 1; left: 59px; top: 179px; position: absolute; width: 42%; overflow-y: scroll; margin-left: 250px;">
       <div id="gg" class="gbrdr">

           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" co DataKeyNames="id"  >

               <Columns>
                    <asp:CommandField ShowDeleteButton="True" />
                    <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" InsertVisible="False" ReadOnly="True" />
                   <%--<asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
<asp:Image ID="Image1" runat="server" DataImageUrlField="ImageName" DataImageUrlFormatString="Uploadimage/{0}" Height="50px" Width="50px"/>
                    </ItemTemplate>
                    </asp:TemplateField>--%>
                   <asp:ImageField HeaderText="Image" DataImageUrlField="ImageName" DataImageUrlFormatString="Uploadimage/{0}"  >
                       <ControlStyle Height="50px" Width="75px" />
                    </asp:ImageField>

                   <asp:BoundField DataField="ImageName" HeaderText="ImageName" SortExpression="ImageName" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
               </Columns>

           </asp:GridView>
           <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
               ConnectionString="<%$ ConnectionStrings:myConnectionString %>" 
            
               SelectCommand="SELECT * FROM [vadm_image]" OldValuesParameterFormatString="original_{0}" DeleteCommand="DELETE FROM [vadm_image] WHERE [id] = @original_id" InsertCommand="INSERT INTO [vadm_image] ([ImageName], [Description]) VALUES (@ImageName, @Description)" UpdateCommand="UPDATE [vadm_image] SET [ImageName] = @ImageName, [Description] = @Description WHERE [id] = @original_id">
               <DeleteParameters>
                   <asp:Parameter Name="original_id" Type="Int32" />
               </DeleteParameters>
               <InsertParameters>
                   <asp:Parameter Name="ImageName" Type="String" />
                   <asp:Parameter Name="Description" Type="String" />
               </InsertParameters>
               <UpdateParameters>
                   <asp:Parameter Name="ImageName" Type="String" />
                   <asp:Parameter Name="Description" Type="String" />
                   <asp:Parameter Name="original_id" Type="Int32" />
               </UpdateParameters>
           </asp:SqlDataSource>
        <%--<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            DataKeyNames="id" DataSourceID="SqlDataSource1" CellPadding="3" CellSpacing="10">
            <EmptyDataRowStyle BackColor="#0099FF" />
            <HeaderStyle BackColor="#232d42" Font-Italic="false" ForeColor="#80D5E6" />
            <Columns>
                <asp:BoundField DataField="dt" HeaderText="Date" SortExpression="dt" />
                <asp:BoundField DataField="cvfile" HeaderText="FileName" SortExpression="cvfile" />
                <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                <asp:BoundField DataField="cname" HeaderText="Name" SortExpression="cname" />
                <asp:BoundField DataField="mobile" HeaderText="Mobile" SortExpression="mobile" />
                <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" ReadOnly="True"
                    SortExpression="id" />
                <asp:HyperLinkField DataNavigateUrlFields="cvfile" DataNavigateUrlFormatString="cvfile/{0}"
                    HeaderText="DownloadFile" Text="See" />
            </Columns>
        </asp:GridView>--%>
        <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:blogsConnectionString5 %>"
            SelectCommand="SELECT [dt] , [cvfile] , [email], [cname] , [mobile], [id] FROM [cntct_tb]">
        </asp:SqlDataSource>--%>
       </div>

      </div>   

      <div id="fortbl" >
       <br /><br />
         <div>
          <table style="border: thin inset #800000">
            <tr width="20px">
                <td colspan="2" style="font-weight: 700; color: #0000FF">
                   Image Uploads...
                </td>
            </tr>
            <tr  >
                <td >
                    Upload Image:
                </td>
                <td >
                    <asp:FileUpload ID="fileuploadimages" runat="server" placeholder="Browse image" class="txt"/>
                    
                </td>
            </tr>
            <tr  width="13%">
                <td >
                    Enter Image Desc:
                </td>
                <td  >
                    <asp:TextBox ID="txtDesc" runat="server"  Height="58px" class="txt" TextMode="MultiLine" width=" 199px" placeholder="Description"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td >
                </td>
                <td  >
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" class="bt"/>
                   
                </td>
            </tr>
            <%--<tr>
                <td colspan="2">
                </td>
            </tr>--%>
        </table>
         </div>
    </div>

    </div>
</asp:Content>

