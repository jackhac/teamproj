<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="videogames.aspx.cs" Inherits="teamproj2.videogames" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">
		<div class="span2">
			<ul class="nav nav-list">
				<li class="nav-header">Video Games</li>
				<li><a href="xbox360.aspx">XBOX 360</a></li>
				<li><a href="ps3.aspx">PS3</a></li>
				<li><a href="wii.aspx">Wii</a></li>
				<li><a href="pc.aspx">PC</a></li>
			</ul>
		</div>
		<div class="span10">
			<ul class="breadcrumb">
				<li><a href="default.aspx">Home</a> <span class="divider">/</span></li>
				<li class="active"><a href="videogames.aspx">Video Games</a> </li>
			</ul>
			<h3>Video Games Categories</h3>
  		<div class="well">
  		<div class="row">
		<ul class="thumbnails">
		<li class="span1">
				
			</li>
			<li class="span2">
				<center><a href="xbox360s.aspx"><img src="img/grey/cat-xbox360_new.jpg"/><br>
				XBOX 360</a></center>
			</li>
			<li class="span2">
				<center><a href="ps3.aspx"><img src="img/grey/cat-ps3_new.jpg"/><br>
				PS3</a></center>
			</li>
			<li class="span2">
				<center><a href="wii.aspx"><img src="img/grey/cat-wii.jpg"/><br>
				Wii</a></center>
			</li>
			<li class="span2">
				<center><a href="pc.aspx"><img src="img/cat-PCgames.jpg"/><br>
				PC</a></center>
			</li>
		</ul>
	</div>
  		</div>
		</div>
	</div>
</asp:Content>
