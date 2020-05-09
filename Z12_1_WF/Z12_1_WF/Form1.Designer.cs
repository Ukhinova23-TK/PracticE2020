namespace Z12_1_WF
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
            this.labelXP2 = new System.Windows.Forms.Label();
            this.labelYP2 = new System.Windows.Forms.Label();
            this.numericUpDownXP2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownScal = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYP2 = new System.Windows.Forms.NumericUpDown();
            this.labelSkal = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYP2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelXP2
            // 
            this.labelXP2.AutoSize = true;
            this.labelXP2.Location = new System.Drawing.Point(69, 12);
            this.labelXP2.Name = "labelXP2";
            this.labelXP2.Size = new System.Drawing.Size(17, 13);
            this.labelXP2.TabIndex = 20;
            this.labelXP2.Text = "X:";
            // 
            // labelYP2
            // 
            this.labelYP2.AutoSize = true;
            this.labelYP2.Location = new System.Drawing.Point(69, 40);
            this.labelYP2.Name = "labelYP2";
            this.labelYP2.Size = new System.Drawing.Size(17, 13);
            this.labelYP2.TabIndex = 21;
            this.labelYP2.Text = "Y:";
            // 
            // numericUpDownXP2
            // 
            this.numericUpDownXP2.Location = new System.Drawing.Point(134, 8);
            this.numericUpDownXP2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownXP2.Name = "numericUpDownXP2";
            this.numericUpDownXP2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownXP2.TabIndex = 22;
            // 
            // numericUpDownScal
            // 
            this.numericUpDownScal.Location = new System.Drawing.Point(134, 70);
            this.numericUpDownScal.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownScal.Name = "numericUpDownScal";
            this.numericUpDownScal.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownScal.TabIndex = 26;
            // 
            // numericUpDownYP2
            // 
            this.numericUpDownYP2.Location = new System.Drawing.Point(134, 38);
            this.numericUpDownYP2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownYP2.Name = "numericUpDownYP2";
            this.numericUpDownYP2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYP2.TabIndex = 23;
            // 
            // labelSkal
            // 
            this.labelSkal.AutoSize = true;
            this.labelSkal.Location = new System.Drawing.Point(69, 72);
            this.labelSkal.Name = "labelSkal";
            this.labelSkal.Size = new System.Drawing.Size(47, 13);
            this.labelSkal.TabIndex = 25;
            this.labelSkal.Text = "Скаляр:";
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(47, 152);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(238, 168);
            this.richTextBox.TabIndex = 27;
            this.richTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button);
            this.panel1.Controls.Add(this.numericUpDownYP2);
            this.panel1.Controls.Add(this.richTextBox);
            this.panel1.Controls.Add(this.labelSkal);
            this.panel1.Controls.Add(this.labelXP2);
            this.panel1.Controls.Add(this.numericUpDownScal);
            this.panel1.Controls.Add(this.labelYP2);
            this.panel1.Controls.Add(this.numericUpDownXP2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 333);
            this.panel1.TabIndex = 28;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(122, 108);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 28;
            this.button.Text = "Показать!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 355);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Point";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYP2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelXP2;
        private System.Windows.Forms.Label labelYP2;
        private System.Windows.Forms.NumericUpDown numericUpDownXP2;
        private System.Windows.Forms.NumericUpDown numericUpDownScal;
        private System.Windows.Forms.NumericUpDown numericUpDownYP2;
        private System.Windows.Forms.Label labelSkal;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button;
    }
}

