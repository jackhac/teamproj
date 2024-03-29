﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="compparts.aspx.cs" Inherits="teamproj2.compparts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="row">
		<div class="span2">
			<ul class="nav nav-list">
				<li class="nav-header">Computer Parts</li>
				<li><a href="videocards.aspx">Video Cards</a></li>
				<li><a href="harddrives.aspx">Hard Drives</a></li>
				<li><a href="cpus.aspx">Processors/CPUs</a></li>
				<li><a href="memory.aspx">Memory/RAM</a></li>
                <li><a href="motherboards.aspx">Motherboards</a></li>
			</ul>
		</div>
		<div class="span10">
			<ul class="breadcrumb">
				<li><a href="default.aspx">Home</a> <span class="divider">/</span></li>
				<li class="active"><a href="compparts.aspx">Computer Parts</a> </li>
			</ul>
			<h3>Computer Parts Categories</h3>
  		<div class="well">
  		<div class="row">
		<ul class="thumbnails">
		<li class="span1">
			</li>
			<li class="span2">
				<center><a href="videocards.aspx"><img src="img/cat-video-cards.jpg"/><br/>
				Video Cards</a></center>
			</li>
			<li class="span2">
				<center><a href="harddrives.aspx"><img src="img/cat-hard-drives.jpg"/><br/>
				Hard Drives</a></center>
			</li>
			<li class="span2">
				<center><a href="cpus.aspx"><img src="img/cat-cpus.jpg"/>
				Processors/CPUs</a></center>
			</li>
			<li class="span2">
				<center><a href="memory.aspx"><img src="img/cat-memory.jpg"/>
				Memory/RAM</a></center>
			</li>
            <li class="span2">
				<center><a href="motherboards.aspx"><img src="img/cat-motherboards.jpg"/>
				Motherboards</a></center>
			</li>
		</ul>
	</div>
  		</div>
		</div>
	</div>
</asp:Content>
