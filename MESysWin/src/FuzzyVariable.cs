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
        public long ID { get; set; }

        public long IdSymptom { get; set; }

        public string Name { get; set; }

        public TypeMFuncEnum Type { get; set; }

        public long IdTriangulare { get; set; }

        public long IdTrapezoidal { get; set; }

        public long IdGaussian { get; set; }

        public Color Color { get; set; }

        public FuzzyVariable(long id_symp, string name, Color color)
        {
            IdSymptom = id_symp;
            Name = name;
        }
    }
}
