using System;
using System.Linq;
using System.Runtime.InteropServices;
using Toci.Architects.Training.Interfaces.GhostRider.Extending.PeselValidator;

namespace Toci.Architects.Training.anaxagore78.Homework.PeselValidator
{

    public class PeselValidatorAnaxagore78 : IPeselValidator
    {
        public enum Sex { Male, Female }

        public string Name()
        {
            return "anaxagore78";
        }

        /*
         Informacja o płci osoby, której zestaw informacji jest identyfikowany, zawarta jest na 10. (przedostatniej) pozycji numeru PESEL.

    cyfry 0, 2, 4, 6, 8 – oznaczają płeć żeńską
    cyfry 1, 3, 5, 7, 9 – oznaczają płeć męską

             */

        public Sex GetSex(string pesel)
        {
            if (!IsPeselValid(pesel))
            {
                throw new Exception(pesel + " nie jest poprawnym numerem PESEL, brak mozliwosci okreslenia płci");
            }
            int sexDigit = int.Parse(pesel[9].ToString());
            return sexDigit % 2 == 0 ? Sex.Female : Sex.Male;
        }


        public bool IsPeselValid(string pesel)
        {
            if (!(pesel.Trim().Length.Equals(11))) return false;  //sprawdzamy czy dlugosc ciagu to 11 znakow

            char[] chars = pesel.ToCharArray();

            if (!(chars.Where(char.IsDigit).Count().Equals(11))) //sprawdzamy czy ciag zawiera 11 cyfr
            {
                //throw new Exception("Numer pesel musi składać sie z 11 cyfr");
                return false;
            }

            int sum = 0;
            int evenIndx = 0;
            int[] evens = new int[4] { 9, 7, 3, 1 };
            int controlDigit = int.Parse(pesel[10].ToString()); //cyfra kontrolna

            for (int i = 0; i < 10; i++)
            {
                sum += int.Parse(pesel[i].ToString()) * evens[evenIndx++];
                if (evenIndx >= evens.Length) evenIndx = 0;
            }

            return (sum % 10).Equals(controlDigit);
            /*
             Jedenasta cyfra jest cyfrą kontrolną, służącą do wychwytywania przekłamań numeru. Jest ona generowana na podstawie pierwszych dziesięciu cyfr. Aby sprawdzić czy dany numer PESEL jest prawidłowy, należy, zakładając, że litery a-j to kolejne cyfry numeru od lewej, obliczyć wyrażenie:

            9×a + 7×b + 3×c + 1×d + 9×e + 7×f + 3×g + 1×h + 9×i + 7×j

            Jeżeli ostatnia cyfra otrzymanego wyniku nie jest równa cyfrze kontrolnej, to znaczy, że numer zawiera błąd[15].

            Przykład dla numeru PESEL 44051401358:

                9×4 + 7×4 + 3×0 + 1×5 + 9×1 + 7×4 + 3×0 + 1×1 + 9×3 + 7×5 = 169

            Wyznaczamy resztę z dzielenia sumy przez 10:

                169:10 = 16 reszta = 9

            Wynik 9 nie jest równy ostatniej cyfrze numeru PESEL, czyli 8, więc numer jest błędny.
             
             */
        }
    }
}