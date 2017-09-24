using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookApp
{
    public partial class AddPersonForm : Form
    {
        ButtonsClass bc = new ButtonsClass();
        LableClass lc = new LableClass();
        TextBoxClass tbc = new TextBoxClass();
        // to do speech recognition
        //SpeechRecognitionEngine Sre = new SpeechRecognitionEngine();

        public AddPersonForm()
        {
            InitializeComponent();
            bc.AddButtons(this, "Save", 242, 160);
            lc.AddLablesForScndWindow(this);
            tbc.CreateATextBoxForScndWindow(this);
            // to do speech recognition
            //Sre.SetInputToDefaultAudioDevice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // to do speech recognition
            /*DictationGrammar dg = new DictationGrammar();

            Sre.LoadGrammar(dg);

            Sre.SpeechRecognized += Sre_SpeechRecognized;
            Sre.SpeechDetected += Sre_SpeechDetected;
            Sre.RecognizeAsync(RecognizeMode.Multiple);*/
        }
        // to do speech recognition
        /*private void Sre_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            
        }*/
        // to do speech recognition
        /*private void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            textBox1.Text = e.Result.Text;
        }*/
    }
}
