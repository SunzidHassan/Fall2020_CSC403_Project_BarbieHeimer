using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmMainMenu : Form
    {

        public static FrmMainMenu Instance;
        public System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();  

        public FrmMainMenu()
        {
            InitializeComponent();
            Instance = this;
            soundPlayer.SoundLocation = "barbenheimer.wav";
            soundPlayer.Play();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BarbieHiemer_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
           
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
            
        }

        private void Play_Click(object sender, EventArgs e)
        {
          

            soundPlayer.Stop();
            this.Hide();
            FrmStatsSelection frmStatsSelection = new FrmStatsSelection();
            frmStatsSelection.ShowDialog();

          /*  Play.ShowDialog();
            Play = null;
            this.Show();*/
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Faq_Click(object sender, EventArgs e)
        {
            FrmFAQ faq = new FrmFAQ();
            faq.Show();

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
