namespace GuessTheNumber.forms
{
    partial class fSettings
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
            this.gbTimer = new System.Windows.Forms.GroupBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.lFreezeTimer = new System.Windows.Forms.Label();
            this.lTimerInt = new System.Windows.Forms.Label();
            this.nudTimerInt = new System.Windows.Forms.NumericUpDown();
            this.bSave = new System.Windows.Forms.Button();
            this.bDefault = new System.Windows.Forms.Button();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.nudStart = new System.Windows.Forms.NumericUpDown();
            this.lStart = new System.Windows.Forms.Label();
            this.gbScore = new System.Windows.Forms.GroupBox();
            this.nudScoreInt = new System.Windows.Forms.NumericUpDown();
            this.cbReset = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerInt)).BeginInit();
            this.gbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            this.gbScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreInt)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTimer
            // 
            this.gbTimer.Controls.Add(this.rbNo);
            this.gbTimer.Controls.Add(this.rbYes);
            this.gbTimer.Controls.Add(this.lFreezeTimer);
            this.gbTimer.Controls.Add(this.lTimerInt);
            this.gbTimer.Controls.Add(this.nudTimerInt);
            this.gbTimer.Location = new System.Drawing.Point(12, 9);
            this.gbTimer.Name = "gbTimer";
            this.gbTimer.Size = new System.Drawing.Size(213, 98);
            this.gbTimer.TabIndex = 0;
            this.gbTimer.TabStop = false;
            this.gbTimer.Text = "Timer settings";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Location = new System.Drawing.Point(164, 63);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 4;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(119, 63);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(43, 17);
            this.rbYes.TabIndex = 3;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // lFreezeTimer
            // 
            this.lFreezeTimer.AutoSize = true;
            this.lFreezeTimer.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFreezeTimer.Location = new System.Drawing.Point(8, 64);
            this.lFreezeTimer.Name = "lFreezeTimer";
            this.lFreezeTimer.Size = new System.Drawing.Size(81, 16);
            this.lFreezeTimer.TabIndex = 2;
            this.lFreezeTimer.Text = "Freeze timer";
            // 
            // lTimerInt
            // 
            this.lTimerInt.AutoSize = true;
            this.lTimerInt.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTimerInt.Location = new System.Drawing.Point(8, 23);
            this.lTimerInt.Name = "lTimerInt";
            this.lTimerInt.Size = new System.Drawing.Size(88, 16);
            this.lTimerInt.TabIndex = 1;
            this.lTimerInt.Text = "Timer interval";
            // 
            // nudTimerInt
            // 
            this.nudTimerInt.DecimalPlaces = 1;
            this.nudTimerInt.Location = new System.Drawing.Point(119, 21);
            this.nudTimerInt.Maximum = new decimal(new int[] {
            590,
            0,
            0,
            65536});
            this.nudTimerInt.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudTimerInt.Name = "nudTimerInt";
            this.nudTimerInt.Size = new System.Drawing.Size(77, 20);
            this.nudTimerInt.TabIndex = 0;
            this.nudTimerInt.Value = new decimal(new int[] {
            100,
            0,
            0,
            65536});
            // 
            // bSave
            // 
            this.bSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.Location = new System.Drawing.Point(12, 276);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(102, 33);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bDefault
            // 
            this.bDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDefault.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDefault.Location = new System.Drawing.Point(123, 276);
            this.bDefault.Name = "bDefault";
            this.bDefault.Size = new System.Drawing.Size(102, 33);
            this.bDefault.TabIndex = 2;
            this.bDefault.Text = "Default";
            this.bDefault.UseVisualStyleBackColor = true;
            this.bDefault.Click += new System.EventHandler(this.bDefault_Click);
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.nudStart);
            this.gbInput.Controls.Add(this.lStart);
            this.gbInput.Location = new System.Drawing.Point(12, 113);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(213, 56);
            this.gbInput.TabIndex = 5;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            // 
            // nudStart
            // 
            this.nudStart.Location = new System.Drawing.Point(126, 22);
            this.nudStart.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(77, 20);
            this.nudStart.TabIndex = 5;
            this.nudStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lStart
            // 
            this.lStart.AutoSize = true;
            this.lStart.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStart.Location = new System.Drawing.Point(8, 23);
            this.lStart.Name = "lStart";
            this.lStart.Size = new System.Drawing.Size(107, 16);
            this.lStart.TabIndex = 2;
            this.lStart.Text = "Minimum number";
            // 
            // gbScore
            // 
            this.gbScore.Controls.Add(this.nudScoreInt);
            this.gbScore.Controls.Add(this.cbReset);
            this.gbScore.Controls.Add(this.label1);
            this.gbScore.Location = new System.Drawing.Point(12, 175);
            this.gbScore.Name = "gbScore";
            this.gbScore.Size = new System.Drawing.Size(213, 94);
            this.gbScore.TabIndex = 6;
            this.gbScore.TabStop = false;
            this.gbScore.Text = "Score";
            // 
            // nudScoreInt
            // 
            this.nudScoreInt.Location = new System.Drawing.Point(126, 22);
            this.nudScoreInt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScoreInt.Name = "nudScoreInt";
            this.nudScoreInt.Size = new System.Drawing.Size(77, 20);
            this.nudScoreInt.TabIndex = 5;
            this.nudScoreInt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbReset
            // 
            this.cbReset.AutoSize = true;
            this.cbReset.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReset.Location = new System.Drawing.Point(11, 59);
            this.cbReset.Name = "cbReset";
            this.cbReset.Size = new System.Drawing.Size(93, 20);
            this.cbReset.TabIndex = 5;
            this.cbReset.Text = "Reset score";
            this.cbReset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Score interval";
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 318);
            this.Controls.Add(this.gbScore);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.bDefault);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.gbTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.gbTimer.ResumeLayout(false);
            this.gbTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimerInt)).EndInit();
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            this.gbScore.ResumeLayout(false);
            this.gbScore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreInt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTimer;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bDefault;
        private System.Windows.Forms.Label lTimerInt;
        private System.Windows.Forms.NumericUpDown nudTimerInt;
        private System.Windows.Forms.Label lFreezeTimer;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Label lStart;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.GroupBox gbScore;
        private System.Windows.Forms.NumericUpDown nudScoreInt;
        private System.Windows.Forms.CheckBox cbReset;
        private System.Windows.Forms.Label label1;
    }
}