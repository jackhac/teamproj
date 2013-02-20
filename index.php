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
<div id="myCarousel" class="carousel slide" >
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
			<div class="thumbnail">
				<img src="http://placehold.it/100x100"/>
				<center><a>Laptops</a></center>
			</div>
			</li>
			<li class="span2">
			<div class="thumbnail">
				<img src="http://placehold.it/100x100"/>
				<center><a>Desktops</a></center>
			</div>
			</li>
			<li class="span2">
			<div class="thumbnail">
				<img src="http://placehold.it/100x100"/>
				<center><a>Monitors</a></center>
			</div>
			</li>
			<li class="span2">
			<div class="thumbnail">
				<img src="http://placehold.it/100x100"/>
				<center><a>Networking</a></center>
			</div>
			</li>
			<li class="span2">
			<div class="thumbnail">
				<img src="http://placehold.it/100x100"/>
				<center><a>Gaming</a></center>
			</div>
			</li>
			<li class="span2">
			<div class="thumbnail">
				<img src="http://placehold.it/100x100"/>
				<center><a>Operating Systems</a></center>
			</div>
			</li>
		</ul>
	</div>
	<h4>Popular Products</h4>
	<div class="row">
		<ul class="thumbnails">
			<li class="span3">
			<div class="thumbnail">
				<img src="http://placehold.it/150x150"/>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</div>
			</li>
			<li class="span3">
			<div class="thumbnail">
				<img src="http://placehold.it/150x150"/>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</div>
			</li>
			<li class="span3">
			<div class="thumbnail">
				<img src="http://placehold.it/150x150"/>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</div>
			</li>
			<li class="span3">
			<div class="thumbnail">
				<img src="http://placehold.it/150x150"/>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</div>
			</li>
		</ul>
	</div>
	<h4>Current Bestsellers</h4>
	<div class="row">
		<ul class="thumbnails">
			<li class="span3">
			<div class="thumbnail">
				<img src="http://placehold.it/150x150"/>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</div>
			</li>
			<li class="span3">
			<div class="thumbnail">
				<img src="http://placehold.it/150x150"/>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</div>
			</li>
			<li class="span3">
			<div class="thumbnail">
				<img src="http://placehold.it/150x150"/>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</div>
			</li>
			<li class="span3">
			<div class="thumbnail">
				<img src="http://placehold.it/150x150"/>
				<a>Item Name</a>
				<h3 class="text-error">$99.99</h3>
			</div>
			</li>
		</ul>
	</div>
	<?php
include "footer.php";
?>
</div>
</body>
</html>