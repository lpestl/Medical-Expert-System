namespace MESysWin.GUI
{
    partial class SymptomEditing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelLingVar = new System.Windows.Forms.Label();
            this.textBoxNameLV = new System.Windows.Forms.TextBox();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.textBoxTop = new System.Windows.Forms.TextBox();
            this.textBoxBottom = new System.Windows.Forms.TextBox();
            this.buttonRedraw = new System.Windows.Forms.Button();
            this.groupBoxTermM = new System.Windows.Forms.GroupBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewFuzzyVar = new System.Windows.Forms.DataGridView();
            this.id_fuzzy_var = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameFuzzyVar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeMfColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeFuzzyVar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBoundTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeBound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorFuzzyVar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnIdTriangle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdTrapez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdGauss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGraph.SuspendLayout();
            this.groupBoxTermM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuzzyVar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(566, 326);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(647, 326);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelLingVar
            // 
            this.labelLingVar.AutoSize = true;
            this.labelLingVar.Location = new System.Drawing.Point(13, 13);
            this.labelLingVar.Name = "labelLingVar";
            this.labelLingVar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLingVar.Size = new System.Drawing.Size(270, 13);
            this.labelLingVar.TabIndex = 2;
            this.labelLingVar.Text = "Имя лингвистической переменной (имя симптома):";
            // 
            // textBoxNameLV
            // 
            this.textBoxNameLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameLV.Location = new System.Drawing.Point(289, 10);
            this.textBoxNameLV.Name = "textBoxNameLV";
            this.textBoxNameLV.Size = new System.Drawing.Size(433, 20);
            this.textBoxNameLV.TabIndex = 3;
            // 
            // panelGraph
            // 
            this.panelGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelGraph.Controls.Add(this.textBoxTop);
            this.panelGraph.Controls.Add(this.textBoxBottom);
            this.panelGraph.Location = new System.Drawing.Point(16, 36);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(362, 280);
            this.panelGraph.TabIndex = 4;
            this.panelGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraph_Paint);
            // 
            // textBoxTop
            // 
            this.textBoxTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTop.Location = new System.Drawing.Point(309, 257);
            this.textBoxTop.Name = "textBoxTop";
            this.textBoxTop.Size = new System.Drawing.Size(50, 20);
            this.textBoxTop.TabIndex = 1;
            this.textBoxTop.Text = "100";
            this.textBoxTop.TextChanged += new System.EventHandler(this.textBoxTop_TextChanged);
            // 
            // textBoxBottom
            // 
            this.textBoxBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxBottom.Location = new System.Drawing.Point(3, 257);
            this.textBoxBottom.Name = "textBoxBottom";
            this.textBoxBottom.Size = new System.Drawing.Size(50, 20);
            this.textBoxBottom.TabIndex = 0;
            this.textBoxBottom.Text = "0";
            this.textBoxBottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxBottom.TextChanged += new System.EventHandler(this.textBoxBottom_TextChanged);
            // 
            // buttonRedraw
            // 
            this.buttonRedraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRedraw.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRedraw.Location = new System.Drawing.Point(12, 326);
            this.buttonRedraw.Name = "buttonRedraw";
            this.buttonRedraw.Size = new System.Drawing.Size(151, 23);
            this.buttonRedraw.TabIndex = 5;
            this.buttonRedraw.Text = "Пересчитать график";
            this.buttonRedraw.UseVisualStyleBackColor = false;
            this.buttonRedraw.Click += new System.EventHandler(this.buttonRedraw_Click);
            // 
            // groupBoxTermM
            // 
            this.groupBoxTermM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTermM.Controls.Add(this.buttonEdit);
            this.groupBoxTermM.Controls.Add(this.buttonRemove);
            this.groupBoxTermM.Controls.Add(this.buttonAdd);
            this.groupBoxTermM.Controls.Add(this.dataGridViewFuzzyVar);
            this.groupBoxTermM.Location = new System.Drawing.Point(384, 37);
            this.groupBoxTermM.Name = "groupBoxTermM";
            this.groupBoxTermM.Size = new System.Drawing.Size(338, 279);
            this.groupBoxTermM.TabIndex = 6;
            this.groupBoxTermM.TabStop = false;
            this.groupBoxTermM.Text = "Базовое терм-множество (список нечетких переменных)";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(65, 249);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(267, 23);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(36, 249);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(23, 23);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(7, 249);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewFuzzyVar
            // 
            this.dataGridViewFuzzyVar.AllowUserToAddRows = false;
            this.dataGridViewFuzzyVar.AllowUserToDeleteRows = false;
            this.dataGridViewFuzzyVar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFuzzyVar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuzzyVar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_fuzzy_var,
            this.NameFuzzyVar,
            this.idTypeMfColumn,
            this.typeFuzzyVar,
            this.idBoundTypeColumn,
            this.typeBound,
            this.ColorFuzzyVar,
            this.ColumnIdTriangle,
            this.ColumnIdTrapez,
            this.ColumnIdGauss});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFuzzyVar.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFuzzyVar.Location = new System.Drawing.Point(7, 30);
            this.dataGridViewFuzzyVar.Name = "dataGridViewFuzzyVar";
            this.dataGridViewFuzzyVar.ReadOnly = true;
            this.dataGridViewFuzzyVar.Size = new System.Drawing.Size(325, 213);
            this.dataGridViewFuzzyVar.TabIndex = 0;
            // 
            // id_fuzzy_var
            // 
            this.id_fuzzy_var.FillWeight = 50F;
            this.id_fuzzy_var.HeaderText = "ID";
            this.id_fuzzy_var.Name = "id_fuzzy_var";
            this.id_fuzzy_var.ReadOnly = true;
            this.id_fuzzy_var.Width = 25;
            // 
            // NameFuzzyVar
            // 
            this.NameFuzzyVar.HeaderText = "Имя";
            this.NameFuzzyVar.Name = "NameFuzzyVar";
            this.NameFuzzyVar.ReadOnly = true;
            // 
            // idTypeMfColumn
            // 
            this.idTypeMfColumn.HeaderText = "ID_MF";
            this.idTypeMfColumn.Name = "idTypeMfColumn";
            this.idTypeMfColumn.ReadOnly = true;
            this.idTypeMfColumn.Width = 30;
            // 
            // typeFuzzyVar
            // 
            this.typeFuzzyVar.HeaderText = "Тип функции";
            this.typeFuzzyVar.Name = "typeFuzzyVar";
            this.typeFuzzyVar.ReadOnly = true;
            // 
            // idBoundTypeColumn
            // 
            this.idBoundTypeColumn.HeaderText = "ID_bound";
            this.idBoundTypeColumn.Name = "idBoundTypeColumn";
            this.idBoundTypeColumn.ReadOnly = true;
            this.idBoundTypeColumn.Width = 30;
            // 
            // typeBound
            // 
            this.typeBound.HeaderText = "Тип границы истинности";
            this.typeBound.Name = "typeBound";
            this.typeBound.ReadOnly = true;
            // 
            // ColorFuzzyVar
            // 
            this.ColorFuzzyVar.FillWeight = 50F;
            this.ColorFuzzyVar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorFuzzyVar.HeaderText = "Цвет";
            this.ColorFuzzyVar.Name = "ColorFuzzyVar";
            this.ColorFuzzyVar.ReadOnly = true;
            this.ColorFuzzyVar.Width = 50;
            // 
            // ColumnIdTriangle
            // 
            this.ColumnIdTriangle.HeaderText = "TriangleId";
            this.ColumnIdTriangle.Name = "ColumnIdTriangle";
            this.ColumnIdTriangle.ReadOnly = true;
            this.ColumnIdTriangle.Width = 25;
            // 
            // ColumnIdTrapez
            // 
            this.ColumnIdTrapez.HeaderText = "TrapezId";
            this.ColumnIdTrapez.Name = "ColumnIdTrapez";
            this.ColumnIdTrapez.ReadOnly = true;
            this.ColumnIdTrapez.Width = 25;
            // 
            // ColumnIdGauss
            // 
            this.ColumnIdGauss.HeaderText = "GaussId";
            this.ColumnIdGauss.Name = "ColumnIdGauss";
            this.ColumnIdGauss.ReadOnly = true;
            this.ColumnIdGauss.Width = 25;
            // 
            // SymptomEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 361);
            this.Controls.Add(this.groupBoxTermM);
            this.Controls.Add(this.buttonRedraw);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.textBoxNameLV);
            this.Controls.Add(this.labelLingVar);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.MinimumSize = new System.Drawing.Size(500, 230);
            this.Name = "SymptomEditing";
            this.Text = "Редактирование симптома";
            this.Resize += new System.EventHandler(this.SymptomEditing_Resize);
            this.panelGraph.ResumeLayout(false);
            this.panelGraph.PerformLayout();
            this.groupBoxTermM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuzzyVar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelLingVar;
        private System.Windows.Forms.TextBox textBoxNameLV;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.TextBox textBoxTop;
        private System.Windows.Forms.TextBox textBoxBottom;
        private System.Windows.Forms.Button buttonRedraw;
        private System.Windows.Forms.GroupBox groupBoxTermM;
        public System.Windows.Forms.DataGridView dataGridViewFuzzyVar;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fuzzy_var;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFuzzyVar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypeMfColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeFuzzyVar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBoundTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeBound;
        private System.Windows.Forms.DataGridViewButtonColumn ColorFuzzyVar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdTriangle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdTrapez;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdGauss;
    }
}