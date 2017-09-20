
<?php

	class DbHandle 
	{
	//postgres lub nie
        public $database;
		public function __construct ($dontUseEnc = false)
        {
            $this->dontUseEnc = $dontUseEnc;
        }

        public function dbConnect()
        {
            if (!isset($this->database))
	    {
		    //podane dane tylko dla testu czy bedzie w stanie sie polaczyc
	            $this->database = pg_pconnect("host=46.101.236.160 user=toci password=aaa111 dbname=toci");
                if (!$this->dontUseEnc)
                    pg_set_client_encoding ($this->database, 'LATIN2');
            }
            return $this->database;
        }
        public function dbClose()
        {
            pg_close($this->database);
        }
        public function Query($query)
        {
            $this->currentQuery = $query;
            $this->result = pg_query($this->dbConnect(), $query);
            $this->currentQuery = '';
            restore_error_handler();
            return $this->result;
        }
        public function PobierzDane($zapytanie, &$ilosc_wierszy = 0)
        {
            set_error_handler(array($this, 'errorHandler'), E_WARNING);
            $this->currentQuery = $zapytanie;
            $result = pg_query($this->dbConnect(), $zapytanie);
            $this->currentQuery = '';
            $newArray = pg_fetch_all($result);

            restore_error_handler();
            $ilosc_wierszy = $newArray ? sizeof($newArray) : 0;
            if($newArray)
            {
                return $newArray;
            }            
            else
            {
                return null;
            }
	}
	}
