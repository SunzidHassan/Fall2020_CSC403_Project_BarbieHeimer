﻿using System;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMainMenu());
            //Application.Run(new FrmStatsSelection());
            //Application.Run(new FrmLevel2());

        }
    }
}
