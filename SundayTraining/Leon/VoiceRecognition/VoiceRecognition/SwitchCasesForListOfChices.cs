using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoiceRecognition
{
    public class SwitchCasesForListOfChices
    {
        public string CheckTheCase(string needle)
        {
            string result = null;
            switch (needle)
            {
                case "hello":
                    result =  "Hello World!";
                    break;
                case "how are you":
                    result =  "I'm good, thank you!";
                    break;
                /*case "start chrome":
                    Process.Start("chrom", "http://www.google.com");
                    break;
                case "close":
                    Application.Exit();
                    break;*/
            }
            return result;
        }
    }
}
