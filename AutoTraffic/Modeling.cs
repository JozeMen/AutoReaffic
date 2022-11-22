using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using Timer = System.Windows.Forms.Timer;
/*using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
*/
namespace AutoTraffic
{
    public partial class Modeling : Form
    {
        private int CountWays;
        private int CountLines;

        int x, wid = 10, y, speed_x = 10, speed_y = 10;
        Timer timer;


        public int setCountLines
        {
            set { CountLines = value; }
        }
        public Modeling()
        {
            InitializeComponent();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            Settings sett_form = new Settings();
            sett_form.ShowDialog();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            if (!this.DesignMode)

            {

                g = e.Graphics;
                Pen pn = new Pen(Color.Blue, 2);
                e.Graphics.FillEllipse(Brushes.Red, x, y, wid, wid);
                base.OnPaint(e);

            }
        }

        Graphics g;

        /*protected override void OnPaint(PaintEventArgs e)

        {

            if (!this.DesignMode)

            {

                g = e.Graphics;
                Pen pn = new Pen(Color.Blue, 2);
                e.Graphics.FillEllipse(Brushes.Red, x, y, wid, wid);
                base.OnPaint(e);

            }

        }*/



        private void timer1_Tick(object sender, EventArgs e)
        {
            int count = 0;
            int max = 1000;
            x += 5;
            if (x > pictureBox1.Width - 10)
            {
                timer.Stop();
            }

            //y += 5;
            //button1.Text = x.ToString();
            count++;
            //Invalidate();

            this.Refresh();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            //MessageBox.Show("СМАРИ ЧО МАГУ!  " + CountLines.ToString());

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.Black);
                int num = CountLines;
                Pen p = new Pen(Color.White, 4);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                for (int i = 1; i < num; i++)
                {
                    g.DrawLine(p, 0, i * pictureBox1.Height / num, pictureBox1.Width, i * pictureBox1.Height / num);
                    //g.DrawLine(new Pen(Color.White, 4), pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);
                }

                 timer = new Timer();
                if (!DesignMode)

                {
                    timer.Interval = 30; // каждые 30 миллисекунд
                    timer.Tick += new EventHandler(timer1_Tick);

                    timer.Start();

                }

                /*
                                System.Windows.Forms.Timer timer = timer1;
                                timer.Interval = 30; // каждые 30 миллисекунд
                                int count = 0;
                                int max = 1000;
                                int x = 10;
                                int y = 10;
                                g.DrawEllipse(Pens.Red, x, y, 10, 10);
                                timer.Tick += new EventHandler((o, ev) =>
                                {
                                    x += 5;
                                    y += 5;
                                    //button1.Text = x.ToString();
                                    g.DrawEllipse(Pens.Red, x, y, 10, 10);
                                    count++;

                                    if (count == max)
                                    {
                                        System.Windows.Forms.Timer t = o as System.Windows.Forms.Timer; // можно тут просто воспользоваться timer
                                        t.Stop();
                                    }
                                });
                                timer.Start();   // запустили, а остановится он сам */


            }


            /* < Button x: Name = "helloButton" Width = "70" Height = "30" Content = "Hello" />

             DoubleAnimation buttonAnimation = new DoubleAnimation();
             buttonAnimation.From = helloButton.ActualWidth;
             buttonAnimation.To = 150;
             buttonAnimation.Duration = TimeSpan.FromSeconds(3);
             helloButton.BeginAnimation(Button.WidthProperty, buttonAnimation);*/
        }
    }
}
