using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Toci.Training.PiotrK
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybor = 0;
            
            do
            {
                Console.WriteLine("Wybierz numer spotkania, z którego zdania chcesz wykonać:\n1)\n2)");
                wybor = Int32.Parse(Console.ReadLine());
            } while (wybor <= 0 || wybor > 2);
            switch(wybor)
            {
                case 1:
                    cMyArrays.operationsOnArrays();
                    break;
                case 2:
                    cQuizLogic.quiz();
                    cIndexOf.myIndexOf();
                    break;
                default:
                    Console.WriteLine("Nie wiem, co powiedzieć...");
                    break;
            }
        }
    }
}
