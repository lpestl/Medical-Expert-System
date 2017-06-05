namespace MESysWin
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStripMainForm = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerForLog = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosisListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symptomEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kbaseEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lingVarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoundaryTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLogin = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelOp = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxBg = new System.Windows.Forms.PictureBox();
            this.tabPageConsultation = new System.Windows.Forms.TabPage();
            this.tabPageBase = new System.Windows.Forms.TabPage();
            this.groupBoxBase = new System.Windows.Forms.GroupBox();
            this.buttonEditRule = new System.Windows.Forms.Button();
            this.buttonRemoveRule = new System.Windows.Forms.Button();
            this.buttonAddRule = new System.Windows.Forms.Button();
            this.dataGridViewBase = new System.Windows.Forms.DataGridView();
            this.IdRuleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RuleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDiagnosisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStripMainForm.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.menuStripLogin.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg)).BeginInit();
            this.tabPageBase.SuspendLayout();
            this.groupBoxBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            // 
            // statusStripMainForm
            // 
            this.statusStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelInfo});
            this.statusStripMainForm.Location = new System.Drawing.Point(0, 659);
            this.statusStripMainForm.Name = "statusStripMainForm";
            this.statusStripMainForm.Size = new System.Drawing.Size(865, 22);
            this.statusStripMainForm.TabIndex = 1;
            this.statusStripMainForm.Text = "statusStripMainForm";
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabelInfo.Text = "Log";
            // 
            // timerForLog
            // 
            this.timerForLog.Enabled = true;
            this.timerForLog.Tick += new System.EventHandler(this.timerForLog_Tick);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.consulToolStripMenuItem,
            this.expertToolStripMenuItem,
            this.kbToolStripMenuItem,
            this.admToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(865, 24);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // consulToolStripMenuItem
            // 
            this.consulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medBookToolStripMenuItem,
            this.diagnosDialogToolStripMenuItem});
            this.consulToolStripMenuItem.Name = "consulToolStripMenuItem";
            this.consulToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.consulToolStripMenuItem.Text = "Констультация";
            // 
            // medBookToolStripMenuItem
            // 
            this.medBookToolStripMenuItem.Name = "medBookToolStripMenuItem";
            this.medBookToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.medBookToolStripMenuItem.Text = "Карта пациента";
            // 
            // diagnosDialogToolStripMenuItem
            // 
            this.diagnosDialogToolStripMenuItem.Name = "diagnosDialogToolStripMenuItem";
            this.diagnosDialogToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.diagnosDialogToolStripMenuItem.Text = "Диф. диагностика методом диалога";
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagnosisListToolStripMenuItem,
            this.symptomEditorToolStripMenuItem,
            this.kbaseEditorToolStripMenuItem});
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.expertToolStripMenuItem.Text = "Эксперт";
            // 
            // diagnosisListToolStripMenuItem
            // 
            this.diagnosisListToolStripMenuItem.Name = "diagnosisListToolStripMenuItem";
            this.diagnosisListToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.diagnosisListToolStripMenuItem.Text = "Список диагнозов";
            this.diagnosisListToolStripMenuItem.Click += new System.EventHandler(this.diagnosisListToolStripMenuItem_Click);
            // 
            // symptomEditorToolStripMenuItem
            // 
            this.symptomEditorToolStripMenuItem.Name = "symptomEditorToolStripMenuItem";
            this.symptomEditorToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.symptomEditorToolStripMenuItem.Text = "Редактор симптоматики";
            this.symptomEditorToolStripMenuItem.Click += new System.EventHandler(this.symptomEditorToolStripMenuItem_Click);
            // 
            // kbaseEditorToolStripMenuItem
            // 
            this.kbaseEditorToolStripMenuItem.Name = "kbaseEditorToolStripMenuItem";
            this.kbaseEditorToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.kbaseEditorToolStripMenuItem.Text = "Редактор базы знаний";
            this.kbaseEditorToolStripMenuItem.Click += new System.EventHandler(this.kbaseEditorToolStripMenuItem_Click);
            // 
            // kbToolStripMenuItem
            // 
            this.kbToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lingVarToolStripMenuItem,
            this.typeToolStripMenuItem,
            this.BoundaryTypeToolStripMenuItem,
            this.quantToolStripMenuItem});
            this.kbToolStripMenuItem.Name = "kbToolStripMenuItem";
            this.kbToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.kbToolStripMenuItem.Text = "Инженер по знаниям";
            // 
            // lingVarToolStripMenuItem
            // 
            this.lingVarToolStripMenuItem.Name = "lingVarToolStripMenuItem";
            this.lingVarToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.lingVarToolStripMenuItem.Text = "Симптомы в нечеткой логике";
            this.lingVarToolStripMenuItem.Click += new System.EventHandler(this.lingVarToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.typeToolStripMenuItem.Text = "Типы функций принадлежности";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.typeToolStripMenuItem_Click);
            // 
            // BoundaryTypeToolStripMenuItem
            // 
            this.BoundaryTypeToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.BoundaryTypeToolStripMenuItem.Name = "BoundaryTypeToolStripMenuItem";
            this.BoundaryTypeToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.BoundaryTypeToolStripMenuItem.Text = "Пограничные типы функций принадлежности";
            this.BoundaryTypeToolStripMenuItem.Click += new System.EventHandler(this.BoundaryTypeToolStripMenuItem_Click);
            // 
            // quantToolStripMenuItem
            // 
            this.quantToolStripMenuItem.Name = "quantToolStripMenuItem";
            this.quantToolStripMenuItem.Size = new System.Drawing.Size(331, 22);
            this.quantToolStripMenuItem.Text = "Квантификаторы";
            this.quantToolStripMenuItem.Click += new System.EventHandler(this.quantToolStripMenuItem_Click);
            // 
            // admToolStripMenuItem
            // 
            this.admToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.admToolStripMenuItem.Name = "admToolStripMenuItem";
            this.admToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.admToolStripMenuItem.Text = "Администратор";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usersToolStripMenuItem.Text = "Пользователи";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingUserToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.serviceToolStripMenuItem.Text = "Сервис";
            // 
            // settingUserToolStripMenuItem
            // 
            this.settingUserToolStripMenuItem.Name = "settingUserToolStripMenuItem";
            this.settingUserToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.settingUserToolStripMenuItem.Text = "Настройки пользователя";
            this.settingUserToolStripMenuItem.Click += new System.EventHandler(this.settingUserToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.settingsToolStripMenuItem.Text = "Настройки приложения";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutToolStripMenuItem.Text = "О программе...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStripLogin
            // 
            this.menuStripLogin.BackColor = System.Drawing.Color.Transparent;
            this.menuStripLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStripLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.menuStripLogin.Location = new System.Drawing.Point(865, 0);
            this.menuStripLogin.Name = "menuStripLogin";
            this.menuStripLogin.Size = new System.Drawing.Size(143, 681);
            this.menuStripLogin.TabIndex = 4;
            this.menuStripLogin.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(130, 25);
            this.userToolStripMenuItem.Text = "Гость";
            this.userToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.modeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(130, 19);
            this.modeToolStripMenuItem.Text = "Режим консультации";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageConsultation);
            this.tabControlMain.Controls.Add(this.tabPageBase);
            this.tabControlMain.ItemSize = new System.Drawing.Size(100, 18);
            this.tabControlMain.Location = new System.Drawing.Point(12, 49);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(984, 607);
            this.tabControlMain.TabIndex = 5;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.labelWarning);
            this.tabPageMain.Controls.Add(this.labelOp);
            this.tabPageMain.Controls.Add(this.labelWelcome);
            this.tabPageMain.Controls.Add(this.pictureBoxBg);
            this.tabPageMain.Location = new System.Drawing.Point(4, 4);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(976, 581);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Welcome";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // labelWarning
            // 
            this.labelWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWarning.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelWarning.Location = new System.Drawing.Point(524, 445);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(446, 133);
            this.labelWarning.TabIndex = 3;
            this.labelWarning.Text = "ВНИМАНИЕ!";
            this.labelWarning.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelOp
            // 
            this.labelOp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOp.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelOp.Location = new System.Drawing.Point(6, 445);
            this.labelOp.Name = "labelOp";
            this.labelOp.Size = new System.Drawing.Size(512, 133);
            this.labelOp.TabIndex = 2;
            this.labelOp.Text = "Область применения:";
            // 
            // labelWelcome
            // 
            this.labelWelcome.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWelcome.Location = new System.Drawing.Point(3, 3);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(970, 38);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Информационная система медицинской диагностики на базе нечеткой логики ";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxBg
            // 
            this.pictureBoxBg.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBoxBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBg.Image = global::MESysWin.Properties.Resources.bgAbout;
            this.pictureBoxBg.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxBg.Name = "pictureBoxBg";
            this.pictureBoxBg.Size = new System.Drawing.Size(970, 575);
            this.pictureBoxBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBg.TabIndex = 0;
            this.pictureBoxBg.TabStop = false;
            // 
            // tabPageConsultation
            // 
            this.tabPageConsultation.Location = new System.Drawing.Point(4, 4);
            this.tabPageConsultation.Name = "tabPageConsultation";
            this.tabPageConsultation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultation.Size = new System.Drawing.Size(976, 581);
            this.tabPageConsultation.TabIndex = 1;
            this.tabPageConsultation.Text = "Консультация";
            this.tabPageConsultation.UseVisualStyleBackColor = true;
            // 
            // tabPageBase
            // 
            this.tabPageBase.Controls.Add(this.groupBoxBase);
            this.tabPageBase.Location = new System.Drawing.Point(4, 4);
            this.tabPageBase.Name = "tabPageBase";
            this.tabPageBase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBase.Size = new System.Drawing.Size(976, 581);
            this.tabPageBase.TabIndex = 2;
            this.tabPageBase.Text = "База знаний";
            this.tabPageBase.UseVisualStyleBackColor = true;
            // 
            // groupBoxBase
            // 
            this.groupBoxBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBase.Controls.Add(this.buttonEditRule);
            this.groupBoxBase.Controls.Add(this.buttonRemoveRule);
            this.groupBoxBase.Controls.Add(this.buttonAddRule);
            this.groupBoxBase.Controls.Add(this.dataGridViewBase);
            this.groupBoxBase.Location = new System.Drawing.Point(6, 6);
            this.groupBoxBase.Name = "groupBoxBase";
            this.groupBoxBase.Size = new System.Drawing.Size(964, 569);
            this.groupBoxBase.TabIndex = 1;
            this.groupBoxBase.TabStop = false;
            this.groupBoxBase.Text = "Правила БАЗЫ ЗНАНИЙ";
            // 
            // buttonEditRule
            // 
            this.buttonEditRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditRule.Location = new System.Drawing.Point(318, 540);
            this.buttonEditRule.Name = "buttonEditRule";
            this.buttonEditRule.Size = new System.Drawing.Size(150, 23);
            this.buttonEditRule.TabIndex = 3;
            this.buttonEditRule.Text = "Изменить правило";
            this.buttonEditRule.UseVisualStyleBackColor = true;
            this.buttonEditRule.Click += new System.EventHandler(this.buttonEditRule_Click);
            // 
            // buttonRemoveRule
            // 
            this.buttonRemoveRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveRule.Location = new System.Drawing.Point(162, 540);
            this.buttonRemoveRule.Name = "buttonRemoveRule";
            this.buttonRemoveRule.Size = new System.Drawing.Size(150, 23);
            this.buttonRemoveRule.TabIndex = 2;
            this.buttonRemoveRule.Text = "Удалить правило";
            this.buttonRemoveRule.UseVisualStyleBackColor = true;
            this.buttonRemoveRule.Click += new System.EventHandler(this.buttonRemoveRule_Click);
            // 
            // buttonAddRule
            // 
            this.buttonAddRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddRule.Location = new System.Drawing.Point(6, 540);
            this.buttonAddRule.Name = "buttonAddRule";
            this.buttonAddRule.Size = new System.Drawing.Size(150, 23);
            this.buttonAddRule.TabIndex = 1;
            this.buttonAddRule.Text = "Добавить правило";
            this.buttonAddRule.UseVisualStyleBackColor = true;
            this.buttonAddRule.Click += new System.EventHandler(this.buttonAddRule_Click);
            // 
            // dataGridViewBase
            // 
            this.dataGridViewBase.AllowUserToAddRows = false;
            this.dataGridViewBase.AllowUserToDeleteRows = false;
            this.dataGridViewBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRuleColumn,
            this.RuleColumn,
            this.IdDiagnosisColumn});
            this.dataGridViewBase.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewBase.Name = "dataGridViewBase";
            this.dataGridViewBase.ReadOnly = true;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBase.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBase.RowTemplate.Height = 66;
            this.dataGridViewBase.Size = new System.Drawing.Size(952, 515);
            this.dataGridViewBase.TabIndex = 0;
            // 
            // IdRuleColumn
            // 
            this.IdRuleColumn.HeaderText = "ID";
            this.IdRuleColumn.Name = "IdRuleColumn";
            this.IdRuleColumn.ReadOnly = true;
            this.IdRuleColumn.Width = 50;
            // 
            // RuleColumn
            // 
            this.RuleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RuleColumn.HeaderText = "Правило";
            this.RuleColumn.Name = "RuleColumn";
            this.RuleColumn.ReadOnly = true;
            // 
            // IdDiagnosisColumn
            // 
            this.IdDiagnosisColumn.HeaderText = "ID диагноза";
            this.IdDiagnosisColumn.Name = "IdDiagnosisColumn";
            this.IdDiagnosisColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.statusStripMainForm);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.menuStripLogin);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "МИС \"Диагноз\"";
            this.statusStripMainForm.ResumeLayout(false);
            this.statusStripMainForm.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.menuStripLogin.ResumeLayout(false);
            this.menuStripLogin.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBg)).EndInit();
            this.tabPageBase.ResumeLayout(false);
            this.groupBoxBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStripMainForm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.Timer timerForLog;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lingVarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BoundaryTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripLogin;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem symptomEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kbaseEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingUserToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageConsultation;
        private System.Windows.Forms.PictureBox pictureBoxBg;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelOp;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.ToolStripMenuItem diagnosisListToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageBase;
        private System.Windows.Forms.GroupBox groupBoxBase;
        private System.Windows.Forms.DataGridView dataGridViewBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRuleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RuleColumn;
        private System.Windows.Forms.Button buttonEditRule;
        private System.Windows.Forms.Button buttonRemoveRule;
        private System.Windows.Forms.Button buttonAddRule;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDiagnosisColumn;
    }
}

