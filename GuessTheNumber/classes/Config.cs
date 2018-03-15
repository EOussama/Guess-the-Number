using System;
using System.Windows.Forms;
using System.Drawing;

namespace GuessTheNumber.classes
{
    public static class Config
    {
        public static bool gameStarted = false;
        private static int number = 0;

        public static bool scoreReset = false;
        public static int scoreInt = 1;
        private static int score = 0;

        public static bool timerFreeze = false;
        public static float timerInt = 10.0F;
        public static float timerVal = timerInt * 1000;

        public static int minVal = 1;

        public static void StartGame()
        {
            gameStarted = true;

            GenerateNumber();
            Form1.startBtn.Text = "Stop";
            Form1.timer.Start();
        }

        public static void StopGame()
        {
            gameStarted = false;

            Form1.startBtn.Text = "Start";
            Form1.timer.Stop();
            timerVal = timerInt * 1000;
        }

        public static void GenerateNumber()
        {
            Random rand = new Random();
            number = rand.Next(minVal, minVal + 9);
        }

        public static void updateButtons()
        {
            for (int i = 0; i < 9; i++)
                Form1.buttons[i].Text = (minVal + i).ToString();
        }

        public static void checkInput(Button btn, int input)
        {
            if (input == number && gameStarted == true)
            {
                Form1.scoreLabel.Text = (score += scoreInt).ToString();
                btn.BackColor = Color.Green;

                if (timerFreeze == true)
                    StopGame();
                else
                {
                    StopGame();
                    StartGame();
                }
            }

            else if (input != number && scoreReset == true)
                Form1.scoreLabel.Text = "0";
        }
    }
}
