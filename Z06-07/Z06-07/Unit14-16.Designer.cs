namespace Z06_07
{
    partial class Unit14
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RemoveAllButton = new System.Windows.Forms.Button();
            this.AddNodeTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.FindNodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(301, 338);
            this.treeView1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(473, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(353, 112);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RemoveAllButton
            // 
            this.RemoveAllButton.Location = new System.Drawing.Point(473, 112);
            this.RemoveAllButton.Name = "RemoveAllButton";
            this.RemoveAllButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveAllButton.TabIndex = 3;
            this.RemoveAllButton.Text = "Remove All";
            this.RemoveAllButton.UseVisualStyleBackColor = true;
            this.RemoveAllButton.Click += new System.EventHandler(this.RemoveAllButton_Click);
            // 
            // AddNodeTextBox
            // 
            this.AddNodeTextBox.Location = new System.Drawing.Point(353, 12);
            this.AddNodeTextBox.Name = "AddNodeTextBox";
            this.AddNodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddNodeTextBox.TabIndex = 4;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(473, 62);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FindNodeTextBox
            // 
            this.FindNodeTextBox.Location = new System.Drawing.Point(353, 62);
            this.FindNodeTextBox.Name = "FindNodeTextBox";
            this.FindNodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.FindNodeTextBox.TabIndex = 6;
            // 
            // Unit14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 362);
            this.Controls.Add(this.FindNodeTextBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.AddNodeTextBox);
            this.Controls.Add(this.RemoveAllButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.treeView1);
            this.Name = "Unit14";
            this.Text = "Unit14";
            this.Click += new System.EventHandler(this.Unit14_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button RemoveAllButton;
        private System.Windows.Forms.TextBox AddNodeTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox FindNodeTextBox;
    }
}