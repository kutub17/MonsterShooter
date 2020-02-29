using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControls
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            this.BackColor = Color.Transparent;
            this.FlatStyle = FlatStyle.Flat;
            this.Size = new Size(163, 80);
            this.BackgroundImage = Properties.Resources.btn_Normal;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.Cursor = Cursors.Hand;
            this.ForeColor = Color.DarkGreen;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackgroundImage = Properties.Resources.btn_Hover;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackgroundImage = Properties.Resources.btn_Normal;
        }

        //protected override void OnMouseDown(MouseEventArgs e)
        //{
        //    base.OnMouseDoubleClick(e);
        //    this.BackgroundImage = Properties.Resources.btn_Click;
        //}

        //protected override void OnMouseUp(MouseEventArgs e)
        //{
        //    base.OnMouseUp(e);
        //    this.BackgroundImage = Properties.Resources.btn_Hover;
        //}
    }
}
