using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MESysWin.src;

namespace MESysWin.GUI
{
    public partial class SymptomEditing : Form
    {
        public SymptomEditing()
        {
            InitializeComponent();

            prototypeSymtom = null;

            dataGridViewFuzzyVar.Enabled = false;
            buttonAdd.Enabled = false;
            buttonRemove.Enabled = false;
            buttonEdit.Enabled = false;
        }

        private Symptom prototypeSymtom;
        public SymptomEditing(Symptom smp)
        {
            InitializeComponent();

            prototypeSymtom = smp;

            textBoxNameLV.Text = prototypeSymtom.Name;
            textBoxBottom.Text = prototypeSymtom.ReasoningBottom.ToString();
            textBoxTop.Text = prototypeSymtom.ReasoningTop.ToString();

            var FuzzyList = DatabaseManager.Instance.GetFuzzyVariables(prototypeSymtom.ID);
            foreach (FuzzyVariable fv in FuzzyList)
            {
                string[] row = new string[] { fv.ID.ToString(), fv.Name/*, smp.ReasoningBottom.ToString(), smp.ReasoningTop.ToString()*/ };
                var i = dataGridViewFuzzyVar.Rows.Add(row);

                // TO DO: Хранить в свойстве класса, а не локально
                dataGridViewFuzzyVar.Rows[i].Cells[2].Value = ((int)fv.Type).ToString();
                dataGridViewFuzzyVar.Rows[i].Cells[3].Value = DatabaseManager.Instance.GetTypeMFunc((long)fv.Type).Name;

                dataGridViewFuzzyVar.Rows[i].Cells[4].Value = ((int)fv.Bound).ToString();
                dataGridViewFuzzyVar.Rows[i].Cells[5].Value = DatabaseManager.Instance.GetBoundaryType((long)fv.Bound).Name;

                var buttonColor = dataGridViewFuzzyVar.Rows[i].Cells[6] as DataGridViewButtonCell;
                buttonColor.FlatStyle = FlatStyle.Popup;
                buttonColor.Style.BackColor = fv.СolorLine;

                dataGridViewFuzzyVar.Rows[i].Cells[7].Value = fv.IdTriangulare;
                dataGridViewFuzzyVar.Rows[i].Cells[8].Value = fv.IdTrapezoidal;
                dataGridViewFuzzyVar.Rows[i].Cells[9].Value = fv.IdGaussian;
            }
        }

        private void panelGraph_Paint(object sender, PaintEventArgs e)
        {
            GraphicOnFrom.PaintGrid(panelGraph);
            GraphicOnFrom.DrawBottomScale(panelGraph, double.Parse(textBoxBottom.Text), double.Parse(textBoxTop.Text));
        }

