namespace Crammer
{
    partial class ChoiceForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.lbTestWord = new System.Windows.Forms.Label();
            this.tlpAnswers = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.Info;
            this.splitContainer.Panel1.Controls.Add(this.lbTestWord);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer.Panel1.Resize += new System.EventHandler(this.splitContainer_Panel1_Resize);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tlpAnswers);
            this.splitContainer.Size = new System.Drawing.Size(347, 343);
            this.splitContainer.SplitterDistance = 100;
            this.splitContainer.TabIndex = 0;
            // 
            // lbTestWord
            // 
            this.lbTestWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTestWord.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbTestWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTestWord.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTestWord.Location = new System.Drawing.Point(10, 10);
            this.lbTestWord.Name = "lbTestWord";
            this.lbTestWord.Size = new System.Drawing.Size(327, 80);
            this.lbTestWord.TabIndex = 0;
            this.lbTestWord.Text = "label1";
            this.lbTestWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpAnswers
            // 
            this.tlpAnswers.ColumnCount = 2;
            this.tlpAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAnswers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAnswers.Location = new System.Drawing.Point(57, 44);
            this.tlpAnswers.Name = "tlpAnswers";
            this.tlpAnswers.RowCount = 2;
            this.tlpAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAnswers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAnswers.Size = new System.Drawing.Size(200, 100);
            this.tlpAnswers.TabIndex = 0;
            // 
            // ChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 343);
            this.Controls.Add(this.splitContainer);
            this.Name = "ChoiceForm";
            this.Text = "frmChoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChoiceForm_FormClosing);
            this.Load += new System.EventHandler(this.ChoiceForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lbTestWord;
        private System.Windows.Forms.TableLayoutPanel tlpAnswers;
    }
}