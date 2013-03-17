<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="item.aspx.cs" Inherits="teamproj2.item" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="span3">
	<img src="http://placehold.it/300x200">
	</div>
	<div class="span8">
		<ul class="breadcrumb">
			<li><a href="default.aspx">Home</a> <span class="divider">/</span></li>
			<li class="active"><a href="item.aspx">Item</a> </li>
		</ul>
		<h4>Item Title</h4>
			<div class="row">
				<div class="span5">
					<h5>Price: $99.99</h5>
				</div>
				<div class="span3">
					<div class="well">
					<center><a class="btn btn-success btn-large" href="item.aspx?pid=1&addcart=1">ADD TO CART</a></center>
					</div>
					
				</div>
			</div>
			
	</div>

<div class="span11 well">
<h4>Product Details</h4>
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
</div>
</asp:Content>
