using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game;

namespace MonsterShooter
{
    public partial class MenuForm : Form
    {       
        public MenuForm()
        {
            InitializeComponent();
        }

        //button functionalities
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("PLAY");
            this.Visible = false;
            new Level(this.Location.X, this.Location.Y);

        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Score");
            //new Score().Write(6);
            MessageBox.Show("Your currect high score: " +  new Score().currentScore.ToString());
        }
    }
}