        private void SymptomEditing_Resize(object sender, EventArgs e)
        {
            GraphicOnFrom.PaintGrid(panelGraph);
            GraphicOnFrom.DrawBottomScale(panelGraph, double.Parse(textBoxBottom.Text), double.Parse(textBoxTop.Text));
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Symptom newSmp;
            LingVar main;
            if (prototypeSymtom != null)
            {
                newSmp = new Symptom(prototypeSymtom.ID, textBoxNameLV.Text, double.Parse(textBoxBottom.Text), double.Parse(textBoxTop.Text));
            } else
            {
                newSmp = new Symptom(-1, textBoxNameLV.Text, double.Parse(textBoxBottom.Text), double.Parse(textBoxTop.Text));
            }

            if (newSmp.CheckData())
            {
                if (prototypeSymtom == null)
                {
                    long insertrd_id = DatabaseManager.Instance.InsertSymptom(newSmp);
                    newSmp.ID = insertrd_id;
                    main = this.Owner as LingVar;
                    if (main != null)
                    {
                        string[] row = new string[] { newSmp.ID.ToString(), newSmp.Name, newSmp.ReasoningBottom.ToString(), newSmp.ReasoningTop.ToString() };
                        main.dataGridViewSymptoms.Rows.Add(row);
                    }
                } else
                {
                    DatabaseManager.Instance.UpdateSymptome(newSmp);
                    main = this.Owner as LingVar;
                    if (main != null)
                    {
                        string[] row = new string[] { newSmp.ID.ToString(), newSmp.Name, newSmp.ReasoningBottom.ToString(), newSmp.ReasoningTop.ToString() };
                        var i = main.dataGridViewSymptoms.SelectedCells[0].RowIndex;
                        main.dataGridViewSymptoms.Rows[i].SetValues(row);
                    }
                }

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(String.Format("Запись не добавлена в базу данных по причине: {0}", newSmp.LastTrouble),
                    "Запись не добавлена / не отредактирована", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuzzyVar.SelectedCells.Count > 0)
            {
                var i = dataGridViewFuzzyVar.SelectedCells[0].RowIndex;
                var id_in_db = Convert.ToInt64(dataGridViewFuzzyVar.Rows[i].Cells[0].Value);

                if (MessageBox.Show("Вы действительно хотите удалить запись о нечеткой переменной из базы знаний, из базы данных и из приложения?\n",
                        String.Format("Удаление \"{0}\"", Convert.ToString(dataGridViewFuzzyVar.Rows[i].Cells[1].Value)),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //var buttonColor = dataGridViewFuzzyVar.Rows[i].Cells[3] as DataGridViewButtonCell;

                    /*FuzzyVariable fv = new FuzzyVariable(id_in_db,
                        Convert.ToString(dataGridViewFuzzyVar.Rows[i].Cells[1].Value),
                        buttonColor.Style.BackColor);*/

                    long j;
                    j = Convert.ToInt64(dataGridViewFuzzyVar.Rows[i].Cells[4].Value);
                    if (j != -1) DatabaseManager.Instance.DeleteFromTable(j,
                        "triangular_mf", "id_triangl_mf");
                    j = Convert.ToInt64(dataGridViewFuzzyVar.Rows[i].Cells[5].Value);
                    if (j != -1) DatabaseManager.Instance.DeleteFromTable(j,
                        "trapezoidal_mf", "id_trapez_mf");
                    j = Convert.ToInt64(dataGridViewFuzzyVar.Rows[i].Cells[6].Value);
                    if (j != -1) DatabaseManager.Instance.DeleteFromTable(j,
                        "gauss_mf", "id_gauss_mf");

                    DatabaseManager.Instance.DeleteFromTable(id_in_db, "fuzzy_variable", "id_var");
                    dataGridViewFuzzyVar.Rows.RemoveAt(i);
                }

            }
            else
            {
                MessageBox.Show("Ничего не удалено! Не выделено ни одной строки с данными.", "Удаления не произошло", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var FuzzyForm = new FuzzyVarForm(prototypeSymtom);
            FuzzyForm.Owner = this;
            FuzzyForm.ShowDialog();
        }

        private void buttonRedraw_Click(object sender, EventArgs e)
        {
            GraphicOnFrom.PaintGrid(panelGraph);
            GraphicOnFrom.DrawBottomScale(panelGraph, double.Parse(textBoxBottom.Text), double.Parse(textBoxTop.Text));

        }

        private void textBoxBottom_TextChanged(object sender, EventArgs e)
        {
            if (prototypeSymtom != null)
            {
                var old = prototypeSymtom.ReasoningBottom;
                double res;
                if (double.TryParse(textBoxBottom.Text, out res))
                {
                    prototypeSymtom.ReasoningBottom = res;
                    if (!prototypeSymtom.CheckData()) prototypeSymtom.ReasoningBottom = old;
                }
            }
        }

        private void textBoxTop_TextChanged(object sender, EventArgs e)
        {
            if (prototypeSymtom != null)
            {
                var old = prototypeSymtom.ReasoningTop;
                double res;
                if (double.TryParse(textBoxTop.Text, out res))
                {
                    prototypeSymtom.ReasoningTop = res;
                    if (!prototypeSymtom.CheckData()) prototypeSymtom.ReasoningTop = old;
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewFuzzyVar.SelectedCells.Count > 0)
            {
                var i = dataGridViewFuzzyVar.SelectedCells[0].RowIndex;
                var id_in_db = Convert.ToInt64(dataGridViewFuzzyVar.Rows[i].Cells[0].Value);

                var colorBut = dataGridViewFuzzyVar.Rows[i].Cells[6] as DataGridViewButtonCell;

                var prototypeFuzzy = new FuzzyVariable(id_in_db,
                    prototypeSymtom.ID,
                    Convert.ToString(dataGridViewFuzzyVar.Rows[i].Cells[1].Value),
                    colorBut.Style.BackColor);

                prototypeFuzzy.Type = (TypeMFuncEnum)Convert.ToInt32(dataGridViewFuzzyVar.Rows[i].Cells[2].Value);
                prototypeFuzzy.Bound = (BoundaryTypeEnum)Convert.ToInt32(dataGridViewFuzzyVar.Rows[i].Cells[4].Value);

                prototypeFuzzy.IdTriangulare = Convert.ToInt64(dataGridViewFuzzyVar.Rows[i].Cells[7].Value);
                prototypeFuzzy.IdTrapezoidal = Convert.ToInt64(dataGridViewFuzzyVar.Rows[i].Cells[8].Value);
                prototypeFuzzy.IdGaussian = Convert.ToInt64(dataGridViewFuzzyVar.Rows[i].Cells[9].Value);

                var FuzzyForm = new FuzzyVarForm(prototypeSymtom, prototypeFuzzy);
                FuzzyForm.Owner = this;
                FuzzyForm.ShowDialog();
            } else
            {
                MessageBox.Show("Ничего не выделено для редактирования!", "Объект не выделен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
