using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petlaFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Petla FOR
            //string[] pamiec = new string[5];

            //for (int i = 0; i < pamiec.Length; i++)
            //{
            //    Console.WriteLine("Podaj " + i + " informację: ");
            //    pamiec[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Dziękujemy, to już wszystkie dane których potrzebowaliśmy!");
            //Console.ReadKey();

            ////Translator Kodu ASCII

            //Console.WriteLine("Podaj coś człowieku");
            //string tekst = Console.ReadLine();

            //foreach (char znak in tekst)
            //{
            //    int i = znak;

            //    if (znak < 97)
            //    {
            //        Przelicz(i);
            //        char c = Convert.ToChar(Przelicz(i));

            //        Console.WriteLine(c);
            //    }
            //    if (znak > 97)
            //    {
            //        Przelicz2(i);
            //        char a = Convert.ToChar(Przelicz2(i));
            //        Console.WriteLine(a);
            //    }

            //    Console.ReadKey();
            //}




            ////Zadanie domowe tydzień 1


            //int[] tablica = new int[] { 10, 11, 11, 42, 12, 15, 12, 51, 12, 25, 43, 13, 251, 45, 3, 2, 234, 32, 1, 2 };
            //int max = int.MinValue;
            //int min = int.MaxValue;
            //int suma = 0;
            //int powtorzenie = 0;
            //for (int i = 0; i < tablica.Length; i++)
            //{

            //    if (max < tablica[i])
            //    {
            //        max = tablica[i];
            //    }
            //    if (max > tablica[i])
            //    {
            //        min = tablica[i];
            //    }
            //    suma = tablica[i] + suma;

            //    if (tablica[i] == 11)
            //    {
            //        powtorzenie++;
            //    }

            //}
            //Console.WriteLine("Maksymalna wartość to: " + max);
            //Console.WriteLine("Minimalna wartość to:" + min);
            //Console.WriteLine("Suma wszyskich elementów wynosi: " + suma);
            //Console.WriteLine("Powtórzeń liczby 11: " + powtorzenie);
            //Console.ReadKey();


            //homework week2
            //wyciaganie tekstu ze stringu

            //string[] tekst = new string[] { "Patryk czasem programuje" };
            //string[] slowo = new string[] {"czasem"};
            ////int dlugosc = 12;

            //for (int i = 0; i < tekst.Length; i++)
            //{
            //    for (int j = 0; j < tekst.Length; j++)
            //    {
            //        if (i != j)
            //        {
            //            if (slowo.Length > j)
            //               // if (slowo[i] = tekst[j])
            //                {

            //                }
            //        }
            //    }
            //}

            // Quizlogiczny
            
            
            string[] pytania =
            {
                "1. Pełna nazwa JWK to: ",
                "2. Jakich karabinków uzywają operatorzy JWK w czasie operacji? ",
                "3. Jak nazywał się Zespół Bojowy wystawiony przez JWK w Afganistanie? ",
                "4. W którym roku została założona Jednostka? ",
                "5. Numer rozpoznawczy JWK to: ",
            };
            string[][] odpowiedz = new string[pytania.Length][];



            int index = 0;

            odpowiedz[index++] = new string[] {"a) Jesteśmy Wielkimi Komandosami", "b) Jedność Wierność Koledzy!", "c) Jednostka Wojskowa Komandosów", };
            odpowiedz[index++] = new string[] { "a) AK-47", "b) AK-74", "c) MP-5", "d) HK-416" };
            odpowiedz[index++] = new string[] { "a) Task Force 50", "b) Najlepsi z najlepszych", "c) Task Force 16", "d) Zespół nr1" };
            odpowiedz[index++] = new string[] { "a) 2011", "b) 2001", "c) 1978", "d) 1998" };
            odpowiedz[index++] = new string[] { "a) 4506", "b) 4101", "c) 3708", "d) 1708"};

            char odp;
            int punkty = 0;
            char[] poprawnaodp = {'c', 'd', 'a', 'a', 'b'};
            char[] poprawnaodp2 = {'C', 'D', 'A', 'A', 'B'};

            Console.WriteLine("Witamy w teście wiedzy o JWK!");
            Console.WriteLine("Aby rozpocząć naciśnij dowolny klawisz!");
            Console.ReadKey();
            for (int i = 0; i < pytania.Length; i++)
            {
                Console.WriteLine(pytania[i]);


                for (int j = 0; j < odpowiedz[i].Length; j++)
                {
                    Console.WriteLine(odpowiedz[i][j]);
                }

                odp = Console.ReadKey(true).KeyChar;


                if (odp == poprawnaodp[i])
                {
                    punkty++;
                }
                if (odp == poprawnaodp2[i])
                {
                    punkty++;
                }

                
                
                }

            Console.WriteLine("Ilość odpowiedzi poprawnych: " + punkty + " złych: " + (pytania.Length - punkty) + ".");
            Console.WriteLine("Dziękujemy za udział w Quizie!");
            Console.WriteLine("Kliknij dowolny klawisz, aby zakończyć!");

            Console.ReadKey();



            //private static int Przelicz(int i)
            //{
            //    return (i + 32);

            //}
            //private static int Przelicz2(int i)
            //{
            //    return (i - 32);
            //}



        }
        }
    }

        




