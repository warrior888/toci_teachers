using System;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;

namespace Toci.Architects.Training.Irzica.Homework.PeselValidator
{
    public class PeselValidatorIza : IPeselValidator
    {
        public string Name()
        {
            return "Iza";
        }

        public bool IsPeselValid(string pesel)
        {
            if (pesel == null) throw new ArgumentNullException("pesel");

            if (pesel.Length != 11)
            {
                return false;
            }

            int[] checkTab =
            {
                1, 3, 7, 9, 1, 3, 7, 9, 1, 3
            };
            var checkSum = 0;
            for (var i = 0; i < pesel.Length-1; i++)
            {
                checkSum += Int32.Parse(pesel.Substring(i, i + 1))*checkTab[i];
            }
            var controlNumber = Int32.Parse(pesel.Substring(10, 11));
            checkSum %= 10;
            checkSum = 10 - checkSum;
            checkSum %= 10;

            return (checkSum == controlNumber);
        }
    }
}