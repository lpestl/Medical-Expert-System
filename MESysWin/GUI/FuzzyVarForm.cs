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
    public partial class FuzzyVarForm : Form
    {
        public FuzzyVarForm(Symptom par)
        {
            InitializeComponent();

            parentSymptom = par;

            prototypeFuzzy = null;

            var w = parentSymptom.ReasoningTop - parentSymptom.ReasoningBottom;

            var step = w / 5;

            textBoxGC.Text = (w / 2 + parentSymptom.ReasoningBottom).ToString();
            textBoxSigma.Text = (w / 10).ToString();

            textBoxTrianglA.Text = (step + parentSymptom.ReasoningBottom).ToString();
            textBoxTrianglB.Text = (w / 2 + parentSymptom.ReasoningBottom).ToString();
            textBoxTrianglC.Text = (4 * step + parentSymptom.ReasoningBottom).ToString();

            textBoxTrapA.Text = (step + parentSymptom.ReasoningBottom).ToString();
            textBoxTrapB.Text = (2 * step + parentSymptom.ReasoningBottom).ToString();
            textBoxTrapC.Text = (3 * step + parentSymptom.ReasoningBottom).ToString();
            textBoxTrapD.Text = (4 * step + parentSymptom.ReasoningBottom).ToString();
        }

        private Symptom parentSymptom;

        private FuzzyVariable prototypeFuzzy;

        private void panelGraph_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph();
            /*GraphicOnFrom.PaintGrid(panelGraph);
            GraphicOnFrom.DrawBottomScale(panelGraph, parentSymptom.ReasoningBottom, parentSymptom.ReasoningTop);

            switch ((TypeMFuncEnum)comboBoxType.SelectedIndex)
            {
                case TypeMFuncEnum.GAUSS:
                    GraphicOnFrom.DrawGaussMF(panelGraph, buttonColor.BackColor, Convert.ToDouble(textBoxGC.Text), Convert.ToDouble(textBoxSigma.Text), parentSymptom.ReasoningBottom, parentSymptom.ReasoningTop);
                    break;
                case TypeMFuncEnum.TRIANGULARE:
                    break;
                case TypeMFuncEnum.TRAPEZOIDAL:
                    break;
                default:
                    break;
            }*/
        }

        private void FuzzyVarForm_Resize(object sender, EventArgs e)
        {
            DrawGraph();
            /*GraphicOnFrom.PaintGrid(panelGraph);
            GraphicOnFrom.DrawBottomScale(panelGraph, parentSymptom.ReasoningBottom, parentSymptom.ReasoningTop);

            switch ((TypeMFuncEnum)comboBoxType.SelectedIndex)
            {
                case TypeMFuncEnum.GAUSS:
                    GraphicOnFrom.DrawGaussMF(panelGraph, buttonColor.BackColor, Convert.ToDouble(textBoxGC.Text), Convert.ToDouble(textBoxSigma.Text), parentSymptom.ReasoningBottom, parentSymptom.ReasoningTop);
                    break;
                case TypeMFuncEnum.TRIANGULARE:
                    break;
                case TypeMFuncEnum.TRAPEZOIDAL:
                    break;
                default:
                    break;
            }*/
        }

        private void DrawGraph()
        {
            GraphicOnFrom.PaintGrid(panelGraph);
            GraphicOnFrom.DrawBottomScale(panelGraph, parentSymptom.ReasoningBottom, parentSymptom.ReasoningTop);

            switch ((TypeMFuncEnum)comboBoxType.SelectedIndex)
            {
                case TypeMFuncEnum.GAUSS:
                    GraphicOnFrom.DrawGaussMF(panelGraph, 
                        buttonColor.BackColor, 
                        Convert.ToDouble(textBoxGC.Text), 
                        Convert.ToDouble(textBoxSigma.Text), 
                        parentSymptom.ReasoningBottom, 
                        parentSymptom.ReasoningTop);
                    break;
                case TypeMFuncEnum.TRIANGULARE:
                    GraphicOnFrom.DrawTrianglMF(panelGraph, 
                        buttonColor.BackColor,
                        Convert.ToDouble(textBoxTrianglA.Text), 
                        Convert.ToDouble(textBoxTrianglB.Text),
                        Convert.ToDouble(textBoxTrianglC.Text),
                        parentSymptom.ReasoningBottom, 
                        parentSymptom.ReasoningTop);
                    break;
                case TypeMFuncEnum.TRAPEZOIDAL:
                    GraphicOnFrom.DrawTrapezMF(panelGraph,
                        buttonColor.BackColor,
                        Convert.ToDouble(textBoxTrapA.Text),
                        Convert.ToDouble(textBoxTrapB.Text),
                        Convert.ToDouble(textBoxTrapC.Text),
                        Convert.ToDouble(textBoxTrapD.Text),
                        parentSymptom.ReasoningBottom,
                        parentSymptom.ReasoningTop);
                    break;
                default:
                    break;
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = comboBoxType.SelectedIndex;

            //tabControlType.Enabled = true;
            tabControlType.Visible = true;
            tabControlType.SelectedIndex = i;

            DrawGraph();            
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = buttonColor.BackColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                buttonColor.BackColor = MyDialog.Color;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            FuzzyVariable newFuzzy;
            if (prototypeFuzzy != null)
            {
                newFuzzy = new FuzzyVariable(prototypeFuzzy.ID, 
                    parentSymptom.ID,
                    textBoxName.Text,
                    buttonColor.BackColor);

                newFuzzy.Type = (TypeMFuncEnum)comboBoxType.SelectedIndex;
            } else
            {
                newFuzzy = new FuzzyVariable(-1, 
                    parentSymptom.ID, 
                    textBoxName.Text, 
                    buttonColor.BackColor);

                newFuzzy.Type = (TypeMFuncEnum)comboBoxType.SelectedIndex;                
            }

            if (newFuzzy.CheckData())
            {
                switch(newFuzzy.Type)
                {
                    case TypeMFuncEnum.GAUSS:
                        if ((prototypeFuzzy != null) && (prototypeFuzzy.IdGaussian >= 0))
                        {
                            
                        } else
                        {
                            newFuzzy.IdGaussian = DatabaseManager.Instance.InsertMF(double.Parse(textBoxGC.Text),
                                double.Parse(textBoxSigma.Text));
                        }
                        break;
                    case TypeMFuncEnum.TRIANGULARE:
                        if ((prototypeFuzzy != null) && (prototypeFuzzy.IdGaussian >= 0))
                        {

                        }
                        else
                        {
                            newFuzzy.IdTriangulare = DatabaseManager.Instance.InsertMF(double.Parse(textBoxTrianglA.Text),
                                double.Parse(textBoxTrianglB.Text),
                                double.Parse(textBoxTrianglC.Text));
                        }
                        break;
                    case TypeMFuncEnum.TRAPEZOIDAL:
                        if ((prototypeFuzzy != null) && (prototypeFuzzy.IdGaussian >= 0))
                        {

                        }
                        else
                        {
                            newFuzzy.IdTrapezoidal = DatabaseManager.Instance.InsertMF(double.Parse(textBoxTrapA.Text),
                                double.Parse(textBoxTrapB.Text),
                                double.Parse(textBoxTrapC.Text),
                                double.Parse(textBoxTrapD.Text));
                        }
                        break;
                    default:
                        break;
                }

                SymptomEditing parent = this.Owner as SymptomEditing;

                if (prototypeFuzzy != null)
                {

                } else
                {
                    prototypeFuzzy = newFuzzy;
                    prototypeFuzzy.ID = DatabaseManager.Instance.InsertFuzzyVar(prototypeFuzzy);

                    string[] row = new string[] { prototypeFuzzy.ID.ToString(), prototypeFuzzy.Name };
                    var i = parent.dataGridViewFuzzyVar.Rows.Add(row);
                    var combo = parent.dataGridViewFuzzyVar.Rows[i].Cells[2] as DataGridViewComboBoxCell;
                    combo.Value = combo.Items[(int)prototypeFuzzy.Type];

                    var buttonColor = parent.dataGridViewFuzzyVar.Rows[i].Cells[3] as DataGridViewButtonCell;
                    buttonColor.FlatStyle = FlatStyle.Flat;
                    buttonColor.Style.BackColor = prototypeFuzzy.Color;

                    parent.dataGridViewFuzzyVar.Rows[i].Cells[4].Value = prototypeFuzzy.IdTriangulare.ToString();
                    parent.dataGridViewFuzzyVar.Rows[i].Cells[5].Value = prototypeFuzzy.IdTrapezoidal.ToString();
                    parent.dataGridViewFuzzyVar.Rows[i].Cells[6].Value = prototypeFuzzy.IdGaussian.ToString();

                }


                this.Close();
            }
            else
            {
                MessageBox.Show(String.Format("Запись не добавлена в базу данных по причине: {0}", newFuzzy.LastTrouble),
                    "Запись не добавлена / не отредактирована", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
