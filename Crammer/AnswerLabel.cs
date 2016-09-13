using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crammer
{
    class AnswerLabel : Label
    {
        public AnswerLabel(int index) : base()
        {
            _ndx = index;
        }

        public int Index
        {
            get
            {
                return _ndx;
            }
        }

        private int _ndx;
    }
}
