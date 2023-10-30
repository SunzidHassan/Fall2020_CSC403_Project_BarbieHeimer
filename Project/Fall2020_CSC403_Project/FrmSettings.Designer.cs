namespace Fall2020_CSC403_Project
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.btn_volume = new System.Windows.Forms.Button();
            this.gobacktomainmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_volume
            // 
            this.btn_volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volume.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Italic);
            this.btn_volume.Location = new System.Drawing.Point(342, 229);
            this.btn_volume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_volume.Name = "btn_volume";
            this.btn_volume.Size = new System.Drawing.Size(176, 47);
            this.btn_volume.TabIndex = 2;
            this.btn_volume.Text = "Volume";
            this.btn_volume.UseVisualStyleBackColor = false;
            this.btn_volume.Click += new System.EventHandler(this.btn_volume_Click);
            // 
            // gobacktomainmenu
            // 
            this.gobacktomainmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gobacktomainmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gobacktomainmenu.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobacktomainmenu.Location = new System.Drawing.Point(759, 0);
            this.gobacktomainmenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gobacktomainmenu.Name = "gobacktomainmenu";
            this.gobacktomainmenu.Size = new System.Drawing.Size(116, 37);
            this.gobacktomainmenu.TabIndex = 3;
            this.gobacktomainmenu.Text = "Main Menu";
            this.gobacktomainmenu.UseVisualStyleBackColor = false;
            this.gobacktomainmenu.Click += new System.EventHandler(this.gobacktomainmenu_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(875, 547);
            this.Controls.Add(this.gobacktomainmenu);
            this.Controls.Add(this.btn_volume);
            this.Name = "FrmSettings";
            this.Text = "FrmSettings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_volume;
        private System.Windows.Forms.Button gobacktomainmenu;
    }
}