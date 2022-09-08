using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;


namespace Lower_Kinder_Garten
{
    public partial class words : Form
    {
        
        public words()
        {
            InitializeComponent();
        }

        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();

        private void words_Load(object sender, EventArgs e)
        {
          
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            pBuilder.AppendText("A   is for Apple Ant  Axe  Arrow Airplane");     //sound_Control
            sSynth.Speak(pBuilder);

           
        }

        private void btnB_Click(object sender, EventArgs e)
        {
           
           

        }

        private void btnc_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btna1_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("a p p l e  apple");
            sSynth.Speak(pBuilder);
        }

        private void btna2_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("a n t   ant ");
            sSynth.Speak(pBuilder);
        }

        private void btna3_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("a i r p l a n e airplane");
            sSynth.Speak(pBuilder);
        }

        private void btna4_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText("a r r o w arrow");
            sSynth.Speak(pBuilder);
        }

        private void btna5_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText(" a x e axe");
            sSynth.Speak(pBuilder);
        }
    }
}
