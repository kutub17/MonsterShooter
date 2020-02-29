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
    public partial class LaserRight : UserControl
    {
        public LaserRight()
        {
            InitializeComponent();
        }

        private void LaserLeft_Resize(object sender, EventArgs e)
        {
            int thickness = 4; // half the line width, kinda

            Point[] pts = {
                            new Point(0, 0), //0
                            new Point(thickness, 0), //A
                            new Point(Width, Height - thickness), //B
                            new Point(Width, Height) , //C
                            new Point(Width - thickness, Height), //D
                            new Point(0, thickness) }; //E // magic numbers! 
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
