using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel1 : Form
    {
        private Player player;

        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        private Enemy finishFlag;
        private Character[] walls;

        private DateTime timeBegin;
        private FrmBattle frmBattle;


        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        public FrmLevel1()
        {
            InitializeComponent();
            soundPlayer.SoundLocation = "gamebgm.wav";
            soundPlayer.Play();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                soundPlayer.Dispose();
                this.Hide();
                FrmPauseMenu pause = new FrmPauseMenu();
                pause.ShowDialog();
                pause = null;
                this.Show();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;


            const int PADDING = 7;
            const int NUM_WALLS = 13;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            UpdateHeathText();
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
            finishFlag = new Enemy(CreatePosition(picLevel1Finish), CreateCollider(picLevel1Finish, PADDING));

            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
            finishFlag.Img = picLevel1Finish.BackgroundImage;

            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);
            finishFlag.Color = Color.White;

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            Game.player = player;
            timeBegin = DateTime.Now;
        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
            //CleanUpDeadCharacter();
        }


        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void UpdateHeathText()
        {
            playerHealth.Text = "Player Health: " + player.Health.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            // move player
            player.Move();

            if (player.Health == 0)
            {
                // Close the current form (FrmLevel)
                this.Close();

                // Assuming your default form is named "FrmDefault"
                FrmDeath formDeath = new FrmDeath();
                formDeath.Show();
            }

            // check collision with walls
            if (HitAWall(player))
            {
                player.MoveBack();
            }

            // check collision with enemies
            if (HitAChar(player, enemyPoisonPacket))
            {
                if (enemyPoisonPacket.Health > 0)
                {
                    Fight(enemyPoisonPacket);
                }
                else
                {
                    Controls.Remove(picEnemyPoisonPacket);
                    enemyPoisonPacket = null;
                    player.AlterHealth(5);
                    UpdateHeathText();
                }
            }
            else if (HitAChar(player, enemyCheeto))
            {
                if (enemyCheeto.Health > 0)
                {
                    Fight(enemyCheeto);
                }
                else
                {
                    Controls.Remove(picEnemyCheeto);
                    enemyCheeto = null;
                    player.AlterHealth(5);
                    UpdateHeathText();
                }
            }
            else if (HitAChar(player, bossKoolaid))
            {
                if (bossKoolaid.Health > 0)
                {
                    Fight(bossKoolaid);
                }

                else
                {
                    Controls.Remove(picBossKoolAid);
                    bossKoolaid = null;
                    player.AlterHealth(5);
                    UpdateHeathText();
                }
            }
            else if (HitAChar(player, finishFlag))
            {
                this.Close();
                FrmLevel1Finish formCongratulations = new FrmLevel1Finish();
                formCongratulations.Show();
            }

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
        }

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (c.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private bool HitAChar(Character you, Character other)
        {
            if (other == null) return false;
            return you.Collider.Intersects(other.Collider);
        }

        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy);
            frmBattle.Show();

            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.GoLeft();
                    break;

                case Keys.Right:
                    player.GoRight();
                    break;

                case Keys.Up:
                    player.GoUp();
                    break;

                case Keys.Down:
                    player.GoDown();
                    break;

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateHeathText();
            //if (player.Health == 0)
            //{
            //    this.Close();
            //    // Assuming your default form is named "FrmDefault"
            //    FrmDeath formDeath = new FrmDeath();
            //    formDeath.Show();
            //}
            //else if (enemyPoisonPacket != null)
            //{
            //    if(enemyPoisonPacket.Health == 0)
            //    {
            //        Controls.Remove(picEnemyPoisonPacket);
            //        enemyPoisonPacket = null;
            //    }
            //}
            //else if (enemyCheeto != null)
            //{
            //    if(enemyCheeto.Health == 0)
            //    {
            //        Controls.Remove(picEnemyCheeto);
            //        enemyCheeto = null;
            //    }
            //}
            //else if (bossKoolaid != null)
            //{
            //    if(bossKoolaid.Health == 0)
            //    {
            //        Controls.Remove(picBossKoolAid);
            //        bossKoolaid = null;
            //    }
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picWall0_Click(object sender, EventArgs e)
        {

        }

        private void picWall1_Click(object sender, EventArgs e)
        {

        }

        private void picWall2_Click(object sender, EventArgs e)
        {

        }

        private void picWall3_Click(object sender, EventArgs e)
        {

        }

        private void picWall4_Click(object sender, EventArgs e)
        {

        }

        private void picWall5_Click(object sender, EventArgs e)
        {

        }

        private void picWall6_Click(object sender, EventArgs e)
        {

        }

        private void picWall7_Click(object sender, EventArgs e)
        {

        }

        private void picWall8_Click(object sender, EventArgs e)
        {

        }

        private void picWall12_Click(object sender, EventArgs e)
        {

        }

        private void picWall11_Click(object sender, EventArgs e)
        {

        }

        private void picPlayer_Click(object sender, EventArgs e)
        {

        }

        private void picEnemyPoisonPacket_Click(object sender, EventArgs e)
        {

        }

        private void picWall9_Click(object sender, EventArgs e)
        {

        }

        private void picWall10_Click(object sender, EventArgs e)
        {

        }

        private void picBossKoolAid_Click(object sender, EventArgs e)
        {

        }

        private void picEnemyCheeto_Click(object sender, EventArgs e)
        {

        }

        private void picLevel1Finish_Click(object sender, EventArgs e)
        {

        }
    }
}
