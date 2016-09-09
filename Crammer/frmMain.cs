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
            pnlWorkArea.Controls.Add(_choiceForm);
            _choiceForm.Dock = DockStyle.Fill;
            _choiceForm.Show();
        }

        private ChoiceForm _choiceForm;
    }
}
