namespace MESysWin.GUI
{
    partial class FuzzyVarForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.groupBoxSettingFuzzy = new System.Windows.Forms.GroupBox();
            this.comboBoxBound = new System.Windows.Forms.ComboBox();
            this.labelBound = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.tabControlType = new System.Windows.Forms.TabControl();
            this.tabPageGauss = new System.Windows.Forms.TabPage();
            this.textBoxSigma = new System.Windows.Forms.TextBox();
            this.textBoxGC = new System.Windows.Forms.TextBox();
            this.labelSigma = new System.Windows.Forms.Label();
            this.labelGC = new System.Windows.Forms.Label();
            this.labelGauss = new System.Windows.Forms.Label();
            this.pictureBoxGauss = new System.Windows.Forms.PictureBox();
            this.tabPageTriangl = new System.Windows.Forms.TabPage();
            this.textBoxTrianglC = new System.Windows.Forms.TextBox();
            this.textBoxTrianglB = new System.Windows.Forms.TextBox();
            this.textBoxTrianglA = new System.Windows.Forms.TextBox();
            this.labelTrglC = new System.Windows.Forms.Label();
            this.labelTrglB = new System.Windows.Forms.Label();
            this.labelTrglA = new System.Windows.Forms.Label();
            this.labelTriangl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageTrapez = new System.Windows.Forms.TabPage();
            this.textBoxTrapD = new System.Windows.Forms.TextBox();
            this.textBoxTrapC = new System.Windows.Forms.TextBox();
            this.textBoxTrapB = new System.Windows.Forms.TextBox();
            this.textBoxTrapA = new System.Windows.Forms.TextBox();
            this.labelTrapD = new System.Windows.Forms.Label();
            this.labelTrapC = new System.Windows.Forms.Label();
            this.labelTrapB = new System.Windows.Forms.Label();
            this.labelTrapA = new System.Windows.Forms.Label();
            this.labelTrapez = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelStopTab = new System.Windows.Forms.Panel();
            this.groupBoxSettingFuzzy.SuspendLayout();
            this.tabControlType.SuspendLayout();
            this.tabPageGauss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGauss)).BeginInit();
            this.tabPageTriangl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageTrapez.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(125, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название переменной:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(6, 60);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(163, 13);
            this.labelType.TabIndex = 1;
            this.labelType.Text = "Тип функции принадлежности:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(6, 89);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(142, 13);
            this.labelColor.TabIndex = 2;
            this.labelColor.Text = "Цвет функции на графике:";
            // 
            // groupBoxSettingFuzzy
            // 
            this.groupBoxSettingFuzzy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSettingFuzzy.Controls.Add(this.comboBoxBound);
            this.groupBoxSettingFuzzy.Controls.Add(this.labelBound);
            this.groupBoxSettingFuzzy.Controls.Add(this.buttonColor);
            this.groupBoxSettingFuzzy.Controls.Add(this.comboBoxType);
            this.groupBoxSettingFuzzy.Controls.Add(this.textBoxName);
            this.groupBoxSettingFuzzy.Controls.Add(this.labelName);
            this.groupBoxSettingFuzzy.Controls.Add(this.labelColor);
            this.groupBoxSettingFuzzy.Controls.Add(this.labelType);
            this.groupBoxSettingFuzzy.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSettingFuzzy.Name = "groupBoxSettingFuzzy";
            this.groupBoxSettingFuzzy.Size = new System.Drawing.Size(300, 166);
            this.groupBoxSettingFuzzy.TabIndex = 3;
            this.groupBoxSettingFuzzy.TabStop = false;
            this.groupBoxSettingFuzzy.Text = "Неопределленная переменная";
            // 
            // comboBoxBound
            // 
            this.comboBoxBound.FormattingEnabled = true;
            this.comboBoxBound.Items.AddRange(new object[] {
            "Крайний левый (ИСТИНА->ЛОЖЬ)",
            "Крайний правый (ЛОЖЬ->ИСТИНА)",
            "Средний (ЛОЖЬ->ИСТИНА->ЛОЖЬ)"});
            this.comboBoxBound.Location = new System.Drawing.Point(108, 116);
            this.comboBoxBound.Name = "comboBoxBound";
            this.comboBoxBound.Size = new System.Drawing.Size(186, 21);
            this.comboBoxBound.TabIndex = 7;
            this.comboBoxBound.SelectedIndexChanged += new System.EventHandler(this.comboBoxBound_SelectedIndexChanged);
            // 
            // labelBound
            // 
            this.labelBound.AutoSize = true;
            this.labelBound.Location = new System.Drawing.Point(6, 119);
            this.labelBound.Name = "labelBound";
            this.labelBound.Size = new System.Drawing.Size(98, 13);
            this.labelBound.TabIndex = 6;
            this.labelBound.Text = "Пограничный тип:";
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Red;
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColor.Location = new System.Drawing.Point(174, 84);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(120, 22);
            this.buttonColor.TabIndex = 5;
            this.buttonColor.Text = " ";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Гауссова MF",
            "Треугольная MF",
            "Трапецеидальная MF"});
            this.comboBoxType.Location = new System.Drawing.Point(174, 57);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(120, 21);
            this.comboBoxType.TabIndex = 4;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(174, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(120, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(616, 426);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(697, 426);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = " Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // panelGraph
            // 
            this.panelGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelGraph.Location = new System.Drawing.Point(318, 12);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(454, 408);
            this.panelGraph.TabIndex = 6;
            this.panelGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraph_Paint);
            this.panelGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGraph_MouseDown);
            this.panelGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGraph_MouseMove);
            this.panelGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelGraph_MouseUp);
            // 
            // tabControlType
            // 
            this.tabControlType.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControlType.Controls.Add(this.tabPageGauss);
            this.tabControlType.Controls.Add(this.tabPageTriangl);
            this.tabControlType.Controls.Add(this.tabPageTrapez);
            this.tabControlType.Location = new System.Drawing.Point(12, 184);
            this.tabControlType.Name = "tabControlType";
            this.tabControlType.SelectedIndex = 0;
            this.tabControlType.Size = new System.Drawing.Size(300, 265);
            this.tabControlType.TabIndex = 7;
            this.tabControlType.Visible = false;
            // 
            // tabPageGauss
            // 
            this.tabPageGauss.Controls.Add(this.textBoxSigma);
            this.tabPageGauss.Controls.Add(this.textBoxGC);
            this.tabPageGauss.Controls.Add(this.labelSigma);
            this.tabPageGauss.Controls.Add(this.labelGC);
            this.tabPageGauss.Controls.Add(this.labelGauss);
            this.tabPageGauss.Controls.Add(this.pictureBoxGauss);
            this.tabPageGauss.Location = new System.Drawing.Point(4, 4);
            this.tabPageGauss.Name = "tabPageGauss";
            this.tabPageGauss.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGauss.Size = new System.Drawing.Size(292, 239);
            this.tabPageGauss.TabIndex = 0;
            this.tabPageGauss.Text = " Гауссова";
            this.tabPageGauss.UseVisualStyleBackColor = true;
            // 
            // textBoxSigma
            // 
            this.textBoxSigma.Location = new System.Drawing.Point(135, 125);
            this.textBoxSigma.Name = "textBoxSigma";
            this.textBoxSigma.Size = new System.Drawing.Size(100, 20);
            this.textBoxSigma.TabIndex = 5;
            // 
            // textBoxGC
            // 
            this.textBoxGC.Location = new System.Drawing.Point(135, 100);
            this.textBoxGC.Name = "textBoxGC";
            this.textBoxGC.Size = new System.Drawing.Size(100, 20);
            this.textBoxGC.TabIndex = 4;
            // 
            // labelSigma
            // 
            this.labelSigma.AutoSize = true;
            this.labelSigma.Location = new System.Drawing.Point(81, 128);
            this.labelSigma.Name = "labelSigma";
            this.labelSigma.Size = new System.Drawing.Size(46, 13);
            this.labelSigma.TabIndex = 3;
            this.labelSigma.Text = "sigma = ";
            // 
            // labelGC
            // 
            this.labelGC.AutoSize = true;
            this.labelGC.Location = new System.Drawing.Point(101, 103);
            this.labelGC.Name = "labelGC";
            this.labelGC.Size = new System.Drawing.Size(25, 13);
            this.labelGC.TabIndex = 2;
            this.labelGC.Text = "c = ";
            // 
            // labelGauss
            // 
            this.labelGauss.AutoSize = true;
            this.labelGauss.Location = new System.Drawing.Point(3, 10);
            this.labelGauss.Name = "labelGauss";
            this.labelGauss.Size = new System.Drawing.Size(188, 13);
            this.labelGauss.TabIndex = 1;
            this.labelGauss.Text = "Гауссова функция принадлежности";
            // 
            // pictureBoxGauss
            // 
            this.pictureBoxGauss.Image = global::MESysWin.Properties.Resources.GaussMF;
            this.pictureBoxGauss.Location = new System.Drawing.Point(3, 26);
            this.pictureBoxGauss.Name = "pictureBoxGauss";
            this.pictureBoxGauss.Size = new System.Drawing.Size(266, 70);
            this.pictureBoxGauss.TabIndex = 0;
            this.pictureBoxGauss.TabStop = false;
            // 
            // tabPageTriangl
            // 
            this.tabPageTriangl.Controls.Add(this.textBoxTrianglC);
            this.tabPageTriangl.Controls.Add(this.textBoxTrianglB);
            this.tabPageTriangl.Controls.Add(this.textBoxTrianglA);
            this.tabPageTriangl.Controls.Add(this.labelTrglC);
            this.tabPageTriangl.Controls.Add(this.labelTrglB);
            this.tabPageTriangl.Controls.Add(this.labelTrglA);
            this.tabPageTriangl.Controls.Add(this.labelTriangl);
            this.tabPageTriangl.Controls.Add(this.pictureBox1);
            this.tabPageTriangl.Location = new System.Drawing.Point(4, 4);
            this.tabPageTriangl.Name = "tabPageTriangl";
            this.tabPageTriangl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTriangl.Size = new System.Drawing.Size(292, 239);
            this.tabPageTriangl.TabIndex = 1;
            this.tabPageTriangl.Text = "Триугольная";
            this.tabPageTriangl.UseVisualStyleBackColor = true;
            // 
            // textBoxTrianglC
            // 
            this.textBoxTrianglC.Location = new System.Drawing.Point(135, 185);
            this.textBoxTrianglC.Name = "textBoxTrianglC";
            this.textBoxTrianglC.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrianglC.TabIndex = 7;
            // 
            // textBoxTrianglB
            // 
            this.textBoxTrianglB.Location = new System.Drawing.Point(135, 160);
            this.textBoxTrianglB.Name = "textBoxTrianglB";
            this.textBoxTrianglB.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrianglB.TabIndex = 6;
            // 
            // textBoxTrianglA
            // 
            this.textBoxTrianglA.Location = new System.Drawing.Point(135, 135);
            this.textBoxTrianglA.Name = "textBoxTrianglA";
            this.textBoxTrianglA.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrianglA.TabIndex = 5;
            // 
            // labelTrglC
            // 
            this.labelTrglC.AutoSize = true;
            this.labelTrglC.Location = new System.Drawing.Point(92, 188);
            this.labelTrglC.Name = "labelTrglC";
            this.labelTrglC.Size = new System.Drawing.Size(25, 13);
            this.labelTrglC.TabIndex = 4;
            this.labelTrglC.Text = "c = ";
            // 
            // labelTrglB
            // 
            this.labelTrglB.AutoSize = true;
            this.labelTrglB.Location = new System.Drawing.Point(92, 163);
            this.labelTrglB.Name = "labelTrglB";
            this.labelTrglB.Size = new System.Drawing.Size(25, 13);
            this.labelTrglB.TabIndex = 3;
            this.labelTrglB.Text = "b = ";
            // 
            // labelTrglA
            // 
            this.labelTrglA.AutoSize = true;
            this.labelTrglA.Location = new System.Drawing.Point(92, 138);
            this.labelTrglA.Name = "labelTrglA";
            this.labelTrglA.Size = new System.Drawing.Size(25, 13);
            this.labelTrglA.TabIndex = 2;
            this.labelTrglA.Text = "a = ";
            // 
            // labelTriangl
            // 
            this.labelTriangl.AutoSize = true;
            this.labelTriangl.Location = new System.Drawing.Point(3, 10);
            this.labelTriangl.Name = "labelTriangl";
            this.labelTriangl.Size = new System.Drawing.Size(206, 13);
            this.labelTriangl.TabIndex = 1;
            this.labelTriangl.Text = "Треугольная функция принадлежности";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MESysWin.Properties.Resources.TglMF;
            this.pictureBox1.Location = new System.Drawing.Point(0, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageTrapez
            // 
            this.tabPageTrapez.Controls.Add(this.textBoxTrapD);
            this.tabPageTrapez.Controls.Add(this.textBoxTrapC);
            this.tabPageTrapez.Controls.Add(this.textBoxTrapB);
            this.tabPageTrapez.Controls.Add(this.textBoxTrapA);
            this.tabPageTrapez.Controls.Add(this.labelTrapD);
            this.tabPageTrapez.Controls.Add(this.labelTrapC);
            this.tabPageTrapez.Controls.Add(this.labelTrapB);
            this.tabPageTrapez.Controls.Add(this.labelTrapA);
            this.tabPageTrapez.Controls.Add(this.labelTrapez);
            this.tabPageTrapez.Controls.Add(this.pictureBox2);
            this.tabPageTrapez.Location = new System.Drawing.Point(4, 4);
            this.tabPageTrapez.Name = "tabPageTrapez";
            this.tabPageTrapez.Size = new System.Drawing.Size(292, 239);
            this.tabPageTrapez.TabIndex = 2;
            this.tabPageTrapez.Text = "Трапецеидальная";
            this.tabPageTrapez.UseVisualStyleBackColor = true;
            // 
            // textBoxTrapD
            // 
            this.textBoxTrapD.Location = new System.Drawing.Point(135, 210);
            this.textBoxTrapD.Name = "textBoxTrapD";
            this.textBoxTrapD.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrapD.TabIndex = 9;
            // 
            // textBoxTrapC
            // 
            this.textBoxTrapC.Location = new System.Drawing.Point(135, 185);
            this.textBoxTrapC.Name = "textBoxTrapC";
            this.textBoxTrapC.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrapC.TabIndex = 8;
            // 
            // textBoxTrapB
            // 
            this.textBoxTrapB.Location = new System.Drawing.Point(135, 160);
            this.textBoxTrapB.Name = "textBoxTrapB";
            this.textBoxTrapB.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrapB.TabIndex = 7;
            // 
            // textBoxTrapA
            // 
            this.textBoxTrapA.Location = new System.Drawing.Point(135, 135);
            this.textBoxTrapA.Name = "textBoxTrapA";
            this.textBoxTrapA.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrapA.TabIndex = 6;
            // 
            // labelTrapD
            // 
            this.labelTrapD.AutoSize = true;
            this.labelTrapD.Location = new System.Drawing.Point(92, 213);
            this.labelTrapD.Name = "labelTrapD";
            this.labelTrapD.Size = new System.Drawing.Size(25, 13);
            this.labelTrapD.TabIndex = 5;
            this.labelTrapD.Text = "d = ";
            // 
            // labelTrapC
            // 
            this.labelTrapC.AutoSize = true;
            this.labelTrapC.Location = new System.Drawing.Point(92, 188);
            this.labelTrapC.Name = "labelTrapC";
            this.labelTrapC.Size = new System.Drawing.Size(25, 13);
            this.labelTrapC.TabIndex = 4;
            this.labelTrapC.Text = "c = ";
            // 
            // labelTrapB
            // 
            this.labelTrapB.AutoSize = true;
            this.labelTrapB.Location = new System.Drawing.Point(92, 163);
            this.labelTrapB.Name = "labelTrapB";
            this.labelTrapB.Size = new System.Drawing.Size(25, 13);
            this.labelTrapB.TabIndex = 3;
            this.labelTrapB.Text = "b = ";
            // 
            // labelTrapA
            // 
            this.labelTrapA.AutoSize = true;
            this.labelTrapA.Location = new System.Drawing.Point(92, 138);
            this.labelTrapA.Name = "labelTrapA";
            this.labelTrapA.Size = new System.Drawing.Size(25, 13);
            this.labelTrapA.TabIndex = 2;
            this.labelTrapA.Text = "a = ";
            // 
            // labelTrapez
            // 
            this.labelTrapez.AutoSize = true;
            this.labelTrapez.Location = new System.Drawing.Point(3, 10);
            this.labelTrapez.Name = "labelTrapez";
            this.labelTrapez.Size = new System.Drawing.Size(232, 13);
            this.labelTrapez.TabIndex = 1;
            this.labelTrapez.Text = "Трапецеидальная функция принадлежности";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MESysWin.Properties.Resources.TpzMF;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelStopTab
            // 
            this.panelStopTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelStopTab.Location = new System.Drawing.Point(0, 426);
            this.panelStopTab.Name = "panelStopTab";
            this.panelStopTab.Size = new System.Drawing.Size(326, 36);
            this.panelStopTab.TabIndex = 8;
            // 
            // FuzzyVarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelStopTab);
            this.Controls.Add(this.tabControlType);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxSettingFuzzy);
            this.Name = "FuzzyVarForm";
            this.Text = "FuzzyVarForm";
            this.Resize += new System.EventHandler(this.FuzzyVarForm_Resize);
            this.groupBoxSettingFuzzy.ResumeLayout(false);
            this.groupBoxSettingFuzzy.PerformLayout();
            this.tabControlType.ResumeLayout(false);
            this.tabPageGauss.ResumeLayout(false);
            this.tabPageGauss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGauss)).EndInit();
            this.tabPageTriangl.ResumeLayout(false);
            this.tabPageTriangl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageTrapez.ResumeLayout(false);
            this.tabPageTrapez.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.GroupBox groupBoxSettingFuzzy;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.TabControl tabControlType;
        private System.Windows.Forms.TabPage tabPageGauss;
        private System.Windows.Forms.TabPage tabPageTriangl;
        private System.Windows.Forms.TabPage tabPageTrapez;
        private System.Windows.Forms.PictureBox pictureBoxGauss;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSigma;
        private System.Windows.Forms.TextBox textBoxGC;
        private System.Windows.Forms.Label labelSigma;
        private System.Windows.Forms.Label labelGC;
        private System.Windows.Forms.Label labelGauss;
        private System.Windows.Forms.Label labelTriangl;
        private System.Windows.Forms.Label labelTrapez;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxTrianglC;
        private System.Windows.Forms.TextBox textBoxTrianglB;
        private System.Windows.Forms.TextBox textBoxTrianglA;
        private System.Windows.Forms.Label labelTrglC;
        private System.Windows.Forms.Label labelTrglB;
        private System.Windows.Forms.Label labelTrglA;
        private System.Windows.Forms.TextBox textBoxTrapD;
        private System.Windows.Forms.TextBox textBoxTrapC;
        private System.Windows.Forms.TextBox textBoxTrapB;
        private System.Windows.Forms.TextBox textBoxTrapA;
        private System.Windows.Forms.Label labelTrapD;
        private System.Windows.Forms.Label labelTrapC;
        private System.Windows.Forms.Label labelTrapB;
        private System.Windows.Forms.Label labelTrapA;
        private System.Windows.Forms.Panel panelStopTab;
        private System.Windows.Forms.ComboBox comboBoxBound;
        private System.Windows.Forms.Label labelBound;
    }
}