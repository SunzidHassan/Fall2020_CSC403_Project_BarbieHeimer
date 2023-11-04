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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.Play = new System.Windows.Forms.Button();
            this.BarbieHiemer = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.Button();
            this.Faq = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.AutoSize = true;
            this.Play.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.Font = new System.Drawing.Font("ROG Fonts", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Play.Location = new System.Drawing.Point(158, 287);
            this.Play.Margin = new System.Windows.Forms.Padding(2);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(352, 67);
            this.Play.TabIndex = 0;
            this.Play.Text = "New Game";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
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
            this.BarbieHiemer.Font = new System.Drawing.Font("ROG Fonts", 47.99999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarbieHiemer.ForeColor = System.Drawing.Color.Maroon;
            this.BarbieHiemer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BarbieHiemer.Location = new System.Drawing.Point(639, 149);
            this.BarbieHiemer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BarbieHiemer.Name = "BarbieHiemer";
            this.BarbieHiemer.Size = new System.Drawing.Size(658, 79);
            this.BarbieHiemer.TabIndex = 1;
            this.BarbieHiemer.Text = "BarbieHiemer";
            this.BarbieHiemer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BarbieHiemer.Click += new System.EventHandler(this.BarbieHiemer_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.Font = new System.Drawing.Font("ROG Fonts", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Settings.Location = new System.Drawing.Point(158, 490);
            this.Settings.Margin = new System.Windows.Forms.Padding(2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(352, 62);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Faq
            // 
            this.Faq.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Faq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Faq.FlatAppearance.BorderSize = 0;
            this.Faq.Font = new System.Drawing.Font("ROG Fonts", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Faq.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Faq.Location = new System.Drawing.Point(158, 586);
            this.Faq.Margin = new System.Windows.Forms.Padding(2);
            this.Faq.Name = "Faq";
            this.Faq.Size = new System.Drawing.Size(352, 61);
            this.Faq.TabIndex = 3;
            this.Faq.Text = "Faq";
            this.Faq.UseVisualStyleBackColor = false;
            this.Faq.Click += new System.EventHandler(this.Faq_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.MediumVioletRed;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.Font = new System.Drawing.Font("ROG Fonts", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Exit.Location = new System.Drawing.Point(158, 683);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(352, 57);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("ROG Fonts", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Location = new System.Drawing.Point(158, 388);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 67);
            this.button1.TabIndex = 5;
            this.button1.Text = "Load Game";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Fall2020_CSC403_Project.Properties.Resources.charSelect4;
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1940, 1000);
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 947);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}