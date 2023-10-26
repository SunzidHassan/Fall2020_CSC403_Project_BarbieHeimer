﻿namespace Fall2020_CSC403_Project
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.Play = new System.Windows.Forms.Button();
            this.BarbieHiemer = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Button();
            this.Faq = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(566, 385);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(198, 59);
            this.Play.TabIndex = 0;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // BarbieHiemer
            // 
            this.BarbieHiemer.AutoSize = true;
            this.BarbieHiemer.BackColor = System.Drawing.Color.Transparent;
            this.BarbieHiemer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarbieHiemer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarbieHiemer.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarbieHiemer.Image = ((System.Drawing.Image)(resources.GetObject("BarbieHiemer.Image")));
            this.BarbieHiemer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BarbieHiemer.Location = new System.Drawing.Point(363, 244);
            this.BarbieHiemer.Name = "BarbieHiemer";
            this.BarbieHiemer.Size = new System.Drawing.Size(401, 60);
            this.BarbieHiemer.TabIndex = 1;
            this.BarbieHiemer.Text = "BarbieHiemer";
            this.BarbieHiemer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BarbieHiemer.Click += new System.EventHandler(this.BarbieHiemer_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Location = new System.Drawing.Point(566, 450);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(198, 59);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            // 
            // Faq
            // 
            this.Faq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Faq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Faq.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Faq.Location = new System.Drawing.Point(566, 524);
            this.Faq.Name = "Faq";
            this.Faq.Size = new System.Drawing.Size(198, 59);
            this.Faq.TabIndex = 3;
            this.Faq.Text = "Faq";
            this.Faq.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(566, 595);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(198, 59);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1347, 793);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Faq);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.BarbieHiemer);
            this.Controls.Add(this.Play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label BarbieHiemer;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Faq;
        private System.Windows.Forms.Button Exit;
    }
}