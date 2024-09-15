namespace MiniGameWizard
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.enemyTwo = new System.Windows.Forms.PictureBox();
            this.enemyThree = new System.Windows.Forms.PictureBox();
            this.bullet = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // enemyOne
            // 
            this.enemyOne.BackColor = System.Drawing.Color.Transparent;
            this.enemyOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enemyOne.Image = global::MiniGameWizard.Properties.Resources.enemy1;
            this.enemyOne.Location = new System.Drawing.Point(36, 83);
            this.enemyOne.Margin = new System.Windows.Forms.Padding(0);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(110, 50);
            this.enemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyOne.TabIndex = 0;
            this.enemyOne.TabStop = false;
            // 
            // enemyTwo
            // 
            this.enemyTwo.BackColor = System.Drawing.Color.Transparent;
            this.enemyTwo.Image = global::MiniGameWizard.Properties.Resources.enemy1;
            this.enemyTwo.Location = new System.Drawing.Point(198, 57);
            this.enemyTwo.Margin = new System.Windows.Forms.Padding(0);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(110, 50);
            this.enemyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyTwo.TabIndex = 0;
            this.enemyTwo.TabStop = false;
            // 
            // enemyThree
            // 
            this.enemyThree.BackColor = System.Drawing.Color.Transparent;
            this.enemyThree.Image = global::MiniGameWizard.Properties.Resources.enemy1;
            this.enemyThree.Location = new System.Drawing.Point(351, 57);
            this.enemyThree.Margin = new System.Windows.Forms.Padding(0);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(110, 50);
            this.enemyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyThree.TabIndex = 0;
            this.enemyThree.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.BackColor = System.Drawing.Color.Transparent;
            this.bullet.Image = global::MiniGameWizard.Properties.Resources.star;
            this.bullet.Location = new System.Drawing.Point(198, 270);
            this.bullet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(33, 33);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet.TabIndex = 0;
            this.bullet.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::MiniGameWizard.Properties.Resources.player1;
            this.player.Location = new System.Drawing.Point(198, 402);
            this.player.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(110, 110);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtScore.Location = new System.Drawing.Point(389, 452);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(132, 50);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Score: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MiniGameWizard.Properties.Resources.sky;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.txtScore);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BatBlasterGame";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

