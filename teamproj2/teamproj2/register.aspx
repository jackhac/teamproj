<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="teamproj2.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%isRegistered();%>
<form id="Form1" runat="server">
<asp:TextBox id="username" runat="server" Text="Username"/><br />
<asp:TextBox id="password" Text="Password" TextMode="password" runat="server" /><br />
<asp:Button ID="Button1" Text="Submit" runat="server" class="btn btn-large btn-primary" OnClick="submit"/>
</form>
</asp:Content>
