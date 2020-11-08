namespace LearningGame
{
    partial class GameHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameHomepage));
            this.label1 = new System.Windows.Forms.Label();
            this.scramble = new System.Windows.Forms.Button();
            this.hangman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(342, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Learning Games";
            // 
            // scramble
            // 
            this.scramble.BackgroundImage = global::LearningGame.Properties.Resources.jumbledaa;
            this.scramble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scramble.Location = new System.Drawing.Point(513, 125);
            this.scramble.Name = "scramble";
            this.scramble.Size = new System.Drawing.Size(456, 377);
            this.scramble.TabIndex = 1;
            this.scramble.UseVisualStyleBackColor = true;
            this.scramble.Click += new System.EventHandler(this.scramble_Click);
            // 
            // hangman
            // 
            this.hangman.BackgroundImage = global::LearningGame.Properties.Resources.Hangman_title;
            this.hangman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hangman.Location = new System.Drawing.Point(12, 125);
            this.hangman.Name = "hangman";
            this.hangman.Size = new System.Drawing.Size(476, 377);
            this.hangman.TabIndex = 1;
            this.hangman.UseVisualStyleBackColor = true;
            this.hangman.Click += new System.EventHandler(this.hangman_Click);
            // 
            // GameHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(981, 514);
            this.Controls.Add(this.scramble);
            this.Controls.Add(this.hangman);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameHomepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learning Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hangman;
        private System.Windows.Forms.Button scramble;
    }
}