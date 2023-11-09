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
    public partial class FrmPauseMenu : Form
    {

        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
   
        public FrmPauseMenu()
        {
            InitializeComponent();
            soundPlayer.SoundLocation = "barbenheimer.wav";
            soundPlayer.Play();
        }

        private void PauseMenu_Load(object sender, EventArgs e)
        {

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            
        }

        private void Contnue_Click(object sender, EventArgs e)
        {
            this.Close();
            soundPlayer.Stop();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmFAQ faq = new FrmFAQ();
            faq.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
            soundPlayer.Stop();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMainMenu mainMenu = new FrmMainMenu();
            mainMenu.Show();
        }
    }
}
