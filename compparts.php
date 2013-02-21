<!DOCTYPE html>
<html>
<head>
    <title>Computers</title>
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
				<li class="nav-header">Computer Parts</li>
				<li><a href="#">Video Cards</a></li>
				<li><a href="#">Hard Drives</a></li>
				<li><a href="#">Monitors</a></li>
				<li><a href="#">Networking</a></li>
				<li><a href="#">Printers</a></li>
			</ul>
		</div>
		<div class="span10">
			<ul class="breadcrumb">
				<li><a href="index.php">Home</a> <span class="divider">/</span></li>
				<li class="active"><a href="compparts.php">Computer Parts</a> </li>
			</ul>
			<h3>Computer Parts Categories</h3>
  		<div class="well">
  		<div class="row">
		<ul class="thumbnails">
		<li class="span1">
				
			</li>
			<li class="span2">
				<center><img src="http://placehold.it/100x100"/><br>
				<a>Video Cards</a></center>
			</li>
			<li class="span2">
				<center><img src="http://placehold.it/100x100"/><br>
				<a>Hard Drives</a></center>
			</li>
			<li class="span2">
				<center><img src="http://placehold.it/100x100"/><br>
				<a>Monitors</a></center>
			</li>
			<li class="span2">
				<center><img src="http://placehold.it/100x100"/><br>
				<a>Networking</a></center>
			</li>
		</ul>
	</div>
	<div class="row">
		<ul class="thumbnails">
			<li class="span1">
				
			</li>
			<li class="span2">
				<center><img src="http://placehold.it/100x100"/>
				<a>Printers</a></center>
			</li>
		</ul>
	</div>
  		</div>
		</div>
	</div>
</div>

</body>
</html>