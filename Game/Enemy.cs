using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using CustomControls;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    class Enemy
    {
        GameForm form;
        public PictureBox enemy;
        Timer timer;
        Container components;

        byte health = 3;

        Point location;

        char direction = 'r';

        int hidingSpotIndex;
        //LaserRight laserRight;

        //internal Enemy(GameForm form, Point location)
        //{
        //    this.form = form;
        //    this.location = location;

        //    Initialize();
        //    //laserRight = new LaserRight();
        //    timer.Start();
        //    enemy.SendToBack();
        //}

        internal Enemy(GameForm form, int index)
        {
            this.hidingSpotIndex = index;
            
            this.form = form;
            this.location = form.environment.enemyHidingSpotList[hidingSpotIndex].Location;

            Initialize();
            //laserRight = new LaserRight();
            timer.Start();
            enemy.SendToBack();
        }

        private void Initialize()
        {
            components = new System.ComponentModel.Container();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);

            // enemy
            var random = new Random().Next(3);
            if (random == 0)
                this.enemy.Image = Game.Properties.Resources.MonsterGameAssets_016;
            else if (random == 1)
                this.enemy.Image = Game.Properties.Resources.MonsterGameAssets_017;
            else
                this.enemy.Image = Game.Properties.Resources.MonsterGameAssets_018;
            
            this.enemy.BackColor = System.Drawing.Color.Transparent;
            this.enemy.Location = this.location;
            this.enemy.Size = new System.Drawing.Size(80, 80);
            this.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // timer1
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);

            form.Controls.Add(this.enemy);
        }

        public void New()
        {
            byte stopAt = 140;
            
            //if(!form.Pause)
            if (enemy.Left < location.X + stopAt && direction == 'r')
            {
                enemy.Left += 5;
            }
            else if (enemy.Left >= location.X + stopAt) // test value 290
            {
                direction = 'l';
                //enemy.Left = location.X + stopAt-1; //test value

                if (enemy.Left == location.X + stopAt-1) //test value: 289
                {
                    timer.Interval = 600;
                    this.Shoot();
                }
                
                timer.Interval = 100;
                //this.laserRight.Visible = false;
            }

            if (direction == 'l')
            {
                if (enemy.Left > location.X) // test value 200
                    enemy.Left -= 5;
                else direction = 'r';
            }

            if (enemy.Left%90 == 0)
                this.Shoot();

        }

        private void Shoot()
        {
            Point playerLocation = new Point(form.player.Charc.Location.X+50, form.player.Charc.Location.Y+50);
            Point enemyShootingLocation = new Point(enemy.Location.X + 40, enemy.Location.Y + 40);

            
            if (playerLocation.X < enemy.Location.X)
            {
                LaserLeft laser = new LaserLeft();
                laser.BackColor = Color.Red;
                laser.Location = new Point(playerLocation.X, enemyShootingLocation.Y);
                laser.Size = new System.Drawing.Size(enemyShootingLocation.X - playerLocation.X, playerLocation.Y - enemyShootingLocation.Y);

                form.Controls.Add(laser);
                laser.BringToFront();
                
                PlayerHitCheck(new Point(laser.Location.X, laser.Location.Y+laser.Height));

                laser.Dispose();
            }
            else
            {
                LaserRight laser = new LaserRight();
                laser.BackColor = Color.Red;
                laser.Location = new System.Drawing.Point(enemyShootingLocation.X , enemyShootingLocation.Y);
                laser.Size = new System.Drawing.Size(playerLocation.X-enemyShootingLocation.X, playerLocation.Y-enemyShootingLocation.Y);

                form.Controls.Add(laser);
                laser.BringToFront();
              
                PlayerHitCheck(new Point( laser.Location.X+laser.Width , laser.Location.Y + laser.Height));

                laser.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (form.Pause)
                return;
            
            New();
        }

        private void PlayerHitCheck(Point point)
        {            
            if (form.player.PlayerInCover)
                return;
            
            PictureBox player = form.player.Charc;

            if (point.X < player.Width + player.Location.X && point.X > player.Location.X)
                form.player.PlayerDamage();
        }

        public void enemy_Click(object sender, MouseEventArgs e)
        {
            form.player.Shoot(enemy.Location.X+e.X , enemy.Location.Y+e.Y);

            if (health <= 0)
            {
                if(form.enemyCreatingLeft > 0)
                    form.CreateEnemy(hidingSpotIndex);
                
                timer.Stop();
                timer.Dispose();
                enemy.Dispose();
                form.Score++;
                --form.NumberOfEnemies;

                int enemyLeft;
                try
                {
                    enemyLeft = Convert.ToInt32(form.lblEnemyNum.Text);
                }
                catch (Exception ex)
                {
                    enemyLeft = 1;
                }
                enemyLeft--;
                form.lblEnemyNum.Text = enemyLeft.ToString();
            }
            else
                health--;

        }
    }
}
