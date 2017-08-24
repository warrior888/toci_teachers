using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace sudoku
{
    public class ReadyTab
    {
        public static int licz;

        public static char[] readTab()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Piotr\Desktop\sudoku\sudoku\sudoku\sudokuTab.txt"); 
            
                                                                        //todo więcej tablic , losowanie tablic

            return sr.ReadToEnd().Substring(2).ToArray();
        }

        public static string getNumber()
        {
            var tab = readTab();
            Random rand = new Random();
            if (licz%6 ==0 || licz % 7 ==0)                         //todo poziomy trudnosci => zalezy od ustawienia
            {
                string liczba = tab[licz].ToString();
                return liczba;
            }
            return " ";
        }
    }
}