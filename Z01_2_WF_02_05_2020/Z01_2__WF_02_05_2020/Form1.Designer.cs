namespace Z01_2_WF_02_05_2020
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
            this.labelKrat = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.numericUpDownKrat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNum = new System.Windows.Forms.NumericUpDown();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKrat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKrat
            // 
            this.labelKrat.AutoSize = true;
            this.labelKrat.Location = new System.Drawing.Point(33, 40);
            this.labelKrat.Name = "labelKrat";
            this.labelKrat.Size = new System.Drawing.Size(63, 13);
            this.labelKrat.TabIndex = 0;
            this.labelKrat.Text = "Кратность:";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(33, 76);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(42, 13);
            this.labelNum.TabIndex = 1;
            this.labelNum.Text = "Число:";
            // 
            // numericUpDownKrat
            // 
            this.numericUpDownKrat.Location = new System.Drawing.Point(114, 38);
            this.numericUpDownKrat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKrat.Name = "numericUpDownKrat";
            this.numericUpDownKrat.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownKrat.TabIndex = 2;
            this.numericUpDownKrat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownNum
            // 
            this.numericUpDownNum.Location = new System.Drawing.Point(114, 74);
            this.numericUpDownNum.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownNum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNum.Name = "numericUpDownNum";
            this.numericUpDownNum.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNum.TabIndex = 3;
            this.numericUpDownNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(36, 150);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.ReadOnly = true;
            this.textBoxAnswer.Size = new System.Drawing.Size(198, 39);
            this.textBoxAnswer.TabIndex = 4;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(159, 109);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 5;
            this.button.Text = "Узнать!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 210);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.numericUpDownNum);
            this.Controls.Add(this.numericUpDownKrat);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelKrat);
            this.Name = "Form1";
            this.Text = "Кратность";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKrat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKrat;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.NumericUpDown numericUpDownKrat;
        private System.Windows.Forms.NumericUpDown numericUpDownNum;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button button;
    }
}

