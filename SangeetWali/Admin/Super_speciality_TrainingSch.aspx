<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="Super_speciality_TrainingSch.aspx.cs" Inherits="Admin_Super_speciality_TrainingSch" %>

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
       </asp:Panel>
          
          <div id="fortbl" >
       <br /><br />
         <div>
          <table border="1px" >
            <tr width="20px">
                <td colspan="2" style="font-weight: 700; color: #0000FF">
                   Add Subjecs Here...
                </td>
            </tr>
            
            <tr  width="13%">
                <td >
                    Subject Name :
                </td>
                <td  >
                    <asp:TextBox ID="txtDesc" runat="server" Height="20px" class="txt" 
                        TextMode="SingleLine" width=" 205px" placeholder="Description" 
                        ontextchanged="txtDesc_TextChanged"></asp:TextBox>
                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                         ControlToValidate="txtDesc" ErrorMessage="Required !" 
                        ForeColor="#FF6699" Font-Size="Smaller"></asp:RequiredFieldValidator>
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

