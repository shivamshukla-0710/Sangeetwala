<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_Master.master" AutoEventWireup="true" CodeFile="youtube.aspx.cs" Inherits="Admin_youtube" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<asp:DataList ID="DataList4" RepeatColumns="3" Width="80%" Height="160" runat="server">

                  <ItemTemplate>

                  <u>
               Name  :- <%# Eval("name")%></u> 

<%--<iframe width="320" height="215"
src="<%#Eval("url")%>">
</iframe>--%>
<embed width="320" height="215"
src="<%#Eval("url")%>">

                   
                     
                  
                  </ItemTemplate>
              </asp:DataList>
</asp:Content>

