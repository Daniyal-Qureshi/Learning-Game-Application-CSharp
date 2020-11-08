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
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hmg = new Homepage();
            hmg.ShowDialog();
            this.Close();

        }

        private void help_Load(object sender, EventArgs e)
        {
            this.richTextBox1.ReadOnly = true;
            try
            {
                this.richTextBox1.LoadFile("Files\\help.txt", RichTextBoxStreamType.PlainText);
            }
            catch(Exception ob) { MessageBox.Show("Give Correct path of file"); }
        }
    }
}
