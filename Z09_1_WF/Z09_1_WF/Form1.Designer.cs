namespace Z09_1_WF
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
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.button = new System.Windows.Forms.Button();
            this.numericUpDownFoot = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRun = new System.Windows.Forms.NumericUpDown();
            this.labelFoot = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelRun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRun)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.Location = new System.Drawing.Point(247, 12);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.ReadOnly = true;
            this.richTextBoxAnswer.Size = new System.Drawing.Size(297, 268);
            this.richTextBoxAnswer.TabIndex = 15;
            this.richTextBoxAnswer.Text = "";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(166, 101);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 14;
            this.button.Text = "Результат!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // numericUpDownFoot
            // 
            this.numericUpDownFoot.DecimalPlaces = 1;
            this.numericUpDownFoot.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownFoot.Location = new System.Drawing.Point(121, 75);
            this.numericUpDownFoot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownFoot.Name = "numericUpDownFoot";
            this.numericUpDownFoot.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFoot.TabIndex = 13;
            this.numericUpDownFoot.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDownEnd
            // 
            this.numericUpDownEnd.DecimalPlaces = 1;
            this.numericUpDownEnd.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownEnd.Location = new System.Drawing.Point(121, 47);
            this.numericUpDownEnd.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownEnd.Name = "numericUpDownEnd";
            this.numericUpDownEnd.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEnd.TabIndex = 12;
            // 
            // numericUpDownRun
            // 
            this.numericUpDownRun.DecimalPlaces = 1;
            this.numericUpDownRun.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownRun.Location = new System.Drawing.Point(121, 18);
            this.numericUpDownRun.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownRun.Name = "numericUpDownRun";
            this.numericUpDownRun.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRun.TabIndex = 11;
            // 
            // labelFoot
            // 
            this.labelFoot.AutoSize = true;
            this.labelFoot.Location = new System.Drawing.Point(12, 77);
            this.labelFoot.Name = "labelFoot";
            this.labelFoot.Size = new System.Drawing.Size(86, 13);
            this.labelFoot.TabIndex = 10;
            this.labelFoot.Text = "Шаг интервала:";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(12, 49);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(97, 13);
            this.labelEnd.TabIndex = 9;
            this.labelEnd.Text = "Конец интервала:";
            // 
            // labelRun
            // 
            this.labelRun.AutoSize = true;
            this.labelRun.Location = new System.Drawing.Point(12, 20);
            this.labelRun.Name = "labelRun";
            this.labelRun.Size = new System.Drawing.Size(103, 13);
            this.labelRun.TabIndex = 8;
            this.labelRun.Text = "Начало интервала:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 292);
            this.Controls.Add(this.richTextBoxAnswer);
            this.Controls.Add(this.button);
            this.Controls.Add(this.numericUpDownFoot);
            this.Controls.Add(this.numericUpDownEnd);
            this.Controls.Add(this.numericUpDownRun);
            this.Controls.Add(this.labelFoot);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelRun);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxAnswer;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.NumericUpDown numericUpDownFoot;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd;
        private System.Windows.Forms.NumericUpDown numericUpDownRun;
        private System.Windows.Forms.Label labelFoot;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelRun;
    }
}

