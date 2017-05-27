namespace MESysWin.GUI
{
    partial class UserEdit
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
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.pictureBoxAva = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelOldPass = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.checkBoxShowOld = new System.Windows.Forms.CheckBox();
            this.checkBoxShowNew = new System.Windows.Forms.CheckBox();
            this.groupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxUser.Controls.Add(this.checkBoxShowNew);
            this.groupBoxUser.Controls.Add(this.checkBoxShowOld);
            this.groupBoxUser.Controls.Add(this.comboBoxGroup);
            this.groupBoxUser.Controls.Add(this.textBoxNewPassword);
            this.groupBoxUser.Controls.Add(this.textBoxOldPassword);
            this.groupBoxUser.Controls.Add(this.textBoxLogin);
            this.groupBoxUser.Controls.Add(this.labelGroup);
            this.groupBoxUser.Controls.Add(this.labelNewPass);
            this.groupBoxUser.Controls.Add(this.labelOldPass);
            this.groupBoxUser.Controls.Add(this.labelName);
            this.groupBoxUser.Controls.Add(this.pictureBoxAva);
            this.groupBoxUser.Location = new System.Drawing.Point(12, 3);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(536, 293);
            this.groupBoxUser.TabIndex = 0;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Данные пользователя";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(392, 302);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(473, 302);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBoxAva
            // 
            this.pictureBoxAva.Image = global::MESysWin.Properties.Resources.AvaGuest;
            this.pictureBoxAva.InitialImage = null;
            this.pictureBoxAva.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxAva.Name = "pictureBoxAva";
            this.pictureBoxAva.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAva.TabIndex = 0;
            this.pictureBoxAva.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(269, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(137, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя пользователя (login):";
            // 
            // labelOldPass
            // 
            this.labelOldPass.AutoSize = true;
            this.labelOldPass.Location = new System.Drawing.Point(269, 67);
            this.labelOldPass.Name = "labelOldPass";
            this.labelOldPass.Size = new System.Drawing.Size(87, 13);
            this.labelOldPass.TabIndex = 2;
            this.labelOldPass.Text = "Старый пароль:";
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Location = new System.Drawing.Point(269, 118);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(83, 13);
            this.labelNewPass.TabIndex = 3;
            this.labelNewPass.Text = "Новый пароль:";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(268, 173);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(161, 13);
            this.labelGroup.TabIndex = 4;
            this.labelGroup.Text = "Права / группа пользователя:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(272, 35);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(166, 20);
            this.textBoxLogin.TabIndex = 5;
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(272, 83);
            this.textBoxOldPassword.MaxLength = 14;
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.PasswordChar = '*';
            this.textBoxOldPassword.Size = new System.Drawing.Size(166, 20);
            this.textBoxOldPassword.TabIndex = 6;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(272, 135);
            this.textBoxNewPassword.MaxLength = 14;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(166, 20);
            this.textBoxNewPassword.TabIndex = 7;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(272, 189);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(166, 21);
            this.comboBoxGroup.TabIndex = 8;
            this.comboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroup_SelectedIndexChanged);
            // 
            // checkBoxShowOld
            // 
            this.checkBoxShowOld.AutoSize = true;
            this.checkBoxShowOld.Location = new System.Drawing.Point(445, 85);
            this.checkBoxShowOld.Name = "checkBoxShowOld";
            this.checkBoxShowOld.Size = new System.Drawing.Size(75, 17);
            this.checkBoxShowOld.TabIndex = 9;
            this.checkBoxShowOld.Text = "Показать";
            this.checkBoxShowOld.UseVisualStyleBackColor = true;
            this.checkBoxShowOld.CheckedChanged += new System.EventHandler(this.checkBoxShowOld_CheckedChanged);
            // 
            // checkBoxShowNew
            // 
            this.checkBoxShowNew.AutoSize = true;
            this.checkBoxShowNew.Location = new System.Drawing.Point(445, 137);
            this.checkBoxShowNew.Name = "checkBoxShowNew";
            this.checkBoxShowNew.Size = new System.Drawing.Size(75, 17);
            this.checkBoxShowNew.TabIndex = 10;
            this.checkBoxShowNew.Text = "Показать";
            this.checkBoxShowNew.UseVisualStyleBackColor = true;
            this.checkBoxShowNew.CheckedChanged += new System.EventHandler(this.checkBoxShowNew_CheckedChanged);
            // 
            // UserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 337);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxUser);
            this.Name = "UserEdit";
            this.Text = "Настройка пользователя";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBoxAva;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Label labelOldPass;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.CheckBox checkBoxShowNew;
        private System.Windows.Forms.CheckBox checkBoxShowOld;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
    }
}