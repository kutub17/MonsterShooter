using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Environments
{
    public abstract class Environment
    {
        protected Form form { get; set; }
        public PictureBox[] playerCoverSpot;
        public PictureBox[] enemyHidingBase;
        public List<PictureBox> enemyHidingSpotList;

        protected Environment(Form form)
        {
            this.form = form;
            enemyHidingSpotList = new List<PictureBox>();
        }

        protected void BuildPlayerCoverSpots(PictureBox image, int xPosition)
        {
            //image.Image = Properties.Resources.haystack;
            image.BackColor = Color.Transparent;
            image.Size = new Size(175, 160);
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Location = new Point(xPosition, 290);
            this.form.Controls.Add(image);
        }

        protected void BuildEnemyHidingBase(PictureBox image, Point location, Size size )
        {
            //image.Image = Properties.Resources.tile_base;
            image.BackColor = Color.Transparent;
            //image.Size = new Size(230, 55);
            image.Size = size;
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.Location = location;
            this.form.Controls.Add(image);
        }

        protected abstract PictureBox EnemyHidingSpot();

        protected void BuildEnemyHidingSpot(PictureBox hidingBase)
        {
            PictureBox hidingSpot = EnemyHidingSpot();

            hidingSpot.BackColor = Color.Transparent;
            hidingSpot.SizeMode = PictureBoxSizeMode.StretchImage;

            int xPos = hidingBase.Location.X + 20;
            int yPos = hidingBase.Location.Y - hidingSpot.Size.Height;

            hidingSpot.Location = new Point(xPos, yPos);

            this.form.Controls.Add(hidingSpot);
            hidingSpot.BringToFront();

            enemyHidingSpotList.Add(hidingSpot);
        }
    }
}
