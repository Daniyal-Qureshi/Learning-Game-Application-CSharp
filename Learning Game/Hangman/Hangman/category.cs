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
    public partial class category : Form
    {
        public category()
        {
          
            InitializeComponent();
          
        }

      
    

        private void Content(object sender, EventArgs e)
        {


            
            this.Hide();
            Button b = (Button)sender;
            WordSelection words = new WordSelection();
            string path = "Files\\" + b.Name + ".txt";
   
            string selectedword = words.getWord(path).ToUpper();
            Console.WriteLine("sleected" + selectedword);
            Form frm = new Selection(selectedword);
            frm.ShowDialog();
            this.Close();
        }
    }
}
