﻿namespace Fall2020_CSC403_Project
{
    partial class FrmPauseMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarbieHiemer = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Faq = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.LoadGame = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Fall2020_CSC403_Project.Properties.Resources.charSelect4;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1697, 864);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BarbieHiemer
            // 
            this.BarbieHiemer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarbieHiemer.AutoSize = true;
            this.BarbieHiemer.BackColor = System.Drawing.Color.DarkViolet;
            this.BarbieHiemer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarbieHiemer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarbieHiemer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarbieHiemer.ForeColor = System.Drawing.Color.Maroon;
            this.BarbieHiemer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BarbieHiemer.Location = new System.Drawing.Point(571, 142);
            this.BarbieHiemer.Name = "BarbieHiemer";
            this.BarbieHiemer.Size = new System.Drawing.Size(539, 93);
            this.BarbieHiemer.TabIndex = 10;
            this.BarbieHiemer.Text = "BarbieHiemer";
            this.BarbieHiemer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Aquamarine;
            this.Exit.Location = new System.Drawing.Point(176, 745);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(469, 70);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Faq
            // 
            this.Faq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Faq.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Faq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Faq.FlatAppearance.BorderSize = 0;
            this.Faq.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Faq.ForeColor = System.Drawing.Color.Aquamarine;
            this.Faq.Location = new System.Drawing.Point(176, 635);
            this.Faq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Faq.Name = "Faq";
            this.Faq.Size = new System.Drawing.Size(469, 70);
            this.Faq.TabIndex = 12;
            this.Faq.Text = "Faq";
            this.Faq.UseVisualStyleBackColor = false;
            this.Faq.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Settings
            // 
            this.Settings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Settings.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.Aquamarine;
            this.Settings.Location = new System.Drawing.Point(176, 534);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(469, 70);
            this.Settings.TabIndex = 13;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoadGame
            // 
            this.LoadGame.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoadGame.BackColor = System.Drawing.Color.MediumVioletRed;
            this.LoadGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadGame.FlatAppearance.BorderSize = 0;
            this.LoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadGame.ForeColor = System.Drawing.Color.Aquamarine;
            this.LoadGame.Location = new System.Drawing.Point(176, 345);
            this.LoadGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(469, 70);
            this.LoadGame.TabIndex = 14;
            this.LoadGame.Text = "Load Game";
            this.LoadGame.UseVisualStyleBackColor = false;
            // 
            // NewGame
            // 
            this.NewGame.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NewGame.BackColor = System.Drawing.Color.MediumVioletRed;
            this.NewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewGame.FlatAppearance.BorderSize = 0;
            this.NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.ForeColor = System.Drawing.Color.Aquamarine;
            this.NewGame.Location = new System.Drawing.Point(176, 241);
            this.NewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(469, 70);
            this.NewGame.TabIndex = 15;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = false;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Continue
            // 
            this.Continue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Continue.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Continue.FlatAppearance.BorderSize = 0;
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.Color.Aquamarine;
            this.Continue.Location = new System.Drawing.Point(176, 137);
            this.Continue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(469, 70);
            this.Continue.TabIndex = 16;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnMainMenu.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnMainMenu.Location = new System.Drawing.Point(176, 438);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(469, 70);
            this.btnMainMenu.TabIndex = 17;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // FrmPauseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1689, 820);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.LoadGame);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Faq);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.BarbieHiemer);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPauseMenu";
            this.Text = "PauseMenu";
            this.Load += new System.EventHandler(this.PauseMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label BarbieHiemer;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Faq;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button btnMainMenu;
    }
}