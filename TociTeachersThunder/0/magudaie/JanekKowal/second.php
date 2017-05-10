<?php

	//2 zad porownywarka znakow 
	
	$komunikat1 = 'dasdasdsassa';
	$komunikat2 = 'asdaasdsssss';
	
	function IsEqual($text1, $text2) {
		return strlen($text1) == strlen($text2);
	}
		
	function WriteScore($text1, $text2){
		if (isEqual($text1, $text2)) {
			echo "\n" . 'zmienne komunikat(x) zawieraja ta sama liczbe znakow' . "\n";
		} else {
			echo 'zmienne komunikat(x) nie zawieraja tej samej liczby znakow'. "\n";
		}
	}
	
	WriteScore($komunikat1, $komunikat2);
	
	//3zad tablica + palindrom
	
	$tablica = array('paja', 'japa', 'lolo', 'radar', 'gaag', 'sennes');
	$length = count($tablica);
	
	for($i = 0; $i < $length; $i++) {
		echo "\n" . $tablica[$i] . " -" . ' to wyraz, ktory ';
		PalindromScore($tablica[$i]);	
	}
	
	function IsPalindrom($komunikat) {
		return $komunikat == strrev($komunikat);
	}
	
	function PalindromScore($komunikat) {
		if (IsPalindrom($komunikat)) {
			echo 'jest palindromem' . "\n";
		} else {
			echo 'nie jest palindromem' . "\n";
		}		
	}
	