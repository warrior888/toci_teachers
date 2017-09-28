<?php


class MailAddressValidator{

    public static function checkMail($mailAddress)
    {
        return filter_var($mailAddress,FILTER_VALIDATE_EMAIL);
    }
}
