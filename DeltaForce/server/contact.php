<?php

require_once "SendMail.php";
require_once "MailAddressValidator.php";


//blokowanie nie ajaxa
if(!(isset($_SERVER['HTTP_X_REQUESTED_WITH']) && !empty($_SERVER['HTTP_X_REQUESTED_WITH']) && strtolower($_SERVER['HTTP_X_REQUESTED_WITH']) == 'xmlhttprequest')) {
    die("Zablokowano nie-ajax");
    }

//sprawdzenie czy dane istnieja
if(!(isset($_POST['contact-input-name'])&&
isset($_POST['contact-input-email'])&&
isset($_POST['contact-input-subject'])&&
isset($_POST['contact-input-message']))) {
    die("Brak wszystkich danych"); // brak wszystkich dnaych
    }


$askerMailAddress= $_POST['contact-input-email'];

if(!MailAddressValidator::checkMail($askerMailAddress))
{
    die("Podany email:".$askerMailAddress." jest nieprawidłowy");
}

$askerName = $_POST['contact-input-name'];
$askerSubject= $_POST['contact-input-subject'];

$askerMessage= "Przesłał: ".$askerName.", mail: ".$_POST['contact-input-message']." <br/ ><br />".$_POST['contact-input-message'];



$mail=new MailSender();
$result = $mail->SendMail($askerSubject,$askerMessage,"tociszkolenia@gmail.com",$askerName);

$message = $result ? 'Mail wysłano pomyślnie.' : 'Wystąpił błąd przy próbie wysłania maila.';

echo json_encode(array('result' => $result, 'message' => $message));
