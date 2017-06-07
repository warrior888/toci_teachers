using System;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;

namespace Toci.Architects.Training.piotex.peselHomework
{
    public class PeselValidatorpiotex : IPeselValidator
    {
        public string Name()
        {
            return "peter";
        }

        public bool IsPeselValid(string pesel)
        {
            long LiczbaPesel = 0;
            long wynik = 0;
            long kolejneLiczbyPesel;

            int[] tablicaLiczb = new[] {9, 7, 3, 1, 9, 7, 4, 1, 9, 7};


            if (pesel.Length == 11 && Int64.TryParse(pesel, out LiczbaPesel) == true)
            {
                for (int i = 0; i < pesel.Length - 1; i++)
                {
                    kolejneLiczbyPesel = Convert.ToInt64(new string(pesel[i], 1));
                    wynik += kolejneLiczbyPesel * tablicaLiczb[i];
                }

                wynik = wynik % 10;
            }

            kolejneLiczbyPesel = Convert.ToInt64(new string(pesel[10], 1));

            bool wyk = wynik == kolejneLiczbyPesel;
            return wyk;
        }
    }
}