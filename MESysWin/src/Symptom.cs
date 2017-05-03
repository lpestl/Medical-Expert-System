using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    public class Symptom
    {
        //private int _id;
        public long ID { get; set; }

        //private string _name;
        public string Name { get; set; }

        //private double _reasoning_bottom;
        public double ReasoningBottom { get; set; }
        //private double _reasoning_top;
        public double ReasoningTop { get; set; }

        public Symptom(long id, string name, double bottom, double top)
        {
            ID = id;
            Name = name;
            ReasoningBottom = bottom;
            ReasoningTop = top;
        }

        public string LastTrouble { get; set; }
        public bool CheckData()
        {
            if (Name == null)
            {
                LastTrouble = "Name == null";
                return false;
            }

            if (Name.Length == 0) {
                LastTrouble = "Name is empty";
                return false;
            }

            if (ReasoningBottom >= ReasoningTop)
            {
                LastTrouble = "Bottom must be < Top";
                return false;
            }

            return true;
        }
    }
}
