<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="harddrives.aspx.cs" Inherits="teamproj2.harddrives" %>
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
				<li><a href="#">EVGA</a></li>
				<li><a href="#">XFX</a></li>
				<li><a href="#">PNY</a></li>
				<li><a href="#">VisionTek</a></li>
				<li><a href="#">Asus</a></li>
				<li class="divider"></li>
				<li class="nav-header">Interface Type</li>
				<li><a href="#">PCI Express 2.0</a></li>
				<li><a href="#">PCI Express 3.0</a></li>
				<li><a href="#">PCI Express 2.1</a></li>
				<li><a href="#">PCI Express</a></li>
				<li class="divider"></li>
				<li class="nav-header">Processor Brand</li>
				<li><a href="#">Intel</a></li>
				<li><a href="#">AMD</a></li>
				<li><a href="#">NVIDIA</a></li>
				<li class="divider"></li>
				<li class="nav-header">Chipset</li>
				<li><a href="#">NVIDIA GeForce</a></li>
				<li><a href="#">AMD Radeon</a></li>
				<li><a href="#">NVIDIA Quadro</a></li>
				<li><a href="#">ATI Radeon</a></li>
				<li class="divider"></li>
				<li class="nav-header">Memory Type</li>
				<li><a href="#">GDDR5</a></li>
				<li><a href="#">DDR3</a></li>
				<li><a href="#">GDDR3</a></li>
				<li><a href="#">DDR2</a></li>
				<li><a href="#">DDR5</a></li>
				<li class="divider"></li>
			</ul>
		</div>
		<div class="span10">
			<ul class="breadcrumb">
				<li><a href="default.aspx">Home</a> <span class="divider">/</span></li>
				<li><a href="compparts.aspx">Computer Parts</a><span class="divider">/ </li>
				<li class="active"><a href="harddrives.aspx">Hard Drives</a></li>
			</ul>
			<h3>Hard Drives</h3>
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
				<a href="item.aspx?pid=<%displayId(2); %>"><img src="<%displayPicture(2); %>"/></center><br>
				<%displayName(2); %></a>
				<h3 class="text-error"><%displayPrice(2); %></h3>
			</li>
			<li class="span3">
				<center>
				<a href="item.aspx?pid=<%displayId(3); %>"><img src="<%displayPicture(3); %>"/></center><br>
				<%displayName(3); %></a>
				<h3 class="text-error"><%displayPrice(3); %></h3>
			</li>
		</ul>
	</div>
	<div class="row">
		<ul class="thumbnails">
			<li class="span3">
				<center>
				<a href="item.aspx?pid=<%displayId(4); %>"><img src="<%displayPicture(4); %>"/></center><br>
				<%displayName(4); %></a>
				<h3 class="text-error"><%displayPrice(4); %></h3>
			</li>
			<li class="span3">
				<center>
				<a href="item.aspx?pid=<%displayId(5); %>"><img src="<%displayPicture(5); %>"/></center><br>
				<%displayName(5); %></a>
				<h3 class="text-error"><%displayPrice(5); %></h3>
			</li>
			<li class="span3">
				<center>
				<a href="item.aspx?pid=<%displayId(6); %>"><img src="<%displayPicture(6); %>"/></center><br>
				<%displayName(6); %></a>
				<h3 class="text-error"><%displayPrice(6); %></h3>
			</li>
		</ul>
	</div>
	<div class="row">
		<ul class="thumbnails">
			<li class="span3">
				<center>
				<a href="item.aspx?pid=<%displayId(7); %>"><img src="<%displayPicture(7); %>"/></center><br>
				<%displayName(7); %></a>
				<h3 class="text-error"><%displayPrice(7); %></h3>
			</li>
			<li class="span3">
				<center>
				<a href="item.aspx?pid=<%displayId(8); %>"><img src="<%displayPicture(8); %>"/></center><br>
				<%displayName(8); %></a>
				<h3 class="text-error"><%displayPrice(8); %></h3>
			</li>
			<li class="span3">
				<center>
				<a href="item.aspx?pid=<%displayId(9); %>"><img src="<%displayPicture(9); %>"/></center><br>
				<%displayName(9); %></a>
				<h3 class="text-error"><%displayPrice(9); %></h3>
			</li>
		</ul>
	</div>
  		</div>
		</div>
	</div>
</asp:Content>
