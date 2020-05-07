namespace Z06_1_WF
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
            this.textBoxMass = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.textBoxPrint = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(13, 13);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(96, 13);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Размер массива:";
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(115, 11);
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
            // textBoxMass
            // 
            this.textBoxMass.Location = new System.Drawing.Point(12, 69);
            this.textBoxMass.Name = "textBoxMass";
            this.textBoxMass.Size = new System.Drawing.Size(372, 20);
            this.textBoxMass.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 50);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(180, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Элементы массива через пробел:";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(12, 141);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(372, 20);
            this.textBoxAnswer.TabIndex = 4;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(309, 11);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 5;
            this.button.Text = "Вывести!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBoxPrint
            // 
            this.textBoxPrint.Location = new System.Drawing.Point(12, 106);
            this.textBoxPrint.Name = "textBoxPrint";
            this.textBoxPrint.ReadOnly = true;
            this.textBoxPrint.Size = new System.Drawing.Size(372, 20);
            this.textBoxPrint.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 173);
            this.Controls.Add(this.textBoxPrint);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxMass);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.labelSize);
            this.Name = "Form1";
            this.Text = "Сумма квадратов четных эелементов";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.TextBox textBoxMass;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBoxPrint;
    }
}

