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
            for (int i = 0; i < MAX_ANSWERS; i++)
            {
                _answers[i] = new Label();
                _answers[i].Dock = DockStyle.Fill;
                _answers[i].TextAlign = ContentAlignment.MiddleCenter;
            }

            tlpAnswers.Controls.Add(_answers[0]);
            tlpAnswers.Controls.Add(_answers[1]);
            tlpAnswers.Controls.Add(_answers[2]);
            tlpAnswers.Controls.Add(_answers[3]);

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
            Random rnd = new Random();
            int ndx = tlpAnswers.RowCount * tlpAnswers.ColumnCount;
            HashSet<int> hset = new HashSet<int>();
            while (hset.Count < ndx)
            {
                int n = rnd.Next(0, _dict.Count);
                if (!hset.Contains(n))
                {
                    hset.Add(n);
                }
            }
            for ( int i = 0; i < ndx; i++)
            {
                _answers[i].Text = _dict.GetTranslate(hset.ElementAt(i));
            }
        }

        Dict _dict;
        Label[] _answers;

        static readonly int MAX_ANSWERS = 9;

        private void tlpAnswers_MouseClick(object sender, MouseEventArgs e)
        {
            //
        }
    }
}
