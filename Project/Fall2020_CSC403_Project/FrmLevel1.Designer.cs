namespace Fall2020_CSC403_Project
{
    partial class FrmLevel1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel1));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.playerHealth = new System.Windows.Forms.Label();
            this.tmrCleanDeadCharacter = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLevel1Finish = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall12 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLevel1Finish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(12, 9);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(46, 18);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            this.lblInGameTime.Click += new System.EventHandler(this.lblInGameTime_Click);
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // playerHealth
            // 
            this.playerHealth.AutoSize = true;
            this.playerHealth.BackColor = System.Drawing.Color.Black;
            this.playerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHealth.ForeColor = System.Drawing.Color.White;
            this.playerHealth.Location = new System.Drawing.Point(178, 9);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.Size = new System.Drawing.Size(89, 18);
            this.playerHealth.TabIndex = 18;
            this.playerHealth.Text = "playerHealth";
            // 
            // tmrCleanDeadCharacter
            // 
            this.tmrCleanDeadCharacter.Enabled = true;
            this.tmrCleanDeadCharacter.Interval = 10;
            this.tmrCleanDeadCharacter.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources._6fb968d062567bde0917bec7d12fe8b4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picLevel1Finish);
            this.panel1.Controls.Add(this.picWall2);
            this.panel1.Controls.Add(this.picWall11);
            this.panel1.Controls.Add(this.picBossKoolAid);
            this.panel1.Controls.Add(this.picWall3);
            this.panel1.Controls.Add(this.picWall8);
            this.panel1.Controls.Add(this.picEnemyPoisonPacket);
            this.panel1.Controls.Add(this.picWall7);
            this.panel1.Controls.Add(this.picWall1);
            this.panel1.Controls.Add(this.picWall5);
            this.panel1.Controls.Add(this.picWall0);
            this.panel1.Controls.Add(this.picWall4);
            this.panel1.Controls.Add(this.picWall10);
            this.panel1.Controls.Add(this.picWall12);
            this.panel1.Controls.Add(this.picWall9);
            this.panel1.Controls.Add(this.picWall6);
            this.panel1.Controls.Add(this.picPlayer);
            this.panel1.Controls.Add(this.picEnemyCheeto);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1402, 848);
            this.panel1.TabIndex = 21;
            // 
            // picLevel1Finish
            // 
            this.picLevel1Finish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picLevel1Finish.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picLevel1Finish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLevel1Finish.BackgroundImage")));
            this.picLevel1Finish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLevel1Finish.Location = new System.Drawing.Point(1042, 137);
            this.picLevel1Finish.Name = "picLevel1Finish";
            this.picLevel1Finish.Size = new System.Drawing.Size(100, 50);
            this.picLevel1Finish.TabIndex = 19;
            this.picLevel1Finish.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall2.Location = new System.Drawing.Point(544, 129);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(469, 67);
            this.picWall2.TabIndex = 16;
            this.picWall2.TabStop = false;
            // 
            // picWall11
            // 
            this.picWall11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWall11.BackColor = System.Drawing.Color.Transparent;
            this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall11.Location = new System.Drawing.Point(544, 553);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(164, 232);
            this.picWall11.TabIndex = 17;
            this.picWall11.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(964, 202);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(193, 194);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall3.Location = new System.Drawing.Point(-5, 516);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(358, 67);
            this.picWall3.TabIndex = 3;
            this.picWall3.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall8.Location = new System.Drawing.Point(1086, 402);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(82, 449);
            this.picWall8.TabIndex = 15;
            this.picWall8.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(103, 226);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(63, 96);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall7.Location = new System.Drawing.Point(707, 784);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(380, 67);
            this.picWall7.TabIndex = 14;
            this.picWall7.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall1.Location = new System.Drawing.Point(76, 129);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(469, 67);
            this.picWall1.TabIndex = 13;
            this.picWall1.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall5.Location = new System.Drawing.Point(-5, 784);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(358, 67);
            this.picWall5.TabIndex = 6;
            this.picWall5.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall0.Location = new System.Drawing.Point(-5, 129);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(82, 388);
            this.picWall0.TabIndex = 12;
            this.picWall0.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall4.Location = new System.Drawing.Point(-5, 582);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(82, 203);
            this.picWall4.TabIndex = 7;
            this.picWall4.TabStop = false;
            // 
            // picWall10
            // 
            this.picWall10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall10.Location = new System.Drawing.Point(646, 217);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(228, 162);
            this.picWall10.TabIndex = 11;
            this.picWall10.TabStop = false;
            // 
            // picWall12
            // 
            this.picWall12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWall12.BackColor = System.Drawing.Color.Transparent;
            this.picWall12.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall12.Location = new System.Drawing.Point(883, 525);
            this.picWall12.Name = "picWall12";
            this.picWall12.Size = new System.Drawing.Size(203, 113);
            this.picWall12.TabIndex = 8;
            this.picWall12.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall9.Location = new System.Drawing.Point(259, 282);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(197, 118);
            this.picWall9.TabIndex = 10;
            this.picWall9.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall6.Location = new System.Drawing.Point(350, 784);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(358, 67);
            this.picWall6.TabIndex = 9;
            this.picWall6.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Image = global::Fall2020_CSC403_Project.Properties.Resources.charbarbie1;
            this.picPlayer.Location = new System.Drawing.Point(294, 627);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(95, 127);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(892, 658);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(64, 107);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources._6fb968d062567bde0917bec7d12fe8b4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Fall2020_CSC403_Project.Properties.Resources._6fb968d062567bde0917bec7d12fe8b4;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1399, 848);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmLevel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources._6fb968d062567bde0917bec7d12fe8b41;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1397, 845);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerHealth);
            this.Controls.Add(this.lblInGameTime);
            this.DoubleBuffered = true;
            this.Name = "FrmLevel1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLevel1Finish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInGameTime;
        private System.Windows.Forms.Timer tmrUpdateInGameTime;
        private System.Windows.Forms.Timer tmrPlayerMove;
        private System.Windows.Forms.Label playerHealth;
        private System.Windows.Forms.Timer tmrCleanDeadCharacter;
        private System.Windows.Forms.PictureBox picLevel1Finish;
        private System.Windows.Forms.PictureBox picWall2;
        private System.Windows.Forms.PictureBox picWall11;
        private System.Windows.Forms.PictureBox picBossKoolAid;
        private System.Windows.Forms.PictureBox picWall3;
        private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
        private System.Windows.Forms.PictureBox picWall7;
        private System.Windows.Forms.PictureBox picWall1;
        private System.Windows.Forms.PictureBox picWall5;
        private System.Windows.Forms.PictureBox picWall0;
        private System.Windows.Forms.PictureBox picWall4;
        private System.Windows.Forms.PictureBox picWall10;
        private System.Windows.Forms.PictureBox picWall12;
        private System.Windows.Forms.PictureBox picWall9;
        private System.Windows.Forms.PictureBox picWall6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picWall8;
        private System.Windows.Forms.PictureBox picEnemyCheeto;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox picPlayer;
    }
}

