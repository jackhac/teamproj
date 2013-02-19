<?php
    $dbusername = 'phpproj';
    $dbpassword = 'kHc16289!';
    $dbhost = 'phpproj.db.10521321.hostedresource.com';
    $dbdatabase = 'phpproj';
    $bd = mysql_connect($dbhost, $dbusername, $dbpassword) 
or die("Opps some thing went wrong");
mysql_select_db($dbdatabase, $bd) or die("Opps some thing went wrong");
?>