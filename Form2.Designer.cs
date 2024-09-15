
namespace MiniGameWizard
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtScore = new System.Windows.Forms.Label();
            this.txtMiss = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("자이언츠 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtScore.Location = new System.Drawing.Point(14, 8);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(97, 27);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Saved: 0";
            this.txtScore.Click += new System.EventHandler(this.txtScore_Click);
            // 
            // txtMiss
            // 
            this.txtMiss.AutoSize = true;
            this.txtMiss.BackColor = System.Drawing.Color.Transparent;
            this.txtMiss.Font = new System.Drawing.Font("자이언츠 Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiss.Location = new System.Drawing.Point(422, 8);
            this.txtMiss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMiss.Name = "txtMiss";
            this.txtMiss.Size = new System.Drawing.Size(107, 27);
            this.txtMiss.TabIndex = 1;
            this.txtMiss.Text = "Missed: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::MiniGameWizard.Properties.Resources.toliet1;
            this.player.Location = new System.Drawing.Point(131, 358);
            this.player.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(110, 130);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MiniGameWizard.Properties.Resources.poo;
            this.pictureBox3.Location = new System.Drawing.Point(351, 113);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "eggs";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(216, 113);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "eggs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 113);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "eggs";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MiniGameWizard.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(534, 500);
            this.Controls.Add(this.txtMiss);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CleanUpGame";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtMiss;
        private System.Windows.Forms.Timer GameTimer;
    }
}

