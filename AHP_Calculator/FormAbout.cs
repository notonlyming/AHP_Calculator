using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHP_Calculator
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != global::AHP_Calculator.Properties.Resources.三叶草small)
            {
                pictureBox1.Image = global::AHP_Calculator.Properties.Resources.三叶草small;
            }
            else
            {
                pictureBox1.Image = global::AHP_Calculator.Properties.Resources.鸟;
            }

        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            MaximumSize = Size;
        }
    }
}
