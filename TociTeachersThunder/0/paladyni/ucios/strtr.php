<?php
  //strtr - funkcja do zamiany jednych znakow na inne w systemie ACSII
  //strtr - ma 3 parametry (test, znaki do podmiany, znaki na ktore zmienic)
  $tekst = "Jam do Jana pojechal na noc";

  echo $tekst;
  echo "/n";

  function LA_strtr($parameter1, $zamienicZ, $zamienicNA){
    for ($i = 0; $i < strlen($parameter1); $i++){
      for($j = 0; $j < strlen($zamienicZ); $j++){
        if($parameter1[$i]==$zamienicZ[$j]){
          echo $zamienicNA[$j];
          break;
        } else {
          echo $parameter1[$i];
          break;
        }
      }
    }
  }

  LA_strtr($tekst, 'nm', 'rk');
  echo "/n";

  $wynik = strtr($tekst, 'nm', 'rk');
  echo $wynik;
?>
