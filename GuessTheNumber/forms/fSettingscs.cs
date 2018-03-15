using System;
using GuessTheNumber.classes;
using System.Windows.Forms;

namespace GuessTheNumber.forms
{
    public partial class fSettings : Form
    {
        // Form -----------------------------------------------------------------------
        public fSettings()
        {
            InitializeComponent();

            nudTimerInt.Value = (decimal)Config.timerInt;
            rbNo.Checked = !(rbYes.Checked = Config.timerFreeze);
            nudStart.Value = Config.minVal;
            nudScoreInt.Value=  Config.scoreInt;
            cbReset.Checked = Config.scoreReset;
        }


        // Buttons --------------------------------------------------------------------
        private void bDefault_Click(object sender, EventArgs e)
        {
            nudTimerInt.Value = (decimal)10.0F;
            rbNo.Checked = !(rbYes.Checked = false);
            nudStart.Value = 1;
            nudScoreInt.Value = 1;
            cbReset.Checked = false;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Config.timerInt = (float)nudTimerInt.Value;
            Config.timerFreeze = rbYes.Checked;
            Config.minVal = (int)nudStart.Value;
            Config.scoreInt = (int)nudScoreInt.Value;
            Config.scoreReset = cbReset.Checked;

            Config.updateButtons();

            MessageBox.Show("You have successfully saved the changes", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
