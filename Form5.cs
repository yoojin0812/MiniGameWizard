using System.Drawing;
using System.Windows.Forms;
using System;

namespace MiniGameWizard
{
    public partial class Form5 : Form
    {
        private Form1 parentForm;
        bool goLeft, goRight, shooting, isGameOver;
        int score;
        int playerSpeed = 12;
        int enemySpeed;
        int bulletSpeed;
        int missedEnemies; // 놓친 enemy의 수를 추적하는 변수
        Random rnd = new Random();

        public Form5(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
            resetGame();
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            enemyOne.Top += enemySpeed;
            enemyTwo.Top += enemySpeed;
            enemyThree.Top += enemySpeed;

            // 화면 아래로 떨어진 enemy 처리
            if (enemyOne.Top > 540)
            {
                enemyOne.Top = -50;
                missedEnemies++; // enemy를 놓침
            }
            if (enemyTwo.Top > 540)
            {
                enemyTwo.Top = -50;
                missedEnemies++; // enemy를 놓침
            }
            if (enemyThree.Top > 540)
            {
                enemyThree.Top = -50;
                missedEnemies++; // enemy를 놓침
            }

            // 놓친 enemy의 수가 3개 이상이면 게임 오버
            if (missedEnemies >= 3)
            {
                ShowGameOverDialog();
            }

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left < 450)
            {
                player.Left += playerSpeed;
            }

            if (shooting == true)
            {
                bulletSpeed = 20;
                bullet.Top -= bulletSpeed;
            }
            else
            {
                bullet.Left = -300;
                bulletSpeed = 0;
            }

            if (bullet.Top < -30)
            {
                shooting = false;
            }

            if (bullet.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                score += 1;
                enemyOne.Top = -450;
                enemyOne.Left = rnd.Next(10, 480);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                score += 1;
                enemyTwo.Top = -450;
                enemyTwo.Left = rnd.Next(10, 480);
                shooting = false;
            }
            if (bullet.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                score += 1;
                enemyThree.Top = -450;
                enemyThree.Left = rnd.Next(10, 480);
                shooting = false;
            }

            if (score == 5)
            {
                enemySpeed = 7;
            }
            if (score == 10)
            {
                enemySpeed = 12;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
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

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false)
            {
                shooting = true;
                bullet.Top = player.Top - 30;
                bullet.Left = player.Left + (player.Width / 2);
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }
        }

        private void resetGame()
        {
            gameTimer.Start();
            enemySpeed = 7;
            missedEnemies = 0; // 놓친 enemy의 수 초기화

            enemyOne.Left = rnd.Next(10, 500);
            enemyTwo.Left = rnd.Next(10, 500);
            enemyThree.Left = rnd.Next(10, 500);

            enemyOne.Top = rnd.Next(0, 450) * -1;
            enemyTwo.Top = rnd.Next(0, 450) * -1;
            enemyThree.Top = rnd.Next(0, 450) * -1;

            score = 0;
            bulletSpeed = 0;
            bullet.Left = -200;
            shooting = false;

            txtScore.Text = "Score: " + score;
        }

        private void ShowGameOverDialog()
        {
            isGameOver = true;
            gameTimer.Stop();

            Form gameOverDialog = new Form
            {
                Text = "Game Over",
                Size = new Size(290, 180), // 다이얼로그의 크기를 늘림
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label messageLabel = new Label
            {
                Text = "Game Over!\n\n예를 누르면 게임이 다시 시작됩니다.\n\n아니오를 누르면 메인 화면으로 돌아갑니다.",
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 250,
                Height = 80,
                Location = new Point(10, 10)
            };
            gameOverDialog.Controls.Add(messageLabel);

            Button yesButton = new Button
            {
                Text = "예",
                DialogResult = DialogResult.Yes,
                Width = 100,
                Height = 25,
                Location = new Point(25, messageLabel.Bottom + 10) // 예 버튼의 위치 조정
            };
            yesButton.Click += (sender, e) => { gameOverDialog.Close(); };
            gameOverDialog.Controls.Add(yesButton);

            Button noButton = new Button
            {
                Text = "아니오",
                DialogResult = DialogResult.No,
                Width = 100,
                Height = 25,
                Location = new Point(155, messageLabel.Bottom + 10) // 아니오 버튼의 위치 조정
            };
            noButton.Click += (sender, e) => { gameOverDialog.Close(); };
            gameOverDialog.Controls.Add(noButton);

            gameOverDialog.FormClosing += (sender, e) =>
            {
                if (gameOverDialog.DialogResult == DialogResult.Yes)
                {
                    resetGame();
                }
                else
                {
                    this.Close();
                    parentForm.Show();
                }
            };

            gameOverDialog.ShowDialog();
        }



        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}