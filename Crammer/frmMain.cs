using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crammer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            pnlWorkArea.Dock = DockStyle.Fill;
            ShowChoiceForm();
        }

        private void ShowChoiceForm()
        {
            _choiceForm = new ChoiceForm();
            _choiceForm.TopLevel = false;
            _choiceForm.AutoScroll = false;
            _choiceForm.FormBorderStyle = FormBorderStyle.None;
            _choiceForm.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            pnlWorkArea.Controls.Add(_choiceForm);            
            _choiceForm.Dock = DockStyle.Fill;

            _choiceForm.Show();
        }

        private ChoiceForm _choiceForm;

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Top = Properties.Settings.Default.MainForm_Top;
            this.Left = Properties.Settings.Default.MainForm_Left;
            this.Width = Properties.Settings.Default.MainForm_Width;
            this.Height = Properties.Settings.Default.MainForm_Height;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.MainForm_Top = this.Top;
            Properties.Settings.Default.MainForm_Left = this.Left;
            Properties.Settings.Default.MainForm_Width = this.Width;
            Properties.Settings.Default.MainForm_Height = this.Height;
            Properties.Settings.Default.Save();

            _choiceForm.Close();
        }

        private void pnlWorkArea_Resize(object sender, EventArgs e)
        {
        }
    }
}
