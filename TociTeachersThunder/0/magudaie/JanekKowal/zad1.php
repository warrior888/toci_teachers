<?php

$slowo = 'polska';


function Word($slowo, $litera) 
{
	$result = "0";
	
	for ($i = 0; $i < strlen($slowo); $i++)
	{
		//$result[] = $slowo[$i];
		
		if ($slowo[$i] == $litera) 
		{
			$result++;		
		}
	}
	return $result; 
}

echo Word('pokazpppp', 'p'); 
