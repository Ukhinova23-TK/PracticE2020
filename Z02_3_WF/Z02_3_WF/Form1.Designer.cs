namespace Z02_3_WF
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
            this.labelRun = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.numericUpDownRun = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEnd = new System.Windows.Forms.NumericUpDown();
            this.textBoxFor = new System.Windows.Forms.TextBox();
            this.textBoxWhile = new System.Windows.Forms.TextBox();
            this.textBoxDoWhile = new System.Windows.Forms.TextBox();
            this.labelFor = new System.Windows.Forms.Label();
            this.labelWhile = new System.Windows.Forms.Label();
            this.labelDoWhile = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRun
            // 
            this.labelRun.AutoSize = true;
            this.labelRun.Location = new System.Drawing.Point(16, 15);
            this.labelRun.Name = "labelRun";
            this.labelRun.Size = new System.Drawing.Size(50, 13);
            this.labelRun.TabIndex = 0;
            this.labelRun.Text = "Начало: ";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(16, 46);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(44, 13);
            this.labelEnd.TabIndex = 1;
            this.labelEnd.Text = "Конец: ";
            // 
            // numericUpDownRun
            // 
            this.numericUpDownRun.Location = new System.Drawing.Point(87, 13);
            this.numericUpDownRun.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownRun.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numericUpDownRun.Name = "numericUpDownRun";
            this.numericUpDownRun.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRun.TabIndex = 2;
            // 
            // numericUpDownEnd
            // 
            this.numericUpDownEnd.Location = new System.Drawing.Point(87, 46);
            this.numericUpDownEnd.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownEnd.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            this.numericUpDownEnd.Name = "numericUpDownEnd";
            this.numericUpDownEnd.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEnd.TabIndex = 3;
            // 
            // textBoxFor
            // 
            this.textBoxFor.Location = new System.Drawing.Point(238, 13);
            this.textBoxFor.Multiline = true;
            this.textBoxFor.Name = "textBoxFor";
            this.textBoxFor.Size = new System.Drawing.Size(191, 137);
            this.textBoxFor.TabIndex = 4;
            // 
            // textBoxWhile
            // 
            this.textBoxWhile.Location = new System.Drawing.Point(435, 12);
            this.textBoxWhile.Multiline = true;
            this.textBoxWhile.Name = "textBoxWhile";
            this.textBoxWhile.Size = new System.Drawing.Size(191, 138);
            this.textBoxWhile.TabIndex = 5;
            // 
            // textBoxDoWhile
            // 
            this.textBoxDoWhile.Location = new System.Drawing.Point(632, 13);
            this.textBoxDoWhile.Multiline = true;
            this.textBoxDoWhile.Name = "textBoxDoWhile";
            this.textBoxDoWhile.Size = new System.Drawing.Size(191, 137);
            this.textBoxDoWhile.TabIndex = 6;
            // 
            // labelFor
            // 
            this.labelFor.AutoSize = true;
            this.labelFor.Location = new System.Drawing.Point(310, 157);
            this.labelFor.Name = "labelFor";
            this.labelFor.Size = new System.Drawing.Size(29, 13);
            this.labelFor.TabIndex = 7;
            this.labelFor.Text = "FOR";
            // 
            // labelWhile
            // 
            this.labelWhile.AutoSize = true;
            this.labelWhile.Location = new System.Drawing.Point(506, 157);
            this.labelWhile.Name = "labelWhile";
            this.labelWhile.Size = new System.Drawing.Size(42, 13);
            this.labelWhile.TabIndex = 8;
            this.labelWhile.Text = "WHILE";
            // 
            // labelDoWhile
            // 
            this.labelDoWhile.AutoSize = true;
            this.labelDoWhile.Location = new System.Drawing.Point(696, 157);
            this.labelDoWhile.Name = "labelDoWhile";
            this.labelDoWhile.Size = new System.Drawing.Size(67, 13);
            this.labelDoWhile.TabIndex = 9;
            this.labelDoWhile.Text = "DO...WHILE";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(132, 86);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 10;
            this.button.Text = "Вывести!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 188);
            this.Controls.Add(this.button);
            this.Controls.Add(this.labelDoWhile);
            this.Controls.Add(this.labelWhile);
            this.Controls.Add(this.labelFor);
            this.Controls.Add(this.textBoxDoWhile);
            this.Controls.Add(this.textBoxWhile);
            this.Controls.Add(this.textBoxFor);
            this.Controls.Add(this.numericUpDownEnd);
            this.Controls.Add(this.numericUpDownRun);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelRun);
            this.Name = "Form1";
            this.Text = "Вывод периода";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRun;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.NumericUpDown numericUpDownRun;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd;
        private System.Windows.Forms.TextBox textBoxFor;
        private System.Windows.Forms.TextBox textBoxWhile;
        private System.Windows.Forms.TextBox textBoxDoWhile;
        private System.Windows.Forms.Label labelFor;
        private System.Windows.Forms.Label labelWhile;
        private System.Windows.Forms.Label labelDoWhile;
        private System.Windows.Forms.Button button;
    }
}

