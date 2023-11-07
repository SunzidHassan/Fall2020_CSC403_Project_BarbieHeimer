namespace Fall2020_CSC403_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPauseMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarbieHiemer = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Faq = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.LoadGame = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Fall2020_CSC403_Project.Properties.Resources.charSelect4;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1916, 949);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BarbieHiemer
            // 
            this.BarbieHiemer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BarbieHiemer.AutoSize = true;
            this.BarbieHiemer.BackColor = System.Drawing.Color.DarkViolet;
            this.BarbieHiemer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarbieHiemer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarbieHiemer.Font = new System.Drawing.Font("Microsoft Sans Serif", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarbieHiemer.ForeColor = System.Drawing.Color.Maroon;
            this.BarbieHiemer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BarbieHiemer.Location = new System.Drawing.Point(613, 141);
            this.BarbieHiemer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BarbieHiemer.Name = "BarbieHiemer";
            this.BarbieHiemer.Size = new System.Drawing.Size(438, 75);
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
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Aquamarine;
            this.Exit.Location = new System.Drawing.Point(204, 648);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(352, 57);
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
            this.Faq.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Faq.ForeColor = System.Drawing.Color.Aquamarine;
            this.Faq.Location = new System.Drawing.Point(204, 559);
            this.Faq.Margin = new System.Windows.Forms.Padding(2);
            this.Faq.Name = "Faq";
            this.Faq.Size = new System.Drawing.Size(352, 57);
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
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.Aquamarine;
            this.Settings.Location = new System.Drawing.Point(204, 478);
            this.Settings.Margin = new System.Windows.Forms.Padding(2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(352, 57);
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
            this.LoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadGame.ForeColor = System.Drawing.Color.Aquamarine;
            this.LoadGame.Location = new System.Drawing.Point(204, 395);
            this.LoadGame.Margin = new System.Windows.Forms.Padding(2);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(352, 57);
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
            this.NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.ForeColor = System.Drawing.Color.Aquamarine;
            this.NewGame.Location = new System.Drawing.Point(204, 294);
            this.NewGame.Margin = new System.Windows.Forms.Padding(2);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(352, 57);
            this.NewGame.TabIndex = 15;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = false;
            // 
            // Continue
            // 
            this.Continue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Continue.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Continue.FlatAppearance.BorderSize = 0;
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.Color.Aquamarine;
            this.Continue.Location = new System.Drawing.Point(204, 209);
            this.Continue.Margin = new System.Windows.Forms.Padding(2);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(352, 57);
            this.Continue.TabIndex = 16;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // FrmPauseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 947);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.LoadGame);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Faq);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.BarbieHiemer);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}