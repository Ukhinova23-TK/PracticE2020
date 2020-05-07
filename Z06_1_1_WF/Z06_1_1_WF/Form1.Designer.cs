namespace Z06_1_1_WF
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
            this.button = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.labelSize = new System.Windows.Forms.Label();
            this.richTextBoxMass = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPrint = new System.Windows.Forms.RichTextBox();
            this.labelSize1 = new System.Windows.Forms.Label();
            this.numericUpDownSize1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize1)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(309, 13);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 12;
            this.button.Text = "Вывести!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(15, 417);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(372, 20);
            this.textBoxAnswer.TabIndex = 11;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 83);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(249, 39);
            this.label.TabIndex = 10;
            this.label.Text = "Элементы массива. \r\nДля разделения элементов строки - Enter. \r\nДля разделения эле" +
    "ментов столбцов - Пробел.\r\n";
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(139, 13);
            this.numericUpDownSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSize.TabIndex = 8;
            this.numericUpDownSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(13, 15);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(101, 13);
            this.labelSize.TabIndex = 7;
            this.labelSize.Text = "Количество строк:";
            // 
            // richTextBoxMass
            // 
            this.richTextBoxMass.Location = new System.Drawing.Point(16, 137);
            this.richTextBoxMass.Name = "richTextBoxMass";
            this.richTextBoxMass.Size = new System.Drawing.Size(368, 122);
            this.richTextBoxMass.TabIndex = 13;
            this.richTextBoxMass.Text = "";
            // 
            // richTextBoxPrint
            // 
            this.richTextBoxPrint.Location = new System.Drawing.Point(16, 275);
            this.richTextBoxPrint.Name = "richTextBoxPrint";
            this.richTextBoxPrint.ReadOnly = true;
            this.richTextBoxPrint.Size = new System.Drawing.Size(368, 122);
            this.richTextBoxPrint.TabIndex = 14;
            this.richTextBoxPrint.Text = "";
            // 
            // labelSize1
            // 
            this.labelSize1.AutoSize = true;
            this.labelSize1.Location = new System.Drawing.Point(13, 47);
            this.labelSize1.Name = "labelSize1";
            this.labelSize1.Size = new System.Drawing.Size(119, 13);
            this.labelSize1.TabIndex = 15;
            this.labelSize1.Text = "Количество столбцов:";
            // 
            // numericUpDownSize1
            // 
            this.numericUpDownSize1.Location = new System.Drawing.Point(138, 45);
            this.numericUpDownSize1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSize1.Name = "numericUpDownSize1";
            this.numericUpDownSize1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSize1.TabIndex = 16;
            this.numericUpDownSize1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.numericUpDownSize1);
            this.Controls.Add(this.labelSize1);
            this.Controls.Add(this.richTextBoxPrint);
            this.Controls.Add(this.richTextBoxMass);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.label);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.labelSize);
            this.Name = "Form1";
            this.Text = "Сумма квадратов четных элементов";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.RichTextBox richTextBoxMass;
        private System.Windows.Forms.RichTextBox richTextBoxPrint;
        private System.Windows.Forms.Label labelSize1;
        private System.Windows.Forms.NumericUpDown numericUpDownSize1;
    }
}

