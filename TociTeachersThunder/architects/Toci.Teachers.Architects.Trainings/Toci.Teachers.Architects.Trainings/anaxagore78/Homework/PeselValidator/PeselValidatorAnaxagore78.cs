using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;

namespace Toci.Architects.Training.anaxagore78.Homework.PeselValidator
{
    public class PeselValidatorAnaxagore78 : IPeselValidator
    {
        public string Name()
        {
            return "anaxagore78";
        }
        public bool IsPeselValid(string pesel)
        {
            if (!(pesel.Trim().Length.Equals(11))) return false;  //sprawdzamy czy dlugosc ciagu to 11 znakow
            char[] chars = pesel.ToCharArray();
            if (!(chars.Where(char.IsDigit).Count().Equals(11))) //sprawdzamy czy ciag zawiera 11 cyfr
            {
                return false; //throw new Exception("Numer pesel musi składać sie z 11 cyfr");
            }
            int controlDigit = int.Parse(pesel[10].ToString());
            int controlSum = GetControlSum(pesel);
            return (controlSum % 10).Equals(controlDigit);
        }

        private static int GetControlSum(string pesel)
        {
            int sum = 0;
            List<int> weights = new List<int> { 9, 7, 3, 1 };
            for (int i = 0; i < 10; i++)
            {
                sum += int.Parse(pesel[i].ToString()) * weights[i % 4];
            }
            return sum;
        }
    }
}