namespace Toci.Training.WojciechSeweryn
{
    public class BankResolver
    {
        const int Start = 2;
        const int Len = 4;
        static readonly CodeGenerator _codeGen = new CodeGenerator();

        public string GetBankName(string bankCodeID)
        {
            return _codeGen.BankList.ContainsKey(bankCodeID) ? _codeGen.BankList[bankCodeID].ToString() : "brak banku";

            /*
            Hashtable bankCodes = new Hashtable();
            
            bankCodes.Add("1010", "Narodowy Bank Polski");
            bankCodes.Add("1020", "PKO BP");
            bankCodes.Add("1030", "Citibank Handlowy");
            bankCodes.Add("1050", "ING");
            bankCodes.Add("1060", "BPH");
            bankCodes.Add("1090", "BZ WBK");
            bankCodes.Add("1130", "BGK");
            bankCodes.Add("1140", "mBank");
            bankCodes.Add("1160", "Bank Millennium");
            bankCodes.Add("1240", "Pekao");
            bankCodes.Add("1280", "HSBC");
            bankCodes.Add("1300", "Meritum Bank");
            bankCodes.Add("1320", "Bank Pocztowy");
            bankCodes.Add("1440", "Nordea Bank");
            bankCodes.Add("1470", "Eurobank");
            bankCodes.Add("1540", "BOŚ");
            bankCodes.Add("1580", "Mercedes-Benz Bank Polska");
            bankCodes.Add("1600", "BNP Paribas Fortis");
            bankCodes.Add("1610", "SGB - Bank");
            bankCodes.Add("1670", "RBS Bank (Polska)");
            bankCodes.Add("1750", "Plus Bank");
            bankCodes.Add("1840", "Raiffeisen Bank");
            bankCodes.Add("1870", "Societe Generale");
            bankCodes.Add("1910", "FM Bank PBP");
            bankCodes.Add("1930", "Bank Polskiej Spółdzielczości");
            bankCodes.Add("1940", "Credit Agricole Bank Polska");
            bankCodes.Add("1950", "Idea Bank");
            bankCodes.Add("2000", "Rabobank Polska");
            bankCodes.Add("2030", "BGŻ");
            bankCodes.Add("2070", "FCE Bank Polska");
            bankCodes.Add("2120", "Santander Consumer Bank");
            bankCodes.Add("2130", "Volkswagen Bank");
            bankCodes.Add("2140", "Fiat Bank Polska");
            bankCodes.Add("2160", "Toyota Bank");
            bankCodes.Add("2190", "DnB Nord");
            bankCodes.Add("2480", "Getin Noble Bank");
            bankCodes.Add("2490", "Alior Bank");

            string bankNameResult;
            if (bankCodes.ContainsKey(bankCodeID))
            {
                bankNameResult = (string) bankCodes[bankCodeID];
            }
            else
            {
                bankNameResult = "Nie ma w Polsce banku o takim kodzie";
            }
            return bankNameResult;
            */
        }

        public string GetBankCodeForAccount(string account)// wyciagnac 4 cyfry z nr konta, sprawdzic czy w hashmapie mamy taka wartosc i zwrocic jaki to bank (by nie robic switch case, ani ifow tylko w hashtable) 
        {
            string removeSpace = account.Replace(" ", "");
            string result = removeSpace.Substring(Start, Len);
            return result;
        }
    }
}