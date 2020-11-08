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
    public partial class Selection : Form
    {
        string selectedword;
        Button[] btnlist;
        SoundPlayer simpleSound;
        int counter,score, currentimage;
        int sec;
        int min;
       
        public Selection(string sw)
        {


            InitializeComponent();
            timer2.Start();
            currentimage = 0;
            counter = 0;
            score = 0;
            sec = 0;
            min = 0;
            
            selectedword = sw;
            btnlist = new MakeButton().createButtons(selectedword.Length, this);
            
        }


        private void Alphabet(object sender, EventArgs e)
        {
            try
            {
                simpleSound = new SoundPlayer("WAVE\\click.wav");
                simpleSound.Play();
            }
            catch (Exception ea) { MessageBox.Show("Sound file missing"); }
            Button b = (Button)sender;
            Boolean check = true;
            this.Controls.Remove(b);


            for (int i = 0; i < selectedword.Length; i++)
            {
                if (selectedword[i].ToString().Equals(b.Text))
                {
                    score += 100;
                    btnlist[i].Text = b.Text;
                    check = false;
                }


            }


            Boolean flag = true;
           
                for (int i = 0; i < btnlist.Length; i++)
                {
                    if (btnlist[i].Text.Length == 0&&selectedword[i].ToString().Trim().Length!=0)
                    {
                    flag = false;
                    break;
                    }

                }

            if (flag)
            {

               Result rs = new Result(selectedword, "YOU WON", score, sec);
                rs.ShowDialog();

            }

                if (check)
                {
                try
                {
                    simpleSound = new SoundPlayer("WAVE\\wrong.wav");
                    simpleSound.Play();

                }
                catch (Exception ea) { MessageBox.Show("Sound file missing"); }
                string add = "Hangman\\" + currentimage + ".jpg";
                    this.pictureBox1.ImageLocation = add;
                    currentimage++;
                    score -= 10;
                }
                this.scorelabel.Text = "" + score;

                if (currentimage == 11)
                {
                    for (int i = 0; i < btnlist.Length; i++)
                    {
                        if (btnlist[i].Text.Length == 0)
                        {
                            btnlist[i].ForeColor = Color.Red;
                            btnlist[i].Text = selectedword[i].ToString();


                        }



                    }

                    
                    this.timer1.Start();          
                   
                }
          
        }

        private void previous(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hm = new Homepage();
            hm.ShowDialog();


            this.Close();
        }

     
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (counter >= 2)
            {
                this.Hide();
                this.timer1.Stop();
               Result rs = new Result( selectedword, "FAILED",score,sec);
                rs.ShowDialog();
                this.Close();
            }
            counter++;
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sec == 60){
                min+=1;
                sec=0;
            }
            

            if(min>=1)
            timelabel.Text = ""+min+"m  " + sec + "s";
            
            else
                timelabel.Text = ""+ sec + "s";
          

            sec++;
        }

       

    }

}