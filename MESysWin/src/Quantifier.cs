using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    public enum QuantifierEnum { EMPTY, NOT, VERY, MORE_OR_LESS }

    public class Quantifier
    {
        public long ID { get; set; }

        public string Name { get; set; }

        public string Rule { get; set; }

        public QuantifierEnum QuantEnumRule { get; set; }

        public Quantifier(string name, QuantifierEnum enumVal)
        {
            ID = -1;
            Rule = String.Empty;
            QuantEnumRule = enumVal;

            Name = name;
        }
    }
}
