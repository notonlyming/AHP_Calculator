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
    public partial class FormText : Form
    {
        public FormText()
        {
            InitializeComponent();
        }

        private void FormText_Resize(object sender, EventArgs e)
        {
            FullSizeText();
        }
        
        private void FullSizeText()
        {
            textBoxText.Location = new Point(0, menuStrip1.Height); //移动至左上角
            textBoxText.Height = this.Size.Height- menuStrip1.Height - 39;
            textBoxText.Width = this.Size.Width - 16;
        }

        public void Show(string ShowText, string caption)
        {
            Show();
            textBoxText.Text = ShowText;
            Text = caption;
        }

        private void FormText_Load(object sender, EventArgs e)
        {
            FullSizeText();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = Text;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter file = System.IO.File.CreateText(saveFileDialog1.FileName);
                file.Write(textBoxText.Text);
                file.Close();
            }
        }
    }
}
