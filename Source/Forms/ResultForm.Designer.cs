namespace NumSystem
{
    partial class ResultForm
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
            this.textGood = new System.Windows.Forms.Label();
            this.textCount = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textGood
            // 
            this.textGood.AutoSize = true;
            this.textGood.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textGood.Location = new System.Drawing.Point(195, 20);
            this.textGood.Name = "textGood";
            this.textGood.Size = new System.Drawing.Size(178, 66);
            this.textGood.TabIndex = 1;
            this.textGood.Text = "Вірно  ";
            // 
            // textCount
            // 
            this.textCount.AutoSize = true;
            this.textCount.Font = new System.Drawing.Font("Calibri", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textCount.Location = new System.Drawing.Point(298, 90);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(75, 66);
            this.textCount.TabIndex = 2;
            this.textCount.Text = "з  ";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(69, 195);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(316, 40);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(30, 20);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(128, 128);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // ResultForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOK;
            this.ClientSize = new System.Drawing.Size(454, 247);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textCount);
            this.Controls.Add(this.textGood);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ваш результат";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label textGood;
        private System.Windows.Forms.Label textCount;
        private System.Windows.Forms.Button btnOK;
    }
}