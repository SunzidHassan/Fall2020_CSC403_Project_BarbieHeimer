using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmDeath : Form
    {
        public FrmDeath()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMainMenu mainMenu = new FrmMainMenu();
            mainMenu.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStatsSelection frmStatsSelection = new FrmStatsSelection();
            frmStatsSelection.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FrmDeath_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
