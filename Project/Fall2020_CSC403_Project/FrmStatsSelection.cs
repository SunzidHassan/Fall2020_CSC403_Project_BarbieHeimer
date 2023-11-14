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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            this.Hide();
            

            FrmLevel1New frmLevel1New = new FrmLevel1New();
            frmLevel1New.picPlayer.Image = Properties.Resources.Rugal;
            frmLevel1New.picInventory.Image = Properties.Resources.Rugal;
            frmLevel1New.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            this.Hide();
            FrmLevel1New frmLevel1New = new FrmLevel1New();
            frmLevel1New.picPlayer.Image = Properties.Resources.charbarbie;
            frmLevel1New.picInventory.Image = Properties.Resources.charbarbie;
            frmLevel1New.ShowDialog();
            this.Close();
        }


        private void pictureBox16_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
            this.Hide();
            FrmLevel1New frmLevel1New = new FrmLevel1New();
            frmLevel1New.picPlayer.Image = Properties.Resources.amongus;
            frmLevel1New.picInventory.Image = Properties.Resources.amongus;
            frmLevel1New.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
