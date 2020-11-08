using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningGame
{
    public partial class WinnerDatabase : Form
    {
        SoundPlayer simpleSound;
        int score, time;
        public WinnerDatabase(int sc,int t)
        {


            InitializeComponent();
            score = sc;
            time = t;      
            this.scorelabel.Text = ""+score;
            

        
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

        private void back_Click(object sender, EventArgs e)
        {

            this.Hide();
            Homepage hmg = new Homepage();
            hmg.ShowDialog();
            this.Close();

        }

        private void WinnerDatabase_Load(object sender, EventArgs e)
        {

      
            try
            {

                simpleSound = new SoundPlayer("WAVE\\Hangman.wav");
                simpleSound.PlayLooping();
                hangmancontextDataContext context = new hangmancontextDataContext();
                var users = from user in context.Users select user;
                foreach (var user in users)
                {
                    ListViewItem item1 = new ListViewItem(user.Name);
                    item1.SubItems.Add("" + user.Score);
                    item1.SubItems.Add("" + user.Time);
                    item1.SubItems.Add(user.Date);
                    item1.SubItems.Add(user.Location);
                    UsersView.Items.Add(item1);
                }
            }

            catch(Exception ob) { MessageBox.Show("Can't access records rightnow"); }
        }

        private void namebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox b = (TextBox)sender;
            if (b.Text.Length>10&& !char.IsControl(e.KeyChar)) {
                e.Handled = true;

            }


            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {

            try
            {
                User record = new User();
                record.Name = namebox.Text;
                record.Location = locationbox.Text;
                record.Score = score;
                record.Time = time;
                record.Date = DateTime.Now.ToShortDateString();
                hangmancontextDataContext context = new hangmancontextDataContext();
                context.Users.InsertOnSubmit(record);
                context.SubmitChanges();
                context.Dispose();
                UsersView.Items.Clear();
                WinnerDatabase_Load(null, null);
            }
            catch (Exception ob) { MessageBox.Show("Can't insert record rightnow"); }


        }
    }
}
