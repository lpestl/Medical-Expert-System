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
        public static void PaintGrid(Graphics area, int w, int h)
        {
            Pen pen_black = new Pen(Color.FromArgb(255, 0, 0, 0));
            
            //area.Clear(panel.BackColor);

            //var w = panel.Width;
            //var h = panel.Height;
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

            for (var i = gy; i < gy + gh; i += step_lines)
            {
                area.DrawLine(pen_gray, gx, gy * 2 + gh - i, gx + gw, gy * 2 + gh - i);
            }

            for (var i = gx; i < gx + gw; i += step_lines)
            {
                area.DrawLine(pen_gray, i, gy, i, gy + gh);
            }
        }

        public static void DrawBottomScale(Graphics area, int w, int h, double Xbottom, double Xtop, bool show = true)
        {
            //var w = panel.Width;
            //var h = panel.Height;
            var gx = 0.1f * w;
            var gw = 0.8f * w;
            var gy = 0.1f * h;
            var gh = 0.7f * h;

            if (Xtop <= Xbottom)
            {
                MessageBox.Show("Неправильно введены значения по шкале X. Справа число должно быть больше чем слева.", "Проверьте введенные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!show) return;

            var length_line = Xtop - Xbottom;
            var Xstep = gw;
            var step_lines = Xstep * length_line / gw;
            do
            {
                Xstep /= 2;
                step_lines = Xstep * length_line / gw;
            } while (!(Xstep < 100));
            
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

        public static void DrawGaussMF(Graphics area, int w, int h, 
            Color color, 
            double c, 
            double sigma, 
            double Xbottom, 
            double Xtop,
            BoundaryTypeEnum bound,
            QuantifierEnum quantEnum = QuantifierEnum.EMPTY)
        {
            Pen pen = new Pen(color, 2);

            //var w = panel.Width;
            //var h = panel.Height;
            var gx = 0.1f * w;
            var gw = 0.8f * w;
            var gy = 0.1f * h;
            var gh = 0.7f * h;

            var k = (Xtop - Xbottom) / gw;

            double xLast = Xbottom;
            double yLast;// = MFunc.GaussMF(xLast, c, sigma, bound);

            switch (quantEnum)
            {
                case QuantifierEnum.NOT:
                    yLast = 1 - MFunc.GaussMF(xLast, c, sigma, bound);
                    break;
                case QuantifierEnum.VERY:
                    yLast = Math.Pow(MFunc.GaussMF(xLast, c, sigma, bound), 2);
                    break;
                case QuantifierEnum.MORE_OR_LESS:
                    yLast = Math.Sqrt(MFunc.GaussMF(xLast, c, sigma, bound));
                    break;
                default:
                    yLast = MFunc.GaussMF(xLast, c, sigma, bound);
                    break;

            }

            double y;
            for (int i = 1; i <= gw; i++)
            {
                double x = Xbottom + k * i;
                switch (quantEnum)
                {
                    case QuantifierEnum.NOT:
                        y = 1- MFunc.GaussMF(x, c, sigma, bound);
                        break;
                    case QuantifierEnum.VERY:
                        y = Math.Pow(MFunc.GaussMF(x, c, sigma, bound), 2);
                        break;
                    case QuantifierEnum.MORE_OR_LESS:
                        y = Math.Sqrt(MFunc.GaussMF(x, c, sigma, bound));
                        break;
                    default:
                        y = MFunc.GaussMF(x, c, sigma, bound);
                        break;

                }
                area.DrawLine(pen,
                    (float)gx + i - 1,
                    (float)(gy + (1 - yLast) * gh),
                    (float)gx + i,
                    (float)(gy + (1 - y) * gh));

                xLast = x;
                yLast = y;
            }

        }

        public static void DrawGaussPoints(Graphics area, int w, int h, 
            string nameFuzzy,
            Color colorLine,
            double c, 
            double sigma, 
            double Xbottom, 
            double Xtop, 
            BoundaryTypeEnum bound,
            int i=0)
        {
            double xX = c;
            double yY = MFunc.GaussMF(c, c, sigma, bound);

            var PointConv = ConvertToScreen(xX, yY, w, h, Xbottom, Xtop);
            var xE = PointConv.X;
            var yE = PointConv.Y;

            var PointNull = ConvertToScreen(xX, -0.05, w, h, Xbottom, Xtop);

            Pen pen = new Pen(Color.Black, 2);

            area.DrawLine(pen, (float)xE - 2, (float)yE, (float)(xE + 2), (float)yE);
            area.DrawLine(pen, (float)xE, (float)yE - 2, (float)xE, (float)(yE + 2));

            Pen pen_gray = new Pen(Color.Gray);
            pen_gray.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            area.DrawLine(pen_gray, xE, yE, PointNull.X, PointNull.Y);

            // Create font and brush.
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            drawFormat.LineAlignment = StringAlignment.Near;
            String txt = (xX).ToString();
            PointF drawPoint = new PointF(PointNull.X, PointNull.Y);

            area.DrawString(txt, drawFont, drawBrush, drawPoint, drawFormat);

            SolidBrush drawBrushName = new SolidBrush(colorLine);
            drawFormat.Alignment = StringAlignment.Center;
            drawFormat.LineAlignment = StringAlignment.Far;
            txt = nameFuzzy;
            if (i % 2 == 0) PointNull = ConvertToScreen(xX, yY + 0.01, w, h, Xbottom, Xtop);
            else PointNull = ConvertToScreen(xX, yY + 0.06, w, h, Xbottom, Xtop);
            drawPoint = new PointF(PointNull.X, PointNull.Y);

            area.DrawString(txt, drawFont, drawBrushName, drawPoint, drawFormat);
        }

        public static Point ConvertToScreen(double x, double y, int w, int h, double Xbottom, double Xtop)
        {
            Point res = new Point(-1, -1);

            var gx = 0.1f * w;
            var gw = 0.8f * w;
            var gy = 0.1f * h;
            var gh = 0.7f * h;

            var k = (Xtop - Xbottom) / gw;
            var nul = (float)(Xbottom / k);

            res.X = (int)(x / k - nul + gx);
            res.Y = (int)(gy + (1 - y) * gh);

            return res;
        }

        public static void DrawTrianglMF(Graphics area, int w, int h, 
            Color color, 
            double a, 
            double b, 
            double c,
            double Xbottom,
            double Xtop,
            BoundaryTypeEnum bound,
            QuantifierEnum quantEnum = QuantifierEnum.EMPTY)
        {
            Pen pen = new Pen(color, 2);

            //var w = panel.Width;
            //var h = panel.Height;
            var gx = 0.1f * w;
            var gw = 0.8f * w;
            var gy = 0.1f * h;
            var gh = 0.7f * h;

            var k = (Xtop - Xbottom) / gw;
            
            var nul = (float)(Xbottom / k);

            //float yBottom = (float)MFunc.TriangularMF(Xbottom, a, b, c, bound);
            //float yA = (float)MFunc.TriangularMF(a, a, b, c, bound);
            //float yB = (float)MFunc.TriangularMF(b, a, b, c, bound);
            //float yC = (float)MFunc.TriangularMF(c, a, b, c, bound);
            //float yTop = (float)MFunc.TriangularMF(Xtop, a, b, c, bound);
            float yBottom, yTop, yA, yB, yC;

            switch (quantEnum)
            {
                case QuantifierEnum.NOT:
                    yBottom = 1.0f - (float)MFunc.TriangularMF(Xbottom, a, b, c, bound);
                    yA = 1.0f - (float)MFunc.TriangularMF(a, a, b, c, bound);
                    yB = 1.0f - (float)MFunc.TriangularMF(b, a, b, c, bound);
                    yC = 1.0f - (float)MFunc.TriangularMF(c, a, b, c, bound);
                    yTop = 1.0f - (float)MFunc.TriangularMF(Xtop, a, b, c, bound);
                    break;
                case QuantifierEnum.VERY:
                    yBottom = (float)Math.Pow(MFunc.TriangularMF(Xbottom, a, b, c, bound),2);
                    yA = (float)Math.Pow(MFunc.TriangularMF(a, a, b, c, bound), 2);
                    yB = (float)Math.Pow(MFunc.TriangularMF(b, a, b, c, bound), 2);
                    yC = (float)Math.Pow(MFunc.TriangularMF(c, a, b, c, bound), 2);
                    yTop = (float)Math.Pow(MFunc.TriangularMF(Xtop, a, b, c, bound), 2);
                    break;
                case QuantifierEnum.MORE_OR_LESS:
                    yBottom = (float)Math.Sqrt(MFunc.TriangularMF(Xbottom, a, b, c, bound));
                    yA = (float)Math.Sqrt(MFunc.TriangularMF(a, a, b, c, bound));
                    yB = (float)Math.Sqrt(MFunc.TriangularMF(b, a, b, c, bound));
                    yC = (float)Math.Sqrt(MFunc.TriangularMF(c, a, b, c, bound));
                    yTop = (float)Math.Sqrt(MFunc.TriangularMF(Xtop, a, b, c, bound));
                    break;
                default:
                    yBottom = (float)MFunc.TriangularMF(Xbottom, a, b, c, bound);
                    yA = (float)MFunc.TriangularMF(a, a, b, c, bound);
                    yB = (float)MFunc.TriangularMF(b, a, b, c, bound);
                    yC = (float)MFunc.TriangularMF(c, a, b, c, bound);
                    yTop = (float)MFunc.TriangularMF(Xtop, a, b, c, bound);
                    break;

            }

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

        public static void DrawTrianglPoints(Graphics area, int w, int h,
            string nameFuzzy,
            Color colorLine,
            double a,
            double b,
            double c,
            double Xbottom,
            double Xtop,
            BoundaryTypeEnum bound,
            bool trapez = false,
            int i = 0)
        {
            var yA = MFunc.TriangularMF(a, a, b, c, bound);
            var yB = MFunc.TriangularMF(b, a, b, c, bound);
            double yC;
            if (!trapez) yC = MFunc.TriangularMF(c, a, b, c, bound);
            else yC = MFunc.TrapezoidalMF(c, a, b, c, c + 1, bound);

            var pointA = ConvertToScreen(a, yA, w, h, Xbottom, Xtop);
            var pointB = ConvertToScreen(b, yB, w, h, Xbottom, Xtop);
            var pointC = ConvertToScreen(c, yC, w, h, Xbottom, Xtop);

            Pen pen = new Pen(Color.Black, 2);

            if (bound != BoundaryTypeEnum.LEFT)
            {
                area.DrawLine(pen, (float)(pointA.X - 2), (float)pointA.Y, (float)(pointA.X + 2), (float)pointA.Y);
                area.DrawLine(pen, (float)pointA.X, (float)pointA.Y - 2, (float)pointA.X, (float)(pointA.Y + 2));
            }

            if ((!trapez) || (bound != BoundaryTypeEnum.LEFT))
            {
                area.DrawLine(pen, (float)(pointB.X - 2), (float)pointB.Y, (float)(pointB.X + 2), (float)pointB.Y);
                area.DrawLine(pen, (float)pointB.X, (float)pointB.Y - 2, (float)pointB.X, (float)(pointB.Y + 2));
            }

            if (bound != BoundaryTypeEnum.RIGHT)
            {
                area.DrawLine(pen, (float)(pointC.X - 2), (float)pointC.Y, (float)(pointC.X + 2), (float)pointC.Y);
                area.DrawLine(pen, (float)pointC.X, (float)pointC.Y - 2, (float)pointC.X, (float)(pointC.Y + 2));
            }

            Pen pen_gray = new Pen(Color.Gray);
            pen_gray.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            var PointNullA = ConvertToScreen(a, -0.05, w, h, Xbottom, Xtop);
            if (bound != BoundaryTypeEnum.LEFT) area.DrawLine(pen_gray, pointA.X, pointA.Y, PointNullA.X, PointNullA.Y);

            var PointNullB = ConvertToScreen(b, -0.05, w, h, Xbottom, Xtop);
            if ((!trapez) || (bound != BoundaryTypeEnum.LEFT))
            {
                area.DrawLine(pen_gray, pointB.X, pointB.Y, PointNullB.X, PointNullB.Y);
            }
            
            var PointNullC = ConvertToScreen(c, -0.05, w, h, Xbottom, Xtop);
            if (bound != BoundaryTypeEnum.RIGHT) area.DrawLine(pen_gray, pointC.X, pointC.Y, PointNullC.X, PointNullC.Y);

            // Create font and brush.
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            drawFormat.LineAlignment = StringAlignment.Near;

            String txt = (a).ToString();
            PointF drawPoint = new PointF(PointNullA.X, PointNullA.Y);
            if (bound != BoundaryTypeEnum.LEFT) area.DrawString(txt, drawFont, drawBrush, drawPoint, drawFormat);

            txt = (b).ToString();
            drawPoint = new PointF(PointNullB.X, PointNullB.Y);
            if ((!trapez) || (bound != BoundaryTypeEnum.LEFT))
            {
                area.DrawString(txt, drawFont, drawBrush, drawPoint, drawFormat);
            }

            txt = (c).ToString();
            drawPoint = new PointF(PointNullC.X, PointNullC.Y);
            if (bound != BoundaryTypeEnum.RIGHT) area.DrawString(txt, drawFont, drawBrush, drawPoint, drawFormat);
            
            SolidBrush drawBrushName = new SolidBrush(colorLine);
            drawFormat.Alignment = StringAlignment.Center;
            drawFormat.LineAlignment = StringAlignment.Far;

            txt = nameFuzzy;
            Point PointNull;
            if (i % 2 == 0)
            {
                if (!trapez) PointNull = ConvertToScreen(b, yB + 0.01, w, h, Xbottom, Xtop);
                else PointNull = ConvertToScreen((c - b) / 2 + b, yB + 0.01, w, h, Xbottom, Xtop);
            } else
            {
                if (!trapez) PointNull = ConvertToScreen(b, yB + 0.06, w, h, Xbottom, Xtop);
                else PointNull = ConvertToScreen((c - b) / 2 + b, yB + 0.06, w, h, Xbottom, Xtop);
            }
            drawPoint = new PointF(PointNull.X, PointNull.Y);

            area.DrawString(txt, drawFont, drawBrushName, drawPoint, drawFormat);
        }

        public static void DrawTrapezMF(Graphics area, int w, int h,
            Color color,
            double a,
            double b,
            double c,
            double d,
            double Xbottom,
            double Xtop,
            BoundaryTypeEnum bound,
            QuantifierEnum quantEnum = QuantifierEnum.EMPTY)
        {
            Pen pen = new Pen(color, 2);

            //var w = panel.Width;
            //var h = panel.Height;
            var gx = 0.1f * w;
            var gw = 0.8f * w;
            var gy = 0.1f * h;
            var gh = 0.7f * h;

            var k = (Xtop - Xbottom) / gw;
            
            var nul = (float)(Xbottom / k);

            //float yBottom = (float)MFunc.TrapezoidalMF(Xbottom, a, b, c, d, bound);
            //float yA = (float)MFunc.TrapezoidalMF(a, a, b, c, d, bound);
            //float yB = (float)MFunc.TrapezoidalMF(b, a, b, c, d, bound);
            //float yC = (float)MFunc.TrapezoidalMF(c, a, b, c, d, bound);
            //float yD = (float)MFunc.TrapezoidalMF(d, a, b, c, d, bound);
            //float yTop = (float)MFunc.TrapezoidalMF(Xtop, a, b, c, d, bound);
            float yBottom, yA, yB, yC, yD, yTop;

            switch (quantEnum)
            {
                case QuantifierEnum.NOT:
                    yBottom = 1.0f - (float)MFunc.TrapezoidalMF(Xbottom, a, b, c, d, bound);
                    yA = 1.0f - (float)MFunc.TrapezoidalMF(a, a, b, c, d, bound);
                    yB = 1.0f - (float)MFunc.TrapezoidalMF(b, a, b, c, d, bound);
                    yC = 1.0f - (float)MFunc.TrapezoidalMF(c, a, b, c, d, bound);
                    yD = 1.0f - (float)MFunc.TrapezoidalMF(d, a, b, c, d, bound);
                    yTop = 1.0f - (float)MFunc.TrapezoidalMF(Xtop, a, b, c, d, bound);
                    break;
                case QuantifierEnum.VERY:
                    yBottom = (float)Math.Pow(MFunc.TrapezoidalMF(Xbottom, a, b, c, d, bound), 2);
                    yA = (float)Math.Pow(MFunc.TrapezoidalMF(a, a, b, c, d, bound), 2);
                    yB = (float)Math.Pow(MFunc.TrapezoidalMF(b, a, b, c, d, bound), 2);
                    yC = (float)Math.Pow(MFunc.TrapezoidalMF(c, a, b, c, d, bound), 2);
                    yD = (float)Math.Pow(MFunc.TrapezoidalMF(d, a, b, c, d, bound), 2);
                    yTop = (float)Math.Pow(MFunc.TrapezoidalMF(Xtop, a, b, c, d, bound), 2);
                    break;
                case QuantifierEnum.MORE_OR_LESS:
                    yBottom = (float)Math.Sqrt(MFunc.TrapezoidalMF(Xbottom, a, b, c, d, bound));
                    yA = (float)Math.Sqrt(MFunc.TrapezoidalMF(a, a, b, c, d, bound));
                    yB = (float)Math.Sqrt(MFunc.TrapezoidalMF(b, a, b, c, d, bound));
                    yC = (float)Math.Sqrt(MFunc.TrapezoidalMF(c, a, b, c, d, bound));
                    yD = (float)Math.Sqrt(MFunc.TrapezoidalMF(d, a, b, c, d, bound));
                    yTop = (float)Math.Sqrt(MFunc.TrapezoidalMF(Xtop, a, b, c, d, bound));
                    break;
                default:
                    yBottom = (float)MFunc.TrapezoidalMF(Xbottom, a, b, c, d, bound);
                    yA = (float)MFunc.TrapezoidalMF(a, a, b, c, d, bound);
                    yB = (float)MFunc.TrapezoidalMF(b, a, b, c, d, bound);
                    yC = (float)MFunc.TrapezoidalMF(c, a, b, c, d, bound);
                    yD = (float)MFunc.TrapezoidalMF(d, a, b, c, d, bound);
                    yTop = (float)MFunc.TrapezoidalMF(Xtop, a, b, c, d, bound);
                    break;
            }

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

        public static void DrawTrapezoidalPoints(Graphics area, int w, int h,
            string nameFuzzy,
            Color colorLine,
            double a,
            double b,
            double c,
            double d,
            double Xbottom,
            double Xtop,
            BoundaryTypeEnum bound,
            int i = 0)
        {
            DrawTrianglPoints(area, w, h,
                nameFuzzy,
                colorLine,
                a,
                b,
                c,
                Xbottom,
                Xtop,
                bound, true, i);

            var yD = MFunc.TrapezoidalMF(d, a, b, c, d, bound);
            var pointD = ConvertToScreen(d, yD, w, h, Xbottom, Xtop);

            Pen pen = new Pen(Color.Black, 2);

            if (bound != BoundaryTypeEnum.RIGHT)
            {
                area.DrawLine(pen, (float)(pointD.X - 2), (float)pointD.Y, (float)(pointD.X + 2), (float)pointD.Y);
                area.DrawLine(pen, (float)pointD.X, (float)pointD.Y - 2, (float)pointD.X, (float)(pointD.Y + 2));
            }

            Pen pen_gray = new Pen(Color.Gray);
            pen_gray.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            var PointNullD = ConvertToScreen(d, -0.05, w, h, Xbottom, Xtop);
            if (bound != BoundaryTypeEnum.RIGHT) area.DrawLine(pen_gray, pointD.X, pointD.Y, PointNullD.X, PointNullD.Y);

            // Create font and brush.
            Font drawFont = new Font("Arial", 10);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            drawFormat.LineAlignment = StringAlignment.Near;

            var txt = (d).ToString();
            var drawPoint = new PointF(PointNullD.X, PointNullD.Y);
            if (bound != BoundaryTypeEnum.RIGHT) area.DrawString(txt, drawFont, drawBrush, drawPoint, drawFormat);

        }

    }
}
