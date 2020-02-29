using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CustomControls
{
    public partial class LaserLeft : UserControl
    {
        public LaserLeft()
        {
            InitializeComponent();
        }

        private void LaserLeft_Resize(object sender, EventArgs e)
        {
            int thickness = 4;

            Point[] pts = {
                            new Point(Width, 0), //0
                            new Point(Width-thickness, 0), //A
                            new Point(0, Height - thickness), //B
                            new Point(0, Height) , //C
                            new Point(thickness, Height), //D
                            new Point(Width, thickness) }; //E 
            byte[] types = {
                            0, // start point
                            1, // line
                            1, // line
                            1, // line
                            1, // line
                            1 }; // line 

            GraphicsPath path = new GraphicsPath(pts, types);

            this.Region = new Region(path);
        }


    }
}
