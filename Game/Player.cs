using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using CustomControls;

namespace Game
{
    public class Player
    {
        internal byte life = 100;
        bool run = false;
        public PictureBox Charc;
        PictureBox pctBoxRight;
        PictureBox pctBoxLeft;

        bool playerInCover;
        public bool PlayerInCover
        {
            get
            {
                foreach (PictureBox coverSpot in form.environment.playerCoverSpot)
                {
                    Rectangle r = Rectangle.Intersect(coverSpot.Bounds, form.player.Charc.Bounds);

                    if (r.Height == form.player.Charc.Height && r.Width == form.player.Charc.Width)
                        return true;
                }

                return false;
            }
        }

        public GameForm form { get; set; }

        int playerHealth;
        public int PlayerHealth
        {
            get { return this.playerHealth; }
            set
            {
                this.playerHealth = value;

                if (value >= 100)
                    this.playerHealth = 100;
                
                if (this.playerHealth <= 0)
                {
                    form.GameOver();
                    return;
                }

                form.lblHealth.Text = (Convert.ToInt32(this.playerHealth).ToString());
                form.healthBar.Size = new Size(value * 2, form.healthBar.Height);
            }
        }


        public Player(GameForm form)
        {
            this.form = form;

            playerHealth = 100;

            //Character Image
            this.Charc = new PictureBox();
            this.Charc.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Charc.BackColor = System.Drawing.Color.Transparent;
            this.Charc.Cursor = System.Windows.Forms.Cursors.Default;
            this.Charc.ErrorImage = null;
            this.Charc.Image = Properties.Resources.Idle_Right;
            this.Charc.Location = new System.Drawing.Point(215, 350);
            this.Charc.Name = "Charc";
            this.Charc.Size = new System.Drawing.Size(54, 100);
            this.Charc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Charc.TabIndex = 0;
            this.Charc.TabStop = false;

            // pctBoxRight
            this.pctBoxRight = new PictureBox();
            this.pctBoxRight.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxRight.Location = new System.Drawing.Point(934, 408);
            this.pctBoxRight.Name = "pctBoxRight";
            this.pctBoxRight.Size = new System.Drawing.Size(21, 94);
            this.pctBoxRight.TabIndex = 2;
            this.pctBoxRight.TabStop = false;

            // pctBoxLeft
            this.pctBoxLeft = new PictureBox();
            this.pctBoxLeft.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxLeft.Location = new System.Drawing.Point(-8, 408);
            this.pctBoxLeft.Name = "pctBoxLeft";
            this.pctBoxLeft.Size = new System.Drawing.Size(21, 94);
            this.pctBoxLeft.TabIndex = 3;
            this.pctBoxLeft.TabStop = false;

            this.form.Controls.Add(this.Charc);
            this.form.Controls.Add(this.pctBoxLeft);
            this.form.Controls.Add(this.pctBoxRight);

            //this.Charc.BringToFront();
        }

        //private void Character_KeyDown(object sender, KeyEventArgs e)
        //{
        //    this.KeyDOWN(e);  


        //}

        //private void Character_KeyUp(object sender, KeyEventArgs e)
        //{
        //    this.KeyUP(e);
        //}


        // // // // // Method

        public void KeyDOWN(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                if (!Charc.Bounds.IntersectsWith(pctBoxLeft.Bounds))
                { Charc.Left -= 8; }
                if (run == false)
                { Charc.Image = Properties.Resources.Run_Left; }
                run = true;
            }

            if (e.KeyCode == Keys.D)
            {
                if (!Charc.Bounds.IntersectsWith(pctBoxRight.Bounds))
                { Charc.Left += 8; }
                if (run == false)
                { Charc.Image = Properties.Resources.Run_Right; }
                run = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                //Charc.Image = Properties.Resources.Shoot_Right;
            }

        }

        public void KeyUP(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                Charc.Image = Properties.Resources.Idle_Left;
                run = false;

            }

            if (e.KeyCode == Keys.D)
            {
                Charc.Image = Properties.Resources.Idle_Right;
                run = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                Charc.Image = Properties.Resources.Idle_Right;
            }

        }

        public void PlayerDamage(int amount=2)
        {
            PlayerHealth -= amount;

            //playerHealth -= amount;            
            
            //form.lblHealth.Text = (Convert.ToInt32(playerHealth).ToString());
            //form.healthBar.Size = new Size(form.healthBar.Width - amount*2, form.healthBar.Height);
        }

        public void Shoot(int xMouse, int yMouse)
        {
            if (form.Pause)
                return;

            if (this.PlayerInCover)
                return;

            Point playerCenter = new Point(Charc.Location.X+(Charc.Width/2) , Charc.Location.Y+(Charc.Height/2));

            if (xMouse > playerCenter.X)
            {
                //player's right ... which means left sided laser is drawn (from start point to left side)
                Charc.Image = Properties.Resources.Idle_Right;

                LaserLeft laser = new LaserLeft();
                Point shootingPoint = new Point(Charc.Location.X+54, Charc.Location.Y + 65);
                laser.Location = new System.Drawing.Point(shootingPoint.X, yMouse);
                laser.Size = new System.Drawing.Size(xMouse - shootingPoint.X, shootingPoint.Y - yMouse);

                form.Controls.Add(laser);
                laser.BringToFront();
                laser.Dispose();
            }

            else
            {
                //player's left ... which means right sided laser is drawn (from start point to right side)
                Charc.Image = Properties.Resources.Idle_Left;

                LaserRight laser = new LaserRight();
                Point shootingPoint = new Point(Charc.Location.X+0 , Charc.Location.Y+69);
                laser.Location = new System.Drawing.Point(xMouse, yMouse);
                laser.Size = new System.Drawing.Size(shootingPoint.X-xMouse, shootingPoint.Y-yMouse);
                
                form.Controls.Add(laser);
                laser.BringToFront();
                laser.Dispose();
            }            
        }
    }
}
