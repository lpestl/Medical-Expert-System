namespace MESysWin.GUI
{
    partial class TypeMFform
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
            this.dataGridViewTypes = new System.Windows.Forms.DataGridView();
            this.IdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTypes
            // 
            this.dataGridViewTypes.AllowUserToAddRows = false;
            this.dataGridViewTypes.AllowUserToDeleteRows = false;
            this.dataGridViewTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdType,
            this.NameType,
            this.DescriptionType});
            this.dataGridViewTypes.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTypes.Name = "dataGridViewTypes";
            this.dataGridViewTypes.ReadOnly = true;
            this.dataGridViewTypes.Size = new System.Drawing.Size(460, 258);
            this.dataGridViewTypes.TabIndex = 0;
            // 
            // IdType
            // 
            this.IdType.FillWeight = 50F;
            this.IdType.HeaderText = "index";
            this.IdType.Name = "IdType";
            this.IdType.ReadOnly = true;
            this.IdType.Width = 50;
            // 
            // NameType
            // 
            this.NameType.FillWeight = 150F;
            this.NameType.HeaderText = "Название функции";
            this.NameType.Name = "NameType";
            this.NameType.ReadOnly = true;
            this.NameType.Width = 150;
            // 
            // DescriptionType
            // 
            this.DescriptionType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionType.HeaderText = "Описание";
            this.DescriptionType.Name = "DescriptionType";
            this.DescriptionType.ReadOnly = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(12, 276);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(93, 276);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.Location = new System.Drawing.Point(174, 276);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(97, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(397, 276);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // TypeMFform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewTypes);
            this.Name = "TypeMFform";
            this.Text = "Типы функций принадлежности";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewTypes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonClose;
    }
}