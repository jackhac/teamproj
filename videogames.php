<!DOCTYPE html>
<html>
<head>
    <title>Video Games</title>
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
	<div class="row">
		<div class="span2">
			<ul class="nav nav-list">
				<li class="nav-header">Video Games</li>
				<li><a href="xbox360.php">XBOX 360</a></li>
				<li><a href="ps3.php">PS3</a></li>
				<li><a href="wii.php">Wii</a></li>
				<li><a href="pc.php">PC</a></li>
			</ul>
		</div>
		<div class="span10">
			<ul class="breadcrumb">
				<li><a href="index.php">Home</a> <span class="divider">/</span></li>
				<li class="active"><a href="videogames.php">Video Games</a> </li>
			</ul>
			<h3>Video Games Categories</h3>
  		<div class="well">
  		<div class="row">
		<ul class="thumbnails">
		<li class="span1">
				
			</li>
			<li class="span2">
				<center><a href="xbox360.php"><img src="img/grey/cat-xbox360_new.jpg"/><br>
				XBOX 360</a></center>
			</li>
			<li class="span2">
				<center><a href="ps3.php"><img src="img/grey/cat-ps3_new.jpg"/><br>
				PS3</a></center>
			</li>
			<li class="span2">
				<center><a href="wii.php"><img src="img/grey/cat-wii.jpg"/><br>
				Wii</a></center>
			</li>
			<li class="span2">
				<center><a href="pc.php"><img src="img/cat-PCgames.jpg"/><br>
				PC</a></center>
			</li>
		</ul>
	</div>
  		</div>
		</div>
	</div>
</div>

</body>
</html>