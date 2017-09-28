using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;

namespace VoiceRecognition
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        //Choices cList = new Choices(/*new string[] { "hello", "how are you", "start chrome", "close" }*/);

        // test
        LIstOfChoices loc = new LIstOfChoices();
        SwitchCasesForListOfChices blabla = new SwitchCasesForListOfChices();

        public Form1()
        {
            InitializeComponent();
            btnStop.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /*private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            loc.CreateAList();
            //cList.Add(new string[] { "hello", "how are you", "start chrome", "close"});
            Grammar gr = new Grammar( new GrammarBuilder(loc.clist));

            try
            {
                sre.RequestRecognizerUpdate();
                sre.LoadGrammar(gr);
                sre.SpeechRecognized += Sre_SpeechRecognized;
                sre.SetInputToDefaultAudioDevice();
                sre.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "something went wrong");
            }
        }*/

        private void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            ss.SpeakAsync(blabla.CheckTheCase(e.Result.Text.ToString()));
            /*switch(e.Result.Text.ToString())
            {
                case "hello":
                    ss.SpeakAsync("Hello World!");
                    break;
                case "how are you":
                    ss.SpeakAsync("I'm good, thank you!");
                    break;
                case "start chrome":
                    Process.Start("chrom", "http://www.google.com");
                    break;
                case "close":
                    Application.Exit();
                    break;
            }*/
            textBoxForContents.Text += e.Result.Text.ToString() + Environment.NewLine;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            sre.RecognizeAsyncStop();  
        }
    }
}
