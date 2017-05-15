using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
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
