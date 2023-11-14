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
    public partial class FrmIntro : Form
    {


        public System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        public FrmIntro()
        {
            InitializeComponent();
            soundPlayer.SoundLocation = "intro.wav";
            soundPlayer.Play();
        }

        Timer Timer;
        private void FrmIntro_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;

            Timer = new Timer();
            Timer.Interval = 6000;
            Timer.Tick += new EventHandler(MyTimer_Tick);
            Timer.Start();
        }



        private void MyTimer_Tick(object sender, EventArgs e)
        {
            Timer.Stop();
            this.Hide();
            FrmStartGame frmStartGame = new FrmStartGame();
            frmStartGame.ShowDialog();
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
