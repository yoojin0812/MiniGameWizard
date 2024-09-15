
namespace MiniGameWizard
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel24);
            this.panel2.Controls.Add(this.panel23);
            this.panel2.Location = new System.Drawing.Point(197, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 417);
            this.panel2.TabIndex = 3;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.White;
            this.panel24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel24.Controls.Add(this.panel25);
            this.panel24.Controls.Add(this.button4);
            this.panel24.Controls.Add(this.button3);
            this.panel24.Controls.Add(this.button2);
            this.panel24.Controls.Add(this.button1);
            this.panel24.Location = new System.Drawing.Point(3, 110);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(385, 304);
            this.panel24.TabIndex = 3;
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel25.Location = new System.Drawing.Point(22, 35);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(35, 35);
            this.panel25.TabIndex = 6;
            this.panel25.Paint += new System.Windows.Forms.PaintEventHandler(this.panel25_Paint);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("둥근모꼴", 25F);
            this.button4.Location = new System.Drawing.Point(63, 224);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(288, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Bat Blaster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.Enter += new System.EventHandler(this.button_Enter);
            this.button4.Leave += new System.EventHandler(this.button_Leave);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("둥근모꼴", 25F);
            this.button3.Location = new System.Drawing.Point(63, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(288, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Bird Adventure";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.Enter += new System.EventHandler(this.button_Enter);
            this.button3.Leave += new System.EventHandler(this.button_Leave);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("둥근모꼴", 25F);
            this.button2.Location = new System.Drawing.Point(63, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(288, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Magic Matching";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Enter += new System.EventHandler(this.button_Enter);
            this.button2.Leave += new System.EventHandler(this.button_Leave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("둥근모꼴", 25F);
            this.button1.Location = new System.Drawing.Point(63, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clean-up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Enter += new System.EventHandler(this.button_Enter);
            this.button1.Leave += new System.EventHandler(this.button_Leave);
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.White;
            this.panel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel23.Location = new System.Drawing.Point(3, 3);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(385, 100);
            this.panel23.TabIndex = 2;
            this.panel23.Paint += new System.Windows.Forms.PaintEventHandler(this.panel23_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 440);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel14.Controls.Add(this.panel18);
            this.panel14.Location = new System.Drawing.Point(72, 263);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(35, 35);
            this.panel14.TabIndex = 4;
            this.panel14.Paint += new System.Windows.Forms.PaintEventHandler(this.panel14_Paint);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel18.Location = new System.Drawing.Point(5, 10);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(25, 25);
            this.panel18.TabIndex = 5;
            this.panel18.Paint += new System.Windows.Forms.PaintEventHandler(this.panel18_Paint);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel13.Controls.Add(this.panel17);
            this.panel13.Location = new System.Drawing.Point(107, 227);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(35, 35);
            this.panel13.TabIndex = 5;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel17.Location = new System.Drawing.Point(9, 7);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(25, 25);
            this.panel17.TabIndex = 5;
            this.panel17.Paint += new System.Windows.Forms.PaintEventHandler(this.panel17_Paint);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel12.Controls.Add(this.panel16);
            this.panel12.Location = new System.Drawing.Point(37, 227);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(35, 35);
            this.panel12.TabIndex = 4;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel16.Location = new System.Drawing.Point(2, 7);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(25, 25);
            this.panel16.TabIndex = 5;
            this.panel16.Paint += new System.Windows.Forms.PaintEventHandler(this.panel16_Paint);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(72, 192);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(35, 35);
            this.panel11.TabIndex = 3;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel15.Location = new System.Drawing.Point(5, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(25, 25);
            this.panel15.TabIndex = 4;
            this.panel15.Paint += new System.Windows.Forms.PaintEventHandler(this.panel15_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel8.Location = new System.Drawing.Point(157, 27);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(20, 5);
            this.panel8.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(56, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 70);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel6.Location = new System.Drawing.Point(7, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(55, 55);
            this.panel6.TabIndex = 2;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.panel22);
            this.panel3.Controls.Add(this.panel21);
            this.panel3.Controls.Add(this.panel20);
            this.panel3.Controls.Add(this.panel19);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(594, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 440);
            this.panel3.TabIndex = 3;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel22.Location = new System.Drawing.Point(113, 100);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(35, 35);
            this.panel22.TabIndex = 8;
            this.panel22.Paint += new System.Windows.Forms.PaintEventHandler(this.panel22_Paint);
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel21.Location = new System.Drawing.Point(43, 100);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(35, 35);
            this.panel21.TabIndex = 7;
            this.panel21.Paint += new System.Windows.Forms.PaintEventHandler(this.panel21_Paint);
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel20.Location = new System.Drawing.Point(78, 136);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(35, 35);
            this.panel20.TabIndex = 6;
            this.panel20.Paint += new System.Windows.Forms.PaintEventHandler(this.panel20_Paint);
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel19.Location = new System.Drawing.Point(78, 65);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(35, 35);
            this.panel19.TabIndex = 5;
            this.panel19.Paint += new System.Windows.Forms.PaintEventHandler(this.panel19_Paint);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel10.Location = new System.Drawing.Point(20, 20);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 20);
            this.panel10.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel9.Location = new System.Drawing.Point(12, 27);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(20, 5);
            this.panel9.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(60, 234);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(70, 70);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel7.Location = new System.Drawing.Point(8, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(55, 55);
            this.panel7.TabIndex = 3;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

