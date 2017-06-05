namespace MESysWin.GUI
{
    partial class KnowledgeBased
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnowledgeBased));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxPreview = new System.Windows.Forms.GroupBox();
            this.richTextBoxPreview = new System.Windows.Forms.RichTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewAntecedent = new System.Windows.Forms.DataGridView();
            this.IdAntecedentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntecedentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBoxAntEditor = new System.Windows.Forms.GroupBox();
            this.buttonQuantEdit = new System.Windows.Forms.Button();
            this.buttonFuzzyEdit = new System.Windows.Forms.Button();
            this.buttonSymptomsEdit = new System.Windows.Forms.Button();
            this.comboBoxSymptoms = new System.Windows.Forms.ComboBox();
            this.buttonSaveAnt = new System.Windows.Forms.Button();
            this.labelSymptoms = new System.Windows.Forms.Label();
            this.textBoxPreview = new System.Windows.Forms.TextBox();
            this.labelFuzzy = new System.Windows.Forms.Label();
            this.labelPreview = new System.Windows.Forms.Label();
            this.comboBoxFuzzy = new System.Windows.Forms.ComboBox();
            this.comboBoxQuant = new System.Windows.Forms.ComboBox();
            this.labelQuant = new System.Windows.Forms.Label();
            this.groupBoxCons = new System.Windows.Forms.GroupBox();
            this.buttonDiagnosisEdit = new System.Windows.Forms.Button();
            this.labelDiagn = new System.Windows.Forms.Label();
            this.comboBoxDiagn = new System.Windows.Forms.ComboBox();
            this.groupBoxInRule = new System.Windows.Forms.GroupBox();
            this.dataGridViewInRule = new System.Windows.Forms.DataGridView();
            this.IdInRuleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AntInRuleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAntecedent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBoxAntEditor.SuspendLayout();
            this.groupBoxCons.SuspendLayout();
            this.groupBoxInRule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInRule)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(846, 646);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(540, 646);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(300, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Сохранить правило в Базе Знаний";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxPreview);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(984, 628);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBoxPreview
            // 
            this.groupBoxPreview.Controls.Add(this.richTextBoxPreview);
            this.groupBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPreview.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPreview.Name = "groupBoxPreview";
            this.groupBoxPreview.Size = new System.Drawing.Size(984, 183);
            this.groupBoxPreview.TabIndex = 0;
            this.groupBoxPreview.TabStop = false;
            this.groupBoxPreview.Text = "Предпросмотр правила";
            // 
            // richTextBoxPreview
            // 
            this.richTextBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxPreview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxPreview.ForeColor = System.Drawing.Color.MediumBlue;
            this.richTextBoxPreview.Location = new System.Drawing.Point(3, 16);
            this.richTextBoxPreview.Name = "richTextBoxPreview";
            this.richTextBoxPreview.ReadOnly = true;
            this.richTextBoxPreview.Size = new System.Drawing.Size(978, 164);
            this.richTextBoxPreview.TabIndex = 0;
            this.richTextBoxPreview.Text = resources.GetString("richTextBoxPreview.Text");
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridViewAntecedent);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(984, 441);
            this.splitContainer2.SplitterDistance = 331;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridViewAntecedent
            // 
            this.dataGridViewAntecedent.AllowUserToAddRows = false;
            this.dataGridViewAntecedent.AllowUserToDeleteRows = false;
            this.dataGridViewAntecedent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAntecedent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAntecedentColumn,
            this.AntecedentColumn});
            this.dataGridViewAntecedent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAntecedent.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAntecedent.MultiSelect = false;
            this.dataGridViewAntecedent.Name = "dataGridViewAntecedent";
            this.dataGridViewAntecedent.ReadOnly = true;
            this.dataGridViewAntecedent.RowHeadersVisible = false;
            this.dataGridViewAntecedent.Size = new System.Drawing.Size(331, 441);
            this.dataGridViewAntecedent.TabIndex = 0;
            this.dataGridViewAntecedent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAntecedent_CellDoubleClick);
            // 
            // IdAntecedentColumn
            // 
            this.IdAntecedentColumn.HeaderText = "ID";
            this.IdAntecedentColumn.Name = "IdAntecedentColumn";
            this.IdAntecedentColumn.ReadOnly = true;
            this.IdAntecedentColumn.Width = 50;
            // 
            // AntecedentColumn
            // 
            this.AntecedentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AntecedentColumn.HeaderText = "Существующие антецеденты";
            this.AntecedentColumn.Name = "AntecedentColumn";
            this.AntecedentColumn.ReadOnly = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBoxInRule);
            this.splitContainer3.Size = new System.Drawing.Size(649, 441);
            this.splitContainer3.SplitterDistance = 324;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBoxAntEditor);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBoxCons);
            this.splitContainer4.Size = new System.Drawing.Size(324, 441);
            this.splitContainer4.SplitterDistance = 277;
            this.splitContainer4.TabIndex = 9;
            // 
            // groupBoxAntEditor
            // 
            this.groupBoxAntEditor.Controls.Add(this.buttonQuantEdit);
            this.groupBoxAntEditor.Controls.Add(this.buttonFuzzyEdit);
            this.groupBoxAntEditor.Controls.Add(this.buttonSymptomsEdit);
            this.groupBoxAntEditor.Controls.Add(this.comboBoxSymptoms);
            this.groupBoxAntEditor.Controls.Add(this.buttonSaveAnt);
            this.groupBoxAntEditor.Controls.Add(this.labelSymptoms);
            this.groupBoxAntEditor.Controls.Add(this.textBoxPreview);
            this.groupBoxAntEditor.Controls.Add(this.labelFuzzy);
            this.groupBoxAntEditor.Controls.Add(this.labelPreview);
            this.groupBoxAntEditor.Controls.Add(this.comboBoxFuzzy);
            this.groupBoxAntEditor.Controls.Add(this.comboBoxQuant);
            this.groupBoxAntEditor.Controls.Add(this.labelQuant);
            this.groupBoxAntEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAntEditor.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAntEditor.Name = "groupBoxAntEditor";
            this.groupBoxAntEditor.Size = new System.Drawing.Size(324, 277);
            this.groupBoxAntEditor.TabIndex = 9;
            this.groupBoxAntEditor.TabStop = false;
            this.groupBoxAntEditor.Text = "Редактор антецедента";
            // 
            // buttonQuantEdit
            // 
            this.buttonQuantEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuantEdit.Location = new System.Drawing.Point(13, 163);
            this.buttonQuantEdit.Name = "buttonQuantEdit";
            this.buttonQuantEdit.Size = new System.Drawing.Size(305, 23);
            this.buttonQuantEdit.TabIndex = 11;
            this.buttonQuantEdit.Text = "Полный список квантификаторов";
            this.buttonQuantEdit.UseVisualStyleBackColor = true;
            this.buttonQuantEdit.Click += new System.EventHandler(this.buttonQuantEdit_Click);
            // 
            // buttonFuzzyEdit
            // 
            this.buttonFuzzyEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFuzzyEdit.Location = new System.Drawing.Point(13, 108);
            this.buttonFuzzyEdit.Name = "buttonFuzzyEdit";
            this.buttonFuzzyEdit.Size = new System.Drawing.Size(305, 23);
            this.buttonFuzzyEdit.TabIndex = 10;
            this.buttonFuzzyEdit.Text = "Список нечетких переменных";
            this.buttonFuzzyEdit.UseVisualStyleBackColor = true;
            this.buttonFuzzyEdit.Visible = false;
            // 
            // buttonSymptomsEdit
            // 
            this.buttonSymptomsEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSymptomsEdit.Location = new System.Drawing.Point(13, 46);
            this.buttonSymptomsEdit.Name = "buttonSymptomsEdit";
            this.buttonSymptomsEdit.Size = new System.Drawing.Size(305, 23);
            this.buttonSymptomsEdit.TabIndex = 9;
            this.buttonSymptomsEdit.Text = "Полный список симптомов";
            this.buttonSymptomsEdit.UseVisualStyleBackColor = true;
            this.buttonSymptomsEdit.Click += new System.EventHandler(this.buttonSymptomsEdit_Click);
            // 
            // comboBoxSymptoms
            // 
            this.comboBoxSymptoms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSymptoms.FormattingEnabled = true;
            this.comboBoxSymptoms.Location = new System.Drawing.Point(103, 19);
            this.comboBoxSymptoms.Name = "comboBoxSymptoms";
            this.comboBoxSymptoms.Size = new System.Drawing.Size(215, 21);
            this.comboBoxSymptoms.TabIndex = 1;
            this.comboBoxSymptoms.SelectedIndexChanged += new System.EventHandler(this.comboBoxSymptoms_SelectedIndexChanged);
            // 
            // buttonSaveAnt
            // 
            this.buttonSaveAnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAnt.BackColor = System.Drawing.Color.Yellow;
            this.buttonSaveAnt.Location = new System.Drawing.Point(13, 242);
            this.buttonSaveAnt.Name = "buttonSaveAnt";
            this.buttonSaveAnt.Size = new System.Drawing.Size(305, 23);
            this.buttonSaveAnt.TabIndex = 8;
            this.buttonSaveAnt.Text = "Сохранить в правило";
            this.buttonSaveAnt.UseVisualStyleBackColor = false;
            this.buttonSaveAnt.Click += new System.EventHandler(this.buttonSaveAnt_Click);
            // 
            // labelSymptoms
            // 
            this.labelSymptoms.AutoSize = true;
            this.labelSymptoms.Location = new System.Drawing.Point(10, 22);
            this.labelSymptoms.Name = "labelSymptoms";
            this.labelSymptoms.Size = new System.Drawing.Size(53, 13);
            this.labelSymptoms.TabIndex = 0;
            this.labelSymptoms.Text = "Симптом";
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPreview.Location = new System.Drawing.Point(13, 216);
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.ReadOnly = true;
            this.textBoxPreview.Size = new System.Drawing.Size(305, 20);
            this.textBoxPreview.TabIndex = 7;
            // 
            // labelFuzzy
            // 
            this.labelFuzzy.AutoSize = true;
            this.labelFuzzy.Location = new System.Drawing.Point(10, 81);
            this.labelFuzzy.Name = "labelFuzzy";
            this.labelFuzzy.Size = new System.Drawing.Size(79, 13);
            this.labelFuzzy.TabIndex = 2;
            this.labelFuzzy.Text = "Нечеткая пер.";
            // 
            // labelPreview
            // 
            this.labelPreview.AutoSize = true;
            this.labelPreview.Location = new System.Drawing.Point(10, 200);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(152, 13);
            this.labelPreview.TabIndex = 6;
            this.labelPreview.Text = "Предпросмотр антецедента:";
            // 
            // comboBoxFuzzy
            // 
            this.comboBoxFuzzy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFuzzy.FormattingEnabled = true;
            this.comboBoxFuzzy.Location = new System.Drawing.Point(103, 78);
            this.comboBoxFuzzy.Name = "comboBoxFuzzy";
            this.comboBoxFuzzy.Size = new System.Drawing.Size(215, 21);
            this.comboBoxFuzzy.TabIndex = 3;
            this.comboBoxFuzzy.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuzzy_SelectedIndexChanged);
            // 
            // comboBoxQuant
            // 
            this.comboBoxQuant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxQuant.FormattingEnabled = true;
            this.comboBoxQuant.Location = new System.Drawing.Point(103, 136);
            this.comboBoxQuant.Name = "comboBoxQuant";
            this.comboBoxQuant.Size = new System.Drawing.Size(215, 21);
            this.comboBoxQuant.TabIndex = 5;
            this.comboBoxQuant.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuant_SelectedIndexChanged);
            // 
            // labelQuant
            // 
            this.labelQuant.AutoSize = true;
            this.labelQuant.Location = new System.Drawing.Point(10, 139);
            this.labelQuant.Name = "labelQuant";
            this.labelQuant.Size = new System.Drawing.Size(86, 13);
            this.labelQuant.TabIndex = 4;
            this.labelQuant.Text = "Квантификатор";
            // 
            // groupBoxCons
            // 
            this.groupBoxCons.Controls.Add(this.buttonDiagnosisEdit);
            this.groupBoxCons.Controls.Add(this.labelDiagn);
            this.groupBoxCons.Controls.Add(this.comboBoxDiagn);
            this.groupBoxCons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCons.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCons.Name = "groupBoxCons";
            this.groupBoxCons.Size = new System.Drawing.Size(324, 160);
            this.groupBoxCons.TabIndex = 0;
            this.groupBoxCons.TabStop = false;
            this.groupBoxCons.Text = "Заключение";
            // 
            // buttonDiagnosisEdit
            // 
            this.buttonDiagnosisEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDiagnosisEdit.Location = new System.Drawing.Point(13, 69);
            this.buttonDiagnosisEdit.Name = "buttonDiagnosisEdit";
            this.buttonDiagnosisEdit.Size = new System.Drawing.Size(305, 23);
            this.buttonDiagnosisEdit.TabIndex = 2;
            this.buttonDiagnosisEdit.Text = "Полный список диагнозов";
            this.buttonDiagnosisEdit.UseVisualStyleBackColor = true;
            this.buttonDiagnosisEdit.Click += new System.EventHandler(this.buttonDiagnosisEdit_Click);
            // 
            // labelDiagn
            // 
            this.labelDiagn.AutoSize = true;
            this.labelDiagn.Location = new System.Drawing.Point(10, 26);
            this.labelDiagn.Name = "labelDiagn";
            this.labelDiagn.Size = new System.Drawing.Size(51, 13);
            this.labelDiagn.TabIndex = 1;
            this.labelDiagn.Text = "Диагноз";
            // 
            // comboBoxDiagn
            // 
            this.comboBoxDiagn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDiagn.FormattingEnabled = true;
            this.comboBoxDiagn.Location = new System.Drawing.Point(13, 42);
            this.comboBoxDiagn.Name = "comboBoxDiagn";
            this.comboBoxDiagn.Size = new System.Drawing.Size(305, 21);
            this.comboBoxDiagn.TabIndex = 0;
            this.comboBoxDiagn.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiagn_SelectedIndexChanged);
            // 
            // groupBoxInRule
            // 
            this.groupBoxInRule.Controls.Add(this.buttonRemove);
            this.groupBoxInRule.Controls.Add(this.dataGridViewInRule);
            this.groupBoxInRule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInRule.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInRule.Name = "groupBoxInRule";
            this.groupBoxInRule.Size = new System.Drawing.Size(321, 441);
            this.groupBoxInRule.TabIndex = 9;
            this.groupBoxInRule.TabStop = false;
            this.groupBoxInRule.Text = "Антецеденты внутри правила";
            // 
            // dataGridViewInRule
            // 
            this.dataGridViewInRule.AllowUserToAddRows = false;
            this.dataGridViewInRule.AllowUserToDeleteRows = false;
            this.dataGridViewInRule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInRule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInRule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInRuleColumn,
            this.AntInRuleColumn});
            this.dataGridViewInRule.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewInRule.Name = "dataGridViewInRule";
            this.dataGridViewInRule.ReadOnly = true;
            this.dataGridViewInRule.RowHeadersVisible = false;
            this.dataGridViewInRule.Size = new System.Drawing.Size(309, 385);
            this.dataGridViewInRule.TabIndex = 0;
            // 
            // IdInRuleColumn
            // 
            this.IdInRuleColumn.HeaderText = "ID";
            this.IdInRuleColumn.Name = "IdInRuleColumn";
            this.IdInRuleColumn.ReadOnly = true;
            this.IdInRuleColumn.Width = 50;
            // 
            // AntInRuleColumn
            // 
            this.AntInRuleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AntInRuleColumn.HeaderText = "Антецеденты в правиле";
            this.AntInRuleColumn.Name = "AntInRuleColumn";
            this.AntInRuleColumn.ReadOnly = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(6, 410);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(309, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Удалить из правила";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // KnowledgeBased
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Name = "KnowledgeBased";
            this.Text = "Редактор правил Базы Знаний";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxPreview.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAntecedent)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBoxAntEditor.ResumeLayout(false);
            this.groupBoxAntEditor.PerformLayout();
            this.groupBoxCons.ResumeLayout(false);
            this.groupBoxCons.PerformLayout();
            this.groupBoxInRule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInRule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxPreview;
        private System.Windows.Forms.RichTextBox richTextBoxPreview;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridViewAntecedent;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBoxInRule;
        private System.Windows.Forms.DataGridView dataGridViewInRule;
        private System.Windows.Forms.Button buttonSaveAnt;
        private System.Windows.Forms.TextBox textBoxPreview;
        private System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.ComboBox comboBoxQuant;
        private System.Windows.Forms.Label labelQuant;
        private System.Windows.Forms.ComboBox comboBoxFuzzy;
        private System.Windows.Forms.Label labelFuzzy;
        private System.Windows.Forms.ComboBox comboBoxSymptoms;
        private System.Windows.Forms.Label labelSymptoms;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAntecedentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AntecedentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInRuleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AntInRuleColumn;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBoxAntEditor;
        private System.Windows.Forms.GroupBox groupBoxCons;
        private System.Windows.Forms.Label labelDiagn;
        private System.Windows.Forms.ComboBox comboBoxDiagn;
        private System.Windows.Forms.Button buttonFuzzyEdit;
        private System.Windows.Forms.Button buttonSymptomsEdit;
        private System.Windows.Forms.Button buttonQuantEdit;
        private System.Windows.Forms.Button buttonDiagnosisEdit;
        private System.Windows.Forms.Button buttonRemove;
    }
}