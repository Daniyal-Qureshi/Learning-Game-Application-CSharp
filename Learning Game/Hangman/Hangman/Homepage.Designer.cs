namespace LearningGame
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.music = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.start.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.start.FlatAppearance.BorderSize = 2;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start.Location = new System.Drawing.Point(244, 236);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(227, 66);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            this.start.MouseLeave += new System.EventHandler(this.start_MouseLeave);
            this.start.MouseHover += new System.EventHandler(this.start_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(244, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 66);
            this.button2.TabIndex = 0;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.start_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.start_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(277, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 92);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hang \n Man";
            // 
            // music
            // 
            this.music.BackColor = System.Drawing.Color.Transparent;
            this.music.BackgroundImage = global::LearningGame.Properties.Resources.volume1;
            this.music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.music.Location = new System.Drawing.Point(608, 12);
            this.music.Name = "music";
            this.music.Size = new System.Drawing.Size(52, 48);
            this.music.TabIndex = 2;
            this.music.Tag = "on";
            this.music.UseVisualStyleBackColor = false;
            this.music.Click += new System.EventHandler(this.music_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.GrayText;
            this.home.BackgroundImage = global::LearningGame.Properties.Resources.download;
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.home.Location = new System.Drawing.Point(26, 25);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(48, 49);
            this.home.TabIndex = 3;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LearningGame.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.home);
            this.Controls.Add(this.music);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button music;
        private System.Windows.Forms.Button home;
    }
}