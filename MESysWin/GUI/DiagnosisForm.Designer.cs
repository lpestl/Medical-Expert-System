namespace MESysWin.GUI
{
    partial class DiagnosisForm
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
            this.groupBoxDiagnosis = new System.Windows.Forms.GroupBox();
            this.dataGridViewDiagnosis = new System.Windows.Forms.DataGridView();
            this.buttonCorrect = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDiagnosis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiagnosis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDiagnosis
            // 
            this.groupBoxDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDiagnosis.Controls.Add(this.dataGridViewDiagnosis);
            this.groupBoxDiagnosis.Controls.Add(this.buttonCorrect);
            this.groupBoxDiagnosis.Controls.Add(this.buttonRemove);
            this.groupBoxDiagnosis.Controls.Add(this.buttonAdd);
            this.groupBoxDiagnosis.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDiagnosis.Name = "groupBoxDiagnosis";
            this.groupBoxDiagnosis.Size = new System.Drawing.Size(888, 431);
            this.groupBoxDiagnosis.TabIndex = 2;
            this.groupBoxDiagnosis.TabStop = false;
            this.groupBoxDiagnosis.Text = "Список диагнозов";
            // 
            // dataGridViewDiagnosis
            // 
            this.dataGridViewDiagnosis.AllowUserToAddRows = false;
            this.dataGridViewDiagnosis.AllowUserToDeleteRows = false;
            this.dataGridViewDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDiagnosis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiagnosis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.NameColumn,
            this.descriptionColumn,
            this.symptomsColumn,
            this.treatmentColumn});
            this.dataGridViewDiagnosis.Location = new System.Drawing.Point(7, 19);
            this.dataGridViewDiagnosis.Name = "dataGridViewDiagnosis";
            this.dataGridViewDiagnosis.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDiagnosis.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDiagnosis.RowTemplate.Height = 60;
            this.dataGridViewDiagnosis.Size = new System.Drawing.Size(875, 371);
            this.dataGridViewDiagnosis.TabIndex = 4;
            // 
            // buttonCorrect
            // 
            this.buttonCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCorrect.Location = new System.Drawing.Point(68, 397);
            this.buttonCorrect.Name = "buttonCorrect";
            this.buttonCorrect.Size = new System.Drawing.Size(814, 25);
            this.buttonCorrect.TabIndex = 3;
            this.buttonCorrect.Text = "Редактировать";
            this.buttonCorrect.UseVisualStyleBackColor = true;
            this.buttonCorrect.Click += new System.EventHandler(this.buttonCorrect_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(37, 397);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(25, 25);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(6, 397);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(25, 25);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 50;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Диагноз";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 200;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionColumn.HeaderText = "Описание";
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.ReadOnly = true;
            // 
            // symptomsColumn
            // 
            this.symptomsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.symptomsColumn.HeaderText = "Симптомы";
            this.symptomsColumn.Name = "symptomsColumn";
            this.symptomsColumn.ReadOnly = true;
            // 
            // treatmentColumn
            // 
            this.treatmentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.treatmentColumn.HeaderText = "Лечение";
            this.treatmentColumn.Name = "treatmentColumn";
            this.treatmentColumn.ReadOnly = true;
            // 
            // DiagnosisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.groupBoxDiagnosis);
            this.Name = "DiagnosisForm";
            this.Text = "Диагнозы";
            this.groupBoxDiagnosis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiagnosis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDiagnosis;
        public System.Windows.Forms.DataGridView dataGridViewDiagnosis;
        private System.Windows.Forms.Button buttonCorrect;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptomsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentColumn;
    }
}