<?php

class Hello {
	public function sayHello($imie)
	{
		return 'Hello, ' . $imie;
	}
}

$newFriend = new Hello();
echo $newFriend->sayHello('friend');