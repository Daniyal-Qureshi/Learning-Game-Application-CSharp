using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace LearningGame
{
    public partial class Homepage: Form
    {
        SoundPlayer simpleSound;
        public Homepage()
        {
            InitializeComponent();
            try
            {
                simpleSound = new SoundPlayer("WAVE\\Hangman.wav");
                simpleSound.PlayLooping();
            }
            catch(Exception ob) { MessageBox.Show("Sound file missing"); }
        }

      

        private void start_Click(object sender, EventArgs e)
        {
            if (simpleSound != null)
                simpleSound.Stop();


            this.Hide();
            new category().ShowDialog();
            this.Close();





        }

        private void music_Click(object sender, EventArgs e)
        {


            

            string tag = (string)music.Tag;
            if (tag.Equals("off"))
            {
               simpleSound.PlayLooping();
         
                music.Tag = "on";
                music.BackgroundImage = Properties.Resources.volume1;
            }

            else
            {
                music.Tag = "off";
                simpleSound.Stop();
                music.BackgroundImage = Properties.Resources.mute11;
            }
        }

        private void start_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.White;


        }

        private void start_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            b.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (simpleSound != null)
                simpleSound.Stop();


            this.Hide();
            help he = new help();
            he.ShowDialog();
            this.Close();
        }

        private void home_Click(object sender, EventArgs e)
        {
            if (simpleSound != null)
                simpleSound.Stop();

            this.Hide();
            GameHomepage hm = new GameHomepage();
            hm.ShowDialog();
            this.Close();
        }
    }
}
