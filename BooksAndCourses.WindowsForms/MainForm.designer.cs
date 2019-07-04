namespace BooksAndCourses.WinForms
{
    partial class MainForm
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
            this.mainContainer = new System.Windows.Forms.SplitContainer();
            this.Загрузить = new System.Windows.Forms.Button();
            this.Выгрузить = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvResources = new System.Windows.Forms.DataGridView();
            this.EditBtn = new System.Windows.Forms.Button();
            this.treeProperties = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).BeginInit();
            this.mainContainer.Panel1.SuspendLayout();
            this.mainContainer.Panel2.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            // 
            // mainContainer.Panel1
            // 
            this.mainContainer.Panel1.Controls.Add(this.Загрузить);
            this.mainContainer.Panel1.Controls.Add(this.Выгрузить);
            this.mainContainer.Panel1.Controls.Add(this.RemoveBtn);
            this.mainContainer.Panel1.Controls.Add(this.AddBtn);
            this.mainContainer.Panel1.Controls.Add(this.label1);
            this.mainContainer.Panel1.Controls.Add(this.statusStrip);
            this.mainContainer.Panel1.Controls.Add(this.dgvResources);
            // 
            // mainContainer.Panel2
            // 
            this.mainContainer.Panel2.Controls.Add(this.EditBtn);
            this.mainContainer.Panel2.Controls.Add(this.treeProperties);
            this.mainContainer.Size = new System.Drawing.Size(1184, 661);
            this.mainContainer.SplitterDistance = 394;
            this.mainContainer.TabIndex = 0;
            // 
            // Загрузить
            // 
            this.Загрузить.Location = new System.Drawing.Point(201, 600);
            this.Загрузить.Name = "Загрузить";
            this.Загрузить.Size = new System.Drawing.Size(118, 24);
            this.Загрузить.TabIndex = 6;
            this.Загрузить.Text = "Загрузить";
            this.Загрузить.UseVisualStyleBackColor = true;
            this.Загрузить.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Выгрузить
            // 
            this.Выгрузить.Location = new System.Drawing.Point(201, 567);
            this.Выгрузить.Name = "Выгрузить";
            this.Выгрузить.Size = new System.Drawing.Size(118, 26);
            this.Выгрузить.TabIndex = 5;
            this.Выгрузить.Text = "Выгрузить";
            this.Выгрузить.UseVisualStyleBackColor = true;
            this.Выгрузить.Click += new System.EventHandler(this.Unload_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RemoveBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveBtn.Location = new System.Drawing.Point(44, 599);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(118, 25);
            this.RemoveBtn.TabIndex = 4;
            this.RemoveBtn.Text = "Удалить";
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Lime;
            this.AddBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.Location = new System.Drawing.Point(44, 568);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(118, 25);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 639);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(394, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // dgvResources
            // 
            this.dgvResources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResources.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvResources.Location = new System.Drawing.Point(0, 0);
            this.dgvResources.Name = "dgvResources";
            this.dgvResources.RowHeadersVisible = false;
            this.dgvResources.Size = new System.Drawing.Size(394, 561);
            this.dgvResources.TabIndex = 0;
            this.dgvResources.CurrentCellChanged += new System.EventHandler(this.dgvResources_CurrentCellChanged);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Yellow;
            this.EditBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBtn.Location = new System.Drawing.Point(597, 567);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(177, 40);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // treeProperties
            // 
            this.treeProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeProperties.Location = new System.Drawing.Point(0, 0);
            this.treeProperties.Name = "treeProperties";
            this.treeProperties.Size = new System.Drawing.Size(786, 561);
            this.treeProperties.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.mainContainer);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1062, 700);
            this.Name = "MainForm";
            this.Text = "Источники для изучения C#";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainContainer.Panel1.ResumeLayout(false);
            this.mainContainer.Panel1.PerformLayout();
            this.mainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainContainer)).EndInit();
            this.mainContainer.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResources)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainContainer;
        private System.Windows.Forms.DataGridView dgvResources;
        private System.Windows.Forms.TreeView treeProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button Выгрузить;
        private System.Windows.Forms.Button Загрузить;
    }
}

