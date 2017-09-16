using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Teachers.Checkmate.Interfaces;

namespace Toci.Teachers.Checkmate
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph gr; 

            for (int i = 0; i < 100; i++)
            {
               gr = new Graph();
                gr.Name = "GR" + i;

                gr.AddNeighbour(gr);
            }

            


            Dictionary<string, string> TociGangstas = new Dictionary<string, string>
            {
                { "GR", "Audi r8" },
                { "WS", "Porsche panamera" },
            };

            int ja = 1;
            int max = 8;

            Dictionary<int, Func<int, int, bool> > mapka = new Dictionary<int, Func<int, int, bool>>
            {
                //{ ja, (1,1) => {return true }},
            };

            mapka.Add(ja, (i1, i2) => i1 > i2);

            //nt i = 8;

        }
    }
}
