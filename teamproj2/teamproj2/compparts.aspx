<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="compparts.aspx.cs" Inherits="teamproj2.compparts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">
		<div class="span2">
			<ul class="nav nav-list">
				<li class="nav-header">Computer Parts</li>
				<li><a href="videocards.aspx">Video Cards</a></li>
				<li><a href="harddrives.aspx">Hard Drives</a></li>
				<li><a href="monitors.aspx">Monitors</a></li>
				<li><a href="networking.aspx">Networking</a></li>
				<li><a href="printers.aspx">Printers</a></li>
				<li><a href="cpus.aspx">Processors/CPUs</a></li>
				<li><a href="memory.aspx">Memory/RAM</a></li>
			</ul>
		</div>
        
		<div class="span10">
			<ul class="breadcrumb">
				<li><a href="index.aspx">Home</a> <span class="divider">/</span></li>
				<li class="active"><a href="compparts.aspx">Computer Parts</a> </li>
			</ul>
			<h3>Computer Parts Categories</h3>
  		<div class="well">
  		<div class="row">
		<ul class="thumbnails">
		<li class="span1">
				
			</li>
			<li class="span2">
				<center><a href="videocards.aspx"><img src="img/cat-video-cards.jpg"/><br>
				Video Cards</a></center>
			</li>
			<li class="span2">
				<center><a href="harddrives.aspx"><img src="img/cat-hard-drives.jpg"/><br>
				Hard Drives</a></center>
			</li>
			<li class="span2">
				<center><a href="monitors.aspx"><img src="img/grey/cat-monitors.jpg"/><br>
				Monitors</a></center>
			</li>
			<li class="span2">
				<center><a href="networking.aspx"><img src="img/grey/cat-networking.jpg"/><br>
				Networking</a></center>
			</li>
		</ul>
	</div>
	<div class="row">
		<ul class="thumbnails">
			<li class="span1">
				
			</li>
			<li class="span2">
				<center><a href="printers.aspx"><img src="img/grey/cat-printers.jpg"/>
				Printers</a></center>
			</li>
			<li class="span2">
				<center><a href="cpus.aspx"><img src="img/cat-cpus.jpg"/>
				Processors/CPUs</a></center>
			</li>
			<li class="span2">
				<center><a href="memory.aspx"><img src="img/cat-memory.jpg"/>
				Memory/RAM</a></center>
			</li>
		</ul>
	</div>
  		</div>
		</div>
	</div>
</asp:Content>
