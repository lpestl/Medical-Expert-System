using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    class FuzzyVariable
    {
        public int ID { get; set; }

        public int IdSymptom { get; set; }

        public string Name { get; set; }

        public TypeMFuncEnum Type { get; set; }

        public int IdTriangulare { get; set; }

        public int IdTrapezoidal { get; set; }

        public int IdGaussian { get; set; }

        public Color Color { get; set; }

        public FuzzyVariable(int id_symp, string name, Color color)
        {
            IdSymptom = id_symp;
            Name = name;
        }
    }
}
