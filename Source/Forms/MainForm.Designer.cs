namespace NumSystem
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolTip toolTip;
            this.pictureBtnClose = new System.Windows.Forms.PictureBox();
            this.comboTestType = new System.Windows.Forms.ComboBox();
            this.editTestCount = new System.Windows.Forms.NumericUpDown();
            this.comboRadix = new System.Windows.Forms.ComboBox();
            this.editTestLevel = new System.Windows.Forms.NumericUpDown();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теоріяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSolution = new System.Windows.Forms.TextBox();
            this.editCalc = new System.Windows.Forms.TextBox();
            this.btnTestStart = new System.Windows.Forms.Button();
            this.btnPassExam = new System.Windows.Forms.Button();
            this.btnTheory = new System.Windows.Forms.Button();
            this.textComboTestType = new System.Windows.Forms.Label();
            this.textTestCount = new System.Windows.Forms.Label();
            this.textRadix = new System.Windows.Forms.Label();
            this.textTestLevel = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarFormText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarNameText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarSurnameText = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarTastProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.textTask = new System.Windows.Forms.TextBox();
            toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTestCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTestLevel)).BeginInit();
            this.menuMain.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBtnClose
            // 
            this.pictureBtnClose.Location = new System.Drawing.Point(669, 8);
            this.pictureBtnClose.Name = "pictureBtnClose";
            this.pictureBtnClose.Size = new System.Drawing.Size(22, 22);
            this.pictureBtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBtnClose.TabIndex = 1;
            this.pictureBtnClose.TabStop = false;
            toolTip.SetToolTip(this.pictureBtnClose, "Закрити вікно");
            this.pictureBtnClose.Click += new System.EventHandler(this.pictureBtnClose_Click);
            this.pictureBtnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBtnClose_MouseDown);
            this.pictureBtnClose.MouseEnter += new System.EventHandler(this.pictureBtnClose_MouseEnter);
            this.pictureBtnClose.MouseLeave += new System.EventHandler(this.pictureBtnClose_MouseLeave);
            // 
            // comboTestType
            // 
            this.comboTestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTestType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboTestType.FormattingEnabled = true;
            this.comboTestType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboTestType.Items.AddRange(new object[] {
            "→ Переклад систем числення",
            "+ Додавання",
            "− Віднімання",
            "× Множення",
            "÷ Ділення"});
            this.comboTestType.Location = new System.Drawing.Point(438, 60);
            this.comboTestType.Name = "comboTestType";
            this.comboTestType.Size = new System.Drawing.Size(310, 31);
            this.comboTestType.TabIndex = 9;
            toolTip.SetToolTip(this.comboTestType, "Виберіть тип завдання");
            this.comboTestType.SelectedIndexChanged += new System.EventHandler(this.comboTestType_SelectedIndexChanged);
            this.comboTestType.FontChanged += new System.EventHandler(this.comboTestType_FontChanged);
            this.comboTestType.LocationChanged += new System.EventHandler(this.comboTestType_LocationChanged);
            this.comboTestType.VisibleChanged += new System.EventHandler(this.comboTestType_VisibleChanged);
            this.comboTestType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.editTestCount_KeyUp);
            // 
            // editTestCount
            // 
            this.editTestCount.AutoSize = true;
            this.editTestCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editTestCount.Location = new System.Drawing.Point(438, 376);
            this.editTestCount.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.editTestCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.editTestCount.Name = "editTestCount";
            this.editTestCount.Size = new System.Drawing.Size(100, 27);
            this.editTestCount.TabIndex = 11;
            toolTip.SetToolTip(this.editTestCount, "Введіть кількість завдань та\r\nнатисніть ENTER для продовження.");
            this.editTestCount.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.editTestCount.Visible = false;
            this.editTestCount.FontChanged += new System.EventHandler(this.editTestCount_FontChanged);
            this.editTestCount.LocationChanged += new System.EventHandler(this.editTestCount_LocationChanged);
            this.editTestCount.VisibleChanged += new System.EventHandler(this.editTestCount_VisibleChanged);
            this.editTestCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.editTestCount_KeyUp);
            // 
            // comboRadix
            // 
            this.comboRadix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRadix.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboRadix.FormattingEnabled = true;
            this.comboRadix.Location = new System.Drawing.Point(438, 170);
            this.comboRadix.Name = "comboRadix";
            this.comboRadix.Size = new System.Drawing.Size(249, 31);
            this.comboRadix.TabIndex = 13;
            toolTip.SetToolTip(this.comboRadix, "Виберіть основи систем числення,\r\nз якими буде проводитися тестування.");
            this.comboRadix.Visible = false;
            this.comboRadix.SelectedIndexChanged += new System.EventHandler(this.comboRadix_SelectedIndexChanged);
            this.comboRadix.LocationChanged += new System.EventHandler(this.comboRadix_LocationChanged);
            this.comboRadix.VisibleChanged += new System.EventHandler(this.comboRadix_VisibleChanged);
            this.comboRadix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.editTestCount_KeyUp);
            // 
            // editTestLevel
            // 
            this.editTestLevel.AutoSize = true;
            this.editTestLevel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editTestLevel.Location = new System.Drawing.Point(438, 274);
            this.editTestLevel.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.editTestLevel.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.editTestLevel.Name = "editTestLevel";
            this.editTestLevel.Size = new System.Drawing.Size(100, 27);
            this.editTestLevel.TabIndex = 15;
            toolTip.SetToolTip(this.editTestLevel, "Введіть важкість завдань.\r\nВід неї залежить кількість цифр в числах,\r\nякі будуть " +
        "даватися в завданнях.");
            this.editTestLevel.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.editTestLevel.Visible = false;
            this.editTestLevel.LocationChanged += new System.EventHandler(this.editTestLevel_LocationChanged);
            this.editTestLevel.VisibleChanged += new System.EventHandler(this.editTestLevel_VisibleChanged);
            this.editTestLevel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.editTestCount_KeyUp);
            this.editTestLevel.Leave += new System.EventHandler(this.editTestLevel_Leave);
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuMain.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.допомогаToolStripMenuItem});
            this.menuMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(211, 37);
            this.menuMain.TabIndex = 0;
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(82, 33);
            this.менюToolStripMenuItem.Text = "Меню";
            this.менюToolStripMenuItem.ToolTipText = "Натисніть, щоб перейти до початкового екрану";
            this.менюToolStripMenuItem.Click += new System.EventHandler(this.менюToolStripMenuItem_Click);
            // 
            // допомогаToolStripMenuItem
            // 
            this.допомогаToolStripMenuItem.AutoSize = false;
            this.допомогаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.теоріяToolStripMenuItem,
            this.оПрограмеToolStripMenuItem});
            this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
            this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(121, 33);
            this.допомогаToolStripMenuItem.Text = "Допомога";
            // 
            // теоріяToolStripMenuItem
            // 
            this.теоріяToolStripMenuItem.Name = "теоріяToolStripMenuItem";
            this.теоріяToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.теоріяToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.теоріяToolStripMenuItem.Text = "Теорія";
            this.теоріяToolStripMenuItem.Click += new System.EventHandler(this.теоріяToolStripMenuItem_Click);
            // 
            // оПрограмеToolStripMenuItem
            // 
            this.оПрограмеToolStripMenuItem.Name = "оПрограмеToolStripMenuItem";
            this.оПрограмеToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.оПрограмеToolStripMenuItem.Text = "О програме";
            this.оПрограмеToolStripMenuItem.Click += new System.EventHandler(this.оПрограмеToolStripMenuItem_Click);
            // 
            // editSolution
            // 
            this.editSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editSolution.Location = new System.Drawing.Point(60, 257);
            this.editSolution.MaxLength = 48;
            this.editSolution.Name = "editSolution";
            this.editSolution.Size = new System.Drawing.Size(390, 106);
            this.editSolution.TabIndex = 2;
            this.editSolution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editSolution_KeyPress);
            this.editSolution.KeyUp += new System.Windows.Forms.KeyEventHandler(this.editSolution_KeyUp);
            // 
            // editCalc
            // 
            this.editCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editCalc.Location = new System.Drawing.Point(564, 70);
            this.editCalc.Multiline = true;
            this.editCalc.Name = "editCalc";
            this.editCalc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.editCalc.Size = new System.Drawing.Size(160, 329);
            this.editCalc.TabIndex = 4;
            this.editCalc.Visible = false;
            this.editCalc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.editCalc_KeyPress);
            // 
            // btnTestStart
            // 
            this.btnTestStart.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTestStart.Location = new System.Drawing.Point(120, 147);
            this.btnTestStart.Name = "btnTestStart";
            this.btnTestStart.Size = new System.Drawing.Size(256, 80);
            this.btnTestStart.TabIndex = 6;
            this.btnTestStart.Text = "Пройти тест";
            this.btnTestStart.UseVisualStyleBackColor = true;
            this.btnTestStart.Click += new System.EventHandler(this.btnTestStart_Click);
            // 
            // btnPassExam
            // 
            this.btnPassExam.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPassExam.Location = new System.Drawing.Point(120, 233);
            this.btnPassExam.Name = "btnPassExam";
            this.btnPassExam.Size = new System.Drawing.Size(256, 80);
            this.btnPassExam.TabIndex = 7;
            this.btnPassExam.Text = "Здати екзамен";
            this.btnPassExam.UseVisualStyleBackColor = true;
            this.btnPassExam.Click += new System.EventHandler(this.btnPassExam_Click);
            // 
            // btnTheory
            // 
            this.btnTheory.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTheory.Location = new System.Drawing.Point(120, 61);
            this.btnTheory.Name = "btnTheory";
            this.btnTheory.Size = new System.Drawing.Size(256, 80);
            this.btnTheory.TabIndex = 8;
            this.btnTheory.Text = "Теорія";
            this.btnTheory.UseVisualStyleBackColor = true;
            this.btnTheory.Click += new System.EventHandler(this.btnTheory_Click);
            // 
            // textComboTestType
            // 
            this.textComboTestType.AutoSize = true;
            this.textComboTestType.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textComboTestType.Location = new System.Drawing.Point(434, 34);
            this.textComboTestType.Name = "textComboTestType";
            this.textComboTestType.Size = new System.Drawing.Size(131, 23);
            this.textComboTestType.TabIndex = 10;
            this.textComboTestType.Text = "Тип завдання";
            // 
            // textTestCount
            // 
            this.textTestCount.AutoSize = true;
            this.textTestCount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTestCount.Location = new System.Drawing.Point(434, 350);
            this.textTestCount.Name = "textTestCount";
            this.textTestCount.Size = new System.Drawing.Size(164, 23);
            this.textTestCount.TabIndex = 12;
            this.textTestCount.Text = "Кількість завдань";
            this.textTestCount.Visible = false;
            // 
            // textRadix
            // 
            this.textRadix.AutoSize = true;
            this.textRadix.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textRadix.Location = new System.Drawing.Point(434, 144);
            this.textRadix.Name = "textRadix";
            this.textRadix.Size = new System.Drawing.Size(229, 23);
            this.textRadix.TabIndex = 14;
            this.textRadix.Text = "Основи систем числення";
            this.textRadix.Visible = false;
            // 
            // textTestLevel
            // 
            this.textTestLevel.AutoSize = true;
            this.textTestLevel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTestLevel.Location = new System.Drawing.Point(434, 248);
            this.textTestLevel.Name = "textTestLevel";
            this.textTestLevel.Size = new System.Drawing.Size(163, 23);
            this.textTestLevel.TabIndex = 16;
            this.textTestLevel.Text = "Важкість завдань";
            this.textTestLevel.Visible = false;
            // 
            // statusBar
            // 
            this.statusBar.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarFormText,
            this.statusBarNameText,
            this.statusBarSurnameText,
            this.statusBarTastProgress});
            this.statusBar.Location = new System.Drawing.Point(0, 451);
            this.statusBar.Name = "statusBar";
            this.statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusBar.Size = new System.Drawing.Size(779, 30);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 17;
            // 
            // statusBarFormText
            // 
            this.statusBarFormText.AutoSize = false;
            this.statusBarFormText.Name = "statusBarFormText";
            this.statusBarFormText.Size = new System.Drawing.Size(52, 25);
            this.statusBarFormText.Click += new System.EventHandler(this.statusBarNameText_Click);
            // 
            // statusBarNameText
            // 
            this.statusBarNameText.AutoSize = false;
            this.statusBarNameText.Name = "statusBarNameText";
            this.statusBarNameText.Size = new System.Drawing.Size(44, 25);
            this.statusBarNameText.Click += new System.EventHandler(this.statusBarNameText_Click);
            // 
            // statusBarSurnameText
            // 
            this.statusBarSurnameText.AutoSize = false;
            this.statusBarSurnameText.Name = "statusBarSurnameText";
            this.statusBarSurnameText.Size = new System.Drawing.Size(97, 25);
            this.statusBarSurnameText.Click += new System.EventHandler(this.statusBarNameText_Click);
            // 
            // statusBarTastProgress
            // 
            this.statusBarTastProgress.AutoSize = false;
            this.statusBarTastProgress.Name = "statusBarTastProgress";
            this.statusBarTastProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusBarTastProgress.Size = new System.Drawing.Size(100, 24);
            // 
            // textTask
            // 
            this.textTask.AcceptsReturn = true;
            this.textTask.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTask.Font = new System.Drawing.Font("Calibri", 62.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTask.Location = new System.Drawing.Point(60, 70);
            this.textTask.Multiline = true;
            this.textTask.Name = "textTask";
            this.textTask.ReadOnly = true;
            this.textTask.Size = new System.Drawing.Size(390, 75);
            this.textTask.TabIndex = 5;
            this.textTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 481);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.textTestLevel);
            this.Controls.Add(this.editTestLevel);
            this.Controls.Add(this.textRadix);
            this.Controls.Add(this.comboRadix);
            this.Controls.Add(this.textTestCount);
            this.Controls.Add(this.editTestCount);
            this.Controls.Add(this.textComboTestType);
            this.Controls.Add(this.comboTestType);
            this.Controls.Add(this.btnTheory);
            this.Controls.Add(this.btnPassExam);
            this.Controls.Add(this.btnTestStart);
            this.Controls.Add(this.editCalc);
            this.Controls.Add(this.editSolution);
            this.Controls.Add(this.pictureBtnClose);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.textTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Системи числення";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTestCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editTestLevel)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теоріяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограмеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBtnClose;
        private System.Windows.Forms.TextBox editSolution;
        private System.Windows.Forms.TextBox editCalc;
        private System.Windows.Forms.Button btnTestStart;
        private System.Windows.Forms.Button btnPassExam;
        private System.Windows.Forms.Button btnTheory;
        private System.Windows.Forms.ComboBox comboTestType;
        private System.Windows.Forms.Label textComboTestType;
        private System.Windows.Forms.NumericUpDown editTestCount;
        private System.Windows.Forms.Label textTestCount;
        private System.Windows.Forms.ComboBox comboRadix;
        private System.Windows.Forms.Label textRadix;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown editTestLevel;
        private System.Windows.Forms.Label textTestLevel;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarFormText;
        private System.Windows.Forms.ToolStripStatusLabel statusBarNameText;
        private System.Windows.Forms.ToolStripStatusLabel statusBarSurnameText;
        private System.Windows.Forms.ToolStripProgressBar statusBarTastProgress;
        private System.Windows.Forms.TextBox textTask;
    }
}

