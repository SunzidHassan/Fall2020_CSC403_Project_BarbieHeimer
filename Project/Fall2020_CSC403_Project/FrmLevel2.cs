using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel2 : Form
    {
        private Player player;
        private int horizontalWallDirection = 1; // 1 for right, -1 for left
        private int verticalWallDirection = 1;   // 1 for down, -1 for up


        private int playerStartX;
        private int playerStartY;
        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        //private Enemy finishFlag;
        private Character[] walls;

        private DateTime timeBegin;
        private FrmBattle frmBattle;

        private float MaxTime = 300;
        private float playerTime;



        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        public FrmLevel2(Image playerImage, Image inventoryImage)
        {
            InitializeComponent();
            //soundPlayer.SoundLocation = "gamebgm.wav";
            //soundPlayer.Play();
            SoundPlayer simpleSound = new SoundPlayer(Resources.level1);
            simpleSound.PlayLooping();
            //picWall13PositionX = picWall13.Left;
            picPlayer.Image = playerImage;
            picInventory.Image = inventoryImage;
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
            /*FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;*/
            /*FormBorderStyle = FormBorderStyle.FixedSingle; // Change to a desired border style
            WindowState = FormWindowState.Normal; // Change to normal window state*/

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = false;




            const int PADDING = 7;
            const int NUM_WALLS = 19;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            player.Img = picPlayer.Image;
            playerStartX = picPlayer.Location.X;
            playerStartY = picPlayer.Location.Y;

            //UpdateHeathText();
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
            //finishFlag = new Enemy(CreatePosition(picLevel1Finish), CreateCollider(picLevel1Finish, PADDING));

            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
            //finishFlag.Img = picLevel1Finish.BackgroundImage;

            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);
            //finishFlag.Color = Color.White;

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }


            Game.player = player;
            timeBegin = DateTime.Now;

            if (lblPlayer.Text == "Player 1")
            {
                if (lblDifficulty.Text == "Easy")
                {
                    player.AlterStrength(+2);
                    player.AlterHealth(-2);
                    playerTime = 240;
                }
                else if (lblDifficulty.Text == "Hard")
                {
                    player.AlterStrength(+1);
                    player.AlterHealth(-5);
                    playerTime = 180;
                }
            }
            else if (lblPlayer.Text == "Player 2")
            {
                if (lblDifficulty.Text == "Easy")
                {
                    player.AlterStrength(+1);
                    player.AlterHealth(0);
                    playerTime = 240;
                }
                else if (lblDifficulty.Text == "Hard")
                {
                    player.AlterStrength(0);
                    player.AlterHealth(-2);
                    playerTime = 180;
                }
            }
            else if (lblPlayer.Text == "Player 3")
            {
                if (lblDifficulty.Text == "Easy")
                {
                    player.AlterStrength(+1);
                    player.AlterHealth(-2);
                    playerTime = 300;
                }
                else if (lblDifficulty.Text == "Hard")
                {
                    player.AlterStrength(0);
                    player.AlterHealth(-5);
                    playerTime = 240;
                }
            }
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

        /*private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
            //CleanUpDeadCharacter();
        }*/
        /*private void UpdateHeathText()
        {
            playerHealth.Text = "Player Health: " + player.Health.ToString();
        }
*/






        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            float time = (float)span.TotalSeconds;
            float remainingTime = playerTime - time;

            //udate player box pposition code needed
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

            player.Move();

            if (player.Health < 1)
            {
                FrmDeath formDeath = new FrmDeath();
                formDeath.Show();
                this.Close();
            }

            if (remainingTime < 1)
            {
                FrmDeath formDeath = new FrmDeath();
                formDeath.Show();
                this.Close();
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
                    Fight(player, enemyPoisonPacket, "Tempting, isn't it? The toxic embrace of Dungeaon's crawl.");
                }
                else
                {
                    Controls.Remove(picEnemyPoisonPacket);
                    enemyPoisonPacket = null;
                    player.AlterHealth(5);
                    //UpdateHeathText();
                }
            }
            else if (HitAChar(player, enemyCheeto))
            {
                if (enemyCheeto.Health > 0)
                {
                    Fight(player, enemyCheeto, "Step into the web of confusion spun by my maneuvers.");
                }
                else
                {
                    Controls.Remove(picEnemyCheeto);
                    enemyCheeto = null;
                    player.AlterHealth(5);
                    //UpdateHeathText();
                }
            }
            else if (HitAChar(player, bossKoolaid))
            {
                if (bossKoolaid.Health > 0)
                {
                    Fight(player, bossKoolaid, "Feel the allure of the dragon's majestic flames.");
                }

                else
                {
                    Controls.Remove(picBossKoolAid);
                    bossKoolaid = null;
                    player.AlterHealth(5);
                    //UpdateHeathText();
                    this.Close();
                    FrmLevel2Finish formCongratulations = new FrmLevel2Finish();
                    formCongratulations.Show();
                }
            }
            else if (HitAChar(player, finishFlag))
            {
                this.Close();
                FrmLevel2Finish formCongratulations = new FrmLevel2Finish();
                formCongratulations.Show();
            }



            if (player.Collider.Intersects(new Collider(picWall15.Bounds)))
            {
                if (picWall15.Visible)
                {
                    // Player cannot pass through the visible picWall15
                    //player.MoveBack();
                   player.resetPosition(playerStartX, playerStartY);
                   player.AlterHealth(-5);  // Adjust the health change as needed
                   player.AlterScore(-5);
                    //UpdateHealthText();      // Update the health display
                }
                else 
                {
                    // Implement player movement logic when picWall15 is not visible
                    player.Move();
                }
            }

            if (player.Collider.Intersects(new Collider(picWall16.Bounds)))
            {
                if (picWall16.Visible)
                {
                    // Player cannot pass through the visible picWall15
                    //player.MoveBack();
                    player.resetPosition(playerStartX, playerStartY);
                    player.AlterHealth(-5);
                    player.AlterScore(-5);
                    //UpdateHealthText();
                }
                else
                {
                    // Implement player movement logic when picWall15 is not visible
                    player.Move();
                }
            }
            
            if (player.Collider.Intersects(new Collider(picWall17.Bounds)))           
            {
                //if (picWall17.Visible)
                //{
                player.resetPosition(playerStartX, playerStartY);
                player.AlterHealth(-5);
                player.AlterScore(-5);
                //}
                if (!picWall17.Visible)
                {
                    // Implement player movement logic when picWall15 is not visible
                    player.Move();
                }
            }
            if (player.Collider.Intersects(new Collider(picWall13.Bounds)))
            {
                //if (picWall13.Visible)
                //{
                    //player.MoveBack();
                 player.resetPosition(playerStartX, playerStartY);
                 player.AlterHealth(-5);
                 player.AlterScore(-5);
                    //UpdateHealthText();
                //}
                if (!picWall13.Visible)
                {
                    // Implement player movement logic when picWall15 is not visible
                    player.Move();
                }
            }
            if (player.Collider.Intersects(new Collider(picWall14.Bounds)))
            {
                //if (picWall14.Visible)
                //{
                    //player.MoveBack();
                 player.resetPosition(playerStartX, playerStartY);
                 player.AlterHealth(-5);
                 player.AlterScore(-5);
                    //UpdateHealthText();
                //}
                if (!picWall14.Visible)
                {
                    // Implement player movement logic when picWall15 is not visible
                    player.Move();
                }
            }
            if (player.Collider.Intersects(new Collider(picWall18.Bounds)))
            {
                //if (picWall18.Visible)
                //{
                    //player.MoveBack();
                 player.resetPosition(playerStartX, playerStartY);
                 player.AlterHealth(-5);
                 player.AlterScore(-5);
                    //UpdateHealthText();
                //}
                if (!picWall18.Visible)
                {
                    // Implement player movement logic when picWall15 is not visible
                    player.Move();
                }
            }
            /*if (player.Collider.Intersects(new Collider(picWall19.Bounds)))
            {
                if (picWall19.Visible)
                {
                    player.MoveBack();
                    player.resetPosition(playerStartX, playerStartY);
                    player.AlterHealth(-5);
                    player.AlterScore(-5);
                    //UpdateHealthText();
                }
                else
                {
                    // Implement player movement logic when picWall15 is not visible
                    player.Move();
                }
            }*/

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

        private void Fight(Player player, Enemy enemy, string enemyMessage)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(player, enemy);
            frmBattle.UpdateEnemyInfo(enemyMessage);
            frmBattle.Show();

            /*if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }*/
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



        /*private bool HasCollisionWithOtherWalls(PictureBox wall)
        {
            foreach (Control control in Controls)
            {
                
                if (control is PictureBox otherWall && otherWall != wall && wall.Bounds.IntersectsWith(otherWall.Bounds))
                {
                    return true; // Collision detected
                }
            }
            return false; // No collision
        }*/
        private bool HasCollisionWithOtherWalls(PictureBox wall)
        {
            foreach (Control control in Controls)
            {
                // Check if the control is a PictureBox
                if (control is PictureBox otherWall)
                {
                    // Check if the control is the player
                    if (otherWall.Name == "picPlayer")
                    {
                        continue; // Skip the player
                    }

                    // Check for collision with other walls
                    else if (otherWall != wall && wall.Bounds.IntersectsWith(otherWall.Bounds))
                    {
                        return true; // Collision detected
                    }
                }
            }

            return false; // No collision
        }



        private void tmrpicWall13_Tick(object sender, EventArgs e)
        {

            int horizontalWallSpeed = 10; // Adjust the speed as needed

            // Save the original position
            int originalLeft13 = picWall13.Left;

            // Move picWall13 horizontally
            picWall13.Left += horizontalWallDirection * horizontalWallSpeed;

            // Check if picWall13 has collided with any other walls
            if (HasCollisionWithOtherWalls(picWall13))
            {
                // Restore the original position
                picWall13.Left = originalLeft13;
                // Change direction when colliding with other walls
                horizontalWallDirection *= -1;
            }
        }

        private void tmrpicWall17_Tick(object sender, EventArgs e)
        {

            //picWall17.Visible = !picWall17.Visible;

            int verticalWallSpeed = 10; // Adjust the speed as needed

            // Save the original position
            int originalTop17 = picWall17.Top;

            // Move picWall17 vertically
            picWall17.Top += verticalWallDirection * verticalWallSpeed;

            // Check if picWall17 has collided with any other walls
            if (HasCollisionWithOtherWalls(picWall17))
            {
                // Restore the original position
                picWall17.Top = originalTop17;
                // Change direction when colliding with other walls
                verticalWallDirection *= -1;
            }
        }

        private void tmrpicWall14_Tick(object sender, EventArgs e)
        {
            int horizontalWallSpeed = 10; // Adjust the speed as needed

            // Save the original position
            int originalLeft14 = picWall14.Left;

            // Move picWall13 horizontally
            picWall14.Left += horizontalWallDirection * horizontalWallSpeed;

            // Check if picWall13 has collided with any other walls
            if (HasCollisionWithOtherWalls(picWall14))
            {
                // Restore the original position
                picWall14.Left = originalLeft14;
                // Change direction when colliding with other walls
                horizontalWallDirection *= -1;
            }
        }

        private void tmrpicWall15_Tick(object sender, EventArgs e)
        {
            picWall15.Visible = !picWall15.Visible;
        }

        private void tmrpicWall16_Tick(object sender, EventArgs e)
        {
            picWall16.Visible = !picWall16.Visible;
        }

        private void picWall17_Click(object sender, EventArgs e)
        {

        }

        private void tmrpicWall18_Tick(object sender, EventArgs e)
        {
            //picWall17.Visible = !picWall17.Visible;

            int verticalWallSpeed = 25; // Adjust the speed as needed

            // Save the original position
            int originalTop18 = picWall18.Top;

            // Move picWall17 vertically
            picWall18.Top += verticalWallDirection * verticalWallSpeed;

            // Check if picWall17 has collided with any other walls
            if (HasCollisionWithOtherWalls(picWall18))
            {
                // Restore the original position
                picWall18.Top = originalTop18;
                // Change direction when colliding with other walls
                verticalWallDirection *= -1;
            }
        }

        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            player.AlterScore(-1);
        }

        private void tmrUpdateScoreBars_Tick(object sender, EventArgs e)
        {
            UpdateHealthBars();
        }

        private void UpdateHealthBars()
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            const int MAX_HEALTHBAR_WIDTH = 400;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblPlayerHealthFull.Text = player.Health.ToString();

            float playerAttackPer = player.strength / (float)player.MaxStrength;
            const int MAX_ATTACKBAR_WIDTH = 400;
            lblPlayerAttackFull.Width = (int)(MAX_ATTACKBAR_WIDTH * playerAttackPer);
            lblPlayerAttackFull.Text = player.strength.ToString();


            TimeSpan span = DateTime.Now - timeBegin;
            float time = (float)span.TotalSeconds;
            float remainingTime = playerTime - time;
            float playerTimePer = remainingTime / MaxTime;
            const int MAX_TIMEBAR_WIDTH = 400;
            lblPlayerTimeFull.Width = (int)(MAX_TIMEBAR_WIDTH * playerTimePer);
            int remainTime = (int)remainingTime;
            lblPlayerTimeFull.Text = remainTime.ToString();

            float playerScorePer = player.Score / (float)player.MaxScore;
            const int MAX_SCOREBAR_HEIGHT = 80;
            lblPlayerScoreFull.Height = (int)(MAX_SCOREBAR_HEIGHT * playerScorePer);
            lblPlayerScoreFull.Text = player.Score.ToString();
        }

        private void picBottomLava2_Click(object sender, EventArgs e)
        {

        }

        private void LvlLabelHealth_Click(object sender, EventArgs e)
        {

        }

        private void LvlLabelAttack_Click(object sender, EventArgs e)
        {

        }

        private void LvlLabelTime_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayerHealthFull_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayerAttackFull_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayerTimeFull_Click(object sender, EventArgs e)
        {

        }

        private void picBottomLava0_Click(object sender, EventArgs e)
        {

        }



        /*private void tmrpicWall19_Tick_1(object sender, EventArgs e)
        {
            //picWall17.Visible = !picWall17.Visible;

            int verticalWallSpeed = 15; // Adjust the speed as needed

            // Save the original position
            int originalTop19 = picWall19.Top;

            // Move picWall17 vertically
            picWall19.Top += verticalWallDirection * verticalWallSpeed;

            // Check if picWall17 has collided with any other walls
            if (HasCollisionWithOtherWalls(picWall19))
            {
                // Restore the original position
                picWall19.Top = originalTop19;
                // Change direction when colliding with other walls
                verticalWallDirection *= -1;
            }
        }*/
    }
}