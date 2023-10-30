using Fall2020_CSC403_Project.Properties;
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
    public partial class FrmLevel1Finish : Form
    {
        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        public FrmLevel1Finish()
        {
            InitializeComponent();
            soundPlayer.SoundLocation = "C:\\Users\\sunzi\\Downloads\\Scrum Project\\Fall2020_CSC403_Project_BarbieHeimer\\Project\\Fall2020_CSC403_Project\\data\\audio\\Level1FinishClap.wav";
            soundPlayer.Play();
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
