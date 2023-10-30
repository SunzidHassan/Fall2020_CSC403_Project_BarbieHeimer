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
    public partial class FrmSettingsVolume : Form
    {
        private FrmMainMenu mainMenuForm;
        public FrmSettingsVolume(FrmMainMenu mainMenu)
        {
            InitializeComponent();
            mainMenuForm = mainMenu;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_volume.Text="Volume : " + volume_control1.Value.ToString() + "%";
        }

        private void gobacktosettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMusicPlay_Click(object sender, EventArgs e)
        {
            mainMenuForm.soundPlayer.Play();
        }

        private void btnMusicStop_Click(object sender, EventArgs e)
        {
            mainMenuForm.soundPlayer.Stop();
        }
    }
}
