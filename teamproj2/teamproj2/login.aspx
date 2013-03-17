<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="teamproj2.login" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="Form1" runat="server">
<asp:TextBox id="username" runat="server" Text="Username"/><br />
<asp:TextBox id="password" Text="Password" TextMode="password" runat="server" /><br />
<asp:Button ID="Button1" Text="Submit" runat="server" class="btn btn-large btn-primary" OnClick="submit"/>
</form>

</asp:Content>
