using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zad.1\n Wczytaj tekst do tablicy i go wyświetl.");
            string[] text_consol = new string[10];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Podaj tekst: ");
                text_consol[i] = Console.ReadLine();
            }
            Console.WriteLine("\nDziękuję za tekst:)\n");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(text_consol[i]);
            }

            //Console.ReadLine();
            Console.WriteLine("\nZad.2\n Wczytaj liczby do tablicy i wyświetl największą.");
            // Console.WriteLine (number_max());

            // Public void number_max()
            //{
            int[] number_tab = new int[3];
                string text_consoll;
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Podaj dowolną całkowitą liczbę: ");
                    text_consoll = Console.ReadLine();
                    number_tab[i] = int.Parse(text_consoll);
                }

            int j = 0;
            int max_liczba = 0;
            foreach (int number_consoll in number_tab)
                {
                
                //Console.WriteLine(number_consoll);
                    if (number_tab[j] > max_liczba)
                    {
                        max_liczba = number_tab[j];
                        //Console.WriteLine("Max liczba to: " + max_liczba);
                }
                    j = j + 1;  
                }
            Console.WriteLine("\nMax liczba to: " + max_liczba);
            //return max_liczba;
            //}

            Console.ReadLine();
            Console.WriteLine("\nZad.3\n Wczytaj liczby do tablicy i wyświetl najmniejszą:");
            int[] number_tab_z2 = new int[3];
            string text_con;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Podaj dowolną całkowitą liczbę: ");
                text_con = Console.ReadLine();
                number_tab_z2[i] = int.Parse(text_con);
            }

            int k = 0;
            int min_liczba = 999;
            foreach (int nr_consoll in number_tab_z2)
            {

                //Console.WriteLine(number_consoll);
                if (number_tab_z2[k] < min_liczba)
                {
                    min_liczba = number_tab_z2[k];
                    //Console.WriteLine("Max liczba to: " + max_liczba);
                }
                k = k + 1;
            }
            Console.WriteLine("\nMin liczba to: " + min_liczba);
            Console.ReadLine();
            Console.WriteLine("\nZad.4\n Wczytaj liczby do tablicy i wyświetl ich sumę:");
            double[] number_tab_z4 = new double[3];
            string text_cons;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Podaj dowolną całkowitą liczbę: ");
                text_cons = Console.ReadLine();
                number_tab_z4[i] = double.Parse(text_cons);
            }

            int l = 0;
            double suma = 0;
            foreach (int nr_consoll in number_tab_z4)
            {
                //Console.WriteLine(number_consoll);
                    suma = suma + number_tab_z4[l];
                l = l + 1;
            }
            Console.WriteLine("\nSuma liczb to: " + suma);
            Console.ReadLine();
            
            Console.WriteLine("\nZad.5\n Wczytaj liczby do tablicy i wyświetl tą która się powtórzyła:");
            int[] number_tab_z5 = new int[3];
            string text_c;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Podaj dowolną całkowitą liczbę: ");
                text_c = Console.ReadLine();
                number_tab_z5[i] = int.Parse(text_c);
            }
            ////////////////////////////////////////////////////////////////////////
             int n = 0;
             int liczba = 0;
             int nrr = 0;
             foreach (int nr_consoll in number_tab_z5)
             {
                 liczba = nr_consoll;

                 //Console.WriteLine(liczba);

                 foreach (int nr in number_tab_z5)
                 {
                     nrr = nr;
                     //Console.WriteLine(nr);
                     if (liczba == nrr)
                     {
                         // Console.WriteLine(n);
                         Console.WriteLine("\nPowtórzona liczba to: " + liczba + "  "+ nrr);
                     }
                 }
                     //for (n = 1; n < number_tab_z5.Length; n++)
                     //{
                    // Console.WriteLine(number_tab_z5[n]);
                     //if (liczba == number_tab_z5[n])
                     //{
                         // Console.WriteLine(n);
                        // Console.WriteLine("\nPowtórzona liczba to: " + liczba);
                    // }
                 //}
             }

             Console.ReadLine();
        }
    }
}
