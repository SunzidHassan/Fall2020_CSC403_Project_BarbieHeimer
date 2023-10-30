﻿using System;
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
    public partial class FrmDeath : Form
    {
        public FrmDeath()
        {
            InitializeComponent();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMainMenu mainMenu = new FrmMainMenu();
            mainMenu.Show();

        }

        private void BtnRetry_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLevel1 Play = new FrmLevel1();
            Play.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
