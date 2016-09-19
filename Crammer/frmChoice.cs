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
            _choiceDir = 0;
            _dict = new Dict();
            LoadDict();

            tlpAnswers.Dock = DockStyle.Fill;
            
            CreateAnswersLabels();

            int ndxCount = tlpAnswers.ColumnCount * tlpAnswers.RowCount;
            for (int i = 0; i < ndxCount; i++ )
            {
                tlpAnswers.Controls.Add(_answers[i]);
            }

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
            _pos = rnd.Next(ndx);
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
                {
                    if (_choiceDir != 0)
                        _answers[i].Text = _dict.GetCurrentTranslate();
                    else
                        _answers[i].Text = _dict.GetCurrentValue();
                }
                else
                {
                    if (_choiceDir != 0)
                        _answers[i].Text = _dict.GetTranslate(hset.ElementAt(i));
                    else
                        _answers[i].Text = _dict.GetValue(hset.ElementAt(i));
                }
            }

            ResetAnswerLabels();
        }

        private void ShowNextItem()
        {
            _dict.NextItem();
            _choiceDir = (DateTime.Now.Second % 2);
            if (_choiceDir != 0)
            {
                lbTestWord.Text = _dict.CurrentItem.Value;
            }
            else
            {
                lbTestWord.Text = _dict.CurrentItem.Translates.ToString();
            }
            FillAnswers();
        }

        private void AnswerLabelMouseClick(object sender, MouseEventArgs e)
        {
            int ndx = (sender as AnswerLabel).Index;
            if (ndx != _pos)
            {
                MessageBox.Show("Ошибка, попробуйте еще раз", "Crammer");
                _answers[ndx].BackColor = Color.DarkOrange;
                return;
            }
            ShowNextItem();
        }

        private void CreateAnswersLabels()
        {
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
        }

        private void ResetAnswerLabels()
        {
            for (int i = 0; i < MAX_ANSWERS; i++)
            {
                _answers[i].BackColor = SystemColors.ButtonFace;
            }
        }

        private Dict _dict;
        private Label[] _answers;
        private int _pos;
        private int _choiceDir;

        static readonly int MAX_ANSWERS = 9;
    }
}
