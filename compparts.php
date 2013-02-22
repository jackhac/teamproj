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
				<li><a href="videocards.php">Video Cards</a></li>
				<li><a href="harddrives.php">Hard Drives</a></li>
				<li><a href="monitors.php">Monitors</a></li>
				<li><a href="networking.php">Networking</a></li>
				<li><a href="printers.php">Printers</a></li>
				<li><a href="cpus.php">Processors/CPUs</a></li>
				<li><a href="memory.php">Memory/RAM</a></li>
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
				<center><a href="videocards.php"><img src="img/cat-video-cards.jpg"/><br>
				Video Cards</a></center>
			</li>
			<li class="span2">
				<center><a href="harddrives.php"><img src="img/cat-hard-drives.jpg"/><br>
				Hard Drives</a></center>
			</li>
			<li class="span2">
				<center><a href="monitors.php"><img src="img/grey/cat-monitors.jpg"/><br>
				Monitors</a></center>
			</li>
			<li class="span2">
				<center><a href="networking.php"><img src="img/grey/cat-networking.jpg"/><br>
				Networking</a></center>
			</li>
		</ul>
	</div>
	<div class="row">
		<ul class="thumbnails">
			<li class="span1">
				
			</li>
			<li class="span2">
				<center><a href="printers.php"><img src="img/grey/cat-printers.jpg"/>
				Printers</a></center>
			</li>
			<li class="span2">
				<center><a href="cpus.php"><img src="img/cat-cpus.jpg"/>
				Processors/CPUs</a></center>
			</li>
			<li class="span2">
				<center><a href="memory.php"><img src="img/cat-memory.jpg"/>
				Memory/RAM</a></center>
			</li>
		</ul>
	</div>
  		</div>
		</div>
	</div>
</div>

</body>
</html>