namespace MESysWin.GUI
{
    partial class QuantForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.listBoxQuant = new System.Windows.Forms.ListBox();
            this.groupBoxQuant = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labelIDvalue = new System.Windows.Forms.Label();
            this.labelRule = new System.Windows.Forms.Label();
            this.labelExample = new System.Windows.Forms.Label();
            this.labelRuleValue = new System.Windows.Forms.Label();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.labelMF = new System.Windows.Forms.Label();
            this.labelQMF = new System.Windows.Forms.Label();
            this.groupBoxQuant.SuspendLayout();
            this.panelGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(636, 351);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // listBoxQuant
            // 
            this.listBoxQuant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxQuant.FormattingEnabled = true;
            this.listBoxQuant.Location = new System.Drawing.Point(6, 19);
            this.listBoxQuant.Name = "listBoxQuant";
            this.listBoxQuant.Size = new System.Drawing.Size(292, 303);
            this.listBoxQuant.TabIndex = 1;
            this.listBoxQuant.SelectedIndexChanged += new System.EventHandler(this.listBoxQuant_SelectedIndexChanged);
            // 
            // groupBoxQuant
            // 
            this.groupBoxQuant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxQuant.Controls.Add(this.buttonEdit);
            this.groupBoxQuant.Controls.Add(this.buttonRemove);
            this.groupBoxQuant.Controls.Add(this.buttonAdd);
            this.groupBoxQuant.Controls.Add(this.listBoxQuant);
            this.groupBoxQuant.Location = new System.Drawing.Point(13, 13);
            this.groupBoxQuant.Name = "groupBoxQuant";
            this.groupBoxQuant.Size = new System.Drawing.Size(304, 361);
            this.groupBoxQuant.TabIndex = 2;
            this.groupBoxQuant.TabStop = false;
            this.groupBoxQuant.Text = "Квантификаторы";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(6, 332);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(87, 332);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Location = new System.Drawing.Point(168, 332);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(130, 23);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(323, 13);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 13);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID:";
            // 
            // labelIDvalue
            // 
            this.labelIDvalue.AutoSize = true;
            this.labelIDvalue.Location = new System.Drawing.Point(350, 13);
            this.labelIDvalue.Name = "labelIDvalue";
            this.labelIDvalue.Size = new System.Drawing.Size(16, 13);
            this.labelIDvalue.TabIndex = 4;
            this.labelIDvalue.Text = "-1";
            // 
            // labelRule
            // 
            this.labelRule.AutoSize = true;
            this.labelRule.Location = new System.Drawing.Point(323, 32);
            this.labelRule.Name = "labelRule";
            this.labelRule.Size = new System.Drawing.Size(202, 13);
            this.labelRule.TabIndex = 5;
            this.labelRule.Text = "Изменение функции принадлежности:";
            // 
            // labelExample
            // 
            this.labelExample.AutoSize = true;
            this.labelExample.Location = new System.Drawing.Point(323, 127);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(50, 13);
            this.labelExample.TabIndex = 6;
            this.labelExample.Text = "Пример:";
            // 
            // labelRuleValue
            // 
            this.labelRuleValue.AutoSize = true;
            this.labelRuleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRuleValue.Location = new System.Drawing.Point(347, 66);
            this.labelRuleValue.Name = "labelRuleValue";
            this.labelRuleValue.Size = new System.Drawing.Size(89, 31);
            this.labelRuleValue.TabIndex = 7;
            this.labelRuleValue.Text = "MF(x)";
            // 
            // panelGraph
            // 
            this.panelGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelGraph.Controls.Add(this.labelQMF);
            this.panelGraph.Controls.Add(this.labelMF);
            this.panelGraph.Location = new System.Drawing.Point(325, 143);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(386, 202);
            this.panelGraph.TabIndex = 8;
            this.panelGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraph_Paint);
            // 
            // labelMF
            // 
            this.labelMF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMF.AutoSize = true;
            this.labelMF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMF.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelMF.Location = new System.Drawing.Point(12, 179);
            this.labelMF.Name = "labelMF";
            this.labelMF.Size = new System.Drawing.Size(46, 16);
            this.labelMF.TabIndex = 9;
            this.labelMF.Text = "MF(x)";
            // 
            // labelQMF
            // 
            this.labelQMF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQMF.AutoSize = true;
            this.labelQMF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQMF.ForeColor = System.Drawing.Color.Red;
            this.labelQMF.Location = new System.Drawing.Point(261, 179);
            this.labelQMF.Name = "labelQMF";
            this.labelQMF.Size = new System.Drawing.Size(122, 16);
            this.labelQMF.TabIndex = 10;
            this.labelQMF.Text = "Quantifier(MF(x))";
            // 
            // QuantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 386);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.labelRuleValue);
            this.Controls.Add(this.labelExample);
            this.Controls.Add(this.labelRule);
            this.Controls.Add(this.labelIDvalue);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.groupBoxQuant);
            this.Controls.Add(this.buttonClose);
            this.Name = "QuantForm";
            this.Text = "Квантификаторы";
            this.Resize += new System.EventHandler(this.QuantForm_Resize);
            this.groupBoxQuant.ResumeLayout(false);
            this.panelGraph.ResumeLayout(false);
            this.panelGraph.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListBox listBoxQuant;
        private System.Windows.Forms.GroupBox groupBoxQuant;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelIDvalue;
        private System.Windows.Forms.Label labelRule;
        private System.Windows.Forms.Label labelExample;
        private System.Windows.Forms.Label labelRuleValue;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Label labelQMF;
        private System.Windows.Forms.Label labelMF;
    }
}