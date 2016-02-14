namespace NumSystem
{
    partial class ControlForm
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
            System.Windows.Forms.ToolTip toolTip;
            this.checkFolder = new System.Windows.Forms.CheckBox();
            this.checkDB = new System.Windows.Forms.CheckBox();
            this.checkCalc = new System.Windows.Forms.CheckBox();
            this.groupControl = new System.Windows.Forms.GroupBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.groupDB = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.textLastLD = new System.Windows.Forms.Label();
            toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupControl.SuspendLayout();
            this.groupDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            toolTip.AutoPopDelay = 10000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 100;
            // 
            // checkFolder
            // 
            this.checkFolder.AutoSize = true;
            this.checkFolder.Location = new System.Drawing.Point(27, 129);
            this.checkFolder.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkFolder.Name = "checkFolder";
            this.checkFolder.Size = new System.Drawing.Size(278, 17);
            this.checkFolder.TabIndex = 2;
            this.checkFolder.Text = "Показувати теку програми у Провіднику Windows";
            toolTip.SetToolTip(this.checkFolder, "Встановіть цей параметр,\r\nщоб захистити теку програми");
            this.checkFolder.UseVisualStyleBackColor = true;
            this.checkFolder.CheckedChanged += new System.EventHandler(this.checkFolder_CheckedChanged);
            // 
            // checkDB
            // 
            this.checkDB.AutoSize = true;
            this.checkDB.Location = new System.Drawing.Point(27, 89);
            this.checkDB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkDB.Name = "checkDB";
            this.checkDB.Size = new System.Drawing.Size(295, 17);
            this.checkDB.TabIndex = 1;
            this.checkDB.Text = "Показувати файл бази данних у Провіднику Windows";
            toolTip.SetToolTip(this.checkDB, "Встановіть цей параметр, щоб захистити\r\nфайл бази данних учнів від небажаного\r\nзм" +
        "інення зі сторони учнів");
            this.checkDB.UseVisualStyleBackColor = true;
            this.checkDB.CheckedChanged += new System.EventHandler(this.checkDB_CheckedChanged);
            // 
            // checkCalc
            // 
            this.checkCalc.AutoSize = true;
            this.checkCalc.Location = new System.Drawing.Point(27, 49);
            this.checkCalc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.checkCalc.Name = "checkCalc";
            this.checkCalc.Size = new System.Drawing.Size(153, 17);
            this.checkCalc.TabIndex = 0;
            this.checkCalc.Text = "Показувати калькулятор";
            toolTip.SetToolTip(this.checkCalc, "Якщо встановити цей параметр,\r\nто, при проходженні учнем тесту,\r\nбуде доступний к" +
        "алькулятор");
            this.checkCalc.UseVisualStyleBackColor = true;
            this.checkCalc.CheckedChanged += new System.EventHandler(this.checkCalc_CheckedChanged);
            // 
            // groupControl
            // 
            this.groupControl.Controls.Add(this.checkFolder);
            this.groupControl.Controls.Add(this.btnPassword);
            this.groupControl.Controls.Add(this.checkDB);
            this.groupControl.Controls.Add(this.checkCalc);
            this.groupControl.Location = new System.Drawing.Point(20, 15);
            this.groupControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupControl.Name = "groupControl";
            this.groupControl.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupControl.Size = new System.Drawing.Size(545, 230);
            this.groupControl.TabIndex = 0;
            this.groupControl.TabStop = false;
            this.groupControl.Text = "Налаштування";
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(27, 178);
            this.btnPassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(490, 33);
            this.btnPassword.TabIndex = 3;
            this.btnPassword.Text = "Змінити пароль";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // groupDB
            // 
            this.groupDB.Controls.Add(this.btnOpen);
            this.groupDB.Controls.Add(this.btnView);
            this.groupDB.Location = new System.Drawing.Point(20, 260);
            this.groupDB.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupDB.Name = "groupDB";
            this.groupDB.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupDB.Size = new System.Drawing.Size(545, 150);
            this.groupDB.TabIndex = 1;
            this.groupDB.TabStop = false;
            this.groupDB.Text = "База данних";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(27, 99);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(490, 33);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Відкрити за допомогою MS Access";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(27, 46);
            this.btnView.Margin = new System.Windows.Forms.Padding(4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(490, 33);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "Переглянути";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // textLastLD
            // 
            this.textLastLD.AutoSize = true;
            this.textLastLD.Location = new System.Drawing.Point(43, 445);
            this.textLastLD.Name = "textLastLD";
            this.textLastLD.Size = new System.Drawing.Size(331, 24);
            this.textLastLD.TabIndex = 2;
            this.textLastLD.Text = "Останній раз програма запускалася   ";
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 484);
            this.Controls.Add(this.textLastLD);
            this.Controls.Add(this.groupDB);
            this.Controls.Add(this.groupControl);
            this.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "ControlForm";
            this.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlForm_FormClosing);
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            this.groupDB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupControl;
        private System.Windows.Forms.GroupBox groupDB;
        private System.Windows.Forms.CheckBox checkCalc;
        private System.Windows.Forms.CheckBox checkDB;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.CheckBox checkFolder;
        private System.Windows.Forms.Label textLastLD;
    }
}