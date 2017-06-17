using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Liczymy
    {
        public double a = 0.0d;
        public double b = 0.0d;
        public char dzialanie ;

        public double licz()
        {
            if (dzialanie == '+')
                return a + b;
            if (dzialanie == '-')
                return a - b;
            if (dzialanie == '*')
                return a * b;
            if (dzialanie == '/')
                return a / b;
            if (dzialanie == '^')
                return Math.Pow(a, b);//znaku ^ nie można zastosować między dwiema liczbami typu double
            if (dzialanie == '!')
            {
                long s = 1;
                for (int i = 1; i <= a; ++i)
                    s *= i;
                return (double)s;
            }
            else
                return 0;
        }
    }
}
