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
    public partial class TypeEdit : Form
    {
        public enum InsertEnum { INSERT, UPDATE };

        public TypeEdit()
        {
            InitializeComponent();
        }

        private InsertEnum insertEnumVar;

        public TypeEdit(int id, string name, string description, InsertEnum enInsert)
        {
            InitializeComponent();

            textBoxId.Text = id.ToString();

            textBoxName.Text = name;

            richTextBoxDescription.Text = description;

            insertEnumVar = enInsert;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            var newType = new TypeMFunc(int.Parse(textBoxId.Text), textBoxName.Text, richTextBoxDescription.Text);
            if (newType.CheckData())
            {
                TypeMFform main;
                switch (insertEnumVar)
                {
                    case InsertEnum.INSERT:
                        DatabaseManager.Instance.InsertType(newType);
                        main = this.Owner as TypeMFform;
                        if (main != null)
                        {
                            string[] row = new string[] { newType.ID.ToString(), newType.Name, newType.Description };
                            main.dataGridViewTypes.Rows.Add(row);
                        }
                        break;
                    case InsertEnum.UPDATE:
                        DatabaseManager.Instance.UpdateType(newType);
                        main = this.Owner as TypeMFform;
                        if (main != null)
                        {
                            string[] row = new string[] { newType.ID.ToString(), newType.Name, newType.Description };
                            var i = main.dataGridViewTypes.SelectedCells[0].RowIndex;
                            main.dataGridViewTypes.Rows[i].SetValues(row);
                        }
                        break;
                    default:
                        break;
                }
               
                this.DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show(String.Format("Запись не добавлена в базу данных по причине: {0}", newType.LastTrouble),
                    "Запись не добавлена / не отредактирована", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
