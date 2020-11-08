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
    public partial class ScramblewordGame : Form
    {
        string selectedword;
        int minutes, seconds, scores;
        SoundPlayer simpleSound;

        Button[] BtnArray;
        public ScramblewordGame()
        {

            InitializeComponent();

            scores = 0;
        }

        private void ScramblewordGame_Load(object sender, EventArgs e)
        {
            BtnArray = new Button[] { Btn1, Btn2, Btn3, Btn4, Btn5 };
            foreach (var i in BtnArray)
                i.BackColor = Color.Chocolate;

            minutes = 0;
            seconds = 0;

            timer2.Start();

            string path = "Files\\Scrumbledwords.txt";
            WordSelection words = new WordSelection();

            selectedword = words.getWord(path).ToUpper();
            
            char[] selectedwordArray = selectedword.ToArray();

           
            Random ob = new Random();
            int number;
            bool check = false;
            string jumbledword = "";

            while (true)
            {
                check = true;
                for (int i = 0; i < selectedwordArray.Length; i++)
                {
                    if (selectedwordArray[i] != '0')
                        check = false;

                }




                number = ob.Next(0, selectedwordArray.Length);
                if (selectedwordArray[number] != '0')
                {
                    jumbledword += selectedwordArray[number];
                    selectedwordArray[number] = '0';



                }

                if (selectedword.Equals(jumbledword))
                    selectedwordArray = selectedword.ToCharArray();



                else if (check == true)
                    break;

            }


            for (int i = 0; i < BtnArray.Length; i++)
                BtnArray[i].Text = jumbledword[i].ToString();






        }

        private void BtnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackColor == Color.Chocolate)
            {
                try
                {
                    simpleSound = new SoundPlayer("WAVE\\click.wav");
                    simpleSound.Play();

                }
                catch (Exception ob) { MessageBox.Show("Sound file not found"); }
                SetBtnProperties(btn, Color.Indigo, SystemColors.InactiveCaption, 1, Color.MediumSlateBlue);
                Textbox.Text += " " + btn.Text;
            }
            else
            {
                SetBtnProperties(btn, Color.Chocolate, SystemColors.ButtonHighlight, 2, Color.White);
                string text = "";
                int counter = 0;
                string Boxtext = this.Textbox.Text;




                for (int i = 0; i < Boxtext.Length; i++)
                {
                    if ((counter == 1 || !(btn.Text.Equals(Boxtext[i].ToString()))) && Boxtext[i] != ' ')
                        text += " " + this.Textbox.Text[i].ToString();

                    if (btn.Text.Equals(this.Textbox.Text[i].ToString()))
                        counter = 1;
                }

                this.Textbox.Text = text;


            }


        }


        private void SetBtnProperties(Button Btn, Color backcolor, Color Forecolor, int bordersize, Color BorderColor)
        {

            Btn.BackColor = backcolor;
            Btn.FlatAppearance.BorderColor = BorderColor;
            Btn.ForeColor = Forecolor;
            Btn.FlatAppearance.BorderSize = bordersize;

        }





        private void Enter_Click(object sender, EventArgs e)
        {
            string word = "";
            for (int i = 0; i < this.Textbox.Text.Length; i++)
                if (this.Textbox.Text[i] != ' ')
                    word += this.Textbox.Text[i];

            if (word.Equals(selectedword))
            {
                this.Resultlabel.Visible = true;
                scores += 1;
                score.Text = "" + scores;
                this.Resultlabel.Text = "Correct word ";
                timer1.Start();
                this.Textbox.Text = "";
                ScramblewordGame_Load(null, null);

            }

            else
            {
                try
                {
                    simpleSound = new SoundPlayer("WAVE\\wrong.wav");
                    simpleSound.Play();
                }
                catch (Exception ob) { MessageBox.Show("Sound file not found"); } 
                    timer1.Start();
                this.Resultlabel.Visible = true;
                this.Resultlabel.Text = "Wrong word";
            }


        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            this.Resultlabel.Visible = false;
            timer1.Stop();


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (seconds == 60)
            {
                minutes += 01;
                seconds = 00;
            }
           

            time.Text = minutes.ToString("D2") + " : " + seconds.ToString("D2");

            if (minutes == 01)
            {
                timer2.Stop();
                this.Hide();
                ScrambleResult rs = new ScrambleResult(scores, minutes, seconds, selectedword);
                rs.ShowDialog();
                this.Close();
            }

            seconds += 1;

        }

        private void home_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            minutes = 0;
            seconds = 0;
            this.Hide();
            GameHomepage hm = new GameHomepage();
            hm.ShowDialog();
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {

            string text = "", letter = "";
            try
            {
                letter = this.Textbox.Text[this.Textbox.Text.Length - 1].ToString();
                for (int i = 0; i < this.Textbox.Text.Length - 2; i++)
                    text += this.Textbox.Text[i];
            }
            catch (Exception ob)
            {
            }

            this.Textbox.Text = text;

            foreach (var i in BtnArray)
                if (i.Text.Equals(letter))
                    SetBtnProperties(i, Color.Chocolate, SystemColors.ButtonHighlight, 2, Color.White);



        }

        private void cancel_Click(object sender, EventArgs e)
        {
            foreach (var i in BtnArray)
                SetBtnProperties(i, Color.Chocolate, SystemColors.ButtonHighlight, 2, Color.White);

            this.Textbox.Text = "";
        }



    }
}
