namespace Fall2020_CSC403_Project
{
    partial class FrmSettingsVolume
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettingsVolume));
            this.lbl_volume = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gobacktosettings = new System.Windows.Forms.Button();
            this.volume_control1 = new Fall2020_CSC403_Project.Volume_control();
            this.btnMusicPlay = new System.Windows.Forms.Label();
            this.btnMusicStop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_volume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_volume.Location = new System.Drawing.Point(38, 228);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(141, 28);
            this.lbl_volume.TabIndex = 1;
            this.lbl_volume.Text = "Volume : 30%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gobacktosettings
            // 
            this.gobacktosettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gobacktosettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gobacktosettings.Font = new System.Drawing.Font("Mistral", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobacktosettings.Location = new System.Drawing.Point(605, -2);
            this.gobacktosettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gobacktosettings.Name = "gobacktosettings";
            this.gobacktosettings.Size = new System.Drawing.Size(116, 37);
            this.gobacktosettings.TabIndex = 2;
            this.gobacktosettings.Text = "Settings";
            this.gobacktosettings.UseVisualStyleBackColor = false;
            this.gobacktosettings.Click += new System.EventHandler(this.gobacktosettings_Click);
            // 
            // volume_control1
            // 
            this.volume_control1.BackColor = System.Drawing.Color.Crimson;
            this.volume_control1.Bar_color = System.Drawing.Color.Yellow;
            this.volume_control1.Location = new System.Drawing.Point(43, 259);
            this.volume_control1.Max = 100;
            this.volume_control1.Min = 0;
            this.volume_control1.Name = "volume_control1";
            this.volume_control1.Size = new System.Drawing.Size(427, 30);
            this.volume_control1.TabIndex = 0;
            this.volume_control1.Value = 50;
            // 
            // btnMusicPlay
            // 
            this.btnMusicPlay.AutoSize = true;
            this.btnMusicPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMusicPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicPlay.Location = new System.Drawing.Point(38, 102);
            this.btnMusicPlay.Name = "btnMusicPlay";
            this.btnMusicPlay.Size = new System.Drawing.Size(114, 28);
            this.btnMusicPlay.TabIndex = 3;
            this.btnMusicPlay.Text = "Play Music";
            this.btnMusicPlay.Click += new System.EventHandler(this.btnMusicPlay_Click);
            // 
            // btnMusicStop
            // 
            this.btnMusicStop.AutoSize = true;
            this.btnMusicStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMusicStop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicStop.Location = new System.Drawing.Point(38, 166);
            this.btnMusicStop.Name = "btnMusicStop";
            this.btnMusicStop.Size = new System.Drawing.Size(117, 28);
            this.btnMusicStop.TabIndex = 4;
            this.btnMusicStop.Text = "Stop Music";
            this.btnMusicStop.Click += new System.EventHandler(this.btnMusicStop_Click);
            // 
            // FrmSettingsVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(722, 446);
            this.Controls.Add(this.btnMusicStop);
            this.Controls.Add(this.btnMusicPlay);
            this.Controls.Add(this.gobacktosettings);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.volume_control1);
            this.Name = "FrmSettingsVolume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSettingsVolume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Volume_control volume_control1;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button gobacktosettings;
        private System.Windows.Forms.Label btnMusicPlay;
        private System.Windows.Forms.Label btnMusicStop;
    }
}