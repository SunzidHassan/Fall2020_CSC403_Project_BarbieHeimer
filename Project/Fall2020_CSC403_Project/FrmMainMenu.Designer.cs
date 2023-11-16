namespace Fall2020_CSC403_Project
{
    partial class FrmMainMenu
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
            this.Play = new System.Windows.Forms.Button();
            this.BarbieHiemer = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Button();
            this.Faq = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Play.AutoSize = true;
            this.Play.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Play.Location = new System.Drawing.Point(101, 374);
            this.Play.Margin = new System.Windows.Forms.Padding(2);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(282, 48);
            this.Play.TabIndex = 0;
            this.Play.Text = "New Game";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // BarbieHiemer
            // 
            this.BarbieHiemer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BarbieHiemer.AutoSize = true;
            this.BarbieHiemer.BackColor = System.Drawing.Color.DarkViolet;
            this.BarbieHiemer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarbieHiemer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarbieHiemer.Font = new System.Drawing.Font("Ravie", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarbieHiemer.ForeColor = System.Drawing.Color.Maroon;
            this.BarbieHiemer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BarbieHiemer.Location = new System.Drawing.Point(624, 166);
            this.BarbieHiemer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BarbieHiemer.Name = "BarbieHiemer";
            this.BarbieHiemer.Size = new System.Drawing.Size(643, 88);
            this.BarbieHiemer.TabIndex = 1;
            this.BarbieHiemer.Text = "BarbieHiemer";
            this.BarbieHiemer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BarbieHiemer.Click += new System.EventHandler(this.BarbieHiemer_Click);
            // 
            // Settings
            // 
            this.Settings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Settings.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.Cyan;
            this.Settings.Location = new System.Drawing.Point(101, 462);
            this.Settings.Margin = new System.Windows.Forms.Padding(2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(282, 49);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Faq
            // 
            this.Faq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Faq.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Faq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Faq.FlatAppearance.BorderSize = 0;
            this.Faq.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Faq.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Faq.Location = new System.Drawing.Point(101, 539);
            this.Faq.Margin = new System.Windows.Forms.Padding(2);
            this.Faq.Name = "Faq";
            this.Faq.Size = new System.Drawing.Size(282, 47);
            this.Faq.TabIndex = 3;
            this.Faq.Text = "Faq";
            this.Faq.UseVisualStyleBackColor = false;
            this.Faq.Click += new System.EventHandler(this.Faq_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Cyan;
            this.Exit.Location = new System.Drawing.Point(101, 625);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(282, 46);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Fall2020_CSC403_Project.Properties.Resources.charSelect4;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Faq);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.BarbieHiemer);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label BarbieHiemer;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Faq;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}