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
            FrmLevel1 Play = new FrmLevel1();
            Play.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
