<?php

require_once 'Db.php';
require_once 'SendMail.php';

	class MailConfirm 
	{
		public $db;
		public $mailer;

		public function __construct()
		{
			$this->db=new Db();
			$this->mailer=new MailSender();
			$this->salt1="sdretf";
			$this->salt2="54fsds";
		}

		public function sendConfirmationMail($applicant)
		{
			$signature=$this->CreateSignature($applicant['email']);
			$confirmLink="http://www.toci.com.pl/server/confirm.php?signature=$signature";
			$subject="Potwierdzenie udziału w szkoleniu TOCI";
			$message="co tam mordo, łap linka <br>".$confirmLink;

			$result=$this->mailer->SendMail($subject,$message,$applicant['email'],$applicant['name']);

			return $result?$signature:false;

		}

		public function CreateSignature($mail)
		{
			return md5($this->salt1.$mail.$this->salt2.microtime(true));
		}

		public function Verify($sign)
		{
			/// get from db

			// updaye e ten mail jest potwierdzony
		}
	}