using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using NPOI.SS.Formula.Functions;

namespace SolarSystem
{
    public partial class Form1 : Form
    {
        int x01, x02, x03, x04, x05, x06, x07, x08, y01, y02, y03, y04, y05, y06, y07, y08;

        double angle = 0;
       



        Thread p1;
        Thread p2;
        Thread p3;
        Thread p4;
        Thread p5;
        Thread p6;
        Thread p7;
        Thread p8;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(1000, 800);
            this.MinimumSize = new Size(1000, 800);



            x01 = 545; y01 = 385;
            x02 = 570; y02 = 350;
            x03 = 601; y03 = 365;
            x04 = 645; y04 = 430;
            x05 = 670; y05 = 470;
            x06 = 725; y06 = 250;
            x07 = 780; y07 = 180;
            x08 = 830; y08 = 370;



            p1 = new Thread(new ThreadStart(Run1));
            p1.Start();

            p2 = new Thread(new ThreadStart(Run2));
            p2.Start();

            p3 = new Thread(new ThreadStart(Run3));
            p3.Start();

            p4 = new Thread(new ThreadStart(Run4));
            p4.Start();

            p5 = new Thread(new ThreadStart(Run5));
            p5.Start();

            p6 = new Thread(new ThreadStart(Run6));
            p6.Start();

            p7 = new Thread(new ThreadStart(Run7));
            p7.Start();

            p8 = new Thread(new ThreadStart(Run8));
            p8.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Image fon = Image.FromFile(@"C:\\fon planet.jpg");
            e.Graphics.DrawImage(fon, 0, 0, this.Width, this.Height);
            Graphics g = this.CreateGraphics();
            this.DoubleBuffered = true;
            g.FillEllipse(Brushes.Yellow, 450, 350, 80, 80); // солнце
            g.FillEllipse(Brushes.Brown, x01, y01, 15, 15); //p1 - Меркурий
            g.FillEllipse(Brushes.Orange, x02, y02, 25, 25); //p2 - Венера
            g.FillEllipse(Brushes.DodgerBlue, x03, y03, 35, 35); //p3 - Земля
            g.FillEllipse(Brushes.Red, x04, y04, 12, 12); //p4 - Марс
            g.FillEllipse(Brushes.SandyBrown, x05, y05, 45, 45); //p5 - Юпитер
            g.FillEllipse(Brushes.SaddleBrown, x06,y06, 40, 40); //p6 - Сатурн
            g.FillEllipse(Brushes.Aquamarine, x07, y07, 37, 37); //p7 - Уран
            g.FillEllipse(Brushes.DarkBlue, x08, y08, 36, 36); //p8 - Нептун

        }
        public void Run1()
        {

            while (angle < 2 * Math.PI)
            {

                angle += 0.01;
                x01 = (int)(100 * Math.Sin(angle) + 450);
                y01 = (int)(100 * Math.Cos(angle) + 350);

                if (angle > 2 * Math.PI)
                {
                    angle = 0.00;
                }

                Thread.Sleep(50);
                this.Invalidate();
            }
          
        }

        public void Run2()
        {

            while (angle < 2 * Math.PI)
            {

                angle += 0.01;
                x02 = (int)(158 * Math.Sin(angle) + 450);
                y02 = (int)(158 * Math.Cos(angle) + 350);

                if (angle > 2 * Math.PI)
                {
                    angle = 0.00;
                }

                Thread.Sleep(250);
                this.Invalidate();
            }
        }
        public void Run3()
        {

            while (angle < 2 * Math.PI)
            {

                angle += 0.01;
                x03 = (int)(209 * Math.Sin(angle) + 450);
                y03 = (int)(209 * Math.Cos(angle) + 350);

                if (angle > 2 * Math.PI)
                {
                    angle = 0.00;
                }
                Thread.Sleep(450);
                this.Invalidate();
            }
        }
        public void Run4()
        {

            while (angle < 2 * Math.PI)
            {

                angle += 0.01;
                x04 = (int)(241 * Math.Sin(angle) + 450);
                y04 = (int)(241 * Math.Cos(angle) + 350);

                if (angle > 2 * Math.PI)
                {
                    angle = 0.00;
                }

                Thread.Sleep(650);
                this.Invalidate();
            }
        }
        public void Run5()
        {

            while (angle < 2 * Math.PI)
            {

                angle += 0.01;
                x05 = (int)(283* Math.Sin(angle) + 450);
                y05 = (int)(283 * Math.Cos(angle) + 350);

                if (angle > 2 * Math.PI)
                {
                    angle = 0.00;
                }

                Thread.Sleep(850);
                this.Invalidate();
            }
        }
        public void Run6()
        {

            while (angle < 2 * Math.PI)
            {

                angle += 0.01;
                x06 = (int)(335 * Math.Sin(angle) + 450);
                y06 = (int)(335 * Math.Cos(angle) + 350);

                if (angle > 2 * Math.PI)
                {
                    angle = 0.00;
                }

                Thread.Sleep(1050);
                this.Invalidate();
            }
        }
        public void Run7()
        {

            while (angle < 2 * Math.PI)
            {

                angle += 0.01;
                x07 = (int)(389 * Math.Sin(angle) + 450);
                y07 = (int)(389 * Math.Cos(angle) + 350);

                if (angle > 2 * Math.PI)
                {
                    angle = 0.00;
                }

                Thread.Sleep(1250);
                this.Invalidate();
            }
        }
        public void Run8()
        {

            while (angle < 2 * Math.PI)
            {

                angle += 0.01;
                x08 = (int)(438 * Math.Sin(angle) + 450);
                y08 = (int)(438 * Math.Cos(angle) + 350);

                if (angle > 2 * Math.PI)
                {
                    angle = 0.00;
                }

                Thread.Sleep(1450);
                this.Invalidate();
            }
        }
    }
}