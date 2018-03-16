namespace GuessTheNumber
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pScore = new System.Windows.Forms.Panel();
            this.lScorePH = new System.Windows.Forms.Label();
            this.lScore = new System.Windows.Forms.Label();
            this.pButtons = new System.Windows.Forms.Panel();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.pTimer = new System.Windows.Forms.Panel();
            this.pbTimerIcon = new System.Windows.Forms.PictureBox();
            this.lTimer = new System.Windows.Forms.Label();
            this.pNumber = new System.Windows.Forms.Panel();
            this.lNumber = new System.Windows.Forms.Label();
            this.msMenu.SuspendLayout();
            this.pScore.SuspendLayout();
            this.pButtons.SuspendLayout();
            this.pTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimerIcon)).BeginInit();
            this.pNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(232, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "Menu";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pScore
            // 
            this.pScore.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pScore.Controls.Add(this.lScorePH);
            this.pScore.Controls.Add(this.lScore);
            this.pScore.Location = new System.Drawing.Point(12, 76);
            this.pScore.Name = "pScore";
            this.pScore.Size = new System.Drawing.Size(100, 43);
            this.pScore.TabIndex = 1;
            // 
            // lScorePH
            // 
            this.lScorePH.AutoSize = true;
            this.lScorePH.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScorePH.Location = new System.Drawing.Point(72, 13);
            this.lScorePH.Name = "lScorePH";
            this.lScorePH.Size = new System.Drawing.Size(18, 19);
            this.lScorePH.TabIndex = 5;
            this.lScorePH.Text = "0";
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore.Location = new System.Drawing.Point(5, 12);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(56, 19);
            this.lScore.TabIndex = 0;
            this.lScore.Text = "Score:";
            // 
            // pButtons
            // 
            this.pButtons.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pButtons.Controls.Add(this.b8);
            this.pButtons.Controls.Add(this.b7);
            this.pButtons.Controls.Add(this.b6);
            this.pButtons.Controls.Add(this.b5);
            this.pButtons.Controls.Add(this.b4);
            this.pButtons.Controls.Add(this.b3);
            this.pButtons.Controls.Add(this.b2);
            this.pButtons.Controls.Add(this.b1);
            this.pButtons.Controls.Add(this.b9);
            this.pButtons.Location = new System.Drawing.Point(12, 170);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(208, 189);
            this.pButtons.TabIndex = 2;
            // 
            // b8
            // 
            this.b8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b8.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(74, 127);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(58, 52);
            this.b8.TabIndex = 8;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(9, 127);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(58, 52);
            this.b7.TabIndex = 7;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b6
            // 
            this.b6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(139, 69);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(58, 52);
            this.b6.TabIndex = 6;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(74, 69);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(58, 52);
            this.b5.TabIndex = 5;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(9, 69);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(58, 52);
            this.b4.TabIndex = 4;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(139, 11);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(58, 52);
            this.b3.TabIndex = 3;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(74, 11);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(58, 52);
            this.b2.TabIndex = 2;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b1
            // 
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(9, 11);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(58, 52);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b9
            // 
            this.b9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b9.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(139, 127);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(58, 52);
            this.b9.TabIndex = 0;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bStart
            // 
            this.bStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.Location = new System.Drawing.Point(12, 125);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(208, 36);
            this.bStart.TabIndex = 3;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // pTimer
            // 
            this.pTimer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTimer.Controls.Add(this.pbTimerIcon);
            this.pTimer.Controls.Add(this.lTimer);
            this.pTimer.Location = new System.Drawing.Point(120, 76);
            this.pTimer.Name = "pTimer";
            this.pTimer.Size = new System.Drawing.Size(100, 43);
            this.pTimer.TabIndex = 2;
            // 
            // pbTimerIcon
            // 
            this.pbTimerIcon.Image = global::GuessTheNumber.Properties.Resources.icon_timer;
            this.pbTimerIcon.Location = new System.Drawing.Point(7, 8);
            this.pbTimerIcon.Name = "pbTimerIcon";
            this.pbTimerIcon.Size = new System.Drawing.Size(31, 28);
            this.pbTimerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTimerIcon.TabIndex = 4;
            this.pbTimerIcon.TabStop = false;
            // 
            // lTimer
            // 
            this.lTimer.AutoSize = true;
            this.lTimer.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTimer.Location = new System.Drawing.Point(59, 13);
            this.lTimer.Name = "lTimer";
            this.lTimer.Size = new System.Drawing.Size(36, 19);
            this.lTimer.TabIndex = 3;
            this.lTimer.Text = "10.0";
            // 
            // pNumber
            // 
            this.pNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNumber.Controls.Add(this.lNumber);
            this.pNumber.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNumber.Location = new System.Drawing.Point(12, 27);
            this.pNumber.Name = "pNumber";
            this.pNumber.Size = new System.Drawing.Size(208, 43);
            this.pNumber.TabIndex = 4;
            // 
            // lNumber
            // 
            this.lNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lNumber.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumber.Location = new System.Drawing.Point(0, 0);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(206, 41);
            this.lNumber.TabIndex = 6;
            this.lNumber.Text = "0";
            this.lNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 368);
            this.Controls.Add(this.pNumber);
            this.Controls.Add(this.pTimer);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.pScore);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess the Number";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.pScore.ResumeLayout(false);
            this.pScore.PerformLayout();
            this.pButtons.ResumeLayout(false);
            this.pTimer.ResumeLayout(false);
            this.pTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimerIcon)).EndInit();
            this.pNumber.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pScore;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Panel pTimer;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label lTimer;
        private System.Windows.Forms.PictureBox pbTimerIcon;
        private System.Windows.Forms.Label lScorePH;
        private System.Windows.Forms.Panel pNumber;
        private System.Windows.Forms.Label lNumber;
    }
}

