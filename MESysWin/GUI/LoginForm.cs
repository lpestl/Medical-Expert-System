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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            if (Settings.Instance.currenUser.Login.Equals("Гость"))
            {
                buttonLogout.Visible = false;
            }

            textBoxLogin.Text = Settings.Instance.currenUser.Login;
            textBoxLogin.SelectAll();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Settings.Instance.Logout();
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Settings.Instance.Logout();
            if (Settings.Instance.Login(textBoxLogin.Text, textBoxPassword.Text))
            {
                this.Close();
            } else
            {
                MessageBox.Show("Неправельно введен логин или пароль. Проверьте данные и повторите попытку.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            } else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void checkBoxShowPassword_MouseLeave(object sender, EventArgs e)
        {
            //checkBoxShowPassword.Checked = false;
        }
    }
}
