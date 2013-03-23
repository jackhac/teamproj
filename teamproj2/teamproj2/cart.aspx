<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="teamproj2.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="form1" runat="server">  
        <div class="container">  
            <h1>Shopping Cart</h1>  
            <a href="Default.aspx">< Back</a><br />
            <div class="well">
                <%LoadCart();%>
                
            </div>
        </div>  
    </form> 
</asp:Content>
