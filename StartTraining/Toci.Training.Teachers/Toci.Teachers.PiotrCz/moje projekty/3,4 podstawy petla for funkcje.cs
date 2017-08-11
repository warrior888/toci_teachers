using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace zzliczanieLiterWKandydacie
{
    class Program
    {
        static void Main(string[] args)
        {

           // Console.WriteLine(" nowa linia po tym writeline\n");
           // Console.WriteLine("\n nowa linia przed tym write line ");

            string[] tablicaImion = new string[10];
            tablicaImion[0] = "Adrian";
            tablicaImion[1] = "Arkadiusz";
            tablicaImion[2] = "Marta";
            tablicaImion[3] = "beatka";
            tablicaImion[8] = "bartek";
            //.....
            tablicaImion[9] = "Piotrek";

            //wywolanie do public static int FindIndexInTable
            int index = FindIndexInTable(tablicaImion, "beatka");
            //wywolujemy FindIndexInTable dla tablicaImion oraz tekstu beatka oczekuje, ze dostane 3
            //koniec wywolanie FindIndexInTable
            Console.WriteLine("index = " + index + "\n");

            for (int i = 0; i < tablicaImion.Length; i++)
            {
                //  tablicaImion[i] = "beatka"; ta linijka nadpisuje wsyzstie wiersze w tablicyImion
                Console.WriteLine("imiona z tablicy imion, imie nuemr " + i + " : " + tablicaImion[i]);

            }

            string name = "beatka i bartek";
            int stringLength = name.Length;
            bool truefalse = stringLength == 19;

            DateTime date = new DateTime(2017, 8, 6);
          //  Console.WriteLine(date);

            for (int i = 0; i < name.Length; i++)
            {
             //   Console.WriteLine("i = " + i + "zaczek dla i w name = " + name[i]);
            }

          //  Console.WriteLine("\n \n");

            //NSAPISASC FUNKCJE KTORA ODWROCI TEKST:

            for (int i = name.Length - 1; i >= 0; i--)
            {
              //  Console.WriteLine("i = " + i + "zaczek dla i w name = " + name[i]);
              //  Console.Write(name[i]);
            }

            string reversed = ReverseString(name);
            string reversedTEST = ReverseString("TEXT TESTOWY");
           // Console.WriteLine("\n odwrocony " + reversed);
           // Console.WriteLine("\n odwrocony " + reversedTEST);
           // Console.WriteLine("\n substring " + Substring("beatka", 2, 4));
           // Console.WriteLine("\n substring " + Substring("bartlomiej", 1, 3));

            // Console.WriteLine(name.Reverse()); odwraca stringa z automatu 

            if (stringLength > 10) //> < >= <= || - lub && - iS
            {
               // Console.WriteLine(stringLength);
                Console.ReadLine();
            }
        }
        //FindIndexInTable w tym przypadku ma za zadanie przeszukac 
        //tabliceImion dla stringu beatka FindIndexInTable(tablicaImion, "beatka");
        //oraz podac jego index tutaj bedzoe to 3
        public static int FindIndexInTable(string[] table, string value)
        {
            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] == value) //dla 0 Adrian == beatka, dla 1 Arkadiusz == beatka itd.
                {
                    return i;
                }
            }
            
            return -1;
        }

        public static string ReverseString(string candidate)

            {
                string result = "";

                for (int i = candidate.Length - 1; i >= 0; i--)
                {
                    result = result + candidate[i];
                }
                return result;
            }

            //FUNKCJA KTORA PODMIENIA TEKST W TEKSCIE:
            public static string Substring(string candidate, int start, int length)
            //candidate = szukanie w jakim tekscie? start = od czego zaczynamy
            //length = przez ile miejsc idziemy?
            {
                string fragment = "";
                for (int i = start; i < start + length; i++)
                {
                    fragment += candidate[i]; // skladnie += stosuje sie zeby uproscic
                    // zapis normanie wyglada to tak : fragment = fragment + candidate[i]
                }
                return fragment;
            }

            public static string ReplaceInText(string candidate, string find, string replace)
            {
                //podmienia w stringu beata za at daje atk => beata => beatka
                for (int i = 0; i < candidate.Length; i++)
                {
                    string sub = Substring(candidate, i, find.Length); // przechodzi
                    //przez string beata => be ea at ta i szuka co pomiedmienic
                }
                //return
                return null;
            }
    }//1.500 > 10/na 1dzien >500 + 10 \0 *2%
    //2.500 > 10/na 1dzien >500 + 20 \0 *2%
    //3.500 > 10/na 1dzien >500 + 30 \0 *2%
    //4.500 > 10/na 1dzien >500 + 40 \0 *2%
    //5.500 > 10/na 1dzien >500 + 50 \0 *2%
   //6.550 > 11/na dzien >550 + 11 \0
   //7.550 > 11/na dzien >550 + 21 \0
   //8.550 > 11/na dzien >550 + 31 \0
   //9.550 > 11/na dzien >550 + 41 \0
   //10.550 > 11/na dzien >550 + 51 \0
   //11.550 > 12/na dzien >600 12 \5
   //12.550 > 12/na dzien >600 +22 \5
   //13.550 > 12/na dzien >600 +32 \5
   //14.550 > 12/na dzien >600 +42 \5
   //15.550 > 12/na dzien >600 +52 \5
   //16.550 > 13/na dzien>650 + 13 \10
   //17.550 > 13/na dzien>650 + 23 \10
   //18.550 > 13/na dzien>650 +33 \10
   //19.550 > 13/na dzien>650 + 43 \10
   //20.550 > 13/na dzien>650 + 53 \10
   //21.550 > 14/na dzien>700 + 14 \15
   //22.550 > 14/na dzien>700 + 24 \15
   //23.550 > 14/na dzien>700 + 34 \15
   //24.550 > 14/na dzien>700 + 44 \15
   //25.550 > 14/na dzien>700 + 54 \15
   //26.550 > 15/na dzien>750 + 15 \20
   //27.550 > 15/na dzien>750 + 25 \20
   //28.550 > 15/na dzien>750 + 35 \20
   //29.550 > 15/na dzien>750 + 45 \20
   //30.550 > 15/na dzien>750 + 55 \20
   //31.550 > 16/na dzien>800 + 16 \25
   
   //1.550 > 16/na dzien>850 + 26 \30
   //6.550 > 16/na dzien>900 + 36 \35
   //11.550 > 16/na dzien>950 + 46 \40
   //21.550 > 16/na dzien>1000 + 56 \45
   //26.550 > 16/na dzien>1100 + 17 + 1 = 18   \50
   //31.550 > 16/na dzien>1100\0
 
   //31.550 > 16/na dzien>1200\0
   
    
}


        
       
       
    
    


