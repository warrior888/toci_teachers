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
           
            Console.WriteLine(" nowa linia po tym writeline\n");
            Console.WriteLine("\n nowa linia przed tym write line ");

            string name = "beatka i bartek";
            int stringLength = name.Length;
            bool truefalse = stringLength == 19;
          
            DateTime date = new DateTime(2017,8,6);
            Console.WriteLine(date);

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("i = " + i + "zaczek dla i w name = " + name[i]);
            }

            Console.WriteLine("\n \n");

            //NSAPISASC FUNKCJE KTORA ODWROCI TEKST:

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine("i = " + i + "zaczek dla i w name = " + name[i]);
                Console.Write(name[i]);
            }

            string reversed = ReverseString(name);
            string reversedTEST = ReverseString("TEXT TESTOWY");
            Console.WriteLine("\n odwrocony " + reversed);
            Console.WriteLine("\n odwrocony " + reversedTEST);
            Console.WriteLine("\n substring " + Substring("beatka", 2, 4));
            Console.WriteLine("\n substring " + Substring("bartlomiej", 1, 3));

           // Console.WriteLine(name.Reverse()); odwraca stringa z automatu 

            if (stringLength >10) //> < >= <= || - lub && - iS
            {
                Console.WriteLine(stringLength);
                Console.ReadLine();
            }
        }

        public static string ReverseString(string candidate)

        {
            string result = "";

            for (int i = candidate.Length -1; i >= 0; i--)
            {
                result = result + candidate[i];
            }
            return result;
        }

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
        //FUNKCJA KTORA PODMIENIA TEKST W TEKSCIE:
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
    }
}

        
       
       
    
    


