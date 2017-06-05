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
        Graphics graphics;
        BufferedGraphics bufferedGraphics;
        BufferedGraphicsContext bufferedGraphicsContext;

        public SymptomEditing()
        {
            InitializeComponent();

            graphics = panelGraph.CreateGraphics();
            bufferedGraphicsContext = new BufferedGraphicsContext();
            bufferedGraphics = bufferedGraphicsContext.Allocate(graphics, new Rectangle(0, 0, panelGraph.Width, panelGraph.Height));

            prototypeSymtom = null;

            dataGridViewFuzzyVar.Enabled = false;
            buttonAdd.Enabled = false;
            buttonRemove.Enabled = false;
            buttonEdit.Enabled = false;

            isInit = true;
        }

        private bool isInit = false;
        private Symptom prototypeSymtom;

        public List<FuzzyVariable> FuzzyList;

        public SymptomEditing(Symptom smp)
        {
            InitializeComponent();

            graphics = panelGraph.CreateGraphics();
            bufferedGraphicsContext = new BufferedGraphicsContext();
            bufferedGraphics = bufferedGraphicsContext.Allocate(graphics, new Rectangle(0, 0, panelGraph.Width, panelGraph.Height));

            prototypeSymtom = smp;

            textBoxNameLV.Text = prototypeSymtom.Name;
            textBoxBottom.Text = prototypeSymtom.ReasoningBottom.ToString();
            textBoxTop.Text = prototypeSymtom.ReasoningTop.ToString();

            FuzzyList = DatabaseManager.Instance.GetFuzzyVariables(prototypeSymtom.ID);
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
                buttonColor.Style.BackColor = fv.ColorLine;

                dataGridViewFuzzyVar.Rows[i].Cells[7].Value = fv.TrianglParam.ID;
                if (fv.TrianglParam.ID >= 0)
                {
                    var TrianglP = DatabaseManager.Instance.GetTriangulareMFuncParams(fv.TrianglParam.ID);
                    fv.TrianglParam = TrianglP;
                }
                dataGridViewFuzzyVar.Rows[i].Cells[8].Value = fv.TrapezParam.ID;
                if (fv.TrapezParam.ID >= 0)
                {
                    var TrapezP = DatabaseManager.Instance.GetTrapezoidalMFuncParams(fv.TrapezParam.ID);
                    fv.TrapezParam = TrapezP;
                }
                dataGridViewFuzzyVar.Rows[i].Cells[9].Value = fv.GaussParam.ID;
                if (fv.GaussParam.ID >= 0)
                {
                    var GaussP = DatabaseManager.Instance.GetGaussMFuncParams(fv.GaussParam.ID);
                    fv.GaussParam = GaussP;
                }
            }

            isInit = true;
        }

        private void panelGraph_Paint(object sender, PaintEventArgs e)
        {
            //GraphicOnFrom.PaintGrid(panelGraph);
            //GraphicOnFrom.DrawBottomScale(panelGraph, double.Parse(textBoxBottom.Text), double.Parse(textBoxTop.Text));
            DrawGraphs();
        }

        private void SymptomEditing_Resize(object sender, EventArgs e)
        {

            graphics = panelGraph.CreateGraphics();
            bufferedGraphicsContext = new BufferedGraphicsContext();
            bufferedGraphics = bufferedGraphicsContext.Allocate(graphics, new Rectangle(0, 0, panelGraph.Width, panelGraph.Height));

            //GraphicOnFrom.PaintGrid(panelGraph);
            //GraphicOnFrom.DrawBottomScale(panelGraph, double.Parse(textBoxBottom.Text), double.Parse(textBoxTop.Text));
            DrawGraphs();
        }

        private void buttonRedraw_Click(object sender, EventArgs e)
        {
            //GraphicOnFrom.PaintGrid(panelGraph);
            //GraphicOnFrom.DrawBottomScale(panelGraph, double.Parse(textBoxBottom.Text), double.Parse(textBoxTop.Text));
            DrawGraphs();

        }

        private void DrawGraphs()
        {
            bufferedGraphics.Graphics.Clear(panelGraph.BackColor);
            
            GraphicOnFrom.PaintGrid(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height);
            if ((!isInit) || (FuzzyList == null)) { bufferedGraphics.Render(); return; }
            GraphicOnFrom.DrawBottomScale(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height, double.Parse(textBoxBottom.Text), double.Parse(textBoxTop.Text));

            int i = 0;
            foreach (var fv in FuzzyList)
            {
                switch (fv.Type)
                {
                    case TypeMFuncEnum.GAUSS:
                        GraphicOnFrom.DrawGaussMF(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height,
                            fv.ColorLine,
                            fv.GaussParam.C,
                            fv.GaussParam.Sigma,
                            prototypeSymtom.ReasoningBottom,
                            prototypeSymtom.ReasoningTop,
                            fv.Bound);

                        GraphicOnFrom.DrawGaussPoints(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height,
                            fv.Name,
                            fv.ColorLine,
                            fv.GaussParam.C,
                            fv.GaussParam.Sigma,
                            prototypeSymtom.ReasoningBottom,
                            prototypeSymtom.ReasoningTop,
                            fv.Bound, i);
                        break;
                    case TypeMFuncEnum.TRIANGULARE:
                        GraphicOnFrom.DrawTrianglMF(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height,
                            fv.ColorLine,
                            fv.TrianglParam.A,
                            fv.TrianglParam.B,
                            fv.TrianglParam.C,
                            prototypeSymtom.ReasoningBottom,
                            prototypeSymtom.ReasoningTop,
                            fv.Bound);

                        GraphicOnFrom.DrawTrianglPoints(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height,
                            fv.Name,
                            fv.ColorLine,
                            fv.TrianglParam.A,
                            fv.TrianglParam.B,
                            fv.TrianglParam.C,
                            prototypeSymtom.ReasoningBottom,
                            prototypeSymtom.ReasoningTop,
                            fv.Bound, false, i);
                        break;
                    case TypeMFuncEnum.TRAPEZOIDAL:
                        GraphicOnFrom.DrawTrapezMF(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height,
                            fv.ColorLine,
                            fv.TrapezParam.A,
                            fv.TrapezParam.B,
                            fv.TrapezParam.C,
                            fv.TrapezParam.D,
                            prototypeSymtom.ReasoningBottom,
                            prototypeSymtom.ReasoningTop,
                            fv.Bound);

                        GraphicOnFrom.DrawTrapezoidalPoints(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height,
                            fv.Name,
                            fv.ColorLine,
                            fv.TrapezParam.A,
                            fv.TrapezParam.B,
                            fv.TrapezParam.C,
                            fv.TrapezParam.D,
                            prototypeSymtom.ReasoningBottom,
                            prototypeSymtom.ReasoningTop,
                            fv.Bound, i);
                        break;
                    default:
                        //MessageBox.Show("I don`t know this variable type", "Variable type error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                i++;
            }
            bufferedGraphics.Render();
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

                if (MessageBox.Show("Вы действительно хотите удалить запись о нечеткой переменной из Базы Знаний, " +
                    "из базы данных и из приложения?\r\n\r\n" +
                    "ВНИМАНИЕ!!! Удаление приведет к тому, что будет так же удален АНТЕЦЕДЕНТ из правила в Базе Знаний," +
                    " а значит диагностика в РЕЖИМЕ КОНСУЛЬТАЦИИ будет не верна! Медицинская информационная система " +
                    "будет диагностировать не верно то заболевание, в правиле которого учавствовал данный АНТЕЦЕДЕНТ!!!\r\n\r\n" +
                    "Вы уверены, что хотите удалить эту переменную?",
                        String.Format("Удаление \"{0}\"", Convert.ToString(dataGridViewFuzzyVar.Rows[i].Cells[1].Value)),
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //var buttonColor = dataGridViewFuzzyVar.Rows[i].Cells[3] as DataGridViewButtonCell;

                    /*FuzzyVariable fv = new FuzzyVariable(id_in_db,
                        Convert.ToString(dataGridViewFuzzyVar.Rows[i].Cells[1].Value),
                        buttonColor.Style.BackColor);*/

                    long j,y,z;
                    j = Convert.ToInt64(dataGridViewFuzzyVar.Rows[i].Cells[7].Value);                    
                    y = Convert.ToInt64(dataGridViewFuzzyVar.Rows[i].Cells[8].Value);
                    z = Convert.ToInt64(dataGridViewFuzzyVar.Rows[i].Cells[9].Value);

                    if (DatabaseManager.Instance.DeleteFromTable(id_in_db, "fuzzy_variable", "id_var"))
                    {
                        if (j != -1) DatabaseManager.Instance.DeleteFromTable(j,
                            "triangular_mf", "id_triangl_mf");

                        if (y != -1) DatabaseManager.Instance.DeleteFromTable(y,
                            "trapezoidal_mf", "id_trapez_mf");

                        if (z != -1) DatabaseManager.Instance.DeleteFromTable(z,
                            "gauss_mf", "id_gauss_mf");

                        dataGridViewFuzzyVar.Rows.RemoveAt(i);

                        FuzzyList.Remove(FuzzyList.Find(x => x.ID == id_in_db));
                    } else
                    {
                        MessageBox.Show("Вы не можете удалить выбранную запись, по той причине, что она используется в правиле Базы Знаний." +
                            " Её удаление приведет к неправильной работе приложения." +
                            " Чтобы удалить эту переменную, удалите или измените сначала правило из базы знаний в котором она используется.",
                            "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ничего не удалено! Не выделено ни одной строки с данными.", "Удаления не произошло", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DrawGraphs();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var FuzzyForm = new FuzzyVarForm(prototypeSymtom);
            FuzzyForm.Owner = this;
            FuzzyForm.ShowDialog();

            DrawGraphs();
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

                var prototypeFuzzy = FuzzyList.Find(x => x.ID == id_in_db);
                /*var colorBut = dataGridViewFuzzyVar.Rows[i].Cells[6] as DataGridViewButtonCell;

                var prototypeFuzzy = new FuzzyVariable(id_in_db,
                    prototypeSymtom.ID,
                    Convert.ToString(dataGridViewFuzzyVar.Rows[i].Cells[1].Value),
                    colorBut.Style.BackColor);

                prototypeFuzzy.Type = (TypeMFuncEnum)Convert.ToInt32(dataGridViewFuzzyVar.Rows[i].Cells[2].Value);
                prototypeFuzzy.Bound = (BoundaryTypeEnum)Convert.ToInt32(dataGridViewFuzzyVar.Rows[i].Cells[4].Value);

                prototypeFuzzy.IdTriangulare = Convert.ToInt64(dataGridViewFuzzyVar.Rows[i].Cells[7].Value);
                prototypeFuzzy.IdTrapezoidal = Convert.ToInt64(dataGridViewFuzzyVar.Rows[i].Cells[8].Value);
                prototypeFuzzy.IdGaussian = Convert.ToInt64(dataGridViewFuzzyVar.Rows[i].Cells[9].Value);*/

                var FuzzyForm = new FuzzyVarForm(prototypeSymtom, prototypeFuzzy);
                FuzzyForm.Owner = this;
                FuzzyForm.ShowDialog();
            } else
            {
                MessageBox.Show("Ничего не выделено для редактирования!", "Объект не выделен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DrawGraphs();
        }
    }
}
