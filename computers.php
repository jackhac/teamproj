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
				<li class="nav-header">Computers</li>
				<li><a href="laptops.php">Laptops</a></li>
				<li><a href="ultrabooks.php">Ultrabooks</a></li>
				<li><a href="servers.php">Servers</a></li>
				<li><a href="desktops.php">Desktops</a></li>
			</ul>
		</div>
		<div class="span10">
			<ul class="breadcrumb">
				<li><a href="index.php">Home</a> <span class="divider">/</span></li>
				<li class="active"><a href="computers.php">Computers</a> </li>
			</ul>
			<h3>Computer Categories</h3>
  		<div class="well">
  		<div class="row">
		<ul class="thumbnails">
			<li class="span1">
				
			</li>
			<li class="span2">
				<center><a href="laptops.php"><img src="img/grey/cat-notebooks.jpg" />
				Laptops</a></center>
			</li>
			<li class="span2">
				<center><a href="ultrabooks.php"><img src="img/grey/cat-ultrabooks.jpg"/>
				Ultrabooks</a></center>
			</li>
			<li class="span2">
				<center><a href="servers.php"><img src="img/grey/cat-servers.jpg"/>
				Servers</a></center>
			</li>
			<li class="span2">
				<center><a href="desktops.php"><img src="img/grey/cat-desktops.jpg"/>
				Desktops</a></center>
			</li>
		</ul>
	</div>
  		</div>
		</div>
	</div>
</div>

</body>
</html>