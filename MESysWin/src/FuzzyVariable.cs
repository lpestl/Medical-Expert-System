using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    public class FuzzyVariable
    {
        public long ID { get; set; }

        public long IdSymptom { get; set; }

        public string Name { get; set; }

        public TypeMFuncEnum Type { get; set; }

        public BoundaryTypeEnum Bound { get; set; }

        //public long IdTriangulare { get; set; }
        public GaussMFuncParams GaussParam { get; set; }

        //public long IdTrapezoidal { get; set; }
        public TriangulareMFuncParams TrianglParam { get; set; }

        //public long IdGaussian { get; set; }
        public TrapezoidalMFuncParams TrapezParam { get; set; }

        public Color ColorLine { get; set; }

        public void Set(FuzzyVariable fv)
        {
            ID = fv.ID;
            IdSymptom = fv.IdSymptom;
            Name = fv.Name;
            Type = fv.Type;
            Bound = fv.Bound;
            GaussParam = fv.GaussParam;
            TrianglParam = fv.TrianglParam;
            TrapezParam = fv.TrapezParam;
            ColorLine = fv.ColorLine;
        }

        public FuzzyVariable(long id, long id_symp, string name, Color color)
        {
            ID = id;
            IdSymptom = id_symp;
            Name = name;
            ColorLine = color;

            GaussParam = new GaussMFuncParams(0, 0);
            TrianglParam = new TriangulareMFuncParams(0, 0, 0);
            TrapezParam = new TrapezoidalMFuncParams(0, 0, 0, 0);
            GaussParam.ID = TrianglParam.ID = TrapezParam.ID = -1;
        }

        public string LastTrouble { get; set; }
        public bool CheckData()
        {
            if (Name == null)
            {
                LastTrouble = "Name == null";
                return false;
            }

            if (Name.Length == 0)
            {
                LastTrouble = "Name is empty";
                return false;
            }

            if (IdSymptom < 0)
            {
                LastTrouble = "Parent symptom not exist";
                return false;
            }

            if (((int)Type < 0) || ((int)Type >= 3))
            {
                LastTrouble = "Type MFunc not exist";
                return false;
            }

            /*switch (Type)
            {
                case TypeMFuncEnum.GAUSS:
                    if (IdGaussian < 0)
                    {
                        LastTrouble = "A Gaussian membership function is not defined.";
                        return false;
                    }
                    break;
                case TypeMFuncEnum.TRIANGULARE:
                    if (IdTriangulare < 0)
                    {
                        LastTrouble = "The triangular membership function is not defined.";
                        return false;
                    }
                    break;
                case TypeMFuncEnum.TRAPEZOIDAL:
                    if (IdTrapezoidal < 0)
                    {
                        LastTrouble = "The trapezoid membership function is not defined.";
                        return false;
                    }
                    break;
                default:
                    LastTrouble = "The membership function type is not defined.";
                    return false;
                    //break;
            }*/

            return true;
        }
    }
}
