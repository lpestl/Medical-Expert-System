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
    public partial class BoundaryTypeForm : Form
    {
        public BoundaryTypeForm()
        {
            InitializeComponent();

            var list = DatabaseManager.Instance.GetBoundaryTypes();
            foreach (BoundaryType bound in list)
            {
                string[] row = new string[] { bound.ID.ToString(), bound.Name, bound.Description };
                dataGridViewBound.Rows.Add(row);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewBound.SelectedRows.Count > 0)
            {
                var i = dataGridViewBound.SelectedRows[0].Index;
                var id_in_db = Convert.ToInt32(dataGridViewBound.Rows[i].Cells["IdColumn"].Value);

                if (MessageBox.Show("Вы действительно хотите удалить запись о пограничном типе функции принадлежности из базы знаний, из базы данных и из приложения?\n",
                        String.Format("Удаление {0}", Convert.ToString(dataGridViewBound.Rows[i].Cells[1].Value)),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DatabaseManager.Instance.DeleteFromTable(id_in_db, "boundary_type", "id_bound");
                    dataGridViewBound.Rows.RemoveAt(i);
                }

            }
            else
            {
                MessageBox.Show("Ничего не удалено! Не выделено ни одной строки с данными.", "Удаления не произошло", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var formAdd = new BoundaryEdit(DatabaseManager.Instance.GetMaxId("boundary_type", "id_bound") + 1, "", "", BoundaryEdit.InsertEnum.INSERT);
            formAdd.Owner = this;
            formAdd.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewBound.SelectedCells.Count > 0)
            {
                var i = dataGridViewBound.SelectedCells[0].RowIndex;

                var formAdd = new BoundaryEdit(
                    Convert.ToInt64(dataGridViewBound.Rows[i].Cells[0].Value),
                    Convert.ToString(dataGridViewBound.Rows[i].Cells[1].Value),
                    Convert.ToString(dataGridViewBound.Rows[i].Cells[2].Value),
                    BoundaryEdit.InsertEnum.UPDATE);
                formAdd.Owner = this;
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show("OK");
                }

            }
            else
            {
                MessageBox.Show("Ничего не выделено для редактирования!", "Объект не выделен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
