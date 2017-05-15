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
        public static void PaintGrid(Panel panel)
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

        public static void DrawBottomScale(Panel panel, double Xbottom, double Xtop)
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

        public static void DrawGaussMF(Panel panel, 
            Color color, 
            double c, 
            double sigma, 
            double Xbottom, 
            double Xtop,
            BoundaryTypeEnum bound)
        {
            Pen pen = new Pen(color, 2);

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
            double xLast = Xbottom;
            double yLast = GaussMF(xLast, c, sigma, bound);

            for (int i = 1; i <= gw; i++)
            {
                double x = Xbottom + k * i;
                double y = GaussMF(x, c, sigma, bound);
                area.DrawLine(pen,
                    (float)gx + i - 1,
                    (float)(gy + (1 - yLast) * gh),
                    (float)gx + i,
                    (float)(gy + (1 - y) * gh));

                xLast = x;
                yLast = y;
            }

        }

        public static double GaussMF(double x, double c, double sigma, BoundaryTypeEnum bound)
        {
            double res = 0;
            switch (bound)
            {
                case BoundaryTypeEnum.LEFT:
                    if (x <= c) res = 1;
                    else res = Math.Exp(-((x - c) / sigma) * ((x - c) / sigma));
                    break;
                case BoundaryTypeEnum.RIGHT:
                    if (x >= c) res = 1;
                    else res = Math.Exp(-((x - c) / sigma) * ((x - c) / sigma));
                    break;
                case BoundaryTypeEnum.MIDDLE:
                    res = Math.Exp(-((x - c) / sigma) * ((x - c) / sigma));
                    break;
                default:
                    res = Math.Exp(-((x - c) / sigma) * ((x - c) / sigma));
                    break;
            }
            return res;
        }

        public static bool DrawGaussPoints(Panel panel, int mouseX, int mouseY, double c, double sigma, double Xbottom, double Xtop, BoundaryTypeEnum bound)
        {
            bool res = false;

            double xX = c;
            double yY = GaussMF(c, c, sigma, bound);
            
            var w = panel.Width;
            var h = panel.Height;
            var gx = 0.1f * w;
            var gw = 0.8f * w;
            var gy = 0.1f * h;
            var gh = 0.7f * h;

            var k = (Xtop - Xbottom) / gw;
            var nul = (float)(Xbottom / k);

            var xE = /*(int)Math.Round(*/xX / k - nul + gx;//);
            var yE = /*(int)Math.Round(*/gy + (1 - yY) * gh;//);


            var area = panel.CreateGraphics();

            Pen pen = new Pen(Color.Black, 2);

            area.DrawLine(pen, (float)xE - 2, (float)yE, (float)(xE + 2), (float)yE);
            area.DrawLine(pen, (float)xE, (float)yE - 2, (float)xE, (float)(yE + 2));

            var l = Math.Sqrt((mouseX - xE) * (mouseX - xE) + (mouseY - yE) * (mouseY - yE));

            var r = 10 * (Math.PI / 2 - Math.Atan(l));
            area.DrawEllipse(pen, new Rectangle((int)(xE - r), (int)(yE - r), (int)(2 * r), (int)(2 * r)));

            return res;
        }

        public static void DrawTrianglMF(Panel panel, 
            Color color, 
            double a, 
            double b, 
            double c,
            double Xbottom,
            double Xtop,
            BoundaryTypeEnum bound)
        {
            Pen pen = new Pen(color, 2);

            var w = panel.Width;
            var h = panel.Height;
            var gx = 0.1f * w;
            var gw = 0.8f * w;
            var gy = 0.1f * h;
            var gh = 0.7f * h;

            var k = (Xtop - Xbottom) / gw;
            
            var area = panel.CreateGraphics();

            var nul = (float)(Xbottom / k);

            float yBottom = (float)TriangularMF(Xbottom, a, b, c, bound);
            float yA = (float)TriangularMF(a, a, b, c, bound);
            float yB = (float)TriangularMF(b, a, b, c, bound);
            float yC = (float)TriangularMF(c, a, b, c, bound);
            float yTop = (float)TriangularMF(Xtop, a, b, c, bound);

            if (a >= Xbottom)
            {
                var bottom = (float)(Xbottom / k - nul + gx);
                var top = (float)(a / k - nul + gx);
                area.DrawLine(pen,
                        bottom,
                        gy + (1 - yBottom) * gh,
                        top,
                        gy + (1 - yA) * gh);
                
            }
           
            if (c <= Xtop) 
            {
                var bottom = (float)(c / k - nul + gx);
                var top = (float)(Xtop / k - nul + gx);
                area.DrawLine(pen,
                        bottom,
                        gy + (1 - yC) * gh,
                        top,
                        gy + (1 - yTop) * gh);
                
            }
            
            area.DrawLine(pen,
                    (float)(a / k - nul + gx),
                    gy + (1 - yA) * gh,
                    (float)(b / k - nul + gx),
                    gy + (1 - yB) * gh);

            area.DrawLine(pen,
                    (float)(b / k - nul + gx),
                    gy + (1 - yB) * gh,
                    (float)(c / k - nul + gx),
                    gy + (1 - yC) * gh);
            
        }

        public static double TriangularMF(double x, double a, double b, double c, BoundaryTypeEnum bound)
        {
            double res = 0;
            switch (bound)
            {
                case BoundaryTypeEnum.LEFT:
                    if ((x > b) && (x < c))
                    {
                        res = 1.0d - (x - b) / (c - b);
                    }
                    if (x <= b) res = 1;
                    break;
                case BoundaryTypeEnum.RIGHT:
                    if ((x > a) && (x < b))
                    {
                        res = 1.0d - (b - x) / (b - a);
                    }
                    if (x >= b) res = 1;
                    break;
                case BoundaryTypeEnum.MIDDLE:
                    if ((x > a) && (x < b))
                    {
                        res = 1.0d - (b - x) / (b - a);
                    }
                    if ((x > b) && (x < c))
                    {
                        res = 1.0d - (x - b) / (c - b);
                    }
                    if (x == b) res = 1;
                    break;
                default:
                    if ((x > a) && (x < b))
                    {
                        res = 1.0d - (b - x) / (b - a);
                    }
                    if ((x > b) && (x < c))
                    {
                        res = 1.0d - (x - b) / (c - b);
                    }
                    if (x == b) res = 1;
                    break;
            }
            
            return res;
        }

        public static void DrawTrapezMF(Panel panel,
            Color color,
            double a,
            double b,
            double c,
            double d,
            double Xbottom,
            double Xtop,
            BoundaryTypeEnum bound)
        {
            Pen pen = new Pen(color, 2);

            var w = panel.Width;
            var h = panel.Height;
            var gx = 0.1f * w;
            var gw = 0.8f * w;
            var gy = 0.1f * h;
            var gh = 0.7f * h;

            var k = (Xtop - Xbottom) / gw;

            var area = panel.CreateGraphics();

            var nul = (float)(Xbottom / k);

            float yBottom = (float)TrapezoidalMF(Xbottom, a, b, c, d, bound);
            float yA = (float)TrapezoidalMF(a, a, b, c, d, bound);
            float yB = (float)TrapezoidalMF(b, a, b, c, d, bound);
            float yC = (float)TrapezoidalMF(c, a, b, c, d, bound);
            float yD = (float)TrapezoidalMF(d, a, b, c, d, bound);
            float yTop = (float)TrapezoidalMF(Xtop, a, b, c, d, bound);

            if (a >= Xbottom)
            {
                area.DrawLine(pen,
                        (float)(Xbottom / k - nul + gx),
                        gy + (1 - yBottom) * gh,
                        (float)(a / k - nul + gx),
                        gy + (1 - yA) * gh);
            }

            if (d <= Xtop)
            {
                area.DrawLine(pen,
                        (float)(d / k - nul + gx),
                        gy + (1 - yD) * gh,
                        (float)(Xtop / k - nul + gx),
                        gy + (1 - yTop) * gh);

            }

            area.DrawLine(pen,
                    (float)(a / k - nul + gx),
                    gy + (1 - yA) * gh,
                    (float)(b / k - nul + gx),
                    gy + (1 - yB) * gh);
            
            area.DrawLine(pen,
                (float)(b / k - nul + gx),
                gy + (1 - yB) * gh,
                (float)(c / k - nul + gx),
                gy + (1 - yC) * gh);

            area.DrawLine(pen,
                (float)(c / k - nul + gx),
                gy + (1 - yC) * gh,
                (float)(d / k - nul + gx),
                gy + (1 - yD) * gh);
        }

        public static double TrapezoidalMF(double x, double a, double b, double c, double d, BoundaryTypeEnum bound)
        {
            double res = 0;
            switch (bound)
            {
                case BoundaryTypeEnum.LEFT:
                    if (x <= c)
                    {
                        res = 1;
                    }

                    if ((x > c) && (x < d))
                    {
                        res = 1.0d - (x - c) / (d - c);
                    }
                    break;
                case BoundaryTypeEnum.RIGHT:
                    if ((x > a) && (x < b))
                    {
                        res = 1.0d - (b - x) / (b - a);
                    }

                    if (x >= b)
                    {
                        res = 1;
                    }
                    break;
                case BoundaryTypeEnum.MIDDLE:
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
                    break;
                default:
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
                    break;
            }
            
            return res;
        }

    }
}
