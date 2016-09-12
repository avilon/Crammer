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
    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
            _dict = new Dict();
            LoadDict();

            tlpAnswers.Dock = DockStyle.Fill;
            _answers = new Label[MAX_ANSWERS];
            FillAnswers();
        }

        private void LoadDict()
        {
            _dict.Load();
        }

        private void ChoiceForm_Load(object sender, EventArgs e)
        {
            //this.splitContainer.SplitterDistance = 
            //    Properties.Settings.Default.ChoiceForm_SplitDistance - 3*this.splitContainer.SplitterWidth;
            lbTestWord.Text = _dict.GetItem("book").Value;
        }

        private void ChoiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ChoiceForm_SplitDistance =
                this.splitContainer.SplitterDistance;
            Properties.Settings.Default.Save();
        }

        private void FillAnswers()
        {

        }

        Dict _dict;
        Label[] _answers;

        static readonly int MAX_ANSWERS = 9;

        private void splitContainer_Panel1_Resize(object sender, EventArgs e)
        {
            //lbTestWord.Dock = DockStyle.Fill;
            //lbTestWord.Invalidate();
            //lbTestWord.Width = this.Width - 50;
        }
    }
}
