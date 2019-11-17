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
using System.Resources;
using System.Reflection;
using System.IO;

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
            HierarchyViewGoTop();  //回到顶层
            MaximumSize = Size;  //窗口不可调
        }

        private void HierarchyViewGoTop()
        {
            if (treeViewHierarchy.Nodes.Count > 0)
            {
                treeViewHierarchy.SelectedNode = treeViewHierarchy.Nodes[0];
                treeViewHierarchy.SelectedNode = null;
            }
            //先选第一个，然后取消选择
        }

        private void ScanLevel(bool ClearOrNot, bool PromptOrNot)
        {

            if (treeViewHierarchy.Nodes.Count == 0)
            {
                //如果层次还没建立，重新扫描导致各种清空
                LayerList.Clear();
                listBoxMatrix.Items.Clear();
                MatrixList.Clear();
                return;
            }

            if (PromptOrNot ? MessageBox.Show("This operation will clear all privious pair-wise matrix, continue?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0)
                == DialogResult.Yes : true)
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
                listBoxMatrix.Items.Clear();  //先清除之前的结果，在添加新扫描的结果
                foreach (TreeNodeCollection layer in LayerList)
                {
                    TreeNode parentNode = layer[0].Parent;
                    if (parentNode == null)
                    {
                        //如果为空，说明是顶层，没了爸爸，好惨
                        //listBoxMatrix.Items.Add("Top, no matrix");
                    }
                    else
                    {
                        //加入列表
                        listBoxMatrix.Items.Add("Pait-wise Matrix in " + parentNode.Text);
                    }
                }

                //为每一层构造成对比较矩阵
                if (ClearOrNot)
                {
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

        private int GetTreeNodesDepth(TreeNodeCollection treeNode)
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

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TreeNode NodeSelect = treeViewHierarchy.SelectedNode;
            if (NodeSelect != null)
            {
                treeViewHierarchy.Nodes.Remove(NodeSelect);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Want to clear? This will reset this project!!!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                treeViewHierarchy.Nodes.Clear();
                ScanLevel(true, true);
            }
        }

        private void scanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScanLevel(true, true);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxMatrix.SelectedIndex != -1)
            {
                TreeNodeCollection CurrentLayer = ((TreeNodeCollection[])LayerList.ToArray(typeof(TreeNodeCollection)))[listBoxMatrix.SelectedIndex + 1];
                string[,] CurrentMatrix = ((string[][,])MatrixList.ToArray(typeof(string[,])))[listBoxMatrix.SelectedIndex + 1];

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
            TreeNode[] CurrentAllTreeNodes = getTreeAllNodes(); //生成一维的node列表
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

            //添加矩阵信息
            saveStringBuilder.Append(GetExportMatrixString());

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter file = System.IO.File.CreateText(saveFileDialog1.FileName);
                file.Write(saveStringBuilder.ToString());
                file.Close();
            }
        }

        private void pairWiseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBoxMatrix.SelectedIndex != -1)
            {
                //取出被选层矩阵因素，构造因素字符串数组
                //下面这一行表示从选择的列表框中取出选中的行号索引，到对应的层去找那个孩子集合，取孩子个数，即因素个数，构造相同大小的因素字符串数组
                TreeNodeCollection CurrentLayer = ((TreeNodeCollection[])LayerList.ToArray(typeof(TreeNodeCollection)))[listBoxMatrix.SelectedIndex + 1];
                string[,] CurrentMatrix = ((string[][,])MatrixList.ToArray(typeof(string[,])))[listBoxMatrix.SelectedIndex + 1];

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
            bool GetAnswer =
                MessageBox.Show("Export answer or not? ", "Export type",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes;
            StringBuilder stringBuilder = new StringBuilder();
            //取每个矩阵出来进行导出
            for (int index = 0; index < listBoxMatrix.Items.Count; index++)
            {
                //取出当前矩阵和层次
                TreeNodeCollection CurrentLayer = ((TreeNodeCollection[])LayerList.ToArray(typeof(TreeNodeCollection)))[index + 1];
                string[,] CurrentMatrix = ((string[][,])MatrixList.ToArray(typeof(string[,])))[index + 1];
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
                    stringBuilder.Append("------------------------------------------------\r\n");
                    stringBuilder.Append(formSurvey.getAllQuestionText(needAnswerOrNot: GetAnswer));
                    formSurvey.Close();
                }
            }
            FormText formText = new FormText();
            formText.Show(stringBuilder.ToString(), "SurveyText");
        }

        private void listBoxMatrix_DoubleClick(object sender, EventArgs e)
        {
            showToolStripMenuItem_Click(sender, e);
        }

        private void pairWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pairWiseToolStripMenuItem1_Click(sender, e);
        }

        private void scanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            scanToolStripMenuItem_Click(sender, e);
        }

        private void checkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            checkToolStripMenuItem_Click(sender, e);
        }

        private void listBoxMatrix_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripForMatrixList.Show(new Point(this.Location.X + groupBoxMatrix.Location.X
                    + listBoxMatrix.Location.X + e.Location.X + 10,
                    this.Location.Y + groupBoxMatrix.Location.Y
                    + listBoxMatrix.Location.Y + e.Location.Y + 35));
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportHierarchyFromStr(string CSVFileStr)
        {
            //读入成功，先清除当前会话
            treeViewHierarchy.Nodes.Clear();
            ScanLevel(true, false);
            //分隔每行
            string[] lines = CSVFileStr.Split('\n');
            //建立节点数组
            ArrayList nodesInfo = new ArrayList();
            NodeInfo nodeInfotmp;
            string[] lineInfo;  //每行信息
            foreach (string line in lines)
            {
                //读入每行
                lineInfo = line.Split(',');
                if (lineInfo[0].Equals(""))
                {
                    //跳过空行
                    continue;
                }
                if (int.Parse(lineInfo[0]) >= 0)
                {
                    //如果是节点行，将节点加入列表
                    nodeInfotmp = new NodeInfo
                    {
                        ID = int.Parse(lineInfo[0]),
                        ParentID = int.Parse(lineInfo[1]),
                        Text = lineInfo[2]
                    };
                    nodesInfo.Add(nodeInfotmp);
                }
            }

            //开始重建层次结构
            //首层加入
            for (int i = 0; i < nodesInfo.Count; i++)
            {
                if (((NodeInfo)nodesInfo[i]).ID.Equals(((NodeInfo)nodesInfo[i]).ParentID))
                {
                    treeViewHierarchy.Nodes.Add(((NodeInfo)nodesInfo[i]).Text);
                    break;
                }
            }

            //把剩余的东西加入进去
            TreeNode currentFindNode;
            while (getTreeAllNodes().Length < nodesInfo.Count)
            {
                for (int i = 0; i < nodesInfo.Count; i++)
                {
                    if (((NodeInfo)nodesInfo[i]).ID.Equals(((NodeInfo)nodesInfo[i]).ParentID))
                    {
                        //跳过首层节点
                        continue;
                    }

                    currentFindNode = findTreeNodeByText(findPrentName(
                            ((NodeInfo)nodesInfo[i]).ParentID,
                            nodesInfo
                            )
                    );

                    if (currentFindNode != null)
                    {
                        //找到了，加进去
                        currentFindNode.Nodes.Add(((NodeInfo)nodesInfo[i]).Text);
                    }
                }
            }

            //重扫描层次，但不清除数组
            ScanLevel(true, false);

            treeViewHierarchy.ExpandAll();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CSVFileStr;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader file = System.IO.File.OpenText(openFileDialog1.FileName);
                CSVFileStr = file.ReadToEnd();
                file.Close();
                //导入层次结构
                ImportHierarchyFromStr(CSVFileStr);
                //回到顶层
                HierarchyViewGoTop();

                //导入数组
                ImportMatrixFromStr(openFileDialog1.FileName);
            }
        }

        private string findPrentName(int parentID, ArrayList nodesInfo)
        {
            for (int i = 0; i < nodesInfo.Count; i++)
            {
                if (((NodeInfo)nodesInfo[i]).ID == parentID)
                {
                    return ((NodeInfo)nodesInfo[i]).Text;
                }
            }
            return "";  //返回空字符串表示找不到父母，极有可能是顶层节点下的二级元素
        }

        private TreeNode[] getTreeAllNodes()
        {
            ArrayList nodesInAllLayer = new ArrayList();

            //把层次中的每一层扫描出来,并把所有节点放入数组
            TreeNode currentNode;
            Queue<TreeNode> childrenQue = new Queue<TreeNode>();  //孩儿们，快来排队呀~
            PutChildrenIntoQueue(treeViewHierarchy.Nodes, childrenQue);  //第一波父亲进入队列
            nodesInAllLayer.Add(treeViewHierarchy.Nodes[0]);  //首层元素已被加入列表
            while (childrenQue.Count() > 0)  //找儿子，直到没有要找儿子的父亲
            {
                currentNode = childrenQue.Dequeue();  //排头出列
                if (GetNodeChildren(currentNode).Count != 0)
                {
                    //如果有儿子，把儿子加入队列并把儿子们加入数组
                    PutChildrenIntoQueue(GetNodeChildren(currentNode), childrenQue);
                    nodesInAllLayer.Add(currentNode);
                }
                else
                {
                    nodesInAllLayer.Add(currentNode);
                }
            }
            return (TreeNode[])nodesInAllLayer.ToArray(typeof(TreeNode));
        }

        private TreeNode findTreeNodeByText(string text)
        {
            TreeNode[] AllNodes = getTreeAllNodes();

            foreach (TreeNode node in AllNodes)
            {
                if (node.Text.Equals(text))
                {
                    return node;
                }
            }
            return null;
        }

        private void ImportMatrixFromStr(string FileName)
        {
            if (LayerList.Count > 0)
            //如果已经扫描了，有层次结构了
            {
                string CSVFileStr;
                System.IO.StreamReader file = System.IO.File.OpenText(FileName);
                CSVFileStr = file.ReadToEnd();
                file.Close();
                //分隔每行
                string[] lines = CSVFileStr.Split('\n');
                string[] lineInfo;  //每行信息

                foreach (string line in lines)
                {
                    //读入每行
                    lineInfo = line.Split(',');
                    if (lineInfo[0].Equals(""))
                    {
                        //跳过空行
                        continue;
                    }
                    if (int.Parse(lineInfo[0]) < 0)
                    {
                        //如果是矩阵行
                        //新建矩阵
                        string[,] currentMat = new string[int.Parse(lineInfo[2]), int.Parse(lineInfo[2])];
                        for (int i = 3; i < lineInfo.Length; i++)
                        {
                            //从第三个读到末尾
                            currentMat[(i - 3) % currentMat.GetLength(0),
                                (i - 3) / currentMat.GetLength(0)] = lineInfo[i];
                        }

                        for (int i = 1; i < LayerList.Count; i++)
                        {
                            if (((TreeNodeCollection)LayerList[i])[0]
                                .Parent.Text.Equals(lineInfo[1]))
                            {
                                MatrixList[i] = currentMat;
                            }
                        }
                    }
                }
            }
        }

        private string GetExportMatrixString()
        {
            if (LayerList.Count > 0)
            //如果已经扫描了，有层次结构了
            {
                //构建矩阵字符串
                StringBuilder saveStringBuilder = new StringBuilder();
                int MatrixIndex = 1;
                foreach (string[,] matrix in MatrixList)
                {
                    if (matrix != null)
                    {
                        //记录ID和维数
                        saveStringBuilder.Append("-" + MatrixIndex.ToString() + "," + ((TreeNodeCollection)LayerList[MatrixIndex])[0].Parent.Text + "," + matrix.GetLength(0).ToString());
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(0); j++)
                            {
                                saveStringBuilder.Append("," + matrix[i, j]);
                            }
                        }
                        saveStringBuilder.Append("\n");
                        MatrixIndex++;
                    }
                }
                return saveStringBuilder.ToString();
            }
            else
            {
                //如果保存的时候没扫描，返回空字符串
                return "";
            }
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkMarix(ShowResultOrNot: true);
        }

        private bool checkMarix(bool ShowResultOrNot)
        {
            StringBuilder checkResultStr = new StringBuilder();
            StringBuilder MatrixNotOKPrompt = new StringBuilder();
            MatrixOperater matrixOperater = new MatrixOperater();
            ArrayList checkResultList;
            string[,] currentMatrix;
            bool matrixComplete = true;
            bool AllPass = true;
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();  //新建计时停表
            stopwatch.Restart();
            for (int MatrixIndex = 1; MatrixIndex < MatrixList.Count; MatrixIndex++)
            {
                //显示正在检查那个数组
                checkResultStr.Append("Checking " +
                    listBoxMatrix.Items[MatrixIndex - 1].ToString() + "\r\n");
                //将该数组信息输出
                currentMatrix = (string[,])MatrixList[MatrixIndex];
                for (int i = 0; i < currentMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < currentMatrix.GetLength(1); j++)
                    {
                        checkResultStr.Append(currentMatrix[i, j]);
                        //检查是否要插入制表符
                        if (j < currentMatrix.GetLength(1) - 1)
                        {
                            checkResultStr.Append("\t");
                        }
                    }
                    checkResultStr.Append("\r\n");
                }
                //再换一行，准备输出计算结果和判断结果
                checkResultStr.Append("\r\n");

                //检查数组是否已经填写完毕
                if (matrixOperater.IsMatrixHasZero(currentMatrix))
                {
                    checkResultStr.Append("This matrix not complete(Zero detected)!\r\n");
                    matrixComplete = false;
                }
                else
                {
                    //输出计算结果
                    checkResultList = matrixOperater.CheckMatrix(
                            matrixOperater.conventStringMatrixIntoNumberArray(
                                currentMatrix
                            )
                        );
                    checkResultStr.Append("CI = " + checkResultList[0] + " CR = " + checkResultList[1] +
                        " CR < 0.1? " + (((bool)checkResultList[2]) ? "YES" : "NO") + "\r\n");
                    //如果有超限数组，加入提示
                    if ((bool)checkResultList[2] == false)
                    {
                        MatrixNotOKPrompt.Append(listBoxMatrix.Items[MatrixIndex - 1].ToString() + "\r\n");
                    }
                }
                //输出分隔符
                checkResultStr.Append("------------------------------------------------\r\n");
            }

            //检查结束
            stopwatch.Stop();
            checkResultStr.Append("Checking finish in " + stopwatch.Elapsed.TotalMilliseconds.ToString() + "ms.\r\n");
            //输出检查结果
            if (MatrixNotOKPrompt.ToString().Equals("") && matrixComplete)
            {
                //如果没有不OK的矩阵
                checkResultStr.Append("Congratulations, All Matrix pass the test!\r\n");
                AllPass = true;
            }
            else if (matrixComplete)
            {
                checkResultStr.Append("Some matrix given in the following did not pass the test, check and retest.\r\n");
                checkResultStr.Append(MatrixNotOKPrompt.ToString() + "\r\n");
                AllPass = false;
            }
            else
            {
                checkResultStr.Append("Some matrix not complete, check and retest.\r\n");
                AllPass = false;
            }

            if (ShowResultOrNot)
            {
                //显示结果
                FormText formText = new FormText();
                formText.Show(checkResultStr.ToString(), "MatrixCheckResult");
            }

            return AllPass;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void generateResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormText formText = new FormText();
            formText.Show(GenerateReport(), "AHPCalculatingReport");
        }

        private string GenerateReport()
        {
            StringBuilder ReportStr = new StringBuilder();
            string[,] currentMatrix;
            double[] WeightVector;
            MatrixOperater matrixOperater = new MatrixOperater();
            Hashtable AllFactorWeights = new Hashtable();  //存储所有的权重

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();  //新建计时停表
            stopwatch.Restart();

            if (checkMarix(ShowResultOrNot: false) == true)
            {
                ReportStr.Append("Matrix check pass.\r\n\r\n");
                for (int MatrixIndex = 1; MatrixIndex < MatrixList.Count; MatrixIndex++)
                {
                    currentMatrix = (string[,])MatrixList[MatrixIndex];
                    //输出该层因素
                    ReportStr.Append("    "); //左上角表格留空
                    for (int i = 0; i < currentMatrix.GetLength(0); i++)
                    {
                        ReportStr.Append(((TreeNodeCollection)LayerList[MatrixIndex])[i].Text + " ");
                    }
                    //换行
                    ReportStr.Append("\r\n");
                    //输出矩阵权重
                    ReportStr.Append("W" + MatrixIndex.ToString() + " ");
                    WeightVector = matrixOperater.GetEigenvectorOfMatrix(
                            matrixOperater.conventStringMatrixIntoNumberArray(
                                currentMatrix
                            )
                        );
                    for (int i = 0; i < WeightVector.Length; i++)
                    {
                        ReportStr.Append(Math.Round(WeightVector[i], 4).ToString() + " ");
                        AllFactorWeights.Add(((TreeNodeCollection)LayerList[MatrixIndex])[i].Text, WeightVector[i]);  //把得到的权重存起来
                    }
                    //换行
                    ReportStr.Append("\r\n");
                    //输出分隔符
                    ReportStr.Append("------------------------------------------------\r\n");

                }

                //输出层次总排序
                ReportStr.Append("\r\nTotal sorting weights：\r\n");
                Hashtable totalSortingHashtable = GetTotalSortingWeightVector(AllFactorWeights);
                foreach (string factor in totalSortingHashtable.Keys)
                {
                    ReportStr.Append(factor + ": " + totalSortingHashtable[factor].ToString() + "\r\n");
                }

                ReportStr.Append("------------------------------------------------\r\n");
                stopwatch.Stop();
                ReportStr.Append("Checking finish in " + stopwatch.Elapsed.TotalMilliseconds.ToString() + "ms.\r\n");
            }
            else
            {
                ReportStr.Append("Matrix check not pass!");
            }
            return ReportStr.ToString();
        }

        private string[] GetAllAncestorsName(TreeNode treeNode)
        {
            ArrayList arrayList = new ArrayList();
            TreeNode currentParent = treeNode.Parent;
            while (currentParent != null)
            {
                arrayList.Add(currentParent.Text);
                currentParent = currentParent.Parent;
            }
            return (string[])arrayList.ToArray(typeof(string));
        }

        private Hashtable GetTotalSortingWeightVector(Hashtable AllFactorWeights)
        {
            //最终只需要得到方案层的权重，所以应该只找叶子节点
            Hashtable totalSortingHashtable = new Hashtable();
            string[] names;
            double WeightTmp = 1;
            //遍历每个节点
            for (int layerIndex = 0; layerIndex < LayerList.Count; layerIndex++)
            {
                for (int nodeInLayerIndex = 0; nodeInLayerIndex < ((TreeNodeCollection)LayerList[layerIndex]).Count; nodeInLayerIndex++)
                {
                    if (((TreeNodeCollection)LayerList[layerIndex])[nodeInLayerIndex].Nodes.Count == 0)
                    {
                        //这个是叶子节点
                        //找祖宗
                        names = GetAllAncestorsName(((TreeNodeCollection)LayerList[layerIndex])[nodeInLayerIndex]);
                        //权重先为自己本身
                        WeightTmp = (double)AllFactorWeights[((TreeNodeCollection)LayerList[layerIndex])[nodeInLayerIndex].Text];
                        //刨根
                        foreach (string name in names)
                        {
                            try
                            {
                                WeightTmp *= (double)AllFactorWeights[name];
                            }
                            catch (Exception)
                            {
                                if (AllFactorWeights[name] != null)
                                {
                                    throw;
                                }
                            }
                        }
                        //添加加权好的权重
                        totalSortingHashtable.Add(((TreeNodeCollection)LayerList[layerIndex])[nodeInLayerIndex].Text, WeightTmp);
                    }
                    else
                    {
                        //如果一节点的nodes有东西，那它不是叶子节点
                        continue;  //下一个
                    }
                }
            }
            return totalSortingHashtable;
        }

        private void FormAHP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Want to quit? Remember to save your work ^_^", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void quikStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/notonlyming/AHP_Calculator");
        }

        private void checkUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/notonlyming/AHP_Calculator/releases");
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool HierarhrChanged = false;
            if (treeViewHierarchy.Nodes.Count < 1)
            {
                //如果还没根节点
                string rootText = Microsoft.VisualBasic.Interaction.InputBox("Please enter root node text.", "Title needed");
                if (!rootText.Equals(""))
                {
                    treeViewHierarchy.Nodes.Add(rootText);
                    HierarhrChanged = true;
                }
            }
            else
            {
                //如果有了根节点
                if (treeViewHierarchy.SelectedNode != null)
                {
                    //如果选择了要插入的节点
                    string addSubStr = Microsoft.VisualBasic.Interaction.InputBox("You are now insert a node under " + treeViewHierarchy.SelectedNode.Text
                        + ".\nPlease enter sub node text.", "Subject needed");
                    if (!addSubStr.Equals(""))
                    {
                        if (findTreeNodeByText(addSubStr) == null)
                        {
                            treeViewHierarchy.SelectedNode.Nodes.Add(addSubStr);
                            HierarhrChanged = true;
                        }
                        else
                        {
                            MessageBox.Show("Same name node exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0);
                            treeViewHierarchy.SelectedNode = findTreeNodeByText(addSubStr);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a node to insert!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0);
                }
                treeViewHierarchy.SelectedNode = null;  //取消选择

                //如果层次改变，则用户需要重新扫描矩阵
                if (HierarhrChanged && listBoxMatrix.Items.Count > 0)
                {
                    listBoxMatrix.Items.Clear();
                    MatrixList.Clear();
                    LayerList.Clear();
                    MessageBox.Show("Oops, matrix info invalid because hierarchy changed. \n" +
                        "Privious matrix removed, did you save?\nYou need to scan matrix later.", "Prompt",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0);
                }
            }
        }

        private void insertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            insertToolStripMenuItem_Click(sender, e);
        }

        private void delToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            delToolStripMenuItem_Click(sender, e);
        }

        private void treeViewHierarchy_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripForHierarchy.Show(Location.X + groupBoxHierarchy.Location.X + treeViewHierarchy.Location.X + e.X + 10,
                    Location.Y + groupBoxHierarchy.Location.Y + treeViewHierarchy.Location.Y + e.Y + 33);
            }
        }

        private void showVersionChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly assm = Assembly.GetExecutingAssembly();
            Stream istr = assm.GetManifestResourceStream("AHP_Calculator.Resources.changelog.txt");
            StreamReader sr = new StreamReader(istr);
            string str = sr.ReadToEnd();
            (new FormText()).Show(str.Replace("\n", "\r\n"), "ChangeLog");   
        }
    }
}