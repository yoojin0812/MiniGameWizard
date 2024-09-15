using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace MiniGameWizard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void MakeCircularPanel(Panel panel)
        {
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(new Rectangle(0, 0, panel.Width, panel.Height));
                panel.Region = new Region(gp);
            }
        }

        private void DrawCircleBorder(Graphics g, Panel panel, Color color, float thicknessRatio)
        {
            int thickness = (int)(Math.Min(panel.Width, panel.Height) * thicknessRatio);
            using (Pen pen = new Pen(color, thickness))
            {
                g.DrawEllipse(pen, new Rectangle(0, 0, panel.Width - 1, panel.Height - 1));
            }
        }

        private void MakeEquilateralTriangularPanel(Panel panel, int sideLength, float angle)
        {
            int height = (int)(sideLength * Math.Sqrt(3) / 2);
            PointF p1 = new PointF(sideLength / 2, 0);
            PointF p2 = new PointF(sideLength, height);
            PointF p3 = new PointF(0, height);

            PointF center = new PointF(sideLength / 2, height / 2);

            p1 = RotatePoint(p1, center, angle);
            p2 = RotatePoint(p2, center, angle);
            p3 = RotatePoint(p3, center, angle);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddLine(p1, p2);
                path.AddLine(p2, p3);
                path.AddLine(p3, p1);
                path.CloseFigure();
                panel.Region = new Region(path);
            }
        }

        private PointF RotatePoint(PointF point, PointF pivot, float angle)
        {
            float radian = angle * (float)Math.PI / 180f;
            float cosTheta = (float)Math.Cos(radian);
            float sinTheta = (float)Math.Sin(radian);

            PointF result = new PointF
            {
                X = cosTheta * (point.X - pivot.X) - sinTheta * (point.Y - pivot.Y) + pivot.X,
                Y = sinTheta * (point.X - pivot.X) + cosTheta * (point.Y - pivot.Y) + pivot.Y
            };

            return result;
        }

        private void DrawTextOnPanel(Graphics graphics, string text, Panel panel)
        {
            using (Font font = new Font("Arial", 12))
            {
                SizeF textSize = graphics.MeasureString(text, font);
                PointF locationToDraw = new PointF(
                    (panel.Width / 2) - (textSize.Width / 2),
                    (panel.Height / 2) - (textSize.Height / 2)
                );
                graphics.DrawString(text, font, Brushes.DarkGray, locationToDraw);
            }
        }

        private void MakeSpeechBubblePanel(Panel panel, int width, int height, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(new Rectangle(0, 0, cornerRadius * 2, cornerRadius * 2), 180, 90);
            path.AddLine(cornerRadius, 0, width - cornerRadius, 0);
            path.AddArc(new Rectangle(width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2), 270, 90);

            path.AddLine(width, cornerRadius, width, height - cornerRadius);

            path.AddArc(new Rectangle(width - cornerRadius * 2, height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 0, 90);
            path.AddLine(width - cornerRadius, height, cornerRadius, height);
            path.AddArc(new Rectangle(0, height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2), 90, 90);

            path.AddLine(0, height - cornerRadius, 0, cornerRadius);

            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void DrawTextInPanel(Panel panel, string text, Font font, Color color, int yOffset)
        {
            using (Graphics g = panel.CreateGraphics())
            {
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                RectangleF rect = panel.ClientRectangle;
                rect.Offset(0, yOffset);
                g.DrawString(text, font, new SolidBrush(color), rect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Near});
            }
        }

        private void button_Enter(object sender, EventArgs e)
        {
            Button enteredButton = sender as Button;
            panel25.Left = enteredButton.Left - 40;
            panel25.Top = enteredButton.Top + 10;
        }

        private void button_Leave(object sender, EventArgs e)
        {
            if (ActiveControl is Button)
            {
                Button nextButton = ActiveControl as Button;
                panel25.Left = nextButton.Left - panel25.Width;
                panel25.Top = nextButton.Top;
            }
            else
            {
                panel25.Visible = false;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            MakeCircularPanel(panel4);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            MakeCircularPanel(panel5);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            MakeCircularPanel(panel6);
            DrawCircleBorder(e.Graphics, panel6, Color.DarkGray, 0.05f);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

            MakeCircularPanel(panel7);
            DrawCircleBorder(e.Graphics, panel6, Color.DarkGray, 0.05f);
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            MakeCircularPanel(panel11);
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            MakeCircularPanel(panel12);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            MakeCircularPanel(panel13);
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
            MakeCircularPanel(panel14);
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            MakeEquilateralTriangularPanel(panel15, 25, 0);
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {
            MakeEquilateralTriangularPanel(panel16, 25, 270);

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            MakeEquilateralTriangularPanel(panel17, 25, 90);

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            MakeEquilateralTriangularPanel(panel18, 25, 180);

        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
            MakeCircularPanel(panel19);
            DrawTextOnPanel(e.Graphics, "X", panel19);
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {
            MakeCircularPanel(panel20);
            DrawTextOnPanel(e.Graphics, "B", panel19);
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            MakeCircularPanel(panel21);
            DrawTextOnPanel(e.Graphics, "Y", panel19);
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {
            MakeCircularPanel(panel22);
            DrawTextOnPanel(e.Graphics, "A", panel19);
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {
            MakeSpeechBubblePanel(panel23, 385, 100, 20);
            DrawTextInPanel(panel23, "Choose which game to play.\nPress Space or Enter!", new Font("둥근모꼴", 20, FontStyle.Bold), Color.Black, 25);
        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {
            MakeEquilateralTriangularPanel(panel25, 28, 90);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            this.Hide();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MatchingGame form3 = new MatchingGame(this);
            this.Hide();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            this.Hide();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            this.Hide();
            form5.Show();
        }
    }
}
