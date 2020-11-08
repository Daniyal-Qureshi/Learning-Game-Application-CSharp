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
    public partial class Result : Form
    {
        string selectedword;
        int score, time;
        public Result(string sw,string result,int sc,int t)
        {
            InitializeComponent();
            Game.Text = result;
            selectedword = sw;
            word.Text = sw;
            time = t;
            score = sc;
        }

        private void playagain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hmg = new Homepage();
            hmg.ShowDialog();
            this.Close();

        }

        private void volume_Click(object sender, EventArgs e)
        {
            try
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();
                synth.Volume = 100;
                synth.Speak(selectedword);
            }

            catch (Exception ob) { MessageBox.Show("Text to speeh error"); }
        }

        private void viewscore(object sender, EventArgs e)
        {
            this.Hide();
            WinnerDatabase win = new WinnerDatabase(score, time);
            win.ShowDialog();
            this.Close();

        }
    }
}
