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
    public partial class DiagnosisEditor : Form
    {
        public DiagnosisEditor(Diagnosis diagnosis)
        {
            InitializeComponent();

            prototypeDiagnosis = diagnosis;

            textBoxName.Text = prototypeDiagnosis.Name;
            richTextBoxDescription.Text = prototypeDiagnosis.Description;
            richTextBoxSymptoms.Text = prototypeDiagnosis.Symptoms;
            richTextBoxTreatment.Text = prototypeDiagnosis.Treatment;
        }

        private Diagnosis prototypeDiagnosis;

        private void buttonOk_Click(object sender, EventArgs e)
        {
            prototypeDiagnosis.Name = textBoxName.Text;
            prototypeDiagnosis.Description = richTextBoxDescription.Text;
            prototypeDiagnosis.Symptoms = richTextBoxSymptoms.Text;
            prototypeDiagnosis.Treatment = richTextBoxTreatment.Text;

            var diagnsForm = this.Owner as DiagnosisForm;

            if (prototypeDiagnosis.ID == -1)
            {
                prototypeDiagnosis.ID = DatabaseManager.Instance.InsertDiagnosis(prototypeDiagnosis);

                if (diagnsForm != null)
                {
                    string[] row = new string[] { prototypeDiagnosis.ID.ToString(), prototypeDiagnosis.Name, prototypeDiagnosis.Description, prototypeDiagnosis.Symptoms, prototypeDiagnosis.Treatment };
                    diagnsForm.dataGridViewDiagnosis.Rows.Add(row);

                    this.Close();
                }
            }
            else
            {
                DatabaseManager.Instance.UpdateDiagnosis(prototypeDiagnosis);

                if (diagnsForm != null)
                {
                    string[] row = new string[] { prototypeDiagnosis.ID.ToString(), prototypeDiagnosis.Name, prototypeDiagnosis.Description, prototypeDiagnosis.Symptoms, prototypeDiagnosis.Treatment };

                    var i = diagnsForm.dataGridViewDiagnosis.SelectedCells[0].RowIndex;
                    diagnsForm.dataGridViewDiagnosis.Rows[i].SetValues(row);

                    this.Close();
                }
            }
        }
    }
}
