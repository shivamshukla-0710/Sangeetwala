<%@ Page Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="about.aspx.cs" Inherits="Admin_about" Title="About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="TextBox1" TextMode="MultiLine" Width="1045px" Height="446px" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Update About Detail" 
    onclick="Button1_Click" />

    <br />

</asp:Content>

