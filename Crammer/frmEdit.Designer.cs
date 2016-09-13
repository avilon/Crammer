namespace Crammer
{
    partial class EditForm
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.bbOk = new System.Windows.Forms.Button();
            this.bbCancel = new System.Windows.Forms.Button();
            this.bbClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.bbAdd = new System.Windows.Forms.Button();
            this.bbEdit = new System.Windows.Forms.Button();
            this.bbDelete = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.bbClose);
            this.pnlButtons.Controls.Add(this.bbCancel);
            this.pnlButtons.Controls.Add(this.bbOk);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 215);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(284, 47);
            this.pnlButtons.TabIndex = 0;
            // 
            // bbOk
            // 
            this.bbOk.Location = new System.Drawing.Point(12, 12);
            this.bbOk.Name = "bbOk";
            this.bbOk.Size = new System.Drawing.Size(75, 23);
            this.bbOk.TabIndex = 0;
            this.bbOk.Text = "Ok";
            this.bbOk.UseVisualStyleBackColor = true;
            // 
            // bbCancel
            // 
            this.bbCancel.Location = new System.Drawing.Point(99, 12);
            this.bbCancel.Name = "bbCancel";
            this.bbCancel.Size = new System.Drawing.Size(75, 23);
            this.bbCancel.TabIndex = 1;
            this.bbCancel.Text = "Отмена";
            this.bbCancel.UseVisualStyleBackColor = true;
            // 
            // bbClose
            // 
            this.bbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bbClose.Location = new System.Drawing.Point(186, 12);
            this.bbClose.Name = "bbClose";
            this.bbClose.Size = new System.Drawing.Size(75, 23);
            this.bbClose.TabIndex = 2;
            this.bbClose.Text = "Закрыть";
            this.bbClose.UseVisualStyleBackColor = true;
            this.bbClose.Click += new System.EventHandler(this.bbClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(284, 215);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bbDelete);
            this.panel2.Controls.Add(this.bbEdit);
            this.panel2.Controls.Add(this.bbAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(180, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 195);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tvMain);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 195);
            this.panel3.TabIndex = 2;
            // 
            // tvMain
            // 
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMain.Location = new System.Drawing.Point(0, 0);
            this.tvMain.Name = "tvMain";
            this.tvMain.Size = new System.Drawing.Size(170, 195);
            this.tvMain.TabIndex = 1;
            // 
            // bbAdd
            // 
            this.bbAdd.Location = new System.Drawing.Point(6, 12);
            this.bbAdd.Name = "bbAdd";
            this.bbAdd.Size = new System.Drawing.Size(80, 23);
            this.bbAdd.TabIndex = 0;
            this.bbAdd.Text = "Добавить";
            this.bbAdd.UseVisualStyleBackColor = true;
            // 
            // bbEdit
            // 
            this.bbEdit.Location = new System.Drawing.Point(6, 41);
            this.bbEdit.Name = "bbEdit";
            this.bbEdit.Size = new System.Drawing.Size(80, 23);
            this.bbEdit.TabIndex = 1;
            this.bbEdit.Text = "Редактировать";
            this.bbEdit.UseVisualStyleBackColor = true;
            // 
            // bbDelete
            // 
            this.bbDelete.Location = new System.Drawing.Point(6, 70);
            this.bbDelete.Name = "bbDelete";
            this.bbDelete.Size = new System.Drawing.Size(80, 23);
            this.bbDelete.TabIndex = 2;
            this.bbDelete.Text = "Удалить";
            this.bbDelete.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButtons);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.pnlButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button bbClose;
        private System.Windows.Forms.Button bbCancel;
        private System.Windows.Forms.Button bbOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bbDelete;
        private System.Windows.Forms.Button bbEdit;
        private System.Windows.Forms.Button bbAdd;
    }
}