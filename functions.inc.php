<?php

	function addToCart($pid,$q)
	{
		if ($pid<1 or $q<1) return;
		
		if(is_array($_SESSION['cart']))
		{
			if(product_exists($pid)) return;
			$max=count($_SESSION['cart']);
			$_SESSION['cart'][$max]['productid']=$pid;
			$_SESSION['cart'][$max]['qty']=$q;
		}
		else
		{
			$_SESSION['cart']=array();
			$_SESSION['cart'][0]['productid']=$pid;
			$_SESSION['cart'][0]['qty']=$q;
		}
	}
	
	function displayCart()
	{
		if(is_array($_SESSION['cart']))
		{
			$max=count($_SESSION['cart']);
			echo "<table>";
			for($i=0;$i<$max;$i++)
			{
				$proid=$_SESSION['cart'][$i]['productid'];
				$proqty=$_SESSION['cart'][$i]['qty'];
				echo "<tr>";
					echo "<td>";
						echo $proid;
					echo "</td>";
					echo "<td>";
						echo "Item Name";
					echo "</td>";
					echo "<td>";
						echo $proqty;
					echo "</td>";
					echo "<td>";
						echo "<a href='cart.php?item=$proid&delete=1'>Delete</a>";
					echo "</td>";
				echo "</tr>";
			}
			echo "</table>";
		}
		else
		{
			echo "No Items In Cart!";
		}
	}
	
	function product_exists($pid)
	{
		$pid=intval($pid);
		$max=count($_SESSION['cart']);
		$flag=0;
	
		for($i=0;$i<$max;$i++)
		{
			if($pid==$_SESSION['cart'][$i]['productid'])
			{
			$flag=1;
			break;
			}
		}
		return $flag;
	}
	
	function remove_product($pid)
	{
		$pid=intval($pid);
		$max=count($_SESSION['cart']);
	
		for($i=0;$i<$max;$i++)
		{
			if($pid==$_SESSION['cart'][$i]['productid'])
			{
				unset($_SESSION['cart'][$i]);
				break;
			}
		}
			$_SESSION['cart']=array_values($_SESSION['cart']);
	}

?>