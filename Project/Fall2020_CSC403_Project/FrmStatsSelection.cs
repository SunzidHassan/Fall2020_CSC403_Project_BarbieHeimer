using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmStatsSelection : Form
    {

        public static FrmMainMenu Instance;
        public System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        public FrmStatsSelection()
        {
            InitializeComponent();
            soundPlayer.SoundLocation = "ChooseCharacter.wav";
            soundPlayer.PlayLooping();
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            this.Hide();
            FrmLevel1 frmLevel1 = new FrmLevel1();
            frmLevel1.picPlayer.Image = Properties.Resources.Rugal;
            frmLevel1.ShowDialog();
            frmLevel1 = null;
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            this.Hide();
            FrmLevel1 frmLevel1 = new FrmLevel1();
            frmLevel1.picPlayer.Image = Properties.Resources.charbarbie;
            frmLevel1.ShowDialog();
            frmLevel1 = null;
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            this.Hide();
            FrmLevel1 frmLevel1 = new FrmLevel1();
            frmLevel1.picPlayer.Image = Properties.Resources.amongus;
            frmLevel1.ShowDialog();
            frmLevel1 = null;
            this.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
   
        }
    }
}
