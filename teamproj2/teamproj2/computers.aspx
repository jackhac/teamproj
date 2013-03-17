<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="computers.aspx.cs" Inherits="teamproj2.computers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">
		<div class="span2">
			<ul class="nav nav-list">
				<li class="nav-header">Computers</li>
				<li><a href="laptops.aspx">Laptops</a></li>
				<li><a href="ultrabooks.aspx">Ultrabooks</a></li>
				<li><a href="servers.aspx">Servers</a></li>
				<li><a href="desktops.aspx">Desktops</a></li>
			</ul>
		</div>
		<div class="span10">
			<ul class="breadcrumb">
				<li><a href="default.aspx">Home</a> <span class="divider">/</span></li>
				<li class="active"><a href="computers.aspx">Computers</a> </li>
			</ul>
			<h3>Computer Categories</h3>
  		<div class="well">
  		<div class="row">
		<ul class="thumbnails">
			<li class="span1">
				
			</li>
			<li class="span2">
				<center><a href="laptops.aspx"><img src="img/grey/cat-notebooks.jpg" />
				Laptops</a></center>
			</li>
			<li class="span2">
				<center><a href="ultrabooks.aspx"><img src="img/grey/cat-ultrabooks.jpg"/>
				Ultrabooks</a></center>
			</li>
			<li class="span2">
				<center><a href="servers.aspx"><img src="img/grey/cat-servers.jpg"/>
				Servers</a></center>
			</li>
			<li class="span2">
				<center><a href="desktops.aspx"><img src="img/grey/cat-desktops.jpg"/>
				Desktops</a></center>
			</li>
		</ul>
	</div>
  		</div>
		</div>
	</div>
</asp:Content>
