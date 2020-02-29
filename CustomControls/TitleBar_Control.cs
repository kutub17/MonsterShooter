using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class TitleBar_Control : UserControl
    {
        bool mouseClicked;
        int mouseX;
        int mouseY;

        public Form form { get; set; }
        
        public TitleBar_Control()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            //this.Size = new Size(942, 24);
        }

        /*
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            this.mouseClicked = true;
            this.mouseX = e.X;
            this.mouseY = e.Y;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.mouseClicked = false;
            this.mouseX = e.X;
            this.mouseY = e.Y;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (this.mouseClicked == true)
                form.SetDesktopLocation(MousePosition.X - this.mouseX, MousePosition.Y - this.mouseY);
        }
        */

        private void TitleBar_Control_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseClicked = true;
            this.mouseX = e.X;
            this.mouseY = e.Y;
        }

        private void TitleBar_Control_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseClicked = false;
            this.mouseX = e.X;
            this.mouseY = e.Y;
        }

        private void TitleBar_Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mouseClicked == true)
                form.SetDesktopLocation(MousePosition.X - this.mouseX, MousePosition.Y - this.mouseY);
        }
    }
}
