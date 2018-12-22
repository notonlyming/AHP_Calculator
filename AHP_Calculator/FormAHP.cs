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
            FormMatrix formMatrix = new FormMatrix(new string[,] { { "1", "3" }, { "5", "7" } }, new string[] { "factor1", "factor2" }, "parent");
            formMatrix.Show();
        }
    }
}

