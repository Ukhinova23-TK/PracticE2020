namespace Z09_2_WF
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
            this.labelSize = new System.Windows.Forms.Label();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(12, 15);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(87, 13);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Размер строки:";
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(116, 13);
            this.numericUpDownSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSize.TabIndex = 1;
            this.numericUpDownSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.Location = new System.Drawing.Point(16, 68);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.Size = new System.Drawing.Size(220, 131);
            this.richTextBoxAnswer.TabIndex = 2;
            this.richTextBoxAnswer.Text = "";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(161, 39);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 3;
            this.button.Text = "Показать!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 212);
            this.Controls.Add(this.button);
            this.Controls.Add(this.richTextBoxAnswer);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.labelSize);
            this.Name = "Form1";
            this.Text = "Текст";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer;
        private System.Windows.Forms.Button button;
    }
}

