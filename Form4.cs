using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MiniGameWizard
{
    public partial class Form4 : Form
    {

        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;
 

        private Form1 parentForm;
     


        public Form4(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
            

        }


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)  
            {

                gravity = 10;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();

            DialogResult result =
                MessageBox.Show("Game Over!게임을 다시 시작하려면 확인 버튼을 누르세요.",
                "Game Over", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Form4 newForm = new Form4(parentForm);
                
                newForm.Show();
                this.Close();
            }
            else
            {
                this.Close();
                parentForm.Show();
            }
        }



        private void gameTimerEvent(object sender, EventArgs e)
        {
           
                flappyBird.Top += gravity;
                pipeBottom.Left -= pipeSpeed;

                pipeTop.Left -= pipeSpeed;


                scoreText.Text = "Score: " + score;

                if (pipeBottom.Left < -150)
                {

                    pipeBottom.Left = 800;
                    score++;
                }
                if (pipeTop.Left < -180)
                {

                    pipeTop.Left = 950;
                    score++;
                }


                if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
                    )
                {
                endGame();

            }
                if (score > 5)
                {
                    pipeSpeed = 15;
                
            }

        }
    }
}
