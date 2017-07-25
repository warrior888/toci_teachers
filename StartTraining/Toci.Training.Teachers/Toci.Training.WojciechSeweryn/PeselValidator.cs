using System;

namespace Toci.Training.WojciechSeweryn
{
    public class PeselValidator
    {
        //PESEL 91 09 07 02398
        //      YY MM DD


        public bool IsPeselValid(string peselCandidate)
        {
            int result = 0;
            string year = peselCandidate.Substring(0, 2);
            string month = peselCandidate.Substring(2, 2);
            string day = peselCandidate.Substring(4, 2);

            if (peselCandidate.Length != 11) return false;
            int[] peselNumbers = new int[peselCandidate.Length];
            int[] peselChceck = new int[] { 9, 7, 3, 1, 9, 7, 3, 1, 9, 7 };

            for (int i = 0; i < peselCandidate.Length; i++)
            {
                peselNumbers[i] = int.Parse(peselCandidate[i].ToString());
                if (i < peselCandidate.Length - 1)
                {
                    result += peselNumbers[i] * peselChceck[i];
                }
            }
            result = result % 10;
            if (result == peselNumbers[10] && IsPeselDateValid(year, month, day))
            {
                Console.WriteLine("Ten PESEL jest poprawny!");
                Sex(peselNumbers[9]);
                return true;
            }
            else
            {
                Console.WriteLine("Bledny PESEL");
                return false;
            }
        }

        protected bool IsPeselDateValid(string year, string month, string day)
        {
            int intYear = GetYear(int.Parse(year), int.Parse(month));
            int intMonth = GetMonth(int.Parse(month));
            int intDay = int.Parse(day);

            if (ChceckYear(intYear) && CheckMonth(intMonth) && CheckDays(intYear, intMonth, intDay)) return true;
            return false;
        }

        public int? Sex(int peselNumber)
        {
            if (peselNumber % 2 == 0)
            {
                Console.WriteLine("Jestes kobieta");
            }
            else
            {
                Console.WriteLine("Jestes mezczyzna");
            }
            return null;
        }

        //Out of the range did not include the number of PESEL
        public bool ChceckYear(int year)
        {
            if (year > 1800 && year < 2299) return true;
            return false;
        }

        //The correctness of the month
        public bool CheckMonth(int month)
        {
            if (month > 0 && month < 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetYear(int year, int month)
        {
            if (month > 80 && month < 93) return 1800 + year;
            if (month > 0 && month < 13) return 1900 + year;
            if (month > 20 && month < 33) return 2000 + year;
            if (month > 40 && month < 53) return 2100 + year;
            if (month > 60 && month < 73) return 2200 + year;
            return -1;
        }

        public int GetMonth(int month)
        {
            if (month > 80 && month < 93) return month - 80;
            if (month > 0 && month < 13) return month;
            if (month > 20 && month < 33) return month - 20;
            if (month > 40 && month < 53) return month - 40;
            if (month > 60 && month < 73) return month - 60;
            return -1;
        }

        //Is the year a leap year?
        public bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) return true;
            return false;
        }

        //Number of days per month
        public bool CheckDays(int year, int month, int day)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day > 0 && day < 32) return true;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day > 0 && day < 31) return true;
                    break;
                case 2:
                    if ((IsLeapYear(year) && day > 0 && day < 30) &&
                        (!IsLeapYear(year) && day > 0 && day < 29)) return true;
                    break;
            }
            return false;
        }
    }
}