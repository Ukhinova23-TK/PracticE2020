namespace Z03_1_WF
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
            this.labelNum = new System.Windows.Forms.Label();
            this.numericUpDownNum = new System.Windows.Forms.NumericUpDown();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(24, 25);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(45, 13);
            this.labelNum.TabIndex = 0;
            this.labelNum.Text = "Число: ";
            // 
            // numericUpDownNum
            // 
            this.numericUpDownNum.Location = new System.Drawing.Point(95, 23);
            this.numericUpDownNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownNum.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownNum.Name = "numericUpDownNum";
            this.numericUpDownNum.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNum.TabIndex = 1;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(27, 90);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(188, 20);
            this.textBoxAnswer.TabIndex = 2;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(95, 55);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(120, 23);
            this.button.TabIndex = 3;
            this.button.Text = "Трансформировать!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 132);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.numericUpDownNum);
            this.Controls.Add(this.labelNum);
            this.Name = "Form1";
            this.Text = "Трансформация";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.NumericUpDown numericUpDownNum;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button button;
    }
}

