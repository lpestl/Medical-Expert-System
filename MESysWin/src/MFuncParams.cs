using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    public class MFunc
    {
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

    public class GaussMFuncParams
    {
        public long ID { get; set; }
        public double C { get; set; }
        public double Sigma { get; set; }
        
        public GaussMFuncParams(double c, double sigma)
        {
            ID = -1;
            C = c;
            Sigma = sigma;
        }
    }

    public class TriangulareMFuncParams
    {
        public long ID { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public TriangulareMFuncParams(double a, double b, double c)
        {
            ID = -1;
            A = a; B = b; C = c;
        }
    }

    public class TrapezoidalMFuncParams
    {
        public long ID { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }

        public TrapezoidalMFuncParams(double a, double b, double c, double d)
        {
            ID = -1;
            A = a; B = b; C = c; D = d;
        }
    }
}
