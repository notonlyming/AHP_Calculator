using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AHP_Calculator
{
    public partial class FormAHP : Form
    {
        private ArrayList MatrixList;  //用于存储该层次中的所有成对比较矩阵
        private ArrayList LayerList;  //用于存储treeView中的每一层，里面每一个元素是一个node集合，集合中有儿子
        public FormAHP()
        {
            InitializeComponent();
            LayerList = new ArrayList();
            MatrixList = new ArrayList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeViewHierarchy.ExpandAll();  //把层次结构展开来看
            if (treeViewHierarchy.Nodes.Count > 0)
            {
                treeViewHierarchy.SelectedNode = treeViewHierarchy.Nodes[0];
            }
        }

        private void ScanLevel()
        {

            if (treeViewHierarchy.Nodes.Count == 0)
            {
                //如果层次还没建立，重新扫描导致各种清空
                LayerList.Clear();
                listBox1.Items.Clear();
                MatrixList.Clear();
                return;
            }

            if (MessageBox.Show("This operation will clear all privious pair-wise matrix, continue?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0)
                == DialogResult.Yes)
            {
                //把层次中的每一层扫描出来
                TreeNode currentNode;
                LayerList.Clear();  //清除原先的东西
                Queue<TreeNode> childrenQue = new Queue<TreeNode>();  //孩儿们，快来排队呀~
                PutChildrenIntoQueue(treeViewHierarchy.Nodes, childrenQue);  //第一波父亲进入队列
                LayerList.Add(treeViewHierarchy.Nodes);  //第一层已被加入列表
                while (childrenQue.Count() > 0)  //找儿子，直到没有要找儿子的父亲
                {
                    currentNode = childrenQue.Dequeue();  //排头出列
                    if (GetNodeChildren(currentNode).Count != 0)
                    {
                        //如果有儿子，把儿子加入队列并把儿子们加入数组
                        PutChildrenIntoQueue(GetNodeChildren(currentNode), childrenQue);
                        LayerList.Add(GetNodeChildren(currentNode));
                    }
                }

                //将获得的层次加入列表框
                listBox1.Items.Clear();  //先清除之前的结果，在添加新扫描的结果
                foreach (TreeNodeCollection layer in LayerList)
                {
                    TreeNode parentNode = layer[0].Parent;
                    if (parentNode == null)
                    {
                        //如果为空，说明是顶层，没了爸爸，好惨
                        listBox1.Items.Add("Top, no matrix");
                    }
                    else
                    {
                        //加入列表
                        listBox1.Items.Add("Pait-wise Matrix in " + parentNode.Text);
                    }
                }

                //为每一层构造成对比较矩阵
                MatrixList.Clear();  //每次重新生成前清除之前的结果
                foreach (TreeNodeCollection layer in LayerList)
                {
                    TreeNode parentNode = layer[0].Parent;
                    if (parentNode != null)
                    {
                        //如果不为空，加入列表
                        MatrixList.Add(MakePairWiseMatrix(layer.Count));
                    }
                    else
                    {
                        //如果为空，还是加入，避免无法一一对应
                        MatrixList.Add(null);
                    }
                }
            }
        }

        private void PutChildrenIntoQueue(TreeNodeCollection nodes, Queue<TreeNode> childrenQue)
        {
            foreach (TreeNode node in nodes)
            {
                childrenQue.Enqueue(node);  //开始排队找儿子
            }
        }

        private TreeNodeCollection GetNodeChildren(TreeNode node)
        {
            return node.Nodes;
        }

        private string[,] MakePairWiseMatrix(int length)
        {
            string[,] tmpMa = new string[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == j)
                    {
                        //对角线填1
                        tmpMa[i, j] = "1";
                    }
                    else
                    {
                        tmpMa[i, j] = "0";
                    }
                }
            }
            return tmpMa;
        }

        int GetTreeNodesDepth(TreeNodeCollection treeNode)
        {
            //求该树的最大深度
            int max = 0;
            if (treeNode.Count == 0)
            {
                return 0;
            }
            else
            {
                foreach (TreeNode node in treeNode)
                {
                    if (GetTreeNodesDepth(node.Nodes) > max)
                    {
                        max = GetTreeNodesDepth(node.Nodes);
                    }
                }
                return max + 1;
            }
        }

        private void hireToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewHierarchy.Nodes.Add(Microsoft.VisualBasic.Interaction.InputBox("Please enter node text.", "Title needed"));
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TreeNode NodeSelect = treeViewHierarchy.SelectedNode;
            if (NodeSelect != null)
            {
                treeViewHierarchy.Nodes.Remove(NodeSelect);
            }
        }

        private void subToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewHierarchy.SelectedNode != null)
            {
                treeViewHierarchy.SelectedNode.Nodes.Add(Microsoft.VisualBasic.Interaction.InputBox("Please enter node text.", "Title needed"));
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Want to clear? This will reset this project!!!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                treeViewHierarchy.Nodes.Clear();
                ScanLevel();
            }
        }

        private void scanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScanLevel();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                TreeNodeCollection CurrentLayer = ((TreeNodeCollection[])LayerList.ToArray(typeof(TreeNodeCollection)))[listBox1.SelectedIndex];
                string[,] CurrentMatrix = ((string[][,])MatrixList.ToArray(typeof(string[,])))[listBox1.SelectedIndex];

                if (CurrentMatrix == null)
                {
                    MessageBox.Show("No matrix!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0);
                    return;  //如果矩阵为空，不进行下面的操作
                }

                //取出该层因素
                string[] FactorsString = new string[CurrentLayer.Count];
                int i = 0;
                foreach (TreeNode node in CurrentLayer)
                {
                    FactorsString[i] = node.Text;
                    i++;
                }

                FormMatrix formMatrix = new FormMatrix(CurrentMatrix, FactorsString, CurrentLayer[0].Parent.Text);
                formMatrix.Show();
            }
        }

        struct NodeInfo
        {
            public int ID;
            public int ParentID;
            public TreeNode node;
            public string Text;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (LayerList.Count > 0)
            {
                //如果有扫描好的层次结构，则开始存储
                ArrayList NodesList = new ArrayList();  //新建list用于生成一维的node列表
                //生成一维列表
                foreach (TreeNodeCollection nodes in LayerList)
                {
                    foreach (TreeNode node in nodes)
                    {
                        NodesList.Add(node);
                    }
                }
                TreeNode[] CurrentAllTreeNodes = (TreeNode[])NodesList.ToArray(typeof(TreeNode));
                NodeInfo[] nodeInfos = new NodeInfo[CurrentAllTreeNodes.Length];
                //填充序号和文本
                for (int i = 0; i < nodeInfos.Length; i++)
                {
                    nodeInfos[i].ID = i;
                    nodeInfos[i].node = CurrentAllTreeNodes[i];
                    nodeInfos[i].Text = CurrentAllTreeNodes[i].Text;
                }
                //根据文本查找父节点ID
                for (int i = 0; i < nodeInfos.Length; i++)
                {
                    if (nodeInfos[i].node.Parent != null)
                    {
                        foreach (var node in nodeInfos)
                        {
                            if (nodeInfos[i].node.Parent.Text.Equals(node.Text))
                            {
                                //如果文本相同，找到了
                                nodeInfos[i].ParentID = node.ID;
                                break;
                            }
                        }
                    }
                    else
                    {
                        //如果没有父节点了，ID就是自己的ID
                        nodeInfos[i].ParentID = nodeInfos[i].ID;
                    }

                }

                //构建保存字符串
                StringBuilder saveStringBuilder = new StringBuilder();
                foreach (var node in nodeInfos)
                {
                    saveStringBuilder.Append(node.ID.ToString() + "," + node.ParentID.ToString() + "," + node.Text + "\n");
                }

                MessageBox.Show(saveStringBuilder.ToString());
            }
        }


        private void pairWiseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                //取出被选层矩阵因素，构造因素字符串数组
                //下面这一行表示从选择的列表框中取出选中的行号索引，到对应的层去找那个孩子集合，取孩子个数，即因素个数，构造相同大小的因素字符串数组
                TreeNodeCollection CurrentLayer = ((TreeNodeCollection[])LayerList.ToArray(typeof(TreeNodeCollection)))[listBox1.SelectedIndex];
                string[,] CurrentMatrix = ((string[][,])MatrixList.ToArray(typeof(string[,])))[listBox1.SelectedIndex];

                if (CurrentMatrix == null)
                {
                    MessageBox.Show("No matrix!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0);
                    return;  //如果矩阵为空，不进行下面的操作
                }

                string[] FactorsString = new string[CurrentLayer.Count];
                int i = 0;
                //取出该层因素
                foreach (TreeNode node in CurrentLayer)
                {
                    FactorsString[i] = node.Text;
                    i++;
                }
                FormSurvey formSurvey = new FormSurvey(FactorsString, CurrentLayer[0].Parent.Text, CurrentMatrix);
                formSurvey.Show();
            }
        }

        private void exportTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            //取每个矩阵出来进行导出
            for (int index = 0; index < listBox1.Items.Count; index++)
            {
                //取出当前矩阵和层次
                TreeNodeCollection CurrentLayer = ((TreeNodeCollection[])LayerList.ToArray(typeof(TreeNodeCollection)))[index];
                string[,] CurrentMatrix = ((string[][,])MatrixList.ToArray(typeof(string[,])))[index];
                if (CurrentMatrix != null)
                {
                    string[] FactorsString = new string[CurrentLayer.Count];
                    int i = 0;
                    //取出该层因素
                    foreach (TreeNode node in CurrentLayer)
                    {
                        FactorsString[i] = node.Text;
                        i++;
                    }
                    FormSurvey formSurvey = new FormSurvey(FactorsString, CurrentLayer[0].Parent.Text, CurrentMatrix);
                    formSurvey.Show();
                    stringBuilder.Append("------------------------------ \r\n");
                    stringBuilder.Append(formSurvey.getAllQuestionText());
                    formSurvey.Close();
                }
            }
            FormText formText = new FormText();
            formText.Show(stringBuilder.ToString());
        }
    }
}