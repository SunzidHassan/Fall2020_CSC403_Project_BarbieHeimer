using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel1New : Form
    {
        private Player player;

        private Enemy enemyRockMonster1;
        private Enemy enemyScissorMonster1;
        private Enemy enemyPaperMonster1;
        private Enemy enemyLvl1boss;
        

        private Enemy enemyPoisonPacket;
        private Character[] wall;
        private Character[] lava;
        private Character[] bottomLava;

        private DateTime timeBegin;
        private FrmBattle frmBattle;

        private int playerStartX;
        private int playerStartY;
        private int lava0StartX;
        private int lava0StartY;
        private int lava1StartX;
        private int lava1StartY;
        private int lava2StartX;
        private int lava2StartY;
        private float MaxTime = 300;

        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        public FrmLevel1New()
        {
            InitializeComponent();
            //soundPlayer.SoundLocation = "gamebgm.wav";
            //soundPlayer.Play();
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

        private void FrmLevel1New_Load(object sender, EventArgs e)
        {
            //FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;
            //TopMost = false;

            const int PADDING = 7;
            const int NUM_WALLS = 14;
            const int NUM_LAVA = 3;
            const int NUM_BOTTOMLAVA = 4;


            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            player.Img = picPlayer.Image;
            playerStartX = picPlayer.Location.X;
            playerStartY = picPlayer.Location.Y;

            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyPoisonPacket.Img = picEnemyPoisonPacket.Image;
            enemyPoisonPacket.Color = Color.Green;

            enemyRockMonster1 = new Enemy(CreatePosition(picLvl1EnemyRockMonster1), CreateCollider(picLvl1EnemyRockMonster1, PADDING));
            enemyRockMonster1.Img = picLvl1EnemyRockMonster1.Image;

            enemyPaperMonster1 = new Enemy(CreatePosition(picLvl1EnemyPaperMonster1), CreateCollider(picLvl1EnemyPaperMonster1, PADDING));
            enemyPaperMonster1.Img = picLvl1EnemyPaperMonster1.Image;

            enemyScissorMonster1 = new Enemy(CreatePosition(picLvl1EnemyScissorMonster1), CreateCollider(picLvl1EnemyScissorMonster1, PADDING));
            enemyScissorMonster1.Img = picLvl1EnemyScissorMonster1.Image;
            //enemyLvl1boss = new Enemy(CreatePosition(picLvl1EnemyFinalBoss), CreateCollider(picLvl1EnemyFinalBoss, PADDING));

            bottomLava = new Character[NUM_BOTTOMLAVA];
            for (int l = 0; l < NUM_BOTTOMLAVA; l++)
            {
                PictureBox pic = Controls.Find("picBottomLava" + l.ToString(), true)[0] as PictureBox;
                bottomLava[l] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            wall = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                wall[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            lava = new Character[NUM_LAVA];
            for (int l = 0; l < NUM_LAVA; l++)
            {
                PictureBox pic = Controls.Find("picLava" + l.ToString(), true)[0] as PictureBox;
                lava[l] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            lava0StartX = picLava0.Location.X;
            lava0StartY = picLava0.Location.Y;

            lava1StartX = picLava1.Location.X;
            lava1StartY = picLava1.Location.Y;

            lava2StartX = picLava2.Location.X;
            lava2StartY = picLava2.Location.Y;

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

        private void FrmLevel1New_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        
        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            float time = (float)span.TotalSeconds;
            float remainingTime = MaxTime - time;


            player.Move();
            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);


            if (player.Health < 1)
            {
                this.Close();
                FrmDeath formDeath = new FrmDeath();
                formDeath.Show();
            }

            if (remainingTime < 1)
            {
                this.Close();
                FrmDeath formDeath = new FrmDeath();
                formDeath.Show();
            }

            // check collision with walls
            if (HitWalls(player))
            {
                player.MoveBack();
            }

            else if (HitLava(player))
            {
                player.resetPosition(playerStartX, playerStartY);
                player.AlterHealth(-5);
            }

            // check collision with enemies
            else if (HitAChar(player, enemyPoisonPacket))
            {
                if (enemyPoisonPacket.Health > 0)
                {
                    Fight(player, enemyPoisonPacket);
                }
                else
                {
                    Controls.Remove(picEnemyPoisonPacket);
                    enemyPoisonPacket = null;
                    player.AlterHealth(5);
                }
            }

            // check collision with enemies
            else if (HitAChar(player, enemyRockMonster1))
            {
                if (enemyRockMonster1.Health > 0)
                {
                    Fight(player, enemyRockMonster1);
                }
                else
                {
                    Controls.Remove(picLvl1EnemyRockMonster1);
                    enemyRockMonster1 = null;
                    player.AlterHealth(5);
                }
            }
            else if (HitAChar(player, enemyPaperMonster1))
            {
                if (enemyPaperMonster1.Health > 0)
                {
                    Fight(player, enemyPaperMonster1);
                }
                else
                {
                    Controls.Remove(picLvl1EnemyPaperMonster1);
                    enemyPaperMonster1 = null;
                    player.AlterHealth(5);
                }
            }
            else if (HitAChar(player, enemyScissorMonster1))
            {
                if (enemyScissorMonster1.Health > 0)
                {
                    Fight(player, enemyScissorMonster1);
                }
                else
                {
                    Controls.Remove(picLvl1EnemyScissorMonster1);
                    enemyScissorMonster1 = null;
                    player.AlterHealth(5);
                }
            }
            //else if (HitAChar(player, enemyLvl1boss))
            //{
            //    if (enemyLvl1boss.Health > 0)
            //    {
            //        Fight(enemyLvl1boss);
            //    }

            //    else
            //    {
            //        Controls.Remove(picLvl1EnemyFinalBoss);
            //        enemyLvl1boss = null;
            //        player.AlterHealth(5);
            //    }
            //}
            //else if (HitAChar(player, finishFlag))
            //{
            //    this.Close();
            //    FrmLevel1Finish formCongratulations = new FrmLevel1Finish();
            //    formCongratulations.Show();
            //}
        }


        private bool HitLava(Character c)
        {
            bool HitLava = false;
            for (int l = 0; l < lava.Length; l++)
            {
                if (c.Collider.Intersects(lava[l].Collider))
                {
                    HitLava = true;
                    break;
                }
            }
            return HitLava;

        }

        private bool HitWalls(Character c)
        {
            bool HitWalls = false;
            for (int w = 0; w < wall.Length; w++)
            {
                if (c.Collider.Intersects(wall[w].Collider))
                {
                    HitWalls = true;
                    break;
                }
            }
            return HitWalls;
        }

        private bool HitAChar(Character you, Character other)
        {
            if (other == null) return false;
            return you.Collider.Intersects(other.Collider);
        }

        private void Fight(Player player, Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(player, enemy);
            frmBattle.Show();

            //if (enemy == bossKoolaid)
            //{
            //    frmBattle.SetupForBossBattle();
            //}
        }

        private void FrmLevel1New_KeyDown(object sender, KeyEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateHealthBars();
        }

        private void UpdateHealthBars()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            const int MAX_HEALTHBAR_WIDTH = 500;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblPlayerHealthFull.Text = player.Health.ToString();

            float playerAttackPer = player.strength / (float)player.MaxStrength;
            const int MAX_ATTACKBAR_WIDTH = 500;
            lblPlayerAttackFull.Width = (int)(MAX_ATTACKBAR_WIDTH * playerAttackPer);
            lblPlayerAttackFull.Text = player.strength.ToString();


            TimeSpan span = DateTime.Now - timeBegin;
            float time = (float)span.TotalSeconds;
            float remainingTime = MaxTime - time;
            float playerTimePer = remainingTime / MaxTime;
            const int MAX_TIMEBAR_WIDTH = 500;
            lblPlayerTimeFull.Width = (int)(MAX_TIMEBAR_WIDTH * playerTimePer);
            int remainTime = (int)remainingTime;
            lblPlayerTimeFull.Text = remainTime.ToString();
        }

        private bool HitBottomLava(Character c)
        {
            bool HitBottomLava = false;
            for (int l = 0; l < bottomLava.Length; l++)
            {
                if (c.Collider.Intersects(bottomLava[l].Collider))
                {
                    HitBottomLava = true;
                    break;
                }
            }
            Console.WriteLine(HitBottomLava);
            return HitBottomLava;
        }


        private void lavaMoveTimer1_Tick_1(object sender, EventArgs e)
        {
            lava[0].GoDown();
            lava[0].Move();
            picLava0.Location = new Point((int)lava[0].Position.x, (int)lava[0].Position.y);


            if (HitBottomLava(lava[0]))
            {
                lava[0].resetPosition(lava0StartX, lava0StartY);

            }

            lava[1].GoDown();
            lava[1].Move();
            picLava1.Location = new Point((int)lava[1].Position.x, (int)lava[1].Position.y);

            if (HitBottomLava(lava[1]))
            {
                lava[1].resetPosition(lava1StartX, lava1StartY);
            }

            lava[2].GoDown();
            lava[2].Move();
            picLava2.Location = new Point((int)lava[2].Position.x, (int)lava[2].Position.y);

            if (HitBottomLava(lava[2]))
            {
                lava[2].resetPosition(lava2StartX, lava2StartY);
            }
        }
    }
}
