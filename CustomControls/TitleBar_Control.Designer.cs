namespace CustomControls
{
    partial class TitleBar_Control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TitleBar_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TitleBar_Control";
            this.Size = new System.Drawing.Size(942, 24);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_Control_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_Control_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_Control_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
