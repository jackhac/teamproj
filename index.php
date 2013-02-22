<?php
include "lock.php";
?>
<!DOCTYPE html>
<html>
<head>
    <title>TEAM Project</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="css/bootstrap.min.css" rel="stylesheet" media="screen">
    <style type="text/css">
    body {
            background-color: #fff;
         }
    </style>
    <script src="http://code.jquery.com/jquery.js"></script>
    <script src="js/bootstrap.min.js"></script>
     </head>
<body>
<div class="container">

<?php
include "header.php";

?>
<?php
if($loggedin==true)
{
echo "<div style='float:right'><a href='cart.php'>Shopping Cart</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href='account.php'>My Account</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href='logout.php'>Logout</a></div>";
}
else
{
echo "<div id='abc' style='float:right'><a href='cart.php'>Shopping Cart</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href='login.php'>Login</a> or <a href='register.php'>Register</a></div><br><br>";
}
?>

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
			
				<center><a href="laptops.php"><img src="img/home_laptops.jpg"/>
				Laptops</a></center>
			
			</li>
			<li class="span2">
			
				<center><a href="desktops.php"><img src="img/home_desktops2.jpg"/>
				Desktops</a></center>
			
			</li>
			<li class="span2">
			
				<center><a href="monitors.php"><img src="img/home_monitors.jpg"/>
				Monitors</a></center>
			
			</li>
			<li class="span2">
			
				<center><a href="networking.php"><img src="img/home_networking.jpg"/>
				Networking</a></center>
			
			</li>
			<li class="span2">
			
				<center><a href="gaming.php"><img src="img/xbox.jpg"/>
				Gaming</a></center>
			
			</li>
			<li class="span2">
			
				<center><a href="printers.php"><img src="img/home_printers.jpg"/>
				Printers</a></center>
			
			</li>
		</ul>
	</div>
	<h4>Popular Products</h4>
	<div class="row">
		<ul class="thumbnails">
			<li class="span3">
				<center>
				<img src="http://placehold.it/150x150"/></center><br>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>
			
			</li>
			<li class="span3">
			<center>
				<img src="http://placehold.it/150x150"/></center><br>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>			</li>
			<li class="span3">
			<center>
				<img src="http://placehold.it/150x150"/></center><br>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>			</li>
			<li class="span3">
			<center>
				<img src="http://placehold.it/150x150"/></center><br>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</li>
		</ul>
	</div>
	<h4>Current Bestsellers</h4>
	<div class="row">
		<ul class="thumbnails">
			<li class="span3">
			<center>
				<img src="http://placehold.it/150x150"/></center><br>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</li>
			<li class="span3">
			<center>
				<img src="http://placehold.it/150x150"/></center><br>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</li>
			<li class="span3">
			<center>
				<img src="http://placehold.it/150x150"/></center><br>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</li>
			<li class="span3">
			<center>
				<img src="http://placehold.it/150x150"/></center><br>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</li>
		</ul>
	</div>
	<?php
include "footer.php";
?>
</div>
</body>
</html>