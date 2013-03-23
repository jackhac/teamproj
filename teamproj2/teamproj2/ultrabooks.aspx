<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ultrabooks.aspx.cs" Inherits="teamproj2.ultrabooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">
		<div class="span2">
			<ul class="nav nav-list">
				<li class="nav-header">Price Range</li>
				<li><a href="#">$1 to $24</a></li>
				<li><a href="#">$25 to $49</a></li>
				<li><a href="#">$50 to $99</a></li>
				<li><a href="#">$100 to $199</a></li>
				<li><a href="#">$200 to $499</a></li>
				<li><a href="#">$500 to $749</a></li>
				<li><a href="#">$750 to $999</a></li>
				<li><a href="#">$1000 to $1499</a></li>
				<li><a href="#">$1500 to $2000</a></li>
				<li class="divider"></li>
				<li class="nav-header">Manufacturers</li>
				<li><a href="#">Acer</a></li>
				<li><a href="#">Samsung</a></li>
				<li><a href="#">Toshiba</a></li>
				<li><a href="#">Dell</a></li>
				<li><a href="#">Apple</a></li>
				<li><a href="#">HP</a></li>
				<li class="divider"></li>
				<li class="nav-header">Processor Type</li>
				<li><a href="#">Dual-Core</a></li>
				<li><a href="#">Quad-Core</a></li>
				<li><a href="#">Single-Core</a></li>
				<li class="divider"></li>
				<li class="nav-header">Processor Brand</li>
				<li><a href="#">Intel</a></li>
				<li><a href="#">AMD</a></li>
				<li><a href="#">NVIDIA</a></li>
				<li class="divider"></li>
				
			</ul>
		</div>
		<div class="span10">
			<ul class="breadcrumb">
				<li><a href="default.aspx">Home</a> <span class="divider">/</span></li>
				<li><a href="computers.aspx">Computers</a><span class="divider">/</span> </li>
				<li class="active"><a href="ultrabooks.aspx">Ultrabooks</a></li>
			</ul>
			<h3>Ultrabooks</h3>
  		<div class="well">
  		<div class="row">
		<ul class="thumbnails">
			
			<li class="span3">
				<center>
				<a href="item.aspx?pid=<%displayId(1); %>"><img src="<%displayPicture(1); %>"/></center><br>
				<%displayName(1); %></a>
				<h3 class="text-error"><%displayPrice(1); %></h3>
			
			</li>
			<li class="span3">
				<center>
				<a href="item.aspx"><img src="http://placehold.it/150x150"/></center><br>
				Item Name</a>
				<h3 class="text-error">$99.99</h3>
			
			</li>
			<li class="span3">
				<center>
				<a href="item.aspx"><img src="http://placehold.it/150x150"/></center><br>
				Item Name</a>
				<h3 class="text-error">$99.99</h3>
			
			</li>
		</ul>
	</div>
	<div class="row">
		<ul class="thumbnails">
			<li class="span3">
				<center>
				<a href="item.aspx"><img src="http://placehold.it/150x150"/></center><br>
				Item Name</a>
				<h3 class="text-error">$99.99</h3>
			
			</li>
			<li class="span3">
				<center>
				<a href="item.aspx"><img src="http://placehold.it/150x150"/></center><br>
				Item Name</a>
				<h3 class="text-error">$99.99</h3>
			
			</li>
			<li class="span3">
				<center>
				<a href="item.aspx"><img src="http://placehold.it/150x150"/></center><br>
				Item Name</a>
				<h3 class="text-error">$99.99</h3>
			
			</li>
		</ul>
	</div>
	<div class="row">
		<ul class="thumbnails">
			<li class="span3">
				<center>
				<a href="item.aspx"><img src="http://placehold.it/150x150"/></center><br>
				Item Name</a>
				<h3 class="text-error">$99.99</h3>
			
			</li>
			<li class="span3">
				<center>
				<a href="item.aspx"><img src="http://placehold.it/150x150"/></center><br>
				Item Name</a>
				<h3 class="text-error">$99.99</h3>
			
			</li>
			<li class="span3">
				<center>
				<a href="item.aspx"><img src="http://placehold.it/150x150"/></center><br>
				Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</li>
		</ul>
	</div>
  		</div>
		</div>
	</div>
</asp:Content>
