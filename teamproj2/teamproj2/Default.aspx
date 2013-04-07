<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="teamproj2.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<div id="myCarousel" class="carousel slide" style="width:650px">
                <!-- Carousel items -->
                <div class="carousel-inner">
                <div class="active item">
                    <img src="img/featurespot-g_T71-11133CASUB.jpg" alt="Feature Spot">
                </div>
                <div class="item">
                    <img src="img/featurespot-p_B69-0997.jpg" alt="Feature Spot">
                </div>
                <div class="item">
                    <img src="img/featurespot-stpat_I750-4200CA.jpg" alt="Feature Spot">
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
				<center><a href="laptops.aspx"><img src="img/home_laptops.jpg" alt="Laptops"/>
				Laptops</a></center>
			</li>
			<li class="span2">
				<center><a href="desktops.aspx"><img src="img/home_desktops2.jpg" alt="Desktops"/>
				Desktops</a></center>
			</li>
			<li class="span2">
				<center><a href="ultrabooks.aspx"><img src="img/grey/cat-ultrabooks.jpg" alt="Ultrabooks"/>
				Ultrabooks</a></center>
			</li>
			<li class="span2">
				<center><a href="videocards.aspx"><img src="img/cat-video-cards.jpg" alt="Video Cards"/>
				Video Cards</a></center>
			</li>
			<li class="span2">
				<center><a href="videogames.aspx"><img src="img/xbox.jpg" alt="XBOX"/>
				Gaming</a></center>
			</li>
			<li class="span2">
				<center><a href="harddrives.aspx"><img src="img/cat-hard-drives.jpg" alt="Hard Drives"/>
				Hard Drives</a></center>
			</li>
		</ul>
	</div>
    <h4>Popular Products</h4>
	<div class="row">
		<ul class="thumbnails">
			<li class="span3">
				<center>
				<a href="item.aspx?pid=<%displayId(1);%>"><img src="<%displayPicture(1);%>"/></center><br>
				<%displayName(1); %></a>
				<h3 class="text-error"><%displayPrice(1); %></h3>           </li>
			<li class="span3">
			<center>
				<a href="item.aspx?pid=<%displayId(2);%>"><img src="<%displayPicture(2);%>"/></center><br>
				<%displayName(2); %></a>
				<h3 class="text-error"><%displayPrice(2); %></h3>			</li>
			<li class="span3">
			<center>
				<a href="item.aspx?pid=<%displayId(3);%>"><img src="<%displayPicture(3);%>"/></center><br>
				<%displayName(3); %></a>
				<h3 class="text-error"><%displayPrice(3); %></h3>			</li>
			<li class="span3">
			<center>
				<a href="item.aspx?pid=<%displayId(4);%>"><img src="<%displayPicture(4);%>"/></center><br>
				<%displayName(4); %></a>
				<h3 class="text-error"><%displayPrice(4); %></h3>
			</li>
		</ul>
	</div>
	<h4>Current Bestsellers</h4>
	<div class="row">
		<ul class="thumbnails">
			<li class="span3">
			<center>
				<a href="item.aspx?pid=<%displayId(5);%>"><img src="<%displayPicture(5);%>"/></center><br>
				<%displayName(5); %></a>
				<h3 class="text-error"><%displayPrice(5); %></h3>
			</li>
			<li class="span3">
			<center>
				<a href="item.aspx?pid=<%displayId(6);%>"><img src="<%displayPicture(6);%>"/></center><br>
				<%displayName(6); %></a>
				<h3 class="text-error"><%displayPrice(6); %></h3>
			</li>
			<li class="span3">
			<center>
				<a href="item.aspx?pid=<%displayId(7);%>"><img src="<%displayPicture(7);%>"/></center><br>
				<%displayName(7); %></a>
				<h3 class="text-error"><%displayPrice(7); %></h3>
			</li>
			<li class="span3">
			<center>
				<a href="item.aspx?pid=<%displayId(8);%>"><img src="<%displayPicture(8);%>"/></center><br>
				<%displayName(8); %></a>
				<h3 class="text-error"><%displayPrice(8); %></h3>
			</li>
		</ul>
	</div>
</asp:Content>
