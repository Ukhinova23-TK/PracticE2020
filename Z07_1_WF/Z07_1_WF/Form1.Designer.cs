namespace Z07_1_WF
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
            this.labelStr = new System.Windows.Forms.Label();
            this.textBoxStr = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStr
            // 
            this.labelStr.AutoSize = true;
            this.labelStr.Location = new System.Drawing.Point(13, 13);
            this.labelStr.Name = "labelStr";
            this.labelStr.Size = new System.Drawing.Size(46, 13);
            this.labelStr.TabIndex = 0;
            this.labelStr.Text = "Строка:";
            // 
            // textBoxStr
            // 
            this.textBoxStr.Location = new System.Drawing.Point(89, 13);
            this.textBoxStr.Multiline = true;
            this.textBoxStr.Name = "textBoxStr";
            this.textBoxStr.Size = new System.Drawing.Size(393, 78);
            this.textBoxStr.TabIndex = 1;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(276, 126);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(206, 20);
            this.textBoxSum.TabIndex = 2;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(407, 97);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 3;
            this.button.Text = "Подчитать!";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 160);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxStr);
            this.Controls.Add(this.labelStr);
            this.Name = "Form1";
            this.Text = "Сумма цифр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStr;
        private System.Windows.Forms.TextBox textBoxStr;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button button;
    }
}

