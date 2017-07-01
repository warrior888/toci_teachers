using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        string subs = "hello world again ;-)";

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.subs);
            Console.ReadKey();
        }
    }
}
