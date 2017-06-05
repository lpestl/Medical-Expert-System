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
    public partial class DiagnosisForm : Form
    {
        public DiagnosisForm()
        {
            InitializeComponent();

            var listDiagn = DatabaseManager.Instance.GetDiagnosis();

            foreach (var dia in listDiagn)
            {
                string[] row = new string[] { dia.ID.ToString(), dia.Name, dia.Description, dia.Symptoms, dia.Treatment };
                dataGridViewDiagnosis.Rows.Add(row);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewDiagnosis.SelectedCells.Count > 0)
            {
                var i = dataGridViewDiagnosis.SelectedCells[0].RowIndex;
                var id_in_db = Convert.ToInt64(dataGridViewDiagnosis.Rows[i].Cells[0].Value);

                if (MessageBox.Show("Вы действительно хотите удалить запись о диагнозе из базы знаний, из базы данных и из приложения?\n",
                        String.Format("Удаление {0}", Convert.ToString(dataGridViewDiagnosis.Rows[i].Cells[1].Value)),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DatabaseManager.Instance.DeleteFromTable(id_in_db, "diagnosis", "id_diagnosis"))
                    {
                        dataGridViewDiagnosis.Rows.RemoveAt(i);
                    } else
                    {
                        MessageBox.Show("Вы не можете удалить выбранную запись, по той причине, что она используется в правиле Базы Знаний." +
                            " Её удаление приведет к неправильной работе приложения." +
                            " Чтобы удалить эту переменную, удалите или измените сначала правило из базы знаний в котором она используется.",
                            "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Ничего не удалено! Не выделено ни одной строки с данными.", "Удаления не произошло", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var diagEdit = new DiagnosisEditor(new Diagnosis(String.Empty));
            diagEdit.Owner = this;
            diagEdit.ShowDialog();
        }

        private void buttonCorrect_Click(object sender, EventArgs e)
        {
            if (dataGridViewDiagnosis.SelectedCells.Count > 0)
            {
                var i = dataGridViewDiagnosis.SelectedCells[0].RowIndex;
                var id_in_db = Convert.ToInt64(dataGridViewDiagnosis.Rows[i].Cells[0].Value);

                var prototype = new Diagnosis(Convert.ToString(dataGridViewDiagnosis.Rows[i].Cells[1].Value));
                prototype.ID = Convert.ToInt64(dataGridViewDiagnosis.Rows[i].Cells[0].Value);
                prototype.Description = Convert.ToString(dataGridViewDiagnosis.Rows[i].Cells[2].Value);
                prototype.Symptoms = Convert.ToString(dataGridViewDiagnosis.Rows[i].Cells[3].Value);
                prototype.Treatment = Convert.ToString(dataGridViewDiagnosis.Rows[i].Cells[4].Value);

                var diagEdit = new DiagnosisEditor(prototype);
                diagEdit.Owner = this;
                diagEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ничего не выделено для редактирования!", "Объект не выделен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
