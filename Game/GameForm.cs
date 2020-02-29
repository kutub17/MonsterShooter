using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Environments;

namespace Game
{
    public partial class GameForm : Form
    {
        public Environments.Environment environment;
        public Player player;
        List<Enemy> enemy;
        Color textColor = Color.Black;
        public bool Pause { get; set; }

        int numberOfEnemies;
        public int NumberOfEnemies
        {
            get { return this.numberOfEnemies; }
            set
            {
                if (value == 0)
                    NextLevel();
                else
                    this.numberOfEnemies = value;
            } 
        }
        
        int score;
        public int Score 
        {
            get { return this.score; } 
            set
            { 
                this.score = value;
                this.lblScore.Text = value.ToString();
            } 
        }

        public int enemyCreatingLeft;

        
        public GameForm(int xPos, int yPos, int levelNumber, int score, int numberOfEnemies)
        {            
            InitializeComponent();
            this.Left = xPos;
            this.Top = yPos;
            this.Score = score;

            this.LoadEnvironment();
            
            player = new Player(this);

            panelCheat.Visible = false;

            enemy = new List<Enemy>();

            this.NumberOfEnemies = new Random().Next(levelNumber, numberOfEnemies+1);
            enemyCreatingLeft = NumberOfEnemies;
            
            if (NumberOfEnemies < 4)
            {
                for (int i = 0; i < NumberOfEnemies; i++)
                    CreateEnemy(i);
            }
            else
            {
                for (int i = 0; i < 4; i++)
                    CreateEnemy(i);
            }

            this.lblLevelNumber.Text = levelNumber.ToString();
            this.lblScore.Text = Score.ToString();
            this.lblEnemyNum.Text = NumberOfEnemies.ToString();
        }

        public void CreateEnemy(int index)
        {
            //enemy.Add(new Enemy(this, environment.enemyHidingSpotList[index].Location));
            enemy.Add(new Enemy(this, index));
            enemy[enemy.Count - 1].enemy.MouseClick += new System.Windows.Forms.MouseEventHandler(enemy[enemy.Count - 1].enemy_Click);
            enemyCreatingLeft--;
        }

        private void LoadEnvironment()
        {            
            var r = (new Random()).Next(3);
            
            if (r == 0)
            {
                environment = new Forest(this);
                textColor = Color.Black;
            }
            else if (r == 1)
            {
                environment = new Desert(this);
                textColor = Color.Black;
            }
            else
            {
                environment = new Night(this);
                textColor = Color.White;
            }
            this.SetTextColor();
        }

        private void NextLevel()
        {
            this.Visible = false;
            new Level(this.Location.X , this.Location.Y, Score, player.PlayerHealth+10);
            this.Close();
        }

        private void SetTextColor()
        {
            this.lblHealth.ForeColor = textColor;
            this.lblEnemyNum.ForeColor = textColor;
            this.lblEnemyText.ForeColor = textColor;
            this.lblScore.ForeColor = textColor;
            this.lblScoreText.ForeColor = textColor;
            this.lblLevel.ForeColor = textColor;
            this.lblLevelNumber.ForeColor = textColor;
            this.lblBigMessage.ForeColor = textColor;
        }

        private void customButtonRed1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Quit?", "Quit?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
           if(!Pause)
               this.player.KeyDOWN(e);
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (!Pause)
                this.player.KeyUP(e);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (!Pause)
            {
                Pause = true;
                this.btnPause.Text = "Play";
                lblBigMessage.Visible = true;
            }
            else
            {
                Pause = false;
                this.btnPause.Text = "Pause";
                lblBigMessage.Visible = false;
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            panelCheat.Visible = true;
            panelCheat.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            panelCheat.Visible = false;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtCheat.Text == "levelchange")
                this.LoadEnvironment();
            else if (txtCheat.Text == "hitplayer")
                player.PlayerDamage();
            else if (txtCheat.Text == "nextlevel")
                this.NextLevel();
            else if (txtCheat.Text == "gameover")
                this.GameOver();
            
            
            else if (txtCheat.Text == "?")
                MessageBox.Show(" levelchange \n hitplayer \n nextlevel");
            else
                MessageBox.Show("Unknown command");
        }

        public void GameForm_MouseClick(object sender, MouseEventArgs e)
        {
            this.player.Shoot(e.X , e.Y);
        }

        public void GameOver()
        {
            Pause = true;
            lblBigMessage.Text = "GAME OVER";
            lblBigMessage.Visible = true;
            new Score().Write(Score);
            
            DialogResult result = MessageBox.Show("Do you want to restart?", "Restart?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Visible = false;
                Level.levelNumber = 0;
                new Level(this.Location.X, this.Location.Y);
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
