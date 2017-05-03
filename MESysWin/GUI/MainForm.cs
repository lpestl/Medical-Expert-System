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
using MESysWin.GUI;

namespace MESysWin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DatabaseManager.Instance.DatabaseConnect();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            DatabaseManager.Instance.DatabaseConnect();
        }*/
        
        private void timerForLog_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelInfo.Text = Log.lastLine;
        }

        private void lingVarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var symptomsForm = new LingVar();
            symptomsForm.Show();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var typeForm = new TypeMFform();
            typeForm.Show();
        }
    }
}
