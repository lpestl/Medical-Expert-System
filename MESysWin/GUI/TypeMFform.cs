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
    public partial class TypeMFform : Form
    {
        public TypeMFform()
        {
            InitializeComponent();

            var list = DatabaseManager.Instance.GetTypesMf();
            foreach(TypeMFunc type in list)
            {
                string[] row = new string[] { type.ID.ToString(), type.Name, type.Description };
                dataGridViewTypes.Rows.Add(row);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(dataGridViewTypes.SelectedRows.Count > 0)
            {
                var i = dataGridViewTypes.SelectedRows[0].Index;
                var id_in_db = Convert.ToInt32(dataGridViewTypes.Rows[i].Cells["IdType"].Value);

                if (MessageBox.Show("Вы действительно хотите удалить запись о типе функции принадлежности из базы знаний, из базы данных и из приложения?\n",
                        String.Format("Удаление {0}", Convert.ToString(dataGridViewTypes.Rows[i].Cells[1].Value)),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DatabaseManager.Instance.DeleteFromTable(id_in_db, "mf_type", "id_mf_type");
                    dataGridViewTypes.Rows.RemoveAt(i);
                }

            } else
            {
                MessageBox.Show("Ничего не удалено! Не выделено ни одной строки с данными.", "Удаления не произошло", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DatabaseManager.Instance.GetMaxId("mf_type", "id_mf_type").ToString());

            var formAdd = new TypeEdit(DatabaseManager.Instance.GetMaxId("mf_type", "id_mf_type")+1, "", "", TypeEdit.InsertEnum.INSERT);
            formAdd.Owner = this;
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("OK");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedCells.Count > 0)
            {
                var i = dataGridViewTypes.SelectedCells[0].RowIndex;

                var formAdd = new TypeEdit(
                    Convert.ToInt32(dataGridViewTypes.Rows[i].Cells[0].Value), 
                    Convert.ToString(dataGridViewTypes.Rows[i].Cells[1].Value), 
                    Convert.ToString(dataGridViewTypes.Rows[i].Cells[2].Value),
                    TypeEdit.InsertEnum.UPDATE);
                formAdd.Owner = this;
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show("OK");
                }

            } else
            {
                MessageBox.Show("Ничего не выделено для редактирования!", "Объект не выделен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
