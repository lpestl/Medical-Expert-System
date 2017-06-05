using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    public class Rule
    {
        public long ID { get; set; }

        //public long IdDiagnosis { get; set; }
        public Diagnosis Conclusion { get; set; }

        public string Preview { get; set; }

        public Rule()
        {
            ID = -1;
            Conclusion = new Diagnosis();
            Preview = "ЕСЛИ ___ ТО это ___";
        }
    }
}
