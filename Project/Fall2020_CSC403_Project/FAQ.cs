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
    public partial class FAQ : Form
    {
        public FAQ()
        {
            InitializeComponent();
        }

        private void FAQ_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Qone_Click(object sender, EventArgs e)
        {
            Aone.Visible = !Aone.Visible;
           
        }

        private void Qtwo_Click(object sender, EventArgs e)
        {
            Atwo.Visible = !Atwo.Visible;
        }

        private void Qthree_Click(object sender, EventArgs e)
        {
            Athree.Visible = !Athree.Visible;
        }

        private void Qfour_Click(object sender, EventArgs e)
        {
            Afour.Visible = !Afour.Visible;
        }

        private void Qfive_Click(object sender, EventArgs e)
        {
            Afive.Visible = !Afive.Visible;
        }

        private void Qsix_Click(object sender, EventArgs e)
        {
            Asix.Visible = !Asix.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm mainMenuForm = new MainMenuForm();
        }
    }
    
}
