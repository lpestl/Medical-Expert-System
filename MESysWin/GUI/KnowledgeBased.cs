using MESysWin.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESysWin.GUI
{
    public partial class KnowledgeBased : Form
    {
        public KnowledgeBased(src.Rule rule)
        {
            InitializeComponent();
                        
            prototype = rule;

            prAnt = new Antecedent();

            quantList = null;
            symptomsList = null;
            diagnosisList = null;
            fuzzyList = null;

            UpdateComboQuant();
            UpdateComboSymptoms();
            UpdateComboDiagnosis();

            NewCombos();

            UpdateAntecedentsInRule();
            UpdateAntecedents();
            UpdateAntecedentPreview();
            UpdateRulePreview();

            if (prototype.ID != -1) {
                comboBoxDiagn.Text = DatabaseManager.Instance.GetDiagnosis(prototype.Conclusion.ID).Name;
            }

            richTextBoxPreview.Text = prototype.Preview;
        }

        private void UpdateAntecedentsInRule()
        {
            if (dataGridViewInRule.Rows.Count > 0)
            {
                dataGridViewInRule.Rows.Clear();
            }
            if (prototype.ID >= 0)
            {
                var antlist = DatabaseManager.Instance.GetAntecedentsInRule(prototype);
                foreach(var ant in antlist)
                {
                    string[] row = new string[] { ant.ID.ToString(), ant.Preview };
                    dataGridViewInRule.Rows.Add(row);
                }
            }

        }

        private void UpdateAntecedents()
        {
            if (antecedentList != null)
            {
                antecedentList.Clear();
                dataGridViewAntecedent.Rows.Clear();
            }
            antecedentList = DatabaseManager.Instance.GetAntecedentList();
            foreach (var a in antecedentList)
            {
                string[] row = new string[] { a.ID.ToString(), a.Preview };
                dataGridViewAntecedent.Rows.Add(row);
            }
        }

        private src.Rule prototype;
        private Antecedent prAnt;

        private List<Quantifier> quantList;
        private List<Symptom> symptomsList;
        private List<Diagnosis> diagnosisList;

        private List<FuzzyVariable> fuzzyList;

        private List<Antecedent> antecedentList;

        private void NewCombos()
        {
            fuzzyList = null;
            comboBoxFuzzy.Items.Clear();
            comboBoxFuzzy.SelectedIndex = -1;
            comboBoxFuzzy.Text = "";
            comboBoxFuzzy.Enabled = false;

            //comboBoxQuant.SelectedIndex = 0;
        }

        private void UpdateComboDiagnosis()
        {
            if (diagnosisList != null) diagnosisList.Clear();
            comboBoxDiagn.Items.Clear();
            diagnosisList = DatabaseManager.Instance.GetDiagnosis();
            foreach (var diagn in diagnosisList)
            {
                comboBoxDiagn.Items.Add(diagn.Name);
            }
            comboBoxDiagn.SelectedItem = -1;
            comboBoxDiagn.Text = "";
        }

        private void UpdateComboSymptoms()
        {
            if (symptomsList != null) symptomsList.Clear();
            comboBoxSymptoms.Items.Clear();
            symptomsList = DatabaseManager.Instance.GetSymptomList();
            foreach (var s in symptomsList)
            {
                comboBoxSymptoms.Items.Add(s.Name);
            }
            comboBoxSymptoms.SelectedIndex = -1;
            comboBoxSymptoms.Text = "";
        }

        private void UpdateComboQuant()
        {
            if (quantList != null) quantList.Clear();
            comboBoxQuant.Items.Clear();
            quantList = DatabaseManager.Instance.GetQuantifiers();
            foreach (var q in quantList)
            {
                comboBoxQuant.Items.Add(q.Name.ToLower());
            }
            comboBoxQuant.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if ((comboBoxDiagn.SelectedIndex < 0) || (dataGridViewInRule.Rows.Count == 0))
            {
                MessageBox.Show("В правиле не введен диагноз или список антецедентов пуст. Правило не может быть без заключения или не иметь предпосылок. Заполните правило правильно!", "Правило не заполнено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                if (prototype.ID >= 0)
                {
                    DatabaseManager.Instance.DeleteFromTable(prototype.ID, "knowledge_base", "id_rule");
                }
                //if (prototype.ID == -1)
                //{
                    prototype.ID = DatabaseManager.Instance.InsertRule(prototype);

                    List<Antecedent> rullist = new List<Antecedent>();
                    for (int i=0; i<dataGridViewInRule.Rows.Count; i++)
                    {
                        var anttemp = new Antecedent();
                        anttemp.ID = Convert.ToInt64(dataGridViewInRule.Rows[i].Cells[0].Value);
                        anttemp.Preview = dataGridViewInRule.Rows[i].Cells[1].Value.ToString();
                        rullist.Add(anttemp);
                    }

                    if (DatabaseManager.Instance.InsertRulesAntecedents(rullist, prototype))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                //} 
            }
        }

        private void dataGridViewAntecedent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*MessageBox.Show(String.Format("{0} - {1}", dataGridViewAntecedent.Rows[e.RowIndex].Cells[0].Value.ToString(),
                dataGridViewAntecedent.Rows[e.RowIndex].Cells[1].Value.ToString()));*/
            bool antuse = false;
            for (int i = 0; i < dataGridViewInRule.Rows.Count; i++)
            {
                if (Convert.ToInt64(dataGridViewAntecedent.Rows[e.RowIndex].Cells[0].Value) == Convert.ToInt64(dataGridViewInRule.Rows[i].Cells[0].Value))
                {
                    MessageBox.Show("Выбранный антецедент уже используется в этом правиле", "Повтор антецедента", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    antuse = true;
                    break;
                } 
            }
            if (!antuse)
            {
                string[] row = new string[] { dataGridViewAntecedent.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridViewAntecedent.Rows[e.RowIndex].Cells[1].Value.ToString() };
                dataGridViewInRule.Rows.Add(row);
                UpdateRulePreview();
            }
        }

        private void buttonDiagnosisEdit_Click(object sender, EventArgs e)
        {
            var dForm = new DiagnosisForm();
            dForm.ShowDialog();
            
            UpdateComboDiagnosis();
            UpdateRulePreview();
        }

        private void comboBoxDiagn_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDiagnos = diagnosisList.Find(x => x.Name.Equals(comboBoxDiagn.SelectedItem.ToString()));
            if (selectedDiagnos != null)
            {
                prototype.Conclusion = selectedDiagnos;

                UpdateRulePreview();
            }
        }

        private void UpdateRulePreview()
        {
            prototype.Preview = "ЕСЛИ ";
            if (dataGridViewInRule.Rows.Count == 0) {
                prototype.Preview += "___";
            } else
            {
                for (int i = 0; i < dataGridViewInRule.Rows.Count; i++)
                {
                    prototype.Preview += dataGridViewInRule.Rows[i].Cells[1].Value.ToString();
                    if (i == (dataGridViewInRule.Rows.Count - 1)) prototype.Preview += " ";
                    else prototype.Preview += " И ";
                }
            }

            prototype.Preview += "ТО это ";
            if (prototype.Conclusion.ID != -1)
            {
                prototype.Preview += prototype.Conclusion.Name;
            } else
            {
                prototype.Preview += "___";
            }

            richTextBoxPreview.Text = prototype.Preview;
        }

        private void comboBoxSymptoms_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSymptom = symptomsList.Find(x => x.Name.Equals(comboBoxSymptoms.SelectedItem.ToString()));
            if (selectedSymptom != null)
            {
                //prAnt.LinguisticVariable = selectedSymptom;

                NewCombos();
                fuzzyList = DatabaseManager.Instance.GetFuzzyVariables(selectedSymptom.ID);
                if (fuzzyList.Count > 0)
                {
                    comboBoxFuzzy.Enabled = true;
                    foreach (var fz in fuzzyList)
                    {
                        comboBoxFuzzy.Items.Add(fz.Name);
                    }
                }
            } else
            {
                NewCombos();
            }

            UpdateAntecedentPreview();
        }

        private void UpdateAntecedentPreview()
        {
            var selQuant = quantList.Find(x => x.Name.Equals(comboBoxQuant.SelectedItem.ToString()));
            if (selQuant != null)
            {
                prAnt.Quant = selQuant;
                prAnt.Preview = selQuant.Name;
            }

            prAnt.Preview += " ";
            if (comboBoxFuzzy.Enabled)
            {
                if (comboBoxFuzzy.SelectedItem != null)
                {
                    var selFuzzy = fuzzyList.Find(x => x.Name.Equals(comboBoxFuzzy.SelectedItem.ToString()));
                    if (selFuzzy != null)
                    {
                        prAnt.FuzzyVar = selFuzzy;
                        prAnt.Preview += selFuzzy.Name;
                    }
                    else
                    {
                        prAnt.FuzzyVar = null;
                        prAnt.Preview += "___";
                    }
                } else
                {
                    prAnt.FuzzyVar = null;
                    prAnt.Preview += "___";
                }
            } else
            {
                prAnt.FuzzyVar = null;
                prAnt.Preview += "___";
            }

            prAnt.Preview += " ";
            if (comboBoxSymptoms.SelectedItem != null)
            {
                var selSymp = symptomsList.Find(x => x.Name.Equals(comboBoxSymptoms.SelectedItem.ToString()));
                if (selSymp != null)
                {
                    prAnt.LinguisticVariable = selSymp;
                    prAnt.Preview += selSymp.Name;
                }
                else
                {
                    prAnt.LinguisticVariable = null;
                    prAnt.Preview += "___";
                }
            } else
            {
                prAnt.LinguisticVariable = null;
                prAnt.Preview += "___";
            }

            textBoxPreview.Text = prAnt.Preview;
        }

        private void comboBoxFuzzy_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAntecedentPreview();
        }

        private void comboBoxQuant_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAntecedentPreview();
        }

        private void buttonSymptomsEdit_Click(object sender, EventArgs e)
        {
            var smpForm = new LingVar();
            smpForm.ShowDialog();
            UpdateComboSymptoms();
            NewCombos();
            UpdateAntecedentPreview();
        }

        private void buttonQuantEdit_Click(object sender, EventArgs e)
        {
            var quantForm = new QuantForm();
            quantForm.ShowDialog();
        }

        private void buttonSaveAnt_Click(object sender, EventArgs e)
        {
            if (prAnt.CheckData())
            {
                prAnt.ID = DatabaseManager.Instance.InsertAntecedent(prAnt);
                string[] row = new string[] { prAnt.ID.ToString(), prAnt.Preview };
                dataGridViewInRule.Rows.Add(row);
            }
            else
            {
                MessageBox.Show(String.Format("Запись не добавлена в базу данных по причине: {0}", prAnt.LastTrouble),
                    "Запись не добавлена / не отредактирована", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateAntecedents();

            prAnt.ID = -1;
            UpdateComboSymptoms();
            UpdateComboQuant();
            NewCombos();

            UpdateAntecedentPreview();
            UpdateRulePreview();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewInRule.SelectedCells.Count > 0)
            {
                //if (prototype.ID == -1)
                //{
                    dataGridViewInRule.Rows.RemoveAt(dataGridViewInRule.SelectedCells[0].RowIndex);
                    UpdateRulePreview();
                //} else
                //{

                //}
            } else
            {
                MessageBox.Show("Ничего не выделено для удаления. Выделите один антецедент в правиле, чтобы его удалить.", "Удаление не произошло", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
