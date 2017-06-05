namespace MESysWin.GUI
{
    partial class DiagnosisEditor
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
            this.splitContainerWindow = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxSymptoms = new System.Windows.Forms.GroupBox();
            this.richTextBoxSymptoms = new System.Windows.Forms.RichTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBoxTreatment = new System.Windows.Forms.GroupBox();
            this.richTextBoxTreatment = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWindow)).BeginInit();
            this.splitContainerWindow.Panel1.SuspendLayout();
            this.splitContainerWindow.Panel2.SuspendLayout();
            this.splitContainerWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxName.SuspendLayout();
            this.groupBoxDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBoxSymptoms.SuspendLayout();
            this.groupBoxTreatment.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerWindow
            // 
            this.splitContainerWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerWindow.Location = new System.Drawing.Point(0, 0);
            this.splitContainerWindow.Name = "splitContainerWindow";
            // 
            // splitContainerWindow.Panel1
            // 
            this.splitContainerWindow.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainerWindow.Panel2
            // 
            this.splitContainerWindow.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainerWindow.Size = new System.Drawing.Size(815, 448);
            this.splitContainerWindow.SplitterDistance = 271;
            this.splitContainerWindow.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxDescription);
            this.splitContainer1.Size = new System.Drawing.Size(271, 448);
            this.splitContainer1.SplitterDistance = 47;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.textBoxName);
            this.groupBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxName.Location = new System.Drawing.Point(0, 0);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(271, 47);
            this.groupBoxName.TabIndex = 0;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "Наименование";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(6, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(259, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDescription.Controls.Add(this.richTextBoxDescription);
            this.groupBoxDescription.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(265, 356);
            this.groupBoxDescription.TabIndex = 0;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Описание";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(7, 20);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(252, 330);
            this.richTextBoxDescription.TabIndex = 0;
            this.richTextBoxDescription.Text = "";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBoxSymptoms);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainer2.Panel2.Controls.Add(this.buttonOk);
            this.splitContainer2.Panel2.Controls.Add(this.groupBoxTreatment);
            this.splitContainer2.Size = new System.Drawing.Size(540, 448);
            this.splitContainer2.SplitterDistance = 117;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBoxSymptoms
            // 
            this.groupBoxSymptoms.Controls.Add(this.richTextBoxSymptoms);
            this.groupBoxSymptoms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSymptoms.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSymptoms.Name = "groupBoxSymptoms";
            this.groupBoxSymptoms.Size = new System.Drawing.Size(540, 117);
            this.groupBoxSymptoms.TabIndex = 0;
            this.groupBoxSymptoms.TabStop = false;
            this.groupBoxSymptoms.Text = "Симптомы";
            // 
            // richTextBoxSymptoms
            // 
            this.richTextBoxSymptoms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxSymptoms.Location = new System.Drawing.Point(7, 19);
            this.richTextBoxSymptoms.Name = "richTextBoxSymptoms";
            this.richTextBoxSymptoms.Size = new System.Drawing.Size(521, 92);
            this.richTextBoxSymptoms.TabIndex = 0;
            this.richTextBoxSymptoms.Text = "";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(453, 296);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(372, 296);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBoxTreatment
            // 
            this.groupBoxTreatment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTreatment.Controls.Add(this.richTextBoxTreatment);
            this.groupBoxTreatment.Location = new System.Drawing.Point(3, 2);
            this.groupBoxTreatment.Name = "groupBoxTreatment";
            this.groupBoxTreatment.Size = new System.Drawing.Size(534, 287);
            this.groupBoxTreatment.TabIndex = 0;
            this.groupBoxTreatment.TabStop = false;
            this.groupBoxTreatment.Text = "Лечение";
            // 
            // richTextBoxTreatment
            // 
            this.richTextBoxTreatment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTreatment.Location = new System.Drawing.Point(4, 19);
            this.richTextBoxTreatment.Name = "richTextBoxTreatment";
            this.richTextBoxTreatment.Size = new System.Drawing.Size(521, 262);
            this.richTextBoxTreatment.TabIndex = 0;
            this.richTextBoxTreatment.Text = "";
            // 
            // DiagnosisEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 448);
            this.Controls.Add(this.splitContainerWindow);
            this.Name = "DiagnosisEditor";
            this.Text = "Редактор диагноза";
            this.splitContainerWindow.Panel1.ResumeLayout(false);
            this.splitContainerWindow.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWindow)).EndInit();
            this.splitContainerWindow.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.groupBoxDescription.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBoxSymptoms.ResumeLayout(false);
            this.groupBoxTreatment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerWindow;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxSymptoms;
        private System.Windows.Forms.GroupBox groupBoxTreatment;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.RichTextBox richTextBoxSymptoms;
        private System.Windows.Forms.RichTextBox richTextBoxTreatment;
    }
}