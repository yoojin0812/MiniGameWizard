namespace MiniGameWizard
{
    partial class Form4
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
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::MiniGameWizard.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(409, -6);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(69, 151);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::MiniGameWizard.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(277, 277);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(69, 117);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 1;
            this.pipeBottom.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::MiniGameWizard.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(12, 147);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(56, 45);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 2;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ground
            // 
            this.ground.Image = global::MiniGameWizard.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-8, 388);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(503, 73);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Moccasin;
            this.scoreText.Font = new System.Drawing.Font("문체부 제목 돋음체", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scoreText.Location = new System.Drawing.Point(12, 408);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(126, 37);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "score:0";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyBirdGame";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
    }
}