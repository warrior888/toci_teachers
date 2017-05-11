<?php
	
	$bankAccount = array
	(
		"2510302568998789",
		"2510202568998789",
		"2510402568998789",
		"2510502568998789",
		"2510202568998789",
		"2510602568998789",
		"2510802568998789",
		"2510202568998789"
	);
	
	function sprawdzenieNrKont($lista) 
	{
		$tablica = array(1020 => "ING", 1030 => "alior", 1040 => "pko", 1050 => "wbk", 1060 => "pko sa", 1080 => "mbank");

		for($i = 0; $i < count($lista); $i++)
		{
			$id = rozpoznanieId($lista[$i]);
			echo "nr konta: " . $lista[$i] . " nalezy do banku: " . $tablica[$id] . "\n";
		}
	}
	
	function rozpoznanieId($bankID) 
	{
		return substr($bankID, 2, 4);
	}
	
	sprawdzenieNrKont($bankAccount);
	
	
	