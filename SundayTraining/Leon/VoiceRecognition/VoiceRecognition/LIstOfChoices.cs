using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace VoiceRecognition
{
    public class LIstOfChoices
    {
        public Choices clist = new Choices();

        public void CreateAList()
        {
            clist.Add(new string[] { "hello", "how are you", "start chrome", "close" });
        }
    }
}
