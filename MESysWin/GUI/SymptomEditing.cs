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
    }
}
