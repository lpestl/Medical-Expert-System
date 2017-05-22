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
        Graphics graphics;
        BufferedGraphics bufferedGraphics;
        BufferedGraphicsContext bufferedGraphicsContext;

        public FuzzyVarForm(Symptom par)
        {
            InitializeComponent();

            graphics = panelGraph.CreateGraphics();
            bufferedGraphicsContext = new BufferedGraphicsContext();
            bufferedGraphics = bufferedGraphicsContext.Allocate(graphics, new Rectangle(0, 0, panelGraph.Width, panelGraph.Height));

            parentSymptom = par;

            prototypeFuzzy = null;

            var w = parentSymptom.ReasoningTop - parentSymptom.ReasoningBottom;

            var step = w / 5;

            var typesList = DatabaseManager.Instance.GetTypesMf();
            comboBoxType.Items.Clear();
            foreach (TypeMFunc type in typesList)
            {
                comboBoxType.Items.Add(type.Name);
            }

            var boundList = DatabaseManager.Instance.GetBoundaryTypes();
            comboBoxBound.Items.Clear();
            foreach (BoundaryType bound in boundList) {
                comboBoxBound.Items.Add(bound.Name);
            }
            comboBoxBound.SelectedIndex = comboBoxBound.Items.Count - 1;

            textBoxGC.Text = (w / 2 + parentSymptom.ReasoningBottom).ToString();
            textBoxSigma.Text = (w / 10).ToString();

            textBoxTrianglA.Text = (step + parentSymptom.ReasoningBottom).ToString();
            textBoxTrianglB.Text = (w / 2 + parentSymptom.ReasoningBottom).ToString();
            textBoxTrianglC.Text = (4 * step + parentSymptom.ReasoningBottom).ToString();

            textBoxTrapA.Text = (step + parentSymptom.ReasoningBottom).ToString();
            textBoxTrapB.Text = (2 * step + parentSymptom.ReasoningBottom).ToString();
            textBoxTrapC.Text = (3 * step + parentSymptom.ReasoningBottom).ToString();
            textBoxTrapD.Text = (4 * step + parentSymptom.ReasoningBottom).ToString();

            isInit = true;
        }

        public FuzzyVarForm(Symptom par, FuzzyVariable curr)
        {
            InitializeComponent();

            graphics = panelGraph.CreateGraphics();
            bufferedGraphicsContext = new BufferedGraphicsContext();
            bufferedGraphics = bufferedGraphicsContext.Allocate(graphics, new Rectangle(0, 0, panelGraph.Width, panelGraph.Height));

            parentSymptom = par;

            prototypeFuzzy = curr;

            textBoxName.Text = prototypeFuzzy.Name;

            var w = parentSymptom.ReasoningTop - parentSymptom.ReasoningBottom;

            var step = w / 5;

            var typesList = DatabaseManager.Instance.GetTypesMf();
            comboBoxType.Items.Clear();
            foreach (TypeMFunc type in typesList)
            {
                comboBoxType.Items.Add(type.Name);
            }
            comboBoxType.SelectedIndex = (int)prototypeFuzzy.Type;            

            var boundList = DatabaseManager.Instance.GetBoundaryTypes();
            comboBoxBound.Items.Clear();
            foreach (BoundaryType bound in boundList)
            {
                comboBoxBound.Items.Add(bound.Name);
            }
            comboBoxBound.SelectedIndex = (int)prototypeFuzzy.Bound;

            buttonColor.BackColor = prototypeFuzzy.ColorLine;

            if (prototypeFuzzy.GaussParam.ID < 0) {
                textBoxGC.Text = (w / 2 + parentSymptom.ReasoningBottom).ToString();
                textBoxSigma.Text = (w / 10).ToString();
            } else
            {
                //var param = DatabaseManager.Instance.GetGaussMFuncParams(prototypeFuzzy.GaussParam.ID);
                textBoxGC.Text = prototypeFuzzy.GaussParam.C.ToString();
                textBoxSigma.Text = prototypeFuzzy.GaussParam.Sigma.ToString();
            }

            if (prototypeFuzzy.TrianglParam.ID < 0) {
                textBoxTrianglA.Text = (step + parentSymptom.ReasoningBottom).ToString();
                textBoxTrianglB.Text = (w / 2 + parentSymptom.ReasoningBottom).ToString();
                textBoxTrianglC.Text = (4 * step + parentSymptom.ReasoningBottom).ToString();
            } else
            {
                //var param = DatabaseManager.Instance.GetTriangulareMFuncParams(prototypeFuzzy.TrianglParam.ID);
                textBoxTrianglA.Text = prototypeFuzzy.TrianglParam.A.ToString();
                textBoxTrianglB.Text = prototypeFuzzy.TrianglParam.B.ToString();
                textBoxTrianglC.Text = prototypeFuzzy.TrianglParam.C.ToString();
            }

            if (prototypeFuzzy.TrapezParam.ID < 0)
            {
                textBoxTrapA.Text = (step + parentSymptom.ReasoningBottom).ToString();
                textBoxTrapB.Text = (2 * step + parentSymptom.ReasoningBottom).ToString();
                textBoxTrapC.Text = (3 * step + parentSymptom.ReasoningBottom).ToString();
                textBoxTrapD.Text = (4 * step + parentSymptom.ReasoningBottom).ToString();
            } else
            {
                //var param = DatabaseManager.Instance.GetTrapezoidalMFuncParams(prototypeFuzzy.TrapezParam.ID);
                textBoxTrapA.Text = prototypeFuzzy.TrapezParam.A.ToString();
                textBoxTrapB.Text = prototypeFuzzy.TrapezParam.B.ToString();
                textBoxTrapC.Text = prototypeFuzzy.TrapezParam.C.ToString();
                textBoxTrapD.Text = prototypeFuzzy.TrapezParam.D.ToString();
            }

            isInit = true;

            DrawGraph();
        }

        private Symptom parentSymptom;
        private bool isInit = false;
        private FuzzyVariable prototypeFuzzy;

        private void panelGraph_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph();
        }

        private void FuzzyVarForm_Resize(object sender, EventArgs e)
        {
            graphics = panelGraph.CreateGraphics();
            bufferedGraphicsContext = new BufferedGraphicsContext();
            bufferedGraphics = bufferedGraphicsContext.Allocate(graphics, new Rectangle(0, 0, panelGraph.Width, panelGraph.Height));

            DrawGraph();
        }

        private int mouseX = 0;
        private int mouseY = 0;
        private bool mouseButtonPress = false;

        private void DrawGraph()
        {
            bufferedGraphics.Graphics.Clear(panelGraph.BackColor);

            GraphicOnFrom.PaintGrid(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height);
            GraphicOnFrom.DrawBottomScale(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height, parentSymptom.ReasoningBottom, parentSymptom.ReasoningTop);

            if (!isInit) return;

            switch ((TypeMFuncEnum)comboBoxType.SelectedIndex)
            {
                case TypeMFuncEnum.GAUSS:
                    GraphicOnFrom.DrawGaussMF(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height, 
                        buttonColor.BackColor, 
                        Convert.ToDouble(textBoxGC.Text), 
                        Convert.ToDouble(textBoxSigma.Text), 
                        parentSymptom.ReasoningBottom, 
                        parentSymptom.ReasoningTop,
                        (BoundaryTypeEnum)comboBoxBound.SelectedIndex);

                    GraphicOnFrom.DrawGaussPoints(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height, 
                        textBoxName.Text, 
                        buttonColor.BackColor,
                        Convert.ToDouble(textBoxGC.Text),
                        Convert.ToDouble(textBoxSigma.Text),
                        parentSymptom.ReasoningBottom,
                        parentSymptom.ReasoningTop,
                        (BoundaryTypeEnum)comboBoxBound.SelectedIndex);
                    break;
                case TypeMFuncEnum.TRIANGULARE:
                    GraphicOnFrom.DrawTrianglMF(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height, 
                        buttonColor.BackColor,
                        Convert.ToDouble(textBoxTrianglA.Text), 
                        Convert.ToDouble(textBoxTrianglB.Text),
                        Convert.ToDouble(textBoxTrianglC.Text),
                        parentSymptom.ReasoningBottom, 
                        parentSymptom.ReasoningTop,
                        (BoundaryTypeEnum)comboBoxBound.SelectedIndex);

                    GraphicOnFrom.DrawTrianglPoints(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height,
                        textBoxName.Text,
                        buttonColor.BackColor,
                        Convert.ToDouble(textBoxTrianglA.Text),
                        Convert.ToDouble(textBoxTrianglB.Text),
                        Convert.ToDouble(textBoxTrianglC.Text),
                        parentSymptom.ReasoningBottom,
                        parentSymptom.ReasoningTop,
                        (BoundaryTypeEnum)comboBoxBound.SelectedIndex);
                    break;
                case TypeMFuncEnum.TRAPEZOIDAL:
                    GraphicOnFrom.DrawTrapezMF(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height,
                        buttonColor.BackColor,
                        Convert.ToDouble(textBoxTrapA.Text),
                        Convert.ToDouble(textBoxTrapB.Text),
                        Convert.ToDouble(textBoxTrapC.Text),
                        Convert.ToDouble(textBoxTrapD.Text),
                        parentSymptom.ReasoningBottom,
                        parentSymptom.ReasoningTop,
                        (BoundaryTypeEnum)comboBoxBound.SelectedIndex);

                    GraphicOnFrom.DrawTrapezoidalPoints(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height,
                        textBoxName.Text,
                        buttonColor.BackColor,
                        Convert.ToDouble(textBoxTrapA.Text),
                        Convert.ToDouble(textBoxTrapB.Text),
                        Convert.ToDouble(textBoxTrapC.Text),
                        Convert.ToDouble(textBoxTrapD.Text),
                        parentSymptom.ReasoningBottom,
                        parentSymptom.ReasoningTop,
                        (BoundaryTypeEnum)comboBoxBound.SelectedIndex);
                    break;
                default:
                    //MessageBox.Show("I don`t know this variable type", "Variable type error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            bufferedGraphics.Render();
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

            DrawGraph();
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
            } else
            {
                newFuzzy = new FuzzyVariable(-1, 
                    parentSymptom.ID, 
                    textBoxName.Text, 
                    buttonColor.BackColor);
            }

            newFuzzy.Type = (TypeMFuncEnum)comboBoxType.SelectedIndex;
            newFuzzy.Bound = (BoundaryTypeEnum)comboBoxBound.SelectedIndex;

            newFuzzy.GaussParam = new GaussMFuncParams(double.Parse(textBoxGC.Text),
                                double.Parse(textBoxSigma.Text));
            newFuzzy.TrianglParam = new TriangulareMFuncParams(double.Parse(textBoxTrianglA.Text),
                                double.Parse(textBoxTrianglB.Text),
                                double.Parse(textBoxTrianglC.Text));
            newFuzzy.TrapezParam = new TrapezoidalMFuncParams(double.Parse(textBoxTrapA.Text),
                                double.Parse(textBoxTrapB.Text),
                                double.Parse(textBoxTrapC.Text),
                                double.Parse(textBoxTrapD.Text));

            if (prototypeFuzzy != null)
            {
                newFuzzy.GaussParam.ID = prototypeFuzzy.GaussParam.ID;
                newFuzzy.TrianglParam.ID = prototypeFuzzy.TrianglParam.ID;
                newFuzzy.TrapezParam.ID = prototypeFuzzy.TrapezParam.ID;
            }


            if (newFuzzy.CheckData())
            {
                switch(newFuzzy.Type)
                {
                    case TypeMFuncEnum.GAUSS:
                        if ((prototypeFuzzy != null) && (prototypeFuzzy.GaussParam.ID >= 0))
                        {
                            newFuzzy.GaussParam.ID = prototypeFuzzy.GaussParam.ID;
                            DatabaseManager.Instance.UpdateMF(newFuzzy.GaussParam);
                        }
                        else
                        {                            
                            newFuzzy.GaussParam.ID = DatabaseManager.Instance.InsertMF(newFuzzy.GaussParam);
                            //newFuzzy.IdGaussian = DatabaseManager.Instance.InsertMF(double.Parse(textBoxGC.Text),
                            //    double.Parse(textBoxSigma.Text));
                        }
                        break;
                    case TypeMFuncEnum.TRIANGULARE:
                        if ((prototypeFuzzy != null) && (prototypeFuzzy.TrianglParam.ID >= 0))
                        {
                            newFuzzy.TrianglParam.ID = prototypeFuzzy.TrianglParam.ID;
                            DatabaseManager.Instance.UpdateMF(newFuzzy.TrianglParam);
                        }
                        else
                        {                            
                            newFuzzy.TrianglParam.ID = DatabaseManager.Instance.InsertMF(newFuzzy.TrianglParam);
                            //newFuzzy.IdTriangulare = DatabaseManager.Instance.InsertMF(double.Parse(textBoxTrianglA.Text),
                            //    double.Parse(textBoxTrianglB.Text),
                            //    double.Parse(textBoxTrianglC.Text));
                        }
                        break;
                    case TypeMFuncEnum.TRAPEZOIDAL:
                        if ((prototypeFuzzy != null) && (prototypeFuzzy.TrapezParam.ID >= 0))
                        {
                            newFuzzy.TrapezParam.ID = prototypeFuzzy.TrapezParam.ID;
                            DatabaseManager.Instance.UpdateMF(newFuzzy.TrapezParam);
                        }
                        else
                        {                            
                            newFuzzy.TrapezParam.ID = DatabaseManager.Instance.InsertMF(newFuzzy.TrapezParam);
                            //newFuzzy.IdTrapezoidal = DatabaseManager.Instance.InsertMF(double.Parse(textBoxTrapA.Text),
                            //    double.Parse(textBoxTrapB.Text),
                            //    double.Parse(textBoxTrapC.Text),
                            //    double.Parse(textBoxTrapD.Text));
                        }
                        break;
                    default:
                        break;
                }

                SymptomEditing parent = this.Owner as SymptomEditing;

                int i = -1;
                if (prototypeFuzzy != null)
                {
                    prototypeFuzzy = newFuzzy;
                    DatabaseManager.Instance.UpdateFuzzyVar(prototypeFuzzy);

                    i = parent.dataGridViewFuzzyVar.SelectedCells[0].RowIndex;

                    parent.dataGridViewFuzzyVar.Rows[i].Cells[0].Value = prototypeFuzzy.ID.ToString();
                    parent.dataGridViewFuzzyVar.Rows[i].Cells[1].Value = prototypeFuzzy.Name;

                    parent.FuzzyList.Find(x => x.ID == prototypeFuzzy.ID).Set(prototypeFuzzy);
                }
                else
                {
                    prototypeFuzzy = newFuzzy;
                    prototypeFuzzy.ID = DatabaseManager.Instance.InsertFuzzyVar(prototypeFuzzy);

                    string[] row = new string[] { prototypeFuzzy.ID.ToString(), prototypeFuzzy.Name };
                    i = parent.dataGridViewFuzzyVar.Rows.Add(row);

                    parent.FuzzyList.Add(prototypeFuzzy);
                }

                // TO DO: Хранить в свойстве класса, а не локально
                parent.dataGridViewFuzzyVar.Rows[i].Cells[2].Value = ((int)prototypeFuzzy.Type).ToString();
                parent.dataGridViewFuzzyVar.Rows[i].Cells[3].Value = DatabaseManager.Instance.GetTypeMFunc((long)prototypeFuzzy.Type).Name;

                parent.dataGridViewFuzzyVar.Rows[i].Cells[4].Value = ((int)prototypeFuzzy.Bound).ToString();
                parent.dataGridViewFuzzyVar.Rows[i].Cells[5].Value = DatabaseManager.Instance.GetBoundaryType((long)prototypeFuzzy.Bound).Name;

                var buttonColor = parent.dataGridViewFuzzyVar.Rows[i].Cells[6] as DataGridViewButtonCell;
                buttonColor.FlatStyle = FlatStyle.Flat;
                buttonColor.Style.BackColor = prototypeFuzzy.ColorLine;

                parent.dataGridViewFuzzyVar.Rows[i].Cells[7].Value = prototypeFuzzy.TrapezParam.ID.ToString();
                parent.dataGridViewFuzzyVar.Rows[i].Cells[8].Value = prototypeFuzzy.TrapezParam.ID.ToString();
                parent.dataGridViewFuzzyVar.Rows[i].Cells[9].Value = prototypeFuzzy.GaussParam.ID.ToString();
                
                this.Close();
            }
            else
            {
                MessageBox.Show(String.Format("Запись не добавлена в базу данных по причине: {0}", newFuzzy.LastTrouble),
                    "Запись не добавлена / не отредактирована", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxBound_SelectedIndexChanged(object sender, EventArgs e)
        {
            DrawGraph();
        }

        private void panelGraph_MouseDown(object sender, MouseEventArgs e)
        {
            mouseButtonPress = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void panelGraph_MouseUp(object sender, MouseEventArgs e)
        {
            mouseButtonPress = false;
            mouseX = 0;
            mouseY = 0;
        }

        private void panelGraph_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;

            //DrawGraph();
        }

        private void buttonRedraw_Click(object sender, EventArgs e)
        {
            DrawGraph();
        }
    }
}
