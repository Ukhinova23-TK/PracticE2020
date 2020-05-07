namespace Z06_4_WF
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
            this.richTextBoxPrint = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMass = new System.Windows.Forms.RichTextBox();
            this.button = new System.Windows.Forms.Button();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.labelSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxPrint
            // 
            this.richTextBoxPrint.Location = new System.Drawing.Point(12, 236);
            this.richTextBoxPrint.Name = "richTextBoxPrint";
            this.richTextBoxPrint.ReadOnly = true;
            this.richTextBoxPrint.Size = new System.Drawing.Size(368, 122);
            this.richTextBoxPrint.TabIndex = 30;
            this.richTextBoxPrint.Text = "";
            // 
            // richTextBoxMass
            // 
            this.richTextBoxMass.Location = new System.Drawing.Point(12, 98);
            this.richTextBoxMass.Name = "richTextBoxMass";
            this.richTextBoxMass.Size = new System.Drawing.Size(368, 122);
            this.richTextBoxMass.TabIndex = 29;
            this.richTextBoxMass.Text = "";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(305, 11);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 28;
            this.button.Text = "Вывести!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(11, 378);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(372, 20);
            this.textBoxAnswer.TabIndex = 27;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(8, 44);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(249, 39);
            this.label.TabIndex = 26;
            this.label.Text = "Элементы массива. \r\nДля разделения элементов строки - Enter. \r\nДля разделения эле" +
    "ментов столбцов - Пробел.\r\n";
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(135, 11);
            this.numericUpDownSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSize.TabIndex = 25;
            this.numericUpDownSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(9, 13);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(96, 13);
            this.labelSize.TabIndex = 24;
            this.labelSize.Text = "Размер массива:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 412);
            this.Controls.Add(this.richTextBoxPrint);
            this.Controls.Add(this.richTextBoxMass);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.label);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.labelSize);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxPrint;
        private System.Windows.Forms.RichTextBox richTextBoxMass;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Label labelSize;
    }
}

