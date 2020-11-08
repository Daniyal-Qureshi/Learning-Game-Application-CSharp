using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LearningGame
{
    public partial class GameHomepage : Form
    {
        public GameHomepage()
        {
            InitializeComponent();
        }

        private void hangman_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hm = new Homepage();
            hm.ShowDialog();
            this.Close();


           

        }

        private void scramble_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScramblewordGame sc = new ScramblewordGame();
            sc.ShowDialog();
            this.Close();


        }
    }
}
