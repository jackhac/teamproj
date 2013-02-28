<?php
	include "functions.inc.php";
	session_start();
	$pid2=$_GET['pid'];
	
	if (!isset($_GET['pid']))
	{
		header("Location: item.php?pid=1");
	}
	
	if ($_GET['addcart']==1)
	{
		addToCart($pid2,1);
		//echo "test";
	}

?>
<!DOCTYPE html>
<html>
<head>
    <title>Item</title>
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
	<div class="span3">
	<img src="http://placehold.it/300x200">
	</div>
	<div class="span8">
		<ul class="breadcrumb">
			<li><a href="index.php">Home</a> <span class="divider">/</span></li>
			<li class="active"><a href="item.php">Item</a> </li>
		</ul>
		<h4>Item Title</h4>
			<div class="row">
				<div class="span5">
					<h5>Price: $99.99</h5>
				</div>
				<div class="span3">
					<div class="well">
					<center><a href="item.php?pid=<?php echo $pid2;?>&addcart=1"><button class="btn btn-success btn-large" <?php
					isDisableButton($pid2);
					?>
					>ADD TO CART</button></a></center>
					</div>
					
				</div>
			</div>
			
	</div>
<h4>Product Details</h4>
<div class="span11 well">
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
</div>
</div>
</body>
</html>