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
    public partial class UserControl : Form
    {
        public UserControl()
        {
            InitializeComponent();

            var listGroup = DatabaseManager.Instance.GetGroupUsers();

            foreach (var gr in listGroup)
            {
                string[] row = new string[] { gr.ID.ToString(), gr.Name, gr.Description };
                dataGridViewGroup.Rows.Add(row);
            }

            //dataGridViewGroup.Cells

            var listUsers = DatabaseManager.Instance.GetUserList();

            foreach (var user in listUsers)
            {
                string[] row = new string[] { user.ID.ToString(), user.Login, user.Password, listGroup.Find(x => x.ID == user.GroupId).Name };
                var i = dataGridViewUsers.Rows.Add(row);
                
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedCells.Count > 0)
            {
                var i = dataGridViewUsers.SelectedCells[0].RowIndex;
                var id_in_db = Convert.ToInt64(dataGridViewUsers.Rows[i].Cells[0].Value);

                if (MessageBox.Show("Вы действительно хотите удалить запись о пользователе из базы знаний, из базы данных и из приложения?\n",
                        String.Format("Удаление {0}", Convert.ToString(dataGridViewUsers.Rows[i].Cells[1].Value)),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DatabaseManager.Instance.DeleteFromTable(id_in_db, "login", "id_login");
                    dataGridViewUsers.Rows.RemoveAt(i);
                }

            }
            else
            {
                MessageBox.Show("Ничего не удалено! Не выделено ни одной строки с данными.", "Удаления не произошло", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var formAdd = new UserEdit(new User());
            formAdd.Owner = this;
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("OK");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedCells.Count > 0)
            {
                var i = dataGridViewUsers.SelectedCells[0].RowIndex;

                var user = DatabaseManager.Instance.GetUserList().Find(x => x.ID == Convert.ToInt64(dataGridViewUsers.Rows[i].Cells[0].Value));
                
                var formAdd = new UserEdit(user);
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
