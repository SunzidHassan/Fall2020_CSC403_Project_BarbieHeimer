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
    public partial class FrmLevel1Finish : Form
    {
        public FrmLevel1Finish()
        {
            InitializeComponent();
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
