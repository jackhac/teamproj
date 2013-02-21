<?php
include('dbinfo.inc.php');
session_start();

$prof_check=$_SESSION['cust_user'];

$ses_sql=mysql_query("select username from cust_t where username='$prof_check' ");

$row=mysql_fetch_array($ses_sql);

$prof_session=$row['username'];

$loggedin=false;

if(isset($prof_session))
{
	//header("Location: login.php");
	//echo "logged in";
	$loggedin=true;
}

?>