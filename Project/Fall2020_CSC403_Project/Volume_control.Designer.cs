namespace Fall2020_CSC403_Project
{
    partial class Volume_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Volume_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "Volume_control";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Volume_control_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Volume_control_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Volume_control_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Volume_control_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
