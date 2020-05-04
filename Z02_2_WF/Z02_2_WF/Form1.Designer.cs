namespace Z02_2_WF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.numericUpDownMonths = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDays = new System.Windows.Forms.NumericUpDown();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(27, 22);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(54, 13);
            this.labelMonth.TabIndex = 0;
            this.labelMonth.Text = "Месяцы: ";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Location = new System.Drawing.Point(27, 61);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(34, 13);
            this.labelDays.TabIndex = 1;
            this.labelDays.Text = "Дни: ";
            // 
            // numericUpDownMonths
            // 
            this.numericUpDownMonths.Location = new System.Drawing.Point(30, 38);
            this.numericUpDownMonths.Name = "numericUpDownMonths";
            this.numericUpDownMonths.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMonths.TabIndex = 2;
            // 
            // numericUpDownDays
            // 
            this.numericUpDownDays.Location = new System.Drawing.Point(30, 77);
            this.numericUpDownDays.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDays.Name = "numericUpDownDays";
            this.numericUpDownDays.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDays.TabIndex = 3;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(30, 132);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(120, 20);
            this.textBoxAnswer.TabIndex = 4;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(30, 103);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(120, 23);
            this.button.TabIndex = 5;
            this.button.Text = "Выяснить месяц!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 169);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.numericUpDownDays);
            this.Controls.Add(this.numericUpDownMonths);
            this.Controls.Add(this.labelDays);
            this.Controls.Add(this.labelMonth);
            this.Name = "Form1";
            this.Text = "Месяцы";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.NumericUpDown numericUpDownMonths;
        private System.Windows.Forms.NumericUpDown numericUpDownDays;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button button;
    }
}

