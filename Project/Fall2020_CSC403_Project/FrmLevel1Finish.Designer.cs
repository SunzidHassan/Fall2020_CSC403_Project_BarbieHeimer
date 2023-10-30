namespace Fall2020_CSC403_Project
{
    partial class FrmLevel1Finish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel1Finish));
            this.LblFrmLevel1Congratulations = new System.Windows.Forms.Label();
            this.BtnLevel1FinishMainMenu = new System.Windows.Forms.Button();
            this.BtnLevel1FinishExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFrmLevel1Congratulations
            // 
            this.LblFrmLevel1Congratulations.AutoSize = true;
            this.LblFrmLevel1Congratulations.BackColor = System.Drawing.Color.White;
            this.LblFrmLevel1Congratulations.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic);
            this.LblFrmLevel1Congratulations.Location = new System.Drawing.Point(296, 64);
            this.LblFrmLevel1Congratulations.Name = "LblFrmLevel1Congratulations";
            this.LblFrmLevel1Congratulations.Size = new System.Drawing.Size(186, 38);
            this.LblFrmLevel1Congratulations.TabIndex = 0;
            this.LblFrmLevel1Congratulations.Text = "Congratulations";
            // 
            // BtnLevel1FinishMainMenu
            // 
            this.BtnLevel1FinishMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLevel1FinishMainMenu.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic);
            this.BtnLevel1FinishMainMenu.Location = new System.Drawing.Point(303, 188);
            this.BtnLevel1FinishMainMenu.Name = "BtnLevel1FinishMainMenu";
            this.BtnLevel1FinishMainMenu.Size = new System.Drawing.Size(179, 48);
            this.BtnLevel1FinishMainMenu.TabIndex = 1;
            this.BtnLevel1FinishMainMenu.Text = "Main Menu";
            this.BtnLevel1FinishMainMenu.UseVisualStyleBackColor = false;
            this.BtnLevel1FinishMainMenu.Click += new System.EventHandler(this.BtnLevel1FinishMainMenu_Click);
            // 
            // BtnLevel1FinishExit
            // 
            this.BtnLevel1FinishExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnLevel1FinishExit.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic);
            this.BtnLevel1FinishExit.Location = new System.Drawing.Point(303, 276);
            this.BtnLevel1FinishExit.Name = "BtnLevel1FinishExit";
            this.BtnLevel1FinishExit.Size = new System.Drawing.Size(179, 48);
            this.BtnLevel1FinishExit.TabIndex = 2;
            this.BtnLevel1FinishExit.Text = "Exit";
            this.BtnLevel1FinishExit.UseVisualStyleBackColor = false;
            this.BtnLevel1FinishExit.Click += new System.EventHandler(this.BtnLevel1FinishExit_Click);
            // 
            // FrmLevel1Finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLevel1FinishExit);
            this.Controls.Add(this.BtnLevel1FinishMainMenu);
            this.Controls.Add(this.LblFrmLevel1Congratulations);
            this.Name = "FrmLevel1Finish";
            this.Text = "FrmLevel1Finish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFrmLevel1Congratulations;
        private System.Windows.Forms.Button BtnLevel1FinishMainMenu;
        private System.Windows.Forms.Button BtnLevel1FinishExit;
    }
}