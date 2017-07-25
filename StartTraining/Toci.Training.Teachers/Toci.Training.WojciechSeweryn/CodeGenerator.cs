using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Toci.Training.WojciechSeweryn
{
    public class CodeGenerator
    {
        public Hashtable BankList { get; set; } // = new Hashtable(); 

        public CodeGenerator() //konstruktor
        {
            BankList = new Hashtable();
            StreamReader str = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "//banki.txt", Encoding.Default); // plik znajduje sie w folderze debug

            //2 opcja: 
            //StreamReader str = new StreamReader(@"D:\Dropbox\szkolenie\blablabla\banki.txt"); podajemy konkretna sciezke

            string line = "";
            string[] split = null;
            while (!str.EndOfStream)
            {
                line = str.ReadLine();
                split = line.Split(new[] { " \t" }, StringSplitOptions.None);
                BankList.Add(split[0], split[1]);
            }
            str.Close();
            /*-----zapis do pliku
            StreamWriter wtr = new StreamWriter("");
            wtr.WriteLine();
            */
        }
    }
}