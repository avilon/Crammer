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
                _answers[i] = new AnswerLabel(i);
                _answers[i].Dock = DockStyle.Fill;
                _answers[i].TextAlign = ContentAlignment.MiddleCenter;
                _answers[i].Font = new Font("Tahoma", 12);
                _answers[i].SendToBack();
            }

            tlpAnswers.Controls.Add(_answers[0]);
            tlpAnswers.Controls.Add(_answers[1]);
            tlpAnswers.Controls.Add(_answers[2]);
            tlpAnswers.Controls.Add(_answers[3]);
            tlpAnswers.BringToFront();

            _dict.NextItem();
            lbTestWord.Text = _dict.CurrentItem.Value;
            FillAnswers();
        }

        private void LoadDict()
        {
            _dict.Load();
        }

        private void ChoiceForm_Load(object sender, EventArgs e)
        {
            _dict.NextItem();
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
            int ndx = 4;
            int pos = rnd.Next(4);
            HashSet<int> hset = new HashSet<int>();
            while (hset.Count < ndx)
            {
                int n = rnd.Next(0, _dict.Count);
                if (!hset.Contains(n))
                {
                    if (_dict.GetItem(n).Value != _dict.CurrentItem.Value)
                        hset.Add(n);
                }
            }
            for (int i = 0; i < ndx; i++)
            {
                if (i == pos)
                    _answers[i].Text = _dict.GetCurrentTranslate();
                else
                    _answers[i].Text = _dict.GetTranslate(hset.ElementAt(i));
            }
        }

        Dict _dict;
        Label[] _answers;

        static readonly int MAX_ANSWERS = 9;

        private void tlpAnswers_MouseClick(object sender, MouseEventArgs e)
        {
            int row = 0;
            int verticalOffset = 0;
            foreach (int h in tlpAnswers.GetRowHeights())
            {
                int column = 0;
                int horizontalOffset = 0;
                foreach (int w in tlpAnswers.GetColumnWidths())
                {
                    Rectangle rectangle = new Rectangle(horizontalOffset, verticalOffset, w, h);
                    if (rectangle.Contains(e.Location))
                    {
                        MessageBox.Show(String.Format("row {0}, column {1} was clicked", row, column), "aa");
                        return;
                    }
                    horizontalOffset += w;
                    column++;
                }
                verticalOffset += h;
                row++;
            }
        }

        private void tlpAnswers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse double click", "aa");
        }
    }
}
