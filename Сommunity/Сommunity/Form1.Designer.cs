namespace Сommunity
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripDropDownButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonTable = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLgota = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonView = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemRasselenie = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.общежитиеDataSet = new Сommunity.ОбщежитиеDataSet();
            this.toolStripButtonReport = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.общежитиеDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripDropDownButtonFile
            // 
            this.toolStripDropDownButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.toolStripDropDownButtonFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFile.Image")));
            this.toolStripDropDownButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFile.Name = "toolStripDropDownButtonFile";
            this.toolStripDropDownButtonFile.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButtonFile.Text = "Файл";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem1.Text = "Выход";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripDropDownButtonTable
            // 
            this.toolStripDropDownButtonTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonTable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRoom,
            this.toolStripMenuItemLgota,
            this.toolStripMenuItemStudents});
            this.toolStripDropDownButtonTable.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonTable.Image")));
            this.toolStripDropDownButtonTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonTable.Name = "toolStripDropDownButtonTable";
            this.toolStripDropDownButtonTable.Size = new System.Drawing.Size(70, 22);
            this.toolStripDropDownButtonTable.Text = "Таблицы";
            // 
            // toolStripMenuItemRoom
            // 
            this.toolStripMenuItemRoom.Name = "toolStripMenuItemRoom";
            this.toolStripMenuItemRoom.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItemRoom.Text = "Комнаты";
            this.toolStripMenuItemRoom.Click += new System.EventHandler(this.toolStripMenuItemRoom_Click);
            // 
            // toolStripMenuItemLgota
            // 
            this.toolStripMenuItemLgota.Name = "toolStripMenuItemLgota";
            this.toolStripMenuItemLgota.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItemLgota.Text = "Льготы";
            this.toolStripMenuItemLgota.Click += new System.EventHandler(this.toolStripMenuItemLgota_Click);
            // 
            // toolStripMenuItemStudents
            // 
            this.toolStripMenuItemStudents.Name = "toolStripMenuItemStudents";
            this.toolStripMenuItemStudents.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItemStudents.Text = "Студенты";
            this.toolStripMenuItemStudents.Click += new System.EventHandler(this.toolStripMenuItemStudents_Click);
            // 
            // toolStripDropDownButtonView
            // 
            this.toolStripDropDownButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRasselenie});
            this.toolStripDropDownButtonView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonView.Image")));
            this.toolStripDropDownButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonView.Name = "toolStripDropDownButtonView";
            this.toolStripDropDownButtonView.Size = new System.Drawing.Size(77, 22);
            this.toolStripDropDownButtonView.Text = "Просмотр";
            // 
            // toolStripMenuItemRasselenie
            // 
            this.toolStripMenuItemRasselenie.Name = "toolStripMenuItemRasselenie";
            this.toolStripMenuItemRasselenie.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItemRasselenie.Text = "Расселение";
            this.toolStripMenuItemRasselenie.Click += new System.EventHandler(this.toolStripMenuItemRasselenie_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 22);
            this.toolStripButton1.Text = "Запросы";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFile,
            this.toolStripDropDownButtonTable,
            this.toolStripDropDownButtonView,
            this.toolStripButton1,
            this.toolStripButtonReport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(365, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.общежитиеDataSet;
            this.bindingSource1.Position = 0;
            // 
            // общежитиеDataSet
            // 
            this.общежитиеDataSet.DataSetName = "ОбщежитиеDataSet";
            this.общежитиеDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripButtonReport
            // 
            this.toolStripButtonReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonReport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReport.Image")));
            this.toolStripButtonReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReport.Name = "toolStripButtonReport";
            this.toolStripButtonReport.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonReport.Text = "Отчеты";
            this.toolStripButtonReport.Click += new System.EventHandler(this.toolStripButtonReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 224);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Главная";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.общежитиеDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonTable;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRoom;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLgota;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStudents;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRasselenie;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ОбщежитиеDataSet общежитиеDataSet;
        private System.Windows.Forms.ToolStripButton toolStripButtonReport;
    }
}

