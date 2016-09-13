namespace Crammer
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlWorkArea = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mmFileEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsslFirst = new System.Windows.Forms.ToolStripStatusLabel();
            this.тестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmTestChoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mmTestPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorkArea
            // 
            this.pnlWorkArea.Location = new System.Drawing.Point(99, 105);
            this.pnlWorkArea.Name = "pnlWorkArea";
            this.pnlWorkArea.Size = new System.Drawing.Size(200, 100);
            this.pnlWorkArea.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFirst});
            this.statusStrip.Location = new System.Drawing.Point(0, 280);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(419, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.тестToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFileNew,
            this.mmFileOpen,
            this.mmFileEdit,
            this.toolStripMenuItem1,
            this.mmExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // mmFileNew
            // 
            this.mmFileNew.Name = "mmFileNew";
            this.mmFileNew.Size = new System.Drawing.Size(160, 22);
            this.mmFileNew.Text = "Новый";
            // 
            // mmFileOpen
            // 
            this.mmFileOpen.Name = "mmFileOpen";
            this.mmFileOpen.Size = new System.Drawing.Size(160, 22);
            this.mmFileOpen.Text = "Открыть...";
            // 
            // mmFileEdit
            // 
            this.mmFileEdit.Name = "mmFileEdit";
            this.mmFileEdit.Size = new System.Drawing.Size(160, 22);
            this.mmFileEdit.Text = "Редактировать..";
            this.mmFileEdit.Click += new System.EventHandler(this.mmFileEdit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 6);
            // 
            // mmExit
            // 
            this.mmExit.Name = "mmExit";
            this.mmExit.Size = new System.Drawing.Size(160, 22);
            this.mmExit.Text = "Выход";
            this.mmExit.Click += new System.EventHandler(this.mmExit_Click);
            // 
            // tsslFirst
            // 
            this.tsslFirst.Name = "tsslFirst";
            this.tsslFirst.Size = new System.Drawing.Size(118, 17);
            this.tsslFirst.Text = "toolStripStatusLabel1";
            // 
            // тестToolStripMenuItem
            // 
            this.тестToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmTestChoice,
            this.mmTestPrint});
            this.тестToolStripMenuItem.Name = "тестToolStripMenuItem";
            this.тестToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.тестToolStripMenuItem.Text = "Тест";
            // 
            // mmTestChoice
            // 
            this.mmTestChoice.Name = "mmTestChoice";
            this.mmTestChoice.Size = new System.Drawing.Size(155, 22);
            this.mmTestChoice.Text = "Угадайка";
            this.mmTestChoice.Click += new System.EventHandler(this.mmTestChoice_Click);
            // 
            // mmTestPrint
            // 
            this.mmTestPrint.Name = "mmTestPrint";
            this.mmTestPrint.Size = new System.Drawing.Size(155, 22);
            this.mmTestPrint.Text = "Правописание";
            this.mmTestPrint.Click += new System.EventHandler(this.mmTestPrint_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 302);
            this.Controls.Add(this.pnlWorkArea);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Crammer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlWorkArea;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmFileNew;
        private System.Windows.Forms.ToolStripMenuItem mmFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mmFileEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mmExit;
        private System.Windows.Forms.ToolStripStatusLabel tsslFirst;
        private System.Windows.Forms.ToolStripMenuItem тестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmTestChoice;
        private System.Windows.Forms.ToolStripMenuItem mmTestPrint;

    }
}

