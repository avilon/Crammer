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
    /// <summary>
    /// 
    /// </summary>
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
                _answers[i].MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnswerLabelMouseClick);
            }

            tlpAnswers.Controls.Add(_answers[0]);
            tlpAnswers.Controls.Add(_answers[1]);
            tlpAnswers.Controls.Add(_answers[2]);
            tlpAnswers.Controls.Add(_answers[3]);
            tlpAnswers.Controls.Add(_answers[4]);
            tlpAnswers.Controls.Add(_answers[5]);

            tlpAnswers.BringToFront();

            ShowNextItem();
        }

        public int GetItemCount()
        {
            return _dict.Count;
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
            int ndx = 6;
            _pos = rnd.Next(6);
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
                if (i == _pos)
                    _answers[i].Text = _dict.GetCurrentTranslate();
                else
                    _answers[i].Text = _dict.GetTranslate(hset.ElementAt(i));
            }
        }

        private void ShowNextItem()
        {
            _dict.NextItem();
            lbTestWord.Text = _dict.CurrentItem.Value;
            FillAnswers();
        }

        private Dict _dict;
        private Label[] _answers;
        private int _pos;

        static readonly int MAX_ANSWERS = 9;

        private void AnswerLabelMouseClick(object sender, MouseEventArgs e)
        {
            int ndx = (sender as AnswerLabel).Index;
            if (ndx != _pos)
            {
                MessageBox.Show("Ошибка, попробуйте еще раз", "Crammer");
                return;
            }
            ShowNextItem();
        }
    }
}
