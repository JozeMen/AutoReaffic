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
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Timer = System.Windows.Forms.Timer;
/*using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
*/
namespace AutoTraffic
{
    public partial class Modeling : Form
    {
        private int CountWays;
        private int CountLines;
        private string roadType;
        private bool trigger = false;

        private bool _isStopped = false;

        private Car[] cars;
        private Car[] _reverseCars;


        int wid, y, y1, speed_x = 3, speed_x1 = 4;
        int x1 = -10;
        int x = 300;
        int count = 0;
        int[] speed = { 30, 60, 90 };
        Timer timer = new Timer();

        public string setRoaType
        {
            set { roadType = value; }
        }
        public int setCountLines
        {
            set { CountLines = value; }
        }

        public int setCountWays
        {
            set { CountWays = value; }
        }
        public Modeling()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            Settings sett_form = new Settings();
            sett_form.ShowDialog();
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            _isStopped = true;

            timer.Tick -= new EventHandler(timer1_FirestTick);
            timer.Tick -= new EventHandler(timer1_SecondTick);
            trigger = false;
            timer.Stop();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Tick -= new EventHandler(timer1_FirestTick);
            trigger = false;
            timer.Stop();
            x = 0;
            x1 = -wid;
            y = 0;
            y1 = 0; 
            speed_x = 3; 
            speed_x1 = 4;
            this.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            wid = ((pictureBox1.Height / (CountLines * CountWays)) - 20);
            if (!this.DesignMode)
            {
                g = e.Graphics;
                Pen pn = new Pen(Color.Blue, 2);

                if (trigger)
                {
                    for (int i = 0; i < CountLines * CountWays; i++)
                    {
                        for (int j = 0; j < CountWays; j++)
                        {
                            //e.Graphics.FillEllipse(Brushes.Green, cars[j].cur_x, cars[j].cur_y, wid, wid);
                        }
                        for (int j = 0; j < CountWays; j++)
                        {
                            e.Graphics.FillEllipse(Brushes.Aqua, _reverseCars[j].cur_x, _reverseCars[j].cur_y, wid, wid);
                        }
                        e.Graphics.FillEllipse(Brushes.Red, x, y, wid, wid);
                        if (x >= pictureBox1.Width / 8 || count > 0)
                        {
                            e.Graphics.FillEllipse(Brushes.Blue, x1, y1, wid, wid);
                        }

                        base.OnPaint(e);
                    }
                }
            }
        }

        Graphics g;



        private void timer1_FirestTick(object sender, EventArgs e)
        {
            int decrease = 0;
            if (!trigger)
            {

            }
            else
            {
                if (x >= pictureBox1.Width / 8 || count > 0)
                {
                    if (((Math.Abs(x - x1) < wid + 20) && (Math.Abs(y1 - y) < wid + 20)))
                    {
                        x1 += speed_x - 1;
                        if ((Math.Abs(y1 - y) < wid + 20 && CountLines > 1))
                        {
                            x1 += speed_x - 1;
                            y1++;
                        }
                        else if (CountLines == 1)
                        {
                            x1 += --speed_x1;
                            decrease++;
                        }

                    }
                    else
                    {
                        speed_x1 = speed_x + 5;
                        x1 += speed_x1;
                    }
                }
                if (x > pictureBox1.Width + wid)
                {
                    count = 1;
                    x = 0;
                }
                if (x1 > pictureBox1.Width + wid)
                {
                    x1 = 0;
                }
            }

            int max = 1000;
            x += speed_x; //неа, тут меняем ск-ть
            for (int i = 0; i < cars.Length; i++)
            {
                //cars[i].cur_x += 5;
            }

            this.Refresh();
        }
        private void timer1_SecondTick(object sender, EventArgs e)
        {
            int max = 1000;
            //x += speed_x; //неа, тут меняем ск-ть
            for (int i = 0; i < _reverseCars.Length; i++)
            {
                if (_reverseCars[i].cur_x < -wid - 100)
                {
                    _reverseCars[i].cur_x = _reverseCars[i].start_x;
                }
                else
                {
                    _reverseCars[i].cur_x -= _reverseCars[i].speed;
                }
            }
            this.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            cars = new Car[CountWays];

            if (!_isStopped)
            {
                _reverseCars = new Car[CountWays];

                for (int i = 0; i < CountWays; i++)
                {
                    _reverseCars[i] = new Car(wid);
                    _reverseCars[i].start_x = wid + 500 + (i * 100);
                    _reverseCars[i].cur_x = wid + 500 + (i * 100);
                    _reverseCars[i].start_y = (i + 2) * 80;
                    _reverseCars[i].cur_y = (i + 2) * 80;
                    _reverseCars[i].speed = 5;
                }
            }

            _isStopped = false;

            using (g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.Black);
                int lines = CountLines;
               
                switch (roadType)
                {
                    case "город":
                        Pen p = new Pen(Color.White, 4);
                        p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        for (int i = 1; i < lines * CountWays; i++)
                        {
                            if (CountWays > 1 && i == lines)
                            {
                                Pen p1 = new Pen(Color.White, 4);

                                var firstCoord = (i * pictureBox1.Height / (lines * CountWays)) - 5;
                                var secondCoord = (i * pictureBox1.Height / (lines * CountWays)) + 5;

                                g.DrawLine(p1, 0, firstCoord, pictureBox1.Width - 1, firstCoord);
                                g.DrawLine(p1, 0, secondCoord, pictureBox1.Width - 1, secondCoord);
                                continue;
                            }
                            else
                            {
                                for (int j = 1; j < 10; j++)
                                {
                                    var firstCoord = (i * pictureBox1.Height / (lines * CountWays)) - 5;
                                    g.DrawLine(p, 0, firstCoord, (pictureBox1.Width / 9) * j, firstCoord);
                                }
                            }
                        }
                        break;
                    case "загород":
                        p = new Pen(Color.White, 4);
                        p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        for (int i = 2; i < (lines * CountWays) + 1; i++)
                        {
                            if (CountWays > 1 && i == lines)
                            {
                                Pen p1 = new Pen(Color.White, 4);
                                g.DrawLine(p1, 0, (i * pictureBox1.Height / (lines * CountWays)) - 5, pictureBox1.Width, (i * pictureBox1.Height / (lines * CountWays)) - 5);
                                g.DrawLine(p1, 0, (i * pictureBox1.Height / (lines * CountWays)) + 5, pictureBox1.Width, (i * pictureBox1.Height / (lines * CountWays)) + 5);
                                continue;
                            }
                            g.FillRectangle(Brushes.Green, new Rectangle(0, 0, pictureBox1.Width, wid));
                            g.FillRectangle(Brushes.Green, new Rectangle(0, ((lines * CountWays) - 1) * pictureBox1.Height / (lines * CountWays), pictureBox1.Width, wid));

                            if (i + 2 > (lines * CountWays))
                            {
                                break;
                            }

                            g.DrawLine(p, 0, i * pictureBox1.Height / (lines * CountWays), pictureBox1.Width, i * pictureBox1.Height / (lines * CountWays));
                        }
                        break;
                    default:
                        break;
                }

                //timer = new Timer();
                if (!DesignMode && !trigger)

                {
                    timer.Interval = 30; // каждые 30 миллисекунд
                    timer.Tick += new EventHandler(timer1_FirestTick);
                    timer.Tick += new EventHandler(timer1_SecondTick);
                    //timer.Tick += new EventHandler();
                    timer.Start();
                }
                trigger = true;
            }
        }
    }
}
