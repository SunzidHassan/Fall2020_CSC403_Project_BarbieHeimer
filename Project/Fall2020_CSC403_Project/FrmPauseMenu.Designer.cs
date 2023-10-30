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
            this.BarbieHiemer = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Contnue = new System.Windows.Forms.Button();
            this.Faq = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.BarbieHiemer.Location = new System.Drawing.Point(295, 174);
            this.BarbieHiemer.Name = "BarbieHiemer";
            this.BarbieHiemer.Size = new System.Drawing.Size(502, 75);
            this.BarbieHiemer.TabIndex = 2;
            this.BarbieHiemer.Text = "BarbieHiemer";
            this.BarbieHiemer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(456, 451);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(176, 47);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Location = new System.Drawing.Point(456, 330);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(176, 47);
            this.Settings.TabIndex = 6;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Contnue
            // 
            this.Contnue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Contnue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Contnue.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contnue.Location = new System.Drawing.Point(456, 265);
            this.Contnue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Contnue.Name = "Contnue";
            this.Contnue.Size = new System.Drawing.Size(176, 47);
            this.Contnue.TabIndex = 5;
            this.Contnue.Text = "Continue";
            this.Contnue.UseVisualStyleBackColor = false;
            this.Contnue.Click += new System.EventHandler(this.Contnue_Click);
            // 
            // Faq
            // 
            this.Faq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Faq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Faq.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Faq.Location = new System.Drawing.Point(456, 391);
            this.Faq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Faq.Name = "Faq";
            this.Faq.Size = new System.Drawing.Size(176, 47);
            this.Faq.TabIndex = 8;
            this.Faq.Text = "Faq";
            this.Faq.UseVisualStyleBackColor = false;
            this.Faq.Click += new System.EventHandler(this.Faq_Click);
            // 
            // FrmPauseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 593);
            this.Controls.Add(this.Faq);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Contnue);
            this.Controls.Add(this.BarbieHiemer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPauseMenu";
            this.Text = "PauseMenu";
            this.Load += new System.EventHandler(this.PauseMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BarbieHiemer;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Contnue;
        private System.Windows.Forms.Button Faq;
    }
}