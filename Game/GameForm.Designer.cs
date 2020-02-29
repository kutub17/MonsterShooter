namespace Game
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.btnClose = new CustomControls.CustomButtonRed();
            this.titleBar_Control1 = new CustomControls.TitleBar_Control();
            this.btnPause = new CustomControls.CustomButton();
            this.healthBar = new System.Windows.Forms.Panel();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblEnemyText = new System.Windows.Forms.Label();
            this.lblEnemyNum = new System.Windows.Forms.Label();
            this.lblScoreText = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.panelCheat = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtCheat = new System.Windows.Forms.TextBox();
            this.lblCheat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblLevelNumber = new System.Windows.Forms.Label();
            this.lblBigMessage = new System.Windows.Forms.Label();
            this.panelCheat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(880, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 51);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.customButtonRed1_Click);
            // 
            // titleBar_Control1
            // 
            this.titleBar_Control1.BackColor = System.Drawing.Color.Transparent;
            this.titleBar_Control1.form = this;
            this.titleBar_Control1.Location = new System.Drawing.Point(0, -8);
            this.titleBar_Control1.Name = "titleBar_Control1";
            this.titleBar_Control1.Size = new System.Drawing.Size(942, 24);
            this.titleBar_Control1.TabIndex = 1;
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPause.Location = new System.Drawing.Point(822, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(52, 51);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // healthBar
            // 
            this.healthBar.BackColor = System.Drawing.Color.Green;
            this.healthBar.Location = new System.Drawing.Point(53, 469);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(200, 20);
            this.healthBar.TabIndex = 3;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(10, 469);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(37, 21);
            this.lblHealth.TabIndex = 0;
            this.lblHealth.Text = "100";
            // 
            // lblEnemyText
            // 
            this.lblEnemyText.AutoSize = true;
            this.lblEnemyText.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyText.Location = new System.Drawing.Point(745, 472);
            this.lblEnemyText.Name = "lblEnemyText";
            this.lblEnemyText.Size = new System.Drawing.Size(154, 21);
            this.lblEnemyText.TabIndex = 0;
            this.lblEnemyText.Text = "Number oF Enemies:";
            // 
            // lblEnemyNum
            // 
            this.lblEnemyNum.AutoSize = true;
            this.lblEnemyNum.BackColor = System.Drawing.Color.Transparent;
            this.lblEnemyNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnemyNum.Location = new System.Drawing.Point(905, 472);
            this.lblEnemyNum.Name = "lblEnemyNum";
            this.lblEnemyNum.Size = new System.Drawing.Size(31, 21);
            this.lblEnemyNum.TabIndex = 0;
            this.lblEnemyNum.Text = "???";
            // 
            // lblScoreText
            // 
            this.lblScoreText.AutoSize = true;
            this.lblScoreText.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreText.Location = new System.Drawing.Point(12, 19);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(52, 21);
            this.lblScoreText.TabIndex = 0;
            this.lblScoreText.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(62, 20);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(37, 21);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "000";
            // 
            // panelCheat
            // 
            this.panelCheat.Controls.Add(this.btnExit);
            this.panelCheat.Controls.Add(this.btnGo);
            this.panelCheat.Controls.Add(this.txtCheat);
            this.panelCheat.Controls.Add(this.lblCheat);
            this.panelCheat.Location = new System.Drawing.Point(553, 83);
            this.panelCheat.Name = "panelCheat";
            this.panelCheat.Size = new System.Drawing.Size(200, 100);
            this.panelCheat.TabIndex = 4;
            this.panelCheat.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(115, 64);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(16, 64);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(93, 23);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtCheat
            // 
            this.txtCheat.Location = new System.Drawing.Point(14, 33);
            this.txtCheat.Name = "txtCheat";
            this.txtCheat.Size = new System.Drawing.Size(176, 20);
            this.txtCheat.TabIndex = 6;
            // 
            // lblCheat
            // 
            this.lblCheat.AutoSize = true;
            this.lblCheat.Location = new System.Drawing.Point(10, 9);
            this.lblCheat.Name = "lblCheat";
            this.lblCheat.Size = new System.Drawing.Size(138, 13);
            this.lblCheat.TabIndex = 5;
            this.lblCheat.Text = "Cheat: [Originally for testing]";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(464, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 23);
            this.panel2.TabIndex = 5;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(439, 2);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(49, 21);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Level:";
            // 
            // lblLevelNumber
            // 
            this.lblLevelNumber.AutoSize = true;
            this.lblLevelNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevelNumber.Location = new System.Drawing.Point(489, 2);
            this.lblLevelNumber.Name = "lblLevelNumber";
            this.lblLevelNumber.Size = new System.Drawing.Size(17, 21);
            this.lblLevelNumber.TabIndex = 0;
            this.lblLevelNumber.Text = "?";
            // 
            // lblBigMessage
            // 
            this.lblBigMessage.AutoSize = true;
            this.lblBigMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblBigMessage.Font = new System.Drawing.Font("Bank Gothic", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBigMessage.Location = new System.Drawing.Point(112, 200);
            this.lblBigMessage.Name = "lblBigMessage";
            this.lblBigMessage.Size = new System.Drawing.Size(725, 99);
            this.lblBigMessage.TabIndex = 6;
            this.lblBigMessage.Text = "Game Paused";
            this.lblBigMessage.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 502);
            this.Controls.Add(this.lblBigMessage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCheat);
            this.Controls.Add(this.lblLevelNumber);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblEnemyNum);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblScoreText);
            this.Controls.Add(this.lblEnemyText);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.titleBar_Control1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseClick);
            this.panelCheat.ResumeLayout(false);
            this.panelCheat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomButtonRed btnClose;
        private CustomControls.TitleBar_Control titleBar_Control1;
        private CustomControls.CustomButton btnPause;
        public System.Windows.Forms.Label lblHealth;
        public System.Windows.Forms.Label lblEnemyText;
        public System.Windows.Forms.Label lblEnemyNum;
        public System.Windows.Forms.Label lblScore;
        public System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.Panel panelCheat;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtCheat;
        private System.Windows.Forms.Label lblCheat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Panel healthBar;
        public System.Windows.Forms.Label lblLevelNumber;
        public System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblBigMessage;
    }
}

