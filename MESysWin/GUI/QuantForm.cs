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
    public partial class QuantForm : Form
    {
        Graphics graphics;
        BufferedGraphics bufferedGraphics;
        BufferedGraphicsContext bufferedGraphicsContext;
        private bool isInit = false;
        private List<Quantifier> listQuant;

        public QuantForm()
        {
            InitializeComponent();

            graphics = panelGraph.CreateGraphics();
            bufferedGraphicsContext = new BufferedGraphicsContext();
            bufferedGraphics = bufferedGraphicsContext.Allocate(graphics, new Rectangle(0, 0, panelGraph.Width, panelGraph.Height));

            isInit = true;

            //listBoxQuant.Items.Add(String.Empty);
            listQuant = DatabaseManager.Instance.GetQuantifiers();
            foreach(var quant in listQuant)
            {
                listBoxQuant.Items.Add(quant.Name);
            }

            listBoxQuant.SelectedIndex = 0;
        }

        private void panelGraph_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph();
        }

        public void DrawGraph()
        {

            bufferedGraphics.Graphics.Clear(panelGraph.BackColor);

            GraphicOnFrom.PaintGrid(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height);
            if (!isInit) { bufferedGraphics.Render(); return; }

            GraphicOnFrom.DrawGaussMF(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height, Color.DarkGreen, 50, 15, 0, 100, BoundaryTypeEnum.MIDDLE);
            GraphicOnFrom.DrawGaussMF(bufferedGraphics.Graphics, panelGraph.Width, panelGraph.Height, Color.Red, 50, 15, 0, 100, BoundaryTypeEnum.MIDDLE, (QuantifierEnum)listBoxQuant.SelectedIndex);

            bufferedGraphics.Render();
        }

        private void QuantForm_Resize(object sender, EventArgs e)
        {
            graphics = panelGraph.CreateGraphics();
            bufferedGraphicsContext = new BufferedGraphicsContext();
            bufferedGraphics = bufferedGraphicsContext.Allocate(graphics, new Rectangle(0, 0, panelGraph.Width, panelGraph.Height));

            DrawGraph();
        }

        private void listBoxQuant_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelIDvalue.Text = listQuant[listBoxQuant.SelectedIndex].ID.ToString();
            labelRuleValue.Text = listQuant[listBoxQuant.SelectedIndex].Rule;

            DrawGraph();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
