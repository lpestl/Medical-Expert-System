using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESysWin.src
{
    public class Hipotez
    {
        public Diagnosis HipoteticDiagnosis { get; set; }
        public double Coincidence { get; set; }
    }

    public class Complaint
    {
        public Symptom CurrentSymptom { get; set; }
        public double Conf { get; set; }
        public List<FuzzyVariable> Fuzzy { get; set; }
        public List<double> MFnotFuzzy { get; set; }
        public double NotFuzzy { get; set; }

        public Complaint()
        {
            CurrentSymptom = null;
            Fuzzy = null;
            MFnotFuzzy = null;
        }
    }

    public class LogicOutput
    {
        private static LogicOutput instance;
        public static LogicOutput Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LogicOutput();
                    Log.Print("Create LogicOutput instance singletone", "LogicOutput", Log.type.INFO);
                }
                return instance;
            }
        }

        public List<Complaint> Complaints { get; set; }
        public List<Hipotez> Hipotezes { get; set; }

        public List<Hipotez> NeuroNetHipotez { get; set; }

        public List<Rule> Rulez { get; set; }
        public long numberQest;

        public enum Specified { NEW, SPEC_FUZZY, FUZZYFICATED, END, CONSILIUM, FAIL }
        private Specified state;
        public Specified State {
            get
            {
                return state;
            }
        }

        //private List<Symptom> wasSymptoms;
        private Complaint currentComplaint;
        public Complaint CurrentComplaint
        {
            get
            {
                return currentComplaint;
            }
        }

        private LogicOutput()
        {
            Initialization();
        }

        public void Initialization()
        {
            Complaints = new List<Complaint>();
            Hipotezes = new List<Hipotez>();
            NeuroNetHipotez = new List<Hipotez>();
            //wasSymptoms = new List<Symptom>();

            Rulez = DatabaseManager.Instance.GetRuleList();

            foreach (var r in Rulez)
            {
                r.complaints = DatabaseManager.Instance.GetAntecedentsInRule(r);
            }

            numberQest = 1;

            state = Specified.END;
            currentComplaint = null;
        }

        private bool CheckSymptomList(Symptom ant)
        {
            bool res = false;

            foreach (var symp in Complaints)
            {
                if (ant.ID == symp.CurrentSymptom.ID)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }

        public string GetQuestion()
        {
            string question = "";

            switch (state)
            {
                case Specified.NEW:
                    bool stop = false;
                    foreach (var rule in Rulez)
                    {
                        foreach(var ant in rule.complaints)
                        {
                            if (!CheckSymptomList(ant.LinguisticVariable))
                            {
                                //wasSymptoms.Add(ant.LinguisticVariable);
                                currentComplaint = new Complaint();
                                currentComplaint.CurrentSymptom = ant.LinguisticVariable;
                                stop = true;
                                break;
                            }
                        }
                        if (stop) break;
                    }
                    if (stop) question = String.Format("{0}. У вас есть {1}?\r\n", numberQest, currentComplaint.CurrentSymptom.Name);
                    else
                    {
                        state = Specified.CONSILIUM;
                        question = GetQuestion();
                        question += "\r\nЕсли у вас остались еще жалобы, а экспертная система сообщила, что вопросов больше нет, значит \"База Знаний\" не полная. Обратитесь к врачу, " +
                            " а так же сообщите об этом разработчику программы, администратору и/или к инженеру по знаниям для того, чтобы они смогли пополнить Базу Знаний и улучшить программу.\r\n";
                    }
                    break;
                case Specified.SPEC_FUZZY:
                    question = String.Format("{0}. Какой(-ая, -ое) у вас {1} (", numberQest, currentComplaint.CurrentSymptom.Name);
                    currentComplaint.Fuzzy = DatabaseManager.Instance.GetFuzzyVariables(currentComplaint.CurrentSymptom.ID);
                    //foreach (var fuz in currentComplaint.Fuzzy)
                    for (int i=0; i<currentComplaint.Fuzzy.Count; i++) 
                    {
                        question += currentComplaint.Fuzzy[i].Name;
                        if (i != currentComplaint.Fuzzy.Count - 1)
                        {
                            question += ", ";
                        }
                    }
                    question += ") ?\r\n";
                    break;
                case Specified.FUZZYFICATED:
                    question = String.Format("{0}. Вы знаете точную величину? Или может быть вы сможете оценить ваш симптом \"{1}\" в диапазоне от {2} до {3}?\r\n", 
                        numberQest, 
                        currentComplaint.CurrentSymptom.Name, 
                        currentComplaint.CurrentSymptom.ReasoningBottom, 
                        currentComplaint.CurrentSymptom.ReasoningTop);
                    break;
                case Specified.END:
                    if (numberQest == 1)
                    {
                        question = String.Format("{0}. У вас есть жалобы?\r\n", numberQest);
                    } else
                    {                        
                        question = String.Format("{0}. У вас есть еще жалобы?\r\n", numberQest);
                    }
                    break;
                case Specified.CONSILIUM:
                    question = "Вопросов больше нет. Проверьте поле вывода \"Основная гипотеза\".\r\n" +
                        "Чтобы начать новую консультацию, выберете в меню пункт \"Консультация\" -> \"Диф.диагностика методом диалога\".\r\n";
                    break;
                default:
                    question = "В цепочке логического вывода и диф.диагностики методом диалога закралась какая-то ошибка. Обратитесь к разработчику ПО или попробуйте самостоятельно найти ошибку.\r\n" +
                        "Настоятельно рекомендуем проверить лог файл программы и проверить целостность всех правил в базе знаний.";
                    break;
            }
            numberQest++;

            return question;
        }

        public void SetAnswer(int answer_to_the_previous)
        {
            switch (state)
            {
                case Specified.NEW:
                    //checkedComplains.Add(currentAntecedent);
                    switch (answer_to_the_previous)
                    {
                        case 0:
                            currentComplaint.Conf = -1.0f;
                            break;
                        case 1:
                            currentComplaint.Conf = -0.5f;
                            break;
                        case 2:
                            currentComplaint.Conf = 0;
                            break;
                        case 3:
                            currentComplaint.Conf = 0.5f;
                            state = Specified.SPEC_FUZZY;
                            break;
                        case 4:
                            currentComplaint.Conf = 1.0f;
                            state = Specified.SPEC_FUZZY;
                            break;
                        default:
                            state = Specified.FAIL;
                            break;
                    }
                    Complaints.Add(currentComplaint);
                    UpdateHipotez();
                    break;
                case Specified.SPEC_FUZZY:
                    if (!((answer_to_the_previous >= 0) && (answer_to_the_previous < currentComplaint.Fuzzy.Count))) { state = Specified.FAIL; }
                    else
                    {
                        switch(currentComplaint.Fuzzy[answer_to_the_previous].Type)
                        {
                            case TypeMFuncEnum.GAUSS:
                                currentComplaint.Fuzzy[answer_to_the_previous].GaussParam = DatabaseManager.Instance.GetGaussMFuncParams(currentComplaint.Fuzzy[answer_to_the_previous].GaussParam.ID);
                                currentComplaint.NotFuzzy = currentComplaint.Fuzzy[answer_to_the_previous].GaussParam.C;
                                break;
                            case TypeMFuncEnum.TRIANGULARE:
                                currentComplaint.Fuzzy[answer_to_the_previous].TrianglParam = DatabaseManager.Instance.GetTriangulareMFuncParams(currentComplaint.Fuzzy[answer_to_the_previous].TrianglParam.ID);
                                currentComplaint.NotFuzzy = currentComplaint.Fuzzy[answer_to_the_previous].TrianglParam.B;
                                break;
                            case TypeMFuncEnum.TRAPEZOIDAL:
                                currentComplaint.Fuzzy[answer_to_the_previous].TrapezParam = DatabaseManager.Instance.GetTrapezoidalMFuncParams(currentComplaint.Fuzzy[answer_to_the_previous].TrapezParam.ID);
                                var nf = (currentComplaint.Fuzzy[answer_to_the_previous].TrapezParam.C - currentComplaint.Fuzzy[answer_to_the_previous].TrapezParam.B) / 2 + currentComplaint.Fuzzy[answer_to_the_previous].TrapezParam.B;
                                currentComplaint.NotFuzzy = nf;
                                break;
                            default:
                                currentComplaint.NotFuzzy = 0;
                                break;
                        }
                        currentComplaint.MFnotFuzzy = new List<double>();
                        UpdateFuzzyMF(currentComplaint.NotFuzzy);
                        UpdateCurrentComplaints();
                        UpdateHipotez();
                        state = Specified.FUZZYFICATED;
                    }
                    break;
                case Specified.FUZZYFICATED:
                    if (answer_to_the_previous == 4)
                    {
                        string msg = String.Format("Введите значение симптома в диапазоне от {0} до {1} :",
                            currentComplaint.CurrentSymptom.ReasoningBottom,
                            currentComplaint.CurrentSymptom.ReasoningTop);

                        string input = Microsoft.VisualBasic.Interaction.InputBox(msg,
                           currentComplaint.CurrentSymptom.Name,
                           currentComplaint.NotFuzzy.ToString(),
                           0,
                           0);

                        double x;
                        if (double.TryParse(input, out x))
                        {
                            currentComplaint.NotFuzzy = x;
                            UpdateFuzzyMF(currentComplaint.NotFuzzy);
                            UpdateCurrentComplaints();
                            UpdateHipotez();
                        }

                    }
                    state = Specified.END;
                    break;
                case Specified.END:
                    switch (answer_to_the_previous)
                    {
                        case 0:
                            state = Specified.CONSILIUM;
                            break;
                        case 4:
                            state = Specified.NEW;
                            break;
                        default:
                            state = Specified.FAIL;
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private void UpdateCurrentComplaints()
        {
            for (int i=0; i < Complaints.Count; i++)
            {
                if (Complaints[i].CurrentSymptom.ID == currentComplaint.CurrentSymptom.ID)
                {
                    Complaints[i] = currentComplaint;
                    break;
                }
            }
        }

        private void UpdateFuzzyMF(double notFuz)
        {
            //currentComplaint.MFnotFuzzy = new List<double>();
            foreach(var fuz in currentComplaint.Fuzzy)
            {
                double res = 0;
                switch (fuz.Type)
                {
                    case TypeMFuncEnum.GAUSS:
                        fuz.GaussParam = DatabaseManager.Instance.GetGaussMFuncParams(fuz.GaussParam.ID);
                        res = MFunc.GaussMF(notFuz, fuz.GaussParam.C, fuz.GaussParam.Sigma, fuz.Bound);
                        break;
                    case TypeMFuncEnum.TRIANGULARE:
                        fuz.TrianglParam = DatabaseManager.Instance.GetTriangulareMFuncParams(fuz.TrianglParam.ID);
                        res = MFunc.TriangularMF(notFuz, fuz.TrianglParam.A, fuz.TrianglParam.B, fuz.TrianglParam.C, fuz.Bound);
                        break;
                    case TypeMFuncEnum.TRAPEZOIDAL:
                        fuz.TrapezParam = DatabaseManager.Instance.GetTrapezoidalMFuncParams(fuz.TrapezParam.ID);
                        res = MFunc.TrapezoidalMF(notFuz, fuz.TrapezParam.A, fuz.TrapezParam.B, fuz.TrapezParam.C, fuz.TrapezParam.D, fuz.Bound);
                        break;
                    default:
                        res = 0;
                        break;
                }
                currentComplaint.MFnotFuzzy.Add(res);
            }
        }

        public void UpdateHipotez()
        {
            foreach (var hip in Hipotezes)
            {
                hip.Coincidence = 0;
            }
            foreach (var r in Rulez)
            {
                foreach (var ant in r.complaints)
                {
                    foreach (var c in Complaints)
                    {
                        if (c.CurrentSymptom.ID == ant.LinguisticVariable.ID)
                        {
                            if (c.Fuzzy == null)
                            {
                                Hipotez hip = Hipotezes.Find(x => x.HipoteticDiagnosis.ID == r.Conclusion.ID);
                                //var hip2 = NeuroNetHipotez.Find(x => x.HipoteticDiagnosis.ID == r.Conclusion.ID);
                                if (hip != null)
                                {
                                    hip.Coincidence += c.Conf * (1.0f / r.complaints.Count) / 5;
                                    //if (c.Conf < 0)
                                    //{
                                    //    hip2.Coincidence += c.Conf / 2 * (1.0f / r.complaints.Count);
                                    //} else
                                    //{
                                    //    hip2.Coincidence += c.Conf * (1.0f / r.complaints.Count);
                                    //}                     
                                }
                                else
                                {
                                    hip = new Hipotez();
                                    hip.HipoteticDiagnosis = r.Conclusion;
                                    hip.Coincidence = c.Conf * (1.0f / r.complaints.Count ) / 5;
                                    Hipotezes.Add(hip);

                                    //hip2 = new Hipotez();
                                    //hip2.HipoteticDiagnosis = r.Conclusion;
                                    
                                    //if (c.Conf < 0)
                                    //{                                        
                                    //    hip2.Coincidence += c.Conf / 2 * (0.9f / r.complaints.Count);
                                    //} else
                                    //{
                                    //    hip2.Coincidence += c.Conf * (0.9f / r.complaints.Count);
                                    //}
                                    //NeuroNetHipotez.Add(hip2);
                                }
                            } else
                            {
                                Hipotez hip = Hipotezes.Find(x => x.HipoteticDiagnosis.ID == r.Conclusion.ID);
                                //var hip2 = NeuroNetHipotez.Find(x => x.HipoteticDiagnosis.ID == r.Conclusion.ID);

                                if (hip != null)
                                {
                                    for (int i=0; i < c.Fuzzy.Count; i++)
                                    {
                                        if (ant.FuzzyVar.ID == c.Fuzzy[i].ID)
                                        {
                                            hip.Coincidence += c.Conf * (1.0f / r.complaints.Count) * c.MFnotFuzzy[i];
                                            //if (c.Conf < 0)
                                            //{
                                            //    hip2.Coincidence += c.Conf / 2 * (1.0f / r.complaints.Count) * c.MFnotFuzzy[i];
                                            //} else
                                            //{
                                            //    hip2.Coincidence += c.Conf * (1.0f / r.complaints.Count) * c.MFnotFuzzy[i];
                                            //}
                                        }
                                    }
                                }
                                else
                                {
                                    hip = new Hipotez();
                                    hip.HipoteticDiagnosis = r.Conclusion;
                                    for (int i = 0; i < c.Fuzzy.Count; i++)
                                    {
                                        if (ant.FuzzyVar.ID == c.Fuzzy[i].ID)
                                        {
                                            hip.Coincidence = c.Conf * (1.0f / r.complaints.Count) * c.MFnotFuzzy[i];
                                        }
                                    }
                                    Hipotezes.Add(hip);

                                    //hip2 = new Hipotez();
                                    //hip2.HipoteticDiagnosis = r.Conclusion;
                                    //for (int i = 0; i < c.Fuzzy.Count; i++)
                                    //{
                                    //    if (ant.FuzzyVar.ID == c.Fuzzy[i].ID)
                                    //    {
                                    //        if (c.Conf < 0)
                                    //        {
                                    //            hip2.Coincidence = c.Conf / 2 * (1.0f / r.complaints.Count) * c.MFnotFuzzy[i];
                                    //        } else
                                    //        {
                                    //            hip2.Coincidence = c.Conf * (1.0f / r.complaints.Count) * c.MFnotFuzzy[i];
                                    //        }
                                    //    }
                                    //}
                                    //NeuroNetHipotez.Add(hip2);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
