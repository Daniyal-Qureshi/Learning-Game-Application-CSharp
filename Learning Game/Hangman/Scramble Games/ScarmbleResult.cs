using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningGame
{
    public partial class ScrambleResult : Form
    {
        int scores, minutes, seconds;
        string selectedword;

        public ScrambleResult(int sc, int min, int sec, string word)
        {

            InitializeComponent();
            selectedword = word;
            scores = sc;
            seconds = sec;
            minutes = min;
        }

        private void ScrambleResult_Load(object sender, EventArgs e)
        {
            this.time.Text = minutes + " : " + seconds;
            this.score.Text = "" + scores;
            this.word.Text = selectedword;


        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameHomepage gh = new GameHomepage();
            gh.ShowDialog();
            this.Close();
        }

        private void play_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScramblewordGame sc = new ScramblewordGame();
            sc.ShowDialog();
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Volume = 100;
                synth.Speak(selectedword);
            }
            catch(Exception ob) { MessageBox.Show("Text to speech conversion error"); }

        }
    }
}
