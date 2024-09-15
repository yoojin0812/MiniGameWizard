using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniGameWizard
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;

        bool goLeft, goRight;

        int speed = 10;
        int score = 0;
        int missed = 0;

        Random randX = new Random();
        Random randY = new Random();

        PictureBox splash = new PictureBox();
        Timer splashTimer = new Timer();

        public Form2(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
            splashTimer.Interval = 700;
            splashTimer.Tick += new EventHandler(SplashTimerEvent);
            RestartGame();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Saved: " + score;
            txtMiss.Text = "Missed: " + missed;

            if (goLeft && player.Left > 0)
            {
                player.Left -= 12;
                player.Image = Properties.Resources.toliet2;
            }
            if (goRight && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += 12;
                player.Image = Properties.Resources.toliet1;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "eggs")
                {
                    x.Top += speed;
                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        splash.Image = Properties.Resources.poo2;
                        splash.Location = x.Location;
                        splash.Height = 55;
                        splash.Width = 60;
                        splash.SizeMode = PictureBoxSizeMode.StretchImage;
                        splash.BackColor = Color.Transparent;

                        this.Controls.Add(splash);

                        splash.BringToFront();
                        splashTimer.Start();

                        x.Top = randY.Next(80, 300) * -1;
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                        missed += 1;
                        player.Image = Properties.Resources.toliet_hurt2;
                    }

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Top = randY.Next(80, 300) * -1;
                        x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                        score += 1;
                    }
                }
            }

            if (score > 10)
            {
                speed = 13;
            }

            if (missed > 5)
            {
                GameTimer.Stop();
                ShowGameOverDialog();
            }
        }

        private void SplashTimerEvent(object sender, EventArgs e)
        {
            splashTimer.Stop();
            this.Controls.Remove(splash);
        }

        private void ShowGameOverDialog()
        {
            Form gameOverDialog = new Form
            {
                Text = "Game Over",
                Size = new Size(290, 160),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label message = new Label
            {
                Text = "Game Over!\n\n예를 누르면 게임이 다시 시작됩니다.\n\n아니오를 누르면 메인 화면으로 돌아갑니다.",
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 250,
                Height = 60,
                Location = new Point(10, 10)
            };

            gameOverDialog.Controls.Add(message);

            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 50
            };
            gameOverDialog.Controls.Add(buttonPanel);

            Button btnYes = new Button
            {
                Text = "예",
                DialogResult = DialogResult.Yes,
                Width = 100,
                Height = 25,
                Location = new Point(25, 10)
            };

            buttonPanel.Controls.Add(btnYes);

            Button btnNo = new Button
            {
                Text = "아니오",
                DialogResult = DialogResult.No,
                Width = 100,
                Height = 30,
                Location = new Point(155, 10)
            };

            buttonPanel.Controls.Add(btnNo);

            gameOverDialog.FormClosing += (s, e) =>
            {
                if (gameOverDialog.DialogResult == DialogResult.Yes)
                {
                    RestartGame();
                }
                else
                {
                    this.Close();
                    parentForm.Show();
                }
            };

            gameOverDialog.ShowDialog();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void RestartGame()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "eggs")
                {
                    x.Top = randY.Next(80, 300) * -1;
                    x.Left = randX.Next(5, this.ClientSize.Width - x.Width);
                }
            }

            player.Left = this.ClientSize.Width / 2;
            player.Image = Properties.Resources.toliet2;

            score = 0;
            missed = 0;
            speed = 10;

            goLeft = false;
            goRight = false;

            GameTimer.Start();
        }

        private void txtScore_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
