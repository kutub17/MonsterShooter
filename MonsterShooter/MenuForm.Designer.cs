namespace MonsterShooter
{
    partial class MenuForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.titleBar = new CustomControls.TitleBar_Control();
            this.btnExit = new CustomControls.CustomButtonRed();
            this.btnScore = new CustomControls.CustomButton();
            this.btnPlay = new CustomControls.CustomButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("BankGothic Md BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(125, 68);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(675, 67);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Monster Shooter";
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Transparent;
            this.titleBar.form = this;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(942, 24);
            this.titleBar.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(411, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 70);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnScore
            // 
            this.btnScore.BackColor = System.Drawing.Color.Transparent;
            this.btnScore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScore.BackgroundImage")));
            this.btnScore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScore.FlatAppearance.BorderSize = 0;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnScore.Location = new System.Drawing.Point(411, 287);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(143, 70);
            this.btnScore.TabIndex = 1;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = false;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPlay.Location = new System.Drawing.Point(395, 186);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(175, 80);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MonsterShooter.Properties.Resources.MenuBackground2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 502);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.btnPlay);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomButton btnPlay;
        private CustomControls.CustomButton btnScore;
        private CustomControls.CustomButtonRed btnExit;
        private System.Windows.Forms.Label lblTitle;
        private CustomControls.TitleBar_Control titleBar;

    }
}

