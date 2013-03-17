<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="item.aspx.cs" Inherits="teamproj2.item" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="span3">
	<img src="<%displayPicture();%>"/>
	</div>
	<div class="span8">
		<ul class="breadcrumb">
			<li><a href="default.aspx">Home</a> <span class="divider">/</span></li>
			<li class="active"><a href="item.aspx"><%displayName();%></a> </li>
		</ul>
        
        <ul class="breadcrumb">
			<li><%displayMCategory();%><span class="divider">/</span></li>
			<li><%displaySCategory();%></li>
		</ul>
        
		<h4><%displayName();%></h4>
			<div class="row">
				<div class="span5">
					<h5>Price: <%displayPrice();%></h5>
				</div>
				<div class="span3">
					<div class="well">
					<center><a class="btn btn-success btn-large" href="item.aspx?pid=<%=Request.QueryString["pid"] %>&addcart=1">ADD TO CART</a></center>
					</div>
					
				</div>
			</div>
			
	</div>

<div class="span11 well">
<h4>Product Details</h4>
<%displayDesc();%>

</div>

</asp:Content>
