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
    public partial class UserEdit : Form
    {
        public UserEdit(User user)
        {
            InitializeComponent();

            prototypeUser = user;

            textBoxLogin.Text = prototypeUser.Login;

            if (prototypeUser.ID == -1)
            {
                labelOldPass.Text = "Пароль:";
                labelNewPass.Text = "Подтвердите пароль";
            } else
            {
                textBoxOldPassword.Text = prototypeUser.Password;
                textBoxNewPassword.Text = prototypeUser.Password;
            }

            var groups = DatabaseManager.Instance.GetGroupUsers();
            foreach (var group in groups)
            {
                comboBoxGroup.Items.Add(group.Name);
            }

            comboBoxGroup.SelectedIndex = Convert.ToInt32(prototypeUser.GroupId - 1);
        }

        private User prototypeUser;

        private void checkBoxShowOld_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowOld.Checked)
            {
                textBoxOldPassword.PasswordChar = '\0';
            } else
            {
                textBoxOldPassword.PasswordChar = '*';
            }
        }

        private void checkBoxShowNew_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowNew.Checked)
            {
                textBoxNewPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxNewPassword.PasswordChar = '*';
            }
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxGroup.SelectedIndex)
            {
                /*case 0:
                    break;*/
                case 1:
                    pictureBoxAva.Image = MESysWin.Properties.Resources.AvaUser;
                    break;
                case 2:
                    pictureBoxAva.Image = MESysWin.Properties.Resources.AvaExpert;
                    break;
                case 3:
                    pictureBoxAva.Image = MESysWin.Properties.Resources.AvaAdmin;
                    break;
                default:
                    pictureBoxAva.Image = MESysWin.Properties.Resources.AvaGuest;
                    break;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            prototypeUser.Login = textBoxLogin.Text;

            if (prototypeUser.ID == -1)
            {
                if (textBoxOldPassword.Text.Equals(textBoxNewPassword.Text))
                {
                    prototypeUser.Password = textBoxNewPassword.Text;
                } else
                {
                    MessageBox.Show("Проверьте написание паролей. Пароли не совпадают.", "Пароли не совпадают", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            } else
            {
                if (prototypeUser.Password.Equals(textBoxOldPassword.Text))
                {
                    prototypeUser.Password = textBoxNewPassword.Text;
                } else
                {
                    MessageBox.Show("Проверьте написание старого пароля. Введенный пароль не совпадает с текущим паролем.", "Пароли не совпадают", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            prototypeUser.GroupId = comboBoxGroup.SelectedIndex + 1;

            if (prototypeUser.CheckData())
            {
                if (prototypeUser.ID == -1)
                {
                    var id = DatabaseManager.Instance.InsertUser(prototypeUser);
                    prototypeUser.ID = id;

                    UserControl parent = this.Owner as UserControl;
                    if (parent != null)
                    {
                        string[] row = new string[] { prototypeUser.ID.ToString(), prototypeUser.Login, prototypeUser.Password, comboBoxGroup.SelectedItem.ToString() };
                        parent.dataGridViewUsers.Rows.Add(row);
                    }
                } else
                {
                    DatabaseManager.Instance.UpdateUser(prototypeUser);

                    UserControl parent = this.Owner as UserControl;
                    if (parent != null)
                    {
                        string[] row = new string[] { prototypeUser.ID.ToString(), prototypeUser.Login, prototypeUser.Password, comboBoxGroup.SelectedItem.ToString() };
                        var i = parent.dataGridViewUsers.SelectedCells[0].RowIndex;
                        parent.dataGridViewUsers.Rows[i].SetValues(row);
                    }
                }

                this.Close();
            } else
            {
                MessageBox.Show(String.Format("Запись не добавлена в базу данных по причине: {0}", prototypeUser.LastTrouble),
                    "Запись не добавлена / не отредактирована", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
