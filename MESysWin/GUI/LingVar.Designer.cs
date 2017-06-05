namespace MESysWin.GUI
{
    partial class LingVar
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
            this.groupBoxSymptoms = new System.Windows.Forms.GroupBox();
            this.dataGridViewSymptoms = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBottom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCorrect = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxSymptoms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSymptoms)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSymptoms
            // 
            this.groupBoxSymptoms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSymptoms.Controls.Add(this.dataGridViewSymptoms);
            this.groupBoxSymptoms.Controls.Add(this.buttonCorrect);
            this.groupBoxSymptoms.Controls.Add(this.buttonRemove);
            this.groupBoxSymptoms.Controls.Add(this.buttonAdd);
            this.groupBoxSymptoms.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSymptoms.Name = "groupBoxSymptoms";
            this.groupBoxSymptoms.Size = new System.Drawing.Size(421, 337);
            this.groupBoxSymptoms.TabIndex = 1;
            this.groupBoxSymptoms.TabStop = false;
            this.groupBoxSymptoms.Text = "Симптомы";
            // 
            // dataGridViewSymptoms
            // 
            this.dataGridViewSymptoms.AllowUserToAddRows = false;
            this.dataGridViewSymptoms.AllowUserToDeleteRows = false;
            this.dataGridViewSymptoms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSymptoms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSymptoms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NameColumn,
            this.ColumnBottom,
            this.ColumnTop});
            this.dataGridViewSymptoms.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewSymptoms.Name = "dataGridViewSymptoms";
            this.dataGridViewSymptoms.ReadOnly = true;
            this.dataGridViewSymptoms.Size = new System.Drawing.Size(408, 277);
            this.dataGridViewSymptoms.TabIndex = 4;
            this.dataGridViewSymptoms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSymptoms_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText = "Имя симптома";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // ColumnBottom
            // 
            this.ColumnBottom.HeaderText = "Bottom";
            this.ColumnBottom.Name = "ColumnBottom";
            this.ColumnBottom.ReadOnly = true;
            this.ColumnBottom.Visible = false;
            // 
            // ColumnTop
            // 
            this.ColumnTop.HeaderText = "Top";
            this.ColumnTop.Name = "ColumnTop";
            this.ColumnTop.ReadOnly = true;
            this.ColumnTop.Visible = false;
            // 
            // buttonCorrect
            // 
            this.buttonCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCorrect.Location = new System.Drawing.Point(68, 303);
            this.buttonCorrect.Name = "buttonCorrect";
            this.buttonCorrect.Size = new System.Drawing.Size(347, 25);
            this.buttonCorrect.TabIndex = 3;
            this.buttonCorrect.Text = "Редактировать";
            this.buttonCorrect.UseVisualStyleBackColor = true;
            this.buttonCorrect.Click += new System.EventHandler(this.buttonCorrect_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(37, 303);
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
            this.buttonAdd.Location = new System.Drawing.Point(6, 303);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(25, 25);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // LingVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 361);
            this.Controls.Add(this.groupBoxSymptoms);
            this.Name = "LingVar";
            this.Text = "Симптомы";
            this.groupBoxSymptoms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSymptoms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxSymptoms;
        private System.Windows.Forms.Button buttonCorrect;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        public System.Windows.Forms.DataGridView dataGridViewSymptoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBottom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTop;
    }
}