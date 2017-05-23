<?php
//zad2 ile razy w danym stringu wystepuja podane w nim litery ('polska') wynik p:1, o:1, l:1, s:1 itd


HowManyTimes('pipkasdasdaskkkka'); 

function HowManyTimes($slowo) 
{	
	$result = array();
	
	for ($i = 0; $i < strlen($slowo); $i++)
	{
		$char = substr($slowo, $i, 1);
		$result[$char]++;
	}
	zapis($result);
	//return $result;
}

//funkcja odpowiadajaca za zapis tablicy
function zapis($data)
{
	foreach ($data as $key => $value)
	{
		echo "litera " .$key . " wystepuje tyle razy: " . $value . "\n"; 
	}
}

// korzystanie z funkcji count_chars
function Licz($data)
{
	foreach(count_chars($data, 1) as $i => $val)
	{
		echo "literka: ". chr($i) . " tyle razy wystepuje: " . $val . "\n";
	}
}

