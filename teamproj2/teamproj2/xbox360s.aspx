﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="xbox360s.aspx.cs" Inherits="teamproj2.xbox360s" %>
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
				<li><a href="#">Microsoft</a></li>
				<li><a href="#">Microsoft XBOX</a></li>
				<li><a href="#">Dreamgear</a></li>
				<li><a href="#">NOX</a></li>
				<li><a href="#">Mad Catz</a></li>
				
			</ul>
		</div>
		<div class="span10">
			<ul class="breadcrumb">
				<li><a href="default.aspx">Home</a> <span class="divider">/</span></li>
				<li><a href="videogames.aspx">Video Games</a> <span class="divider">/</span></li>
				<li class="active"><a href="xbox360.aspx">XBOX 360</a></li>
			</ul>
			<h3>XBOX 360</h3>
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
