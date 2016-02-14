namespace NumSystem
{
    partial class SelectPupilForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboClass = new System.Windows.Forms.ComboBox();
            this.textClass = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.Label();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.textSurname = new System.Windows.Forms.Label();
            this.comboSurname = new System.Windows.Forms.ComboBox();
            this.textPassword = new System.Windows.Forms.Label();
            this.editPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboClass
            // 
            this.comboClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboClass.FormattingEnabled = true;
            this.comboClass.Location = new System.Drawing.Point(75, 19);
            this.comboClass.MaxLength = 4;
            this.comboClass.Name = "comboClass";
            this.comboClass.Size = new System.Drawing.Size(600, 21);
            this.comboClass.Sorted = true;
            this.comboClass.TabIndex = 0;
            this.comboClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboClass_KeyPress);
            this.comboClass.Leave += new System.EventHandler(this.comboClass_Leave);
            // 
            // textClass
            // 
            this.textClass.AutoSize = true;
            this.textClass.Location = new System.Drawing.Point(13, 22);
            this.textClass.Name = "textClass";
            this.textClass.Size = new System.Drawing.Size(32, 13);
            this.textClass.TabIndex = 3;
            this.textClass.Text = "Клас";
            // 
            // textName
            // 
            this.textName.AutoSize = true;
            this.textName.Location = new System.Drawing.Point(13, 72);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(26, 13);
            this.textName.TabIndex = 5;
            this.textName.Text = "Ім\'я";
            // 
            // comboName
            // 
            this.comboName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(75, 69);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(600, 21);
            this.comboName.TabIndex = 1;
            this.comboName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboName_KeyPress);
            this.comboName.Leave += new System.EventHandler(this.comboName_Leave);
            // 
            // textSurname
            // 
            this.textSurname.AutoSize = true;
            this.textSurname.Location = new System.Drawing.Point(13, 122);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(56, 13);
            this.textSurname.TabIndex = 7;
            this.textSurname.Text = "Прізвище";
            // 
            // comboSurname
            // 
            this.comboSurname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboSurname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboSurname.FormattingEnabled = true;
            this.comboSurname.Location = new System.Drawing.Point(75, 119);
            this.comboSurname.Name = "comboSurname";
            this.comboSurname.Size = new System.Drawing.Size(600, 21);
            this.comboSurname.TabIndex = 2;
            this.comboSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboName_KeyPress);
            // 
            // textPassword
            // 
            this.textPassword.AutoSize = true;
            this.textPassword.Location = new System.Drawing.Point(13, 172);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(45, 13);
            this.textPassword.TabIndex = 9;
            this.textPassword.Text = "Пароль";
            // 
            // editPassword
            // 
            this.editPassword.Location = new System.Drawing.Point(75, 169);
            this.editPassword.Name = "editPassword";
            this.editPassword.Size = new System.Drawing.Size(600, 20);
            this.editPassword.TabIndex = 3;
            this.editPassword.UseSystemPasswordChar = true;
            // 
            // SelectPupilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 221);
            this.ControlBox = false;
            this.Controls.Add(this.editPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.comboSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.textClass);
            this.Controls.Add(this.comboClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectPupilForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectPupilForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SelectPupilForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboClass;
        private System.Windows.Forms.Label textClass;
        private System.Windows.Forms.Label textName;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.Label textSurname;
        private System.Windows.Forms.ComboBox comboSurname;
        private System.Windows.Forms.Label textPassword;
        private System.Windows.Forms.TextBox editPassword;
    }
}