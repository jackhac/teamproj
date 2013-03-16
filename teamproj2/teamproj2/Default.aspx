<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="teamproj2.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<div id="myCarousel" class="carousel slide" style="width:650px">
                <!-- Carousel items -->
                <div class="carousel-inner">
                <div class="active item">
                    <img src="http://placehold.it/650x250">
                </div>
                <div class="item">
                    <img src="http://placehold.it/650x250">
                </div>
                <div class="item">
                    <img src="http://placehold.it/650x250">
                </div>
                </div>
                <!-- Carousel nav -->
                <a class="carousel-control left" href="#myCarousel" data-slide="prev">&lsaquo;</a>
                <a class="carousel-control right" href="#myCarousel" data-slide="next">&rsaquo;</a>
                
    </div><!--End of Carousel-->
    <h4>Our Most Popular Categories</h4>
    <div class="row">
		<ul class="thumbnails">
			<li class="span2">
			
				<center><a href="laptops.aspx"><img src="img/home_laptops.jpg"/>
				Laptops</a></center>
			
			</li>
			<li class="span2">
			
				<center><a href="desktops.aspx"><img src="img/home_desktops2.jpg"/>
				Desktops</a></center>
			
			</li>
			<li class="span2">
			
				<center><a href="monitors.aspx"><img src="img/home_monitors.jpg"/>
				Monitors</a></center>
			
			</li>
			<li class="span2">
			
				<center><a href="networking.aspx"><img src="img/home_networking.jpg"/>
				Networking</a></center>
			
			</li>
			<li class="span2">
			
				<center><a href="videogames.aspx"><img src="img/xbox.jpg"/>
				Gaming</a></center>
			
			</li>
			<li class="span2">
			
				<center><a href="printers.aspx"><img src="img/home_printers.jpg"/>
				Printers</a></center>
			
			</li>
		</ul>
	</div>
    <h4>Popular Products</h4>
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
				<h3 class="text-error">$99.99</h3>			</li>
			<li class="span3">
			<center>
				<a href="item.aspx"><img src="http://placehold.it/150x150"/></center><br>
				Item Name</a>
				<h3 class="text-error">$99.99</h3>			</li>
			<li class="span3">
			<center>
				<a href="item.aspx"><img src="http://placehold.it/150x150"/></center><br>
				Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</li>
		</ul>
	</div>
	<h4>Current Bestsellers</h4>
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
			<li class="span3">
			<center>
				<a href="item.aspx"><img src="http://placehold.it/150x150"/></center><br>
				Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</li>
		</ul>
	</div>
</asp:Content>
