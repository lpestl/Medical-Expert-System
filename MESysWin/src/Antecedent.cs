using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    public class Antecedent
    {
        public long ID { get; set; }

        public Symptom LinguisticVariable { get; set; }

        public FuzzyVariable FuzzyVar { get; set; }

        public Quantifier Quant { get; set; }

        public string Preview { get; set; }

        public Antecedent()
        {
            ID = -1;

            Preview = "!NOT SET!";

            LinguisticVariable = null;
            FuzzyVar = null;
            Quant = null;
            //var qList = DatabaseManager.Instance.GetQuantifiers();
            //Quant = qList.Find(x => x.ID == 0);
        }

        public string LastTrouble { get; set; }
        public bool CheckData()
        {
            if (LinguisticVariable == null)
            {
                LastTrouble = "Linguistic Variable is null";
                return false;
            }

            if (LinguisticVariable.ID == -1)
            {
                LastTrouble = "Linguistic Variable not exist";
                return false;
            }

            if (FuzzyVar == null)
            {
                LastTrouble = "Fuzzy Variable is null";
                return false;
            }

            if (FuzzyVar.ID == -1)
            {
                LastTrouble = "Fuzzy variable is not exist";
                return false;
            }

            if (Quant == null)
            {
                LastTrouble = "Quntificator is null";
                return false;
            }

            if (Quant.ID == -1)
            {
                LastTrouble = "Quantificator not exist";
                return false;
            }

            return true;
        }
    }
}
