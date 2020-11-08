namespace LearningGame
{
    partial class Result
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Button();
            this.word = new System.Windows.Forms.Label();
            this.Game = new System.Windows.Forms.Label();
            this.viewscorebtn = new System.Windows.Forms.Button();
            this.playagain = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.volume);
            this.panel2.Controls.Add(this.word);
            this.panel2.Controls.Add(this.Game);
            this.panel2.Controls.Add(this.viewscorebtn);
            this.panel2.Controls.Add(this.playagain);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 391);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Answer was...";
            // 
            // volume
            // 
            this.volume.BackgroundImage = global::LearningGame.Properties.Resources.volume1;
            this.volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volume.Location = new System.Drawing.Point(528, 291);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(39, 38);
            this.volume.TabIndex = 3;
            this.volume.UseVisualStyleBackColor = true;
            this.volume.Click += new System.EventHandler(this.volume_Click);
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word.Location = new System.Drawing.Point(156, 289);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(100, 40);
            this.word.TabIndex = 2;
            this.word.Text = "label1";
            // 
            // Game
            // 
            this.Game.AutoSize = true;
            this.Game.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game.Location = new System.Drawing.Point(196, 38);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(137, 67);
            this.Game.TabIndex = 0;
            this.Game.Text = "label";
            // 
            // viewscorebtn
            // 
            this.viewscorebtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.viewscorebtn.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewscorebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewscorebtn.Location = new System.Drawing.Point(340, 133);
            this.viewscorebtn.Name = "viewscorebtn";
            this.viewscorebtn.Size = new System.Drawing.Size(174, 57);
            this.viewscorebtn.TabIndex = 1;
            this.viewscorebtn.Text = "View Score";
            this.viewscorebtn.UseVisualStyleBackColor = false;
            this.viewscorebtn.Click += new System.EventHandler(this.viewscore);
            // 
            // playagain
            // 
            this.playagain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playagain.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playagain.Location = new System.Drawing.Point(130, 133);
            this.playagain.Name = "playagain";
            this.playagain.Size = new System.Drawing.Size(174, 57);
            this.playagain.TabIndex = 1;
            this.playagain.Text = "PLAY AGAIN";
            this.playagain.UseVisualStyleBackColor = false;
            this.playagain.Click += new System.EventHandler(this.playagain_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 397);
            this.panel1.TabIndex = 1;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(655, 402);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Game;
        private System.Windows.Forms.Button playagain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.Button volume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewscorebtn;

    }
}