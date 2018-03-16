using System;
using System.Windows.Forms;
using System.Collections.Generic;
using GuessTheNumber.forms;
using GuessTheNumber.classes;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        public static Label scoreLabel, timerLabel, lNum;
        public static Button startBtn;
        public static List<Button> buttons;
        public static Timer timer;

        // Form ---------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();

            lNum = this.lNumber;
            scoreLabel = this.lScorePH;
            timerLabel = this.lTimer;
            timer = this.updateTimer;
            startBtn = this.bStart;
            buttons = new List<Button>();
            buttons.Add(b1);
            buttons.Add(b2);
            buttons.Add(b3);
            buttons.Add(b4);
            buttons.Add(b5);
            buttons.Add(b6);
            buttons.Add(b7);
            buttons.Add(b8);
            buttons.Add(b9);
        }


        // Button -------------------------------------------------------------------
        private void bStart_Click(object sender, EventArgs e)
        {
            if (Config.gameStarted == true)
                Config.StopGame();
            else
                Config.StartGame();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Config.checkInput(b1, int.Parse(b1.Text));
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Config.checkInput(b2, int.Parse(b2.Text));
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Config.checkInput(b3, int.Parse(b3.Text));
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Config.checkInput(b4, int.Parse(b4.Text));
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Config.checkInput(b5, int.Parse(b5.Text));
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Config.checkInput(b6, int.Parse(b6.Text));
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Config.checkInput(b7, int.Parse(b7.Text));
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Config.checkInput(b8, int.Parse(b8.Text));
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Config.checkInput(b9, int.Parse(b9.Text));
        }


        // Timer --------------------------------------------------------------------
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (Config.timerFreeze == true && (Config.timerVal == 0.0))
                Config.StopGame();
            else if (Config.timerFreeze == false && (Config.timerVal == 0.0))
            {
                Config.StopGame();
                Config.StartGame();
            }
            else
                this.lTimer.Text = ((Config.timerVal -= 100) / 1000).ToString("0.0");
        }


        // Menu Strip ---------------------------------------------------------------
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A simple game called “Guess the number” that sets a hidden random number, and requires the player to guess it, upon inputting the correct number, player's gain score.\nCreated on 3/15/2018", "Guess the number", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSettings form = new fSettings();
            form.ShowDialog();

            if(Config.gameStarted == true)
                Config.StopGame();
        }
    }
}
