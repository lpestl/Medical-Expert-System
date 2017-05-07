using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESysWin.src
{
    class GraphicOnFrom
    {
        public static void PaintGrid(System.Windows.Forms.Panel panel)
        {
            Pen pen_black = new Pen(Color.FromArgb(255, 0, 0, 0));
            var area = panel.CreateGraphics();

            area.Clear(panel.BackColor);

            var w = panel.Width;
            var h = panel.Height;
            var gx = 0.1f * w;
            var gw = 0.8f * w;
            var gy = 0.1f * h;
            var gh = 0.7f * h;

            area.DrawRectangle(pen_black, 
                new Rectangle((int)Math.Round(gx), 
                    (int)Math.Round(gy), 
                    (int)Math.Round(gw), 
                    (int)Math.Round(gh)));

            // Create string to draw.
            //String drawString = "Sample Text";

            // Create font and brush.
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);

            // Create point for upper-left corner of drawing.
            //PointF drawPoint = new PointF(150.0F, 50.0F);

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Far;
            drawFormat.LineAlignment = StringAlignment.Far;
            //drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            for (int i = 0; i < 3; i++)
            {
                area.DrawLine(pen_black,
                    (int)Math.Round(0.05f * w),
                    (int)Math.Round(gy + (gh / 2 * i)),
                    (int)Math.Round(gx),
                    (int)Math.Round(gy + (gh / 2 * i)));

                String txt = ((double)(1) / 2 * (2 - i)).ToString();
                PointF drawPoint = new PointF(gx, gy + (gh / 2 * i));

                area.DrawString(txt, drawFont, drawBrush, drawPoint, drawFormat);
            }

            int step_lines;
            int n = 20;
            do
            {
                step_lines = (int)Math.Round(gh / n);
                n -= 2;
            } while (((gh / n) < 50) && (n != 2));

            Pen pen_gray = new Pen(Color.Gray);
            pen_gray.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            for (var i=gy; i<gy+gh; i+=step_lines)
            {
                area.DrawLine(pen_gray, gx, gy*2 + gh - i, gx + gw, gy*2 + gh - i);
            }

            for (var i=gx; i< gx+gw; i+=step_lines)
            {
                area.DrawLine(pen_gray, i, gy, i, gy + gh);
            }
        }

        public static void DrawBottomScale(System.Windows.Forms.Panel panel, double Xbottom, double Xtop)
        {
            var w = panel.Width;
            var h = panel.Height;
            var gx = 0.1f * w;
            var gw = 0.8f * w;
            var gy = 0.1f * h;
            var gh = 0.7f * h;

            if (Xtop <= Xbottom)
            {
                MessageBox.Show("Неправильно введены значения по шкале X. Справа число должно быть больше чем слева.", "Проверьте введенные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var length_line = Xtop - Xbottom;
            var Xstep = gw;
            var step_lines = Xstep * length_line / gw;
            do
            {
                Xstep /= 2;
                step_lines = Xstep * length_line / gw;
            } while (!(Xstep < 100));

            //double step_lines = 1000;
            /*if (length_line > 1000) step_lines = 100;
            else if (length_line > 100) step_lines = 10;
            else if (length_line > 10) step_lines = 1;
            else if (length_line > 1) step_lines = 0.1f;
            else if (length_line > 0.1f) step_lines = 0.01f;
            else if (length_line > 0.01f) step_lines = 0.001f;*/

            //int Xstep = (int)Math.Round(step_lines * gw / length_line);
            /*while (Xstep < 50)
            {
                //step_lines += step_lines;
                step_lines *= 2;
                Xstep = (int)Math.Round(step_lines * gw / length_line);
            }*/

            var area = panel.CreateGraphics();
            Pen pen_black = new Pen(Color.FromArgb(255, 0, 0, 0));
            // Create font and brush.
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Near;
            drawFormat.LineAlignment = StringAlignment.Near;

            var xtxt = Xbottom;
            for (var i = gx; i < gx+gw; i+=Xstep)
            {
                area.DrawLine(pen_black, i, gy * 2 + gh, i, gy + gh);
                
                String txt = (xtxt).ToString();
                //if (step_lines >= 1) 
                txt = ((Math.Round(xtxt, 5)).ToString());
                //else if (step_lines >= 0.1f) txt = ((Math.Round(xtxt, 1)).ToString());
                //else if (step_lines >= 0.01f) txt = ((Math.Round(xtxt, 2)).ToString());
                xtxt += step_lines;
                PointF drawPoint = new PointF(i, gy + gh);

                area.DrawString(txt, drawFont, drawBrush, drawPoint, drawFormat);
            }
        }

        public static void DrawGaussMF(System.Windows.Forms.Panel panel, 
            Color color, 
            double c, 
            double sigma, 
            double Xbottom, 
            double Xtop)
        {
            Pen pen = new Pen(color);

            var w = panel.Width;
            var h = panel.Height;
            var gx = 0.1f * w;
            var gw = 0.8f * w;
            var gy = 0.1f * h;
            var gh = 0.7f * h;

            var k = (Xtop - Xbottom) / gw;
            //var knx = Xbottom / gx;

            var area = panel.CreateGraphics();

            //area.DrawLine(pen, 0, 0, (float)(Xbottom / k + gx), gy + (1 - 0) * gh);
            var xLast = Xbottom;
            var yLast = GaussMF(xLast, c, sigma);

            for (int i = 1; i <= gw; i++)
            {
                var x = Xbottom + k * i;
                var y = GaussMF(x, c, sigma);

                area.DrawLine(pen,
                    (float)gx + i - 1,
                    (float)(gy + (1 - yLast) * gh),
                    (float)gx + i,
                    (float)(gy + (1 - y) * gh));

                xLast = x;
                yLast = y;
            }
        }

        public static double GaussMF(double x, double c, double sigma)
        {
            return Math.Exp(-((x - c) / sigma) * ((x - c) / sigma));
        }

        public static void DrawTrianglMF(System.Windows.Forms.Panel panel, 
            Color color, 
            double a, 
            double b, 
            double c,
            double Xbottom,
            double Xtop)
        {
            Pen pen = new Pen(color);

            var w = panel.Width;
            var h = panel.Height;
            var gx = 0.1f * w;
            var gw = 0.8f * w;
            var gy = 0.1f * h;
            var gh = 0.7f * h;

            var k = (Xtop - Xbottom) / gw;
            
            var area = panel.CreateGraphics();

            if (a >= Xbottom)
            {
                area.DrawLine(pen,
                    (float)(Xbottom / k + gx),
                    gy + gh,
                    (float)(a / k + gx),
                    gy + gh);
            }
           
            if (c <= Xtop)
            {
                area.DrawLine(pen,
                (float)(c / k + gx),
                gy + gh,
                (float)(Xtop / k + gx),
                gy + gh);
            }

            area.DrawLine(pen,
                (float)(a / k + gx),
                gy + gh,
                (float)(b / k + gx),
                gy);

            area.DrawLine(pen,
                (float)(b / k + gx),
                gy,
                (float)(c / k + gx),
                gy + gh);
            
        }

        public static double TriangularMF(double x, double a, double b, double c)
        {
            double res = 0;

            if ((x > a) && (x < b))
            {
                res = 1.0d - (b - x) / (b - a);
            }
            if ((x > b) && (x < c))
            {
                res = 1.0d - (x - b) / (c - b);
            }
            if (x == b) res = 1;

            return res;
        }

        public static void DrawTrapezMF(System.Windows.Forms.Panel panel,
            Color color,
            double a,
            double b,
            double c,
            double d,
            double Xbottom,
            double Xtop)
        {
            Pen pen = new Pen(color);

            var w = panel.Width;
            var h = panel.Height;
            var gx = 0.1f * w;
            var gw = 0.8f * w;
            var gy = 0.1f * h;
            var gh = 0.7f * h;

            var k = (Xtop - Xbottom) / gw;

            var area = panel.CreateGraphics();

            if (a >= Xbottom)
            {
                area.DrawLine(pen,
                    (float)(Xbottom / k + gx),
                    gy + gh,
                    (float)(a / k + gx),
                    gy + gh);
            }

            if (d <= Xtop)
            {
                area.DrawLine(pen,
                    (float)(d / k + gx),
                    gy + gh,
                    (float)(Xtop / k + gx),
                    gy + gh);
            }
            
            area.DrawLine(pen,
                (float)(a / k + gx),
                gy + gh,
                (float)(b / k + gx),
                gy);

            area.DrawLine(pen,
                (float)(b / k + gx),
                gy,
                (float)(c / k + gx),
                gy);

            area.DrawLine(pen,
                (float)(c / k + gx),
                gy,
                (float)(d / k + gx),
                gy + gh);
        }

        public static double TrapezoidalMF(double x, double a, double b, double c, double d)
        {
            double res = 0;

            if ((x > a) && (x < b))
            {
                res = 1.0d - (b - x) / (b - a);
            }

            if ((x >= b) && (x <= c))
            {
                res = 1;
            }

            if ((x > c) && (x < d))
            {
                res = 1.0d - (x - c) / (d - c);
            }
            return res;
        }

    }
}
