<?php

function HowManyTimes($slowo, $fragment)
{
	$result = array();
	
	for ($i = 0; $i < strlen($slowo)-1; $i++)
	{
		
		$result[] = $slowo[$i].$slowo[++$i];
		$i--;
		
		if ($result[$i] == $fragment)
		 {
		 	$result[$fragment]++;
		 }			
	}
	echo "\n" . "fraza " . '"'. $fragment . '"' . " wystapila w " . '"' . $slowo . '"' . " " . $result[$fragment] . " razy" . "\n";
}

HowManyTimes('polskapolska', 'po');