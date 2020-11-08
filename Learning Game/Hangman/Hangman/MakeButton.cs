using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace LearningGame
{
    public class MakeButton
    {
        public Button[] createButtons(int length,Form frm) {
            
            Button[] btns=new Button[length];
           
            int x = 250;
            int y=449;
            if (length <= 6)
                x = 350;
            for (int i = 0; i < length; i++)
            {
                if (length >8&&i==8)
                {
                    x = 250;
                    y += 80;
                
                }

                btns[i] = new Button();
                btns[i].BackColor = System.Drawing.SystemColors.ButtonHighlight;
                btns[i].FlatAppearance.BorderColor = System.Drawing.Color.Black;
                btns[i].FlatAppearance.BorderSize = 2;
                btns[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btns[i].Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btns[i].ForeColor = System.Drawing.Color.Black;
                btns[i].Location = new System.Drawing.Point(x, y);
                btns[i].Size = new System.Drawing.Size(50, 39);
                btns[i].UseVisualStyleBackColor = false;
                frm.Controls.Add(btns[i]);
                x += 56;
            
            }



            return btns;

        }
    }
}
