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
    public partial class FormAHP : Form
    {
        public FormAHP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddRoot_Click(object sender, EventArgs e)
        {
            treeViewHierarchy.Nodes.Add(Microsoft.VisualBasic.Interaction.InputBox("Please enter node text.", "Title needed"));
        }

        private void buttonAddSub_Click(object sender, EventArgs e)
        {
            if (treeViewHierarchy.SelectedNode != null)
            {
                treeViewHierarchy.SelectedNode.Nodes.Add(Microsoft.VisualBasic.Interaction.InputBox("Please enter node text.", "Title needed"));
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            TreeNode NodeSelect = treeViewHierarchy.SelectedNode;
            if (NodeSelect != null)
            {
                treeViewHierarchy.Nodes.Remove(NodeSelect);
            }

        }

        private void buttonClearNode_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Want to clear?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                treeViewHierarchy.Nodes.Clear();
            }
        }

        private void buttonCreateMatrix_Click(object sender, EventArgs e)
        {
            const int matrixSize = 5;
            TextBox[,] textBoxes = new TextBox[matrixSize,matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    textBoxes[i, j] = new TextBox();
                    textBoxes[i, j].MaxLength = 1;
                    textBoxes[i, j].Font= new Font(new FontFamily("微软雅黑"),12,new FontStyle());
                    textBoxes[i, j].TextAlign = HorizontalAlignment.Center;
                    textBoxes[i, j].Size = new Size(30, 30);

                    groupBoxMatrix.Controls.Add(textBoxes[i, j]);
                    if (i==0 && j==0)
                    {
                        textBoxes[i, j].Left = 29;
                        textBoxes[i, j].Top = 61;
                    }
                    else if (j == 0)
                    {
                        textBoxes[i, j].Left = textBoxes[i-1, j].Left;
                        textBoxes[i, j].Top = textBoxes[i-1, j].Top + textBoxes[i-1,j].Height;
                    }
                    else
                    {
                        textBoxes[i, j].Top = textBoxes[i, 0].Top;
                        textBoxes[i, j].Left = textBoxes[i, j - 1].Left + textBoxes[i, j - 1].Width;
                    }
                }
            }
        }
    }
}

