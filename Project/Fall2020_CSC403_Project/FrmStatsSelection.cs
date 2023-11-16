using Fall2020_CSC403_Project.code;
using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmStatsSelection : Form
    {

        public static FrmMainMenu Instance;
        public System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();

        public Player player1;
        public Player player2;
        public Player player3;

        private bool difficultyHard;

        private int maxHealth;
        private int maxStrength;
        private int maxTime;

        private int player1HealthEasy;
        private int player2HealthEasy;
        private int player3HealthEasy;

        private int player1StrengthEasy;
        private int player2StrengthEasy;
        private int player3StrengthEasy;

        private int player1TimeEasy;
        private int player2TimeEasy;
        private int player3TimeEasy;
        
        private int player1HealthHard;
        private int player2HealthHard;
        private int player3HealthHard;

        private int player1StrengthHard;
        private int player2StrengthHard;
        private int player3StrengthHard;

        private int player1TimeHard;
        private int player2TimeHard;
        private int player3TimeHard;


        public FrmStatsSelection()
        {
            InitializeComponent();
            soundPlayer.SoundLocation = "ChooseCharacter.wav";
            soundPlayer.PlayLooping();

            difficultyHard = false;

            maxHealth = 20;
            maxStrength = 4;
            maxTime = 300;

            player1HealthEasy = 18;
            player2HealthEasy = 20;
            player3HealthEasy = 18;

            player1StrengthEasy = 4;
            player2StrengthEasy = 3;
            player3StrengthEasy = 3;

            player1TimeEasy = 240;
            player2TimeEasy = 240;
            player3TimeEasy = 300;

            player1HealthHard = 15;
            player2HealthHard = 18;
            player3HealthHard = 15;

            player1StrengthHard = 3;
            player2StrengthHard = 2;
            player3StrengthHard = 2;

            player1TimeHard = 180;
            player2TimeHard = 180;
            player3TimeHard = 240;

    }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                soundPlayer.Dispose();
                this.Hide();
                FrmPauseMenu pause = new FrmPauseMenu();
                pause.ShowDialog();
                pause = null;
                this.Show();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FrmStatsSelection_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
        }

        private void picPlayer1_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            this.Hide();
            

            FrmLevel1New frmLevel1New = new FrmLevel1New();
            frmLevel1New.picPlayer.Image = Properties.Resources.Rugal;
            frmLevel1New.picInventory.Image = Properties.Resources.Rugal;
            frmLevel1New.lblPlayer.Text = "Player 1";
            frmLevel1New.lblDifficulty.Text = "Easy";
            if (difficultyHard == true)
            {
                frmLevel1New.lblDifficulty.Text = "Hard";
            }
            frmLevel1New.ShowDialog();
            this.Close();
        }

        private void picPlayer2_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            this.Hide();
            FrmLevel1New frmLevel1New = new FrmLevel1New();
            frmLevel1New.picPlayer.Image = Properties.Resources.charbarbie;
            frmLevel1New.picInventory.Image = Properties.Resources.charbarbie;
            frmLevel1New.lblPlayer.Text = "Player 2";
            frmLevel1New.lblDifficulty.Text = "Easy";
            if (difficultyHard == true)
            {
                frmLevel1New.lblDifficulty.Text = "Hard";
            }
            frmLevel1New.ShowDialog();
            this.Close();
        }


        private void picPlayer3_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            this.Hide();
            FrmLevel1New frmLevel1New = new FrmLevel1New();
            frmLevel1New.picPlayer.Image = Properties.Resources.amongus;
            frmLevel1New.picInventory.Image = Properties.Resources.amongus;
            frmLevel1New.lblPlayer.Text = "Player 3";
            frmLevel1New.lblDifficulty.Text = "Easy";
            if (difficultyHard == true)
            {
                frmLevel1New.lblDifficulty.Text = "Hard";
            }

            frmLevel1New.ShowDialog();
            this.Close();
        }

        private void tmrStatSelectionBarUpdate_Tick(object sender, EventArgs e)
        {
            if(difficultyHard == true)
            {
                UpdateTrackBarsHard();
            }
            else
            {
                UpdateTrackBarsEasy();
            }
        }

        private void UpdateTrackBarsEasy()
        {
            const int MAX_BAR_WIDTH = 130;
            
            float player1StrengthPer = player1StrengthEasy / (float)maxStrength;
            lblPlayer1StrengthFull.Width = (int)(MAX_BAR_WIDTH * player1StrengthPer);
            lblPlayer1StrengthFull.Text = player1StrengthEasy.ToString();

            float player2StrengthPer = player2StrengthEasy / (float)maxStrength;
            lblPlayer2StrengthFull.Width = (int)(MAX_BAR_WIDTH * player2StrengthPer);
            lblPlayer2StrengthFull.Text = player2StrengthEasy.ToString();

            float player3StrengthPer = player3StrengthEasy / (float)maxStrength;
            lblPlayer3StrengthFull.Width = (int)(MAX_BAR_WIDTH * player3StrengthPer);
            lblPlayer3StrengthFull.Text = player3StrengthEasy.ToString();

            float player1HealthPer = player1HealthEasy / (float)maxHealth;
            lblPlayer1HealthFull.Width = (int)(MAX_BAR_WIDTH * player1HealthPer);
            lblPlayer1HealthFull.Text = player1HealthEasy.ToString();

            float player2HealthPer = player2HealthEasy / (float)maxHealth;
            lblPlayer2HealthFull.Width = (int)(MAX_BAR_WIDTH * player2HealthPer);
            lblPlayer2HealthFull.Text = player2HealthEasy.ToString();

            float player3HealthPer = player3HealthEasy / (float)maxHealth;
            lblPlayer3HealthFull.Width = (int)(MAX_BAR_WIDTH * player3HealthPer);
            lblPlayer3HealthFull.Text = player3HealthEasy.ToString();

            float player1TimePer = player1TimeEasy / (float)maxTime;
            lblPlayer1TimeFull.Width = (int)(MAX_BAR_WIDTH * player1TimePer);
            lblPlayer1TimeFull.Text = player1TimeEasy.ToString();

            float player2TimePer = player2TimeEasy / (float)maxTime;
            lblPlayer2TimeFull.Width = (int)(MAX_BAR_WIDTH * player2TimePer);
            lblPlayer2TimeFull.Text = player2TimeEasy.ToString();

            float player3TimePer = player3TimeEasy / (float)maxTime;
            lblPlayer3TimeFull.Width = (int)(MAX_BAR_WIDTH * player3TimePer);
            lblPlayer3TimeFull.Text = player3TimeEasy.ToString();
        }

        private void UpdateTrackBarsHard()
        {
            const int MAX_BAR_WIDTH = 130;

            float player1StrengthPer = player1StrengthHard / (float)maxStrength;
            lblPlayer1StrengthFull.Width = (int)(MAX_BAR_WIDTH * player1StrengthPer);
            lblPlayer1StrengthFull.Text = player1StrengthHard.ToString();

            float player2StrengthPer = player2StrengthHard / (float)maxStrength;
            lblPlayer2StrengthFull.Width = (int)(MAX_BAR_WIDTH * player2StrengthPer);
            lblPlayer2StrengthFull.Text = player2StrengthHard.ToString();

            float player3StrengthPer = player3StrengthHard / (float)maxStrength;
            lblPlayer3StrengthFull.Width = (int)(MAX_BAR_WIDTH * player3StrengthPer);
            lblPlayer3StrengthFull.Text = player3StrengthHard.ToString();

            float player1HealthPer = player1HealthHard / (float)maxHealth;
            lblPlayer1HealthFull.Width = (int)(MAX_BAR_WIDTH * player1HealthPer);
            lblPlayer1HealthFull.Text = player1HealthHard.ToString();

            float player2HealthPer = player2HealthHard / (float)maxHealth;
            lblPlayer2HealthFull.Width = (int)(MAX_BAR_WIDTH * player2HealthPer);
            lblPlayer2HealthFull.Text = player2HealthHard.ToString();

            float player3HealthPer = player3HealthHard / (float)maxHealth;
            lblPlayer3HealthFull.Width = (int)(MAX_BAR_WIDTH * player3HealthPer);
            lblPlayer3HealthFull.Text = player3HealthHard.ToString();

            float player1TimePer = player1TimeHard / (float)maxTime;
            lblPlayer1TimeFull.Width = (int)(MAX_BAR_WIDTH * player1TimePer);
            lblPlayer1TimeFull.Text = player1TimeHard.ToString();

            float player2TimePer = player2TimeHard / (float)maxTime;
            lblPlayer2TimeFull.Width = (int)(MAX_BAR_WIDTH * player2TimePer);
            lblPlayer2TimeFull.Text = player2TimeHard.ToString();

            float player3TimePer = player3TimeHard / (float)maxTime;
            lblPlayer3TimeFull.Width = (int)(MAX_BAR_WIDTH * player3TimePer);
            lblPlayer3TimeFull.Text = player3TimeHard.ToString();
        }

        private void btnStatSelectHard_Click(object sender, EventArgs e)
        {
            difficultyHard = true;
        }

        private void btnStatSelectEasy_Click(object sender, EventArgs e)
        {
            difficultyHard = false;
        }
    }
}
