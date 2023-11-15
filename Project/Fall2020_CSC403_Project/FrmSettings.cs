using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void gobacktomainmenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_volume_Click(object sender, EventArgs e)
        {
            FrmSettingsVolume volume = new FrmSettingsVolume(FrmMainMenu.Instance);
            volume.Show();
        }
    }
}
