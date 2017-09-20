<?php
require ('Mailer/PHPMailerAutoload.php');


class MailSender{

	public $mail;

	public function MailSender()
	{
		$this->mail=new PHPMailer();
		$this->mail->isSMTP();
		$this->mail->SMTPDebug = 1; // debugging: 1 = errors and messages, 2 = messages only
		$this->mail->SMTPAuth = true; // authentication enabled
		$this->mail->SMTPSecure = 'ssl'; // secure transfer enabled REQUIRED for GMail		
		$this->mail->Host = "smtp.gmail.com";
		$this->mail->Port = 465; // or 587
		$this->mail->IsHTML(true);
		$this->mail->Username = 'tociszkolenia@gmail.com';
		$this->mail->Password = 'T0CIszkolenia';
		//$this->mail->SetFrom("example@gmail.com");
		//$this->mail->Subject = "Test";
	}

	public function SendMail($subject, $message, $senderEmail, $senderData=null)
	{

		$this->mail->Subject=$subject;
		$this->mail->Body=$message;
		$this->mail->AddAddress($senderEmail);
		//$this->mail->SetFrom($senderEmail);

		return $this->mail->Send();
	}
}
