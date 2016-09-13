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
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void bbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
