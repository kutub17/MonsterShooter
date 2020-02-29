using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Environments
{
    public class Night : Environment
    {
        public Night(Form form) : base(form)
        {
            //Form Background
            this.form.BackgroundImage = Properties.Resources.BG_Night;

            ///*
            //player hiding spots
            this.playerCoverSpot = new PictureBox[3];
            for (int i = 0; i < 3; i++)
            {
                playerCoverSpot[i] = new PictureBox();
                playerCoverSpot[i].Image = Properties.Resources.haystack_Night;
            }
            BuildPlayerCoverSpots(playerCoverSpot[0], 50);
            BuildPlayerCoverSpots(playerCoverSpot[1], 400);
            BuildPlayerCoverSpots(playerCoverSpot[2], 740);
            //*/

            //Enemy Hiding Base
            this.enemyHidingBase = new PictureBox[4];

            for (int index = 0; index < this.enemyHidingBase.Length; index++)
            {
                this.enemyHidingBase[index] = new PictureBox();
                enemyHidingBase[index].Image = Properties.Resources.tile_base_night;
            }

            BuildEnemyHidingBase(enemyHidingBase[0], new Point(35, 170), new Size(230, 55));
            BuildEnemyHidingBase(enemyHidingBase[1], new Point(250, 100), new Size(230, 55));
            BuildEnemyHidingBase(enemyHidingBase[2], new Point(450, 200), new Size(230, 55));
            BuildEnemyHidingBase(enemyHidingBase[3], new Point(660, 120), new Size(230, 55));

            //Enemy hiding spots
            for (int index = 0; index < enemyHidingBase.Length; index++)
                BuildEnemyHidingSpot(enemyHidingBase[index]);
        }

        protected override PictureBox EnemyHidingSpot()
        {
            //throw new NotImplementedException();
            PictureBox image = new PictureBox();

            int hidingSpotType = (new Random()).Next(3);

            if (hidingSpotType == 0)
            {
                //Box
                image.Image = Properties.Resources.tile_boxes;
                image.Size = new Size(75, 75);
            }
            else if (hidingSpotType == 1)
            {
                //Stone
                //image.Image = Properties.Resources.tile_stones_night;
                //image.Size = new Size(132, 78);
                image.Image = Properties.Resources.tile_boxes;
                image.Size = new Size(75, 75);
            }
            else
            {
                //bush
                //image.Image = Properties.Resources.tile_bush_night;
                //image.Size = new Size(143, 87);
                image.Image = Properties.Resources.tile_boxes;
                image.Size = new Size(75, 75);
            }

            return image;
        }
    }
}
