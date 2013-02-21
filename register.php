<?php ob_start(); ?>
<?php
include('dbinfo.inc.php');
session_start();

$prof_check=$_SESSION['cust_user'];

$ses_sql=mysql_query("select username from cust_t where username='$prof_check' ");

$row=mysql_fetch_array($ses_sql);

$prof_session=$row['username'];

if(isset($prof_session))
{
header("Location: index.php");

}
?>
<!DOCTYPE html>
<html>
<head>
    <title>Register</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="css/bootstrap.min.css" rel="stylesheet" media="screen">
    <style type="text/css">
    body {
            background-color: #fff;
         }
         
         .well
         {
	         width:33%;
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
include("dbinfo.inc.php");
session_start();

if($_SERVER["REQUEST_METHOD"] == "POST")
{
// username and password sent from Form
$username=mysql_real_escape_string($_POST['username']); 
$password=mysql_real_escape_string($_POST['password']); 
//$password=md5($password); // Encrypted Password
$sql="SELECT username FROM cust_t WHERE username='$username'";
$result=mysql_query($sql);
$count=mysql_num_rows($result);

// If result matched $myusername and $mypassword, table row must be 1 row
if($count==1)
{
//session_register("custusername");
//$_SESSION['cust_user']=$username;
echo "Username already in use!";
//header("location: index.php");
}
else 
{
	echo "You Are Registered! <a href='login.php'>Login</a>";
}
}
ob_end_flush();
?>
<center>
<form method="post" class="well">
<h2>Register</h2> 
<input type="text" name="username" placeholder="Username" ><br>
<input type="password" name="password" placeholder="Password" ><br>
<input type="submit" value="Submit" class="btn btn-large btn-primary">
</form></center>
</div>

</body>
</html>