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
            this.button1 = new System.Windows.Forms.Button();
            this.statusStripMainForm = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerForLog = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дифДиагностикаМетодомДиалогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.symptomEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kbaseEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lingVarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoundaryTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLogin = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMainForm.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.menuStripLogin.SuspendLayout();
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // consulToolStripMenuItem
            // 
            this.consulToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medBookToolStripMenuItem,
            this.дифДиагностикаМетодомДиалогаToolStripMenuItem});
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
            // дифДиагностикаМетодомДиалогаToolStripMenuItem
            // 
            this.дифДиагностикаМетодомДиалогаToolStripMenuItem.Name = "дифДиагностикаМетодомДиалогаToolStripMenuItem";
            this.дифДиагностикаМетодомДиалогаToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.дифДиагностикаМетодомДиалогаToolStripMenuItem.Text = "Диф. диагностика методом диалога";
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.symptomEditorToolStripMenuItem,
            this.kbaseEditorToolStripMenuItem});
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.expertToolStripMenuItem.Text = "Эксперт";
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
            this.userToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(130, 19);
            this.userToolStripMenuItem.Text = "Гость";
            this.userToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.modeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(130, 19);
            this.modeToolStripMenuItem.Text = "Режим консультации";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.serviceToolStripMenuItem.Text = "Сервис";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.settingsToolStripMenuItem.Text = "Настройки приложения";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
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
        private System.Windows.Forms.ToolStripMenuItem дифДиагностикаМетодомДиалогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

