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
    public partial class LingVar : Form
    {
        public LingVar()
        {
            InitializeComponent();

            var symptomsList = DatabaseManager.Instance.GetSymptomList();
            foreach (Symptom smp in symptomsList)
            {
                string[] row = new string[] { smp.ID.ToString(), smp.Name, smp.ReasoningBottom.ToString(), smp.ReasoningTop.ToString() };
                dataGridViewSymptoms.Rows.Add(row);
            }
        }

        private void dataGridViewSymptoms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var SympForm = new SymptomEditing();
            SympForm.Owner = this;
            SympForm.ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewSymptoms.SelectedRows.Count > 0)
            {
                var i = dataGridViewSymptoms.SelectedRows[0].Index;
                var id_in_db = Convert.ToInt32(dataGridViewSymptoms.Rows[i].Cells[0].Value);

                if (MessageBox.Show("Вы действительно хотите удалить запись о СИМПТОМЕ как о лингвистической переменной из базы знаний," +
                    " из базы данных и из приложения?\r\n\r\n" +
                    "ВНИМАНИЕ!!! Удаление приведет к тому, что будет так же удален АНТЕЦЕДЕНТ из правила в Базе Знаний," +
                    " а значит диагностика в РЕЖИМЕ КОНСУЛЬТАЦИИ будет не верна! Медицинская информационная система " +
                    "будет диагностировать не верно то заболевание, в правиле которого учавствовал данный АНТЕЦЕДЕНТ!!!\r\n\r\n" +
                    "Вы уверены, что хотите удалить эту переменную?",
                        String.Format("Удаление {0}", Convert.ToString(dataGridViewSymptoms.Rows[i].Cells[1].Value)),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (DatabaseManager.Instance.DeleteFromTable(id_in_db, "linguistic_variable", "id_ling_var"))
                    {
                        dataGridViewSymptoms.Rows.RemoveAt(i);
                    } else
                    {
                        MessageBox.Show("Вы не можете удалить выбранную запись, по той причине, что она используется в правиле Базы Знаний " +
                            "и содержит в себе дочерние элементы (нечеткие переменные)." +
                            " Её удаление приведет к неправильной работе приложения." +
                            " Чтобы удалить эту переменную, удалите или измените сначала правило из базы знаний, в котором она используется," +
                            " а так же все нечеткие переменные, которые к ней относятся.",
                            "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Ничего не удалено! Не выделено ни одной строки с данными.", "Удаления не произошло", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCorrect_Click(object sender, EventArgs e)
        {
            if (dataGridViewSymptoms.SelectedCells.Count > 0)
            {
                var i = dataGridViewSymptoms.SelectedCells[0].RowIndex;

                var SympForm = new SymptomEditing(
                    new Symptom(Convert.ToInt32(dataGridViewSymptoms.Rows[i].Cells[0].Value),
                    Convert.ToString(dataGridViewSymptoms.Rows[i].Cells[1].Value),
                    Convert.ToDouble(dataGridViewSymptoms.Rows[i].Cells[2].Value),
                    Convert.ToDouble(dataGridViewSymptoms.Rows[i].Cells[3].Value)));
                SympForm.Owner = this;
                SympForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ничего не выделено для редактирования!", "Объект не выделен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
