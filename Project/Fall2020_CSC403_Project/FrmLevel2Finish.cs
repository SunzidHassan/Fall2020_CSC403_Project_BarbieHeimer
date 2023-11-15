using Fall2020_CSC403_Project.Properties;
using System;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel2Finish : Form
    {
        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        public FrmLevel2Finish()
        {
            InitializeComponent();
            SoundPlayer simpleSound = new SoundPlayer(Resources.Level1FinishClap);
            simpleSound.Play();
        }

        private void BtnLevel1FinishMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMainMenu mainMenu = new FrmMainMenu();
            mainMenu.Show();
        }

        private void BtnLevel1FinishExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
