using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    public class Diagnosis
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Symptoms { get; set; }

        public string Treatment { get; set; }

        public Diagnosis(string name)
        {
            ID = -1;
            Name = name;

            Treatment = Symptoms = Description = String.Empty;
        }

        public Diagnosis()
        {
            ID = -1;

            Name = Treatment = Symptoms = Description = String.Empty;
        }
    }
}
