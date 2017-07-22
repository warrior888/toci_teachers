using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Training.PiotrK
{
    class cIndexOf
    {
        public static void myIndexOf()
        {
            Console.WriteLine("\nZnajdź index w tablicy\n");
            string ciagDoPrzeszukania = "Lorem ipsum";
            string ciagSzukany;
            Console.WriteLine("Ciąg przeszukiwany: {0}", ciagDoPrzeszukania);
            Console.WriteLine("Wprowadź tekst do wyszukania");
            ciagSzukany = Console.ReadLine();

            bool czyZnalazl = false;

            int ciagDoPrzeszukaniaLength = ciagDoPrzeszukania.Length;
            int ciagSzukanyLength = ciagSzukany.Length;

            for (int i = 0; i < ciagDoPrzeszukaniaLength; i++)
            {
                if (ciagDoPrzeszukania[i] == ciagSzukany[0])
                {
                    string porStr = "";
                    for (int j = 0; j < ciagSzukanyLength; j++)
                    {
                        if (ciagSzukanyLength == 1)
                            porStr += ciagDoPrzeszukania[i];
                        else
                            porStr += ciagDoPrzeszukania[i + j];
                    }
                    if (porStr == ciagSzukany)
                    {
                        Console.WriteLine("Ciąg znaleziony na pozycji {0}, długość: {1}", i, ciagSzukanyLength);
                        czyZnalazl = true;
                    }
                }
            }
            if (!czyZnalazl)
            {
                Console.WriteLine("Ciąg nie został znaeziony");
            }

            Console.ReadKey();
        }
    }
}
