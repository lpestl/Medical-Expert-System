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

            Log.Print("Open MainForm", "mainForm", Log.type.INFO);
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
            Log.Print("Click Menu -> KnowBase -> Symptoms", "mainForm", Log.type.INFO);
            var symptomsForm = new LingVar();
            symptomsForm.Show();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Print("Click Menu -> KnowBase -> MF_types", "mainForm", Log.type.INFO);
            var typeForm = new TypeMFform();
            typeForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Print("Click Menu -> File -> Exit", "mainForm", Log.type.INFO);
            this.Close();
        }
    }
}
