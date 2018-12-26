namespace AHP_Calculator
{
    partial class FormAHP
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("基坑变形失稳");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("基坑突涌");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("基坑坍塌");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("基坑问题", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("维修风险");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("超过使用年限");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("保养不到位");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("盾构", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("防水层失效");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("支撑体系不稳定");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("地面底层裂缝");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("荷载堆积");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("注浆土体位移");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("周围地表变形过大");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("技术", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("自然灾害");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("土质");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("地下空洞");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("水文条件");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("断裂构造面");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("地质", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("周边建筑物");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("地下管线设施");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("周边设施", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("环境", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode21,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("风险", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode25});
            this.buttonShowMatrix = new System.Windows.Forms.Button();
            this.groupBoxHierarchy = new System.Windows.Forms.GroupBox();
            this.buttonClearNode = new System.Windows.Forms.Button();
            this.buttonDelNode = new System.Windows.Forms.Button();
            this.buttonAddSub = new System.Windows.Forms.Button();
            this.buttonAddRoot = new System.Windows.Forms.Button();
            this.treeViewHierarchy = new System.Windows.Forms.TreeView();
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.buttonPairWise = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxHierarchy.SuspendLayout();
            this.groupBoxMatrix.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowMatrix
            // 
            this.buttonShowMatrix.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonShowMatrix.Location = new System.Drawing.Point(164, 431);
            this.buttonShowMatrix.Name = "buttonShowMatrix";
            this.buttonShowMatrix.Size = new System.Drawing.Size(68, 32);
            this.buttonShowMatrix.TabIndex = 6;
            this.buttonShowMatrix.Text = "Show";
            this.buttonShowMatrix.UseVisualStyleBackColor = true;
            this.buttonShowMatrix.Click += new System.EventHandler(this.buttonCreateMatrix_Click);
            // 
            // groupBoxHierarchy
            // 
            this.groupBoxHierarchy.Controls.Add(this.buttonClearNode);
            this.groupBoxHierarchy.Controls.Add(this.buttonDelNode);
            this.groupBoxHierarchy.Controls.Add(this.buttonAddSub);
            this.groupBoxHierarchy.Controls.Add(this.buttonAddRoot);
            this.groupBoxHierarchy.Controls.Add(this.treeViewHierarchy);
            this.groupBoxHierarchy.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHierarchy.Name = "groupBoxHierarchy";
            this.groupBoxHierarchy.Size = new System.Drawing.Size(294, 473);
            this.groupBoxHierarchy.TabIndex = 7;
            this.groupBoxHierarchy.TabStop = false;
            this.groupBoxHierarchy.Text = "Hierarchy";
            // 
            // buttonClearNode
            // 
            this.buttonClearNode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClearNode.Location = new System.Drawing.Point(185, 431);
            this.buttonClearNode.Name = "buttonClearNode";
            this.buttonClearNode.Size = new System.Drawing.Size(60, 32);
            this.buttonClearNode.TabIndex = 10;
            this.buttonClearNode.Text = "Clear";
            this.buttonClearNode.UseVisualStyleBackColor = true;
            this.buttonClearNode.Click += new System.EventHandler(this.buttonClearNode_Click);
            // 
            // buttonDelNode
            // 
            this.buttonDelNode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDelNode.Location = new System.Drawing.Point(185, 389);
            this.buttonDelNode.Name = "buttonDelNode";
            this.buttonDelNode.Size = new System.Drawing.Size(60, 32);
            this.buttonDelNode.TabIndex = 9;
            this.buttonDelNode.Text = "Del";
            this.buttonDelNode.UseVisualStyleBackColor = true;
            this.buttonDelNode.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAddSub
            // 
            this.buttonAddSub.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAddSub.Location = new System.Drawing.Point(45, 431);
            this.buttonAddSub.Name = "buttonAddSub";
            this.buttonAddSub.Size = new System.Drawing.Size(93, 32);
            this.buttonAddSub.TabIndex = 8;
            this.buttonAddSub.Text = "Add sub";
            this.buttonAddSub.UseVisualStyleBackColor = true;
            this.buttonAddSub.Click += new System.EventHandler(this.buttonAddSub_Click);
            // 
            // buttonAddRoot
            // 
            this.buttonAddRoot.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAddRoot.Location = new System.Drawing.Point(45, 389);
            this.buttonAddRoot.Name = "buttonAddRoot";
            this.buttonAddRoot.Size = new System.Drawing.Size(93, 32);
            this.buttonAddRoot.TabIndex = 7;
            this.buttonAddRoot.Text = "Add root";
            this.buttonAddRoot.UseVisualStyleBackColor = true;
            this.buttonAddRoot.Click += new System.EventHandler(this.buttonAddRoot_Click);
            // 
            // treeViewHierarchy
            // 
            this.treeViewHierarchy.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewHierarchy.Location = new System.Drawing.Point(9, 19);
            this.treeViewHierarchy.Name = "treeViewHierarchy";
            treeNode1.Name = "节点5";
            treeNode1.Text = "基坑变形失稳";
            treeNode2.Name = "节点6";
            treeNode2.Text = "基坑突涌";
            treeNode3.Name = "节点12";
            treeNode3.Text = "基坑坍塌";
            treeNode4.Name = "节点3";
            treeNode4.Text = "基坑问题";
            treeNode5.Name = "节点7";
            treeNode5.Text = "维修风险";
            treeNode6.Name = "节点8";
            treeNode6.Text = "超过使用年限";
            treeNode7.Name = "节点18";
            treeNode7.Text = "保养不到位";
            treeNode8.Name = "节点4";
            treeNode8.Text = "盾构";
            treeNode9.Name = "节点13";
            treeNode9.Text = "防水层失效";
            treeNode10.Name = "节点14";
            treeNode10.Text = "支撑体系不稳定";
            treeNode11.Name = "节点15";
            treeNode11.Text = "地面底层裂缝";
            treeNode12.Name = "节点16";
            treeNode12.Text = "荷载堆积";
            treeNode13.Name = "节点17";
            treeNode13.Text = "注浆土体位移";
            treeNode14.Name = "节点19";
            treeNode14.Text = "周围地表变形过大";
            treeNode15.Name = "节点1";
            treeNode15.Text = "技术";
            treeNode16.Name = "节点9";
            treeNode16.Text = "自然灾害";
            treeNode17.Name = "节点20";
            treeNode17.Text = "土质";
            treeNode18.Name = "节点21";
            treeNode18.Text = "地下空洞";
            treeNode19.Name = "节点22";
            treeNode19.Text = "水文条件";
            treeNode20.Name = "节点23";
            treeNode20.Text = "断裂构造面";
            treeNode21.Name = "节点10";
            treeNode21.Text = "地质";
            treeNode22.Name = "节点24";
            treeNode22.Text = "周边建筑物";
            treeNode23.Name = "节点25";
            treeNode23.Text = "地下管线设施";
            treeNode24.Name = "节点11";
            treeNode24.Text = "周边设施";
            treeNode25.Name = "节点2";
            treeNode25.Text = "环境";
            treeNode26.Name = "节点0";
            treeNode26.Text = "风险";
            this.treeViewHierarchy.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26});
            this.treeViewHierarchy.Size = new System.Drawing.Size(278, 363);
            this.treeViewHierarchy.TabIndex = 6;
            // 
            // groupBoxMatrix
            // 
            this.groupBoxMatrix.Controls.Add(this.buttonScan);
            this.groupBoxMatrix.Controls.Add(this.buttonPairWise);
            this.groupBoxMatrix.Controls.Add(this.listBox1);
            this.groupBoxMatrix.Controls.Add(this.buttonShowMatrix);
            this.groupBoxMatrix.Location = new System.Drawing.Point(312, 12);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Size = new System.Drawing.Size(273, 473);
            this.groupBoxMatrix.TabIndex = 8;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "Matrix";
            // 
            // buttonScan
            // 
            this.buttonScan.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonScan.Location = new System.Drawing.Point(164, 393);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(68, 32);
            this.buttonScan.TabIndex = 12;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // buttonPairWise
            // 
            this.buttonPairWise.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPairWise.Location = new System.Drawing.Point(27, 431);
            this.buttonPairWise.Name = "buttonPairWise";
            this.buttonPairWise.Size = new System.Drawing.Size(113, 32);
            this.buttonPairWise.TabIndex = 11;
            this.buttonPairWise.Text = "Pair wise...";
            this.buttonPairWise.UseVisualStyleBackColor = true;
            this.buttonPairWise.Click += new System.EventHandler(this.buttonPairWise_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(11, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 361);
            this.listBox1.TabIndex = 0;
            // 
            // FormAHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(739, 494);
            this.Controls.Add(this.groupBoxMatrix);
            this.Controls.Add(this.groupBoxHierarchy);
            this.Name = "FormAHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AHP Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxHierarchy.ResumeLayout(false);
            this.groupBoxMatrix.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowMatrix;
        private System.Windows.Forms.GroupBox groupBoxHierarchy;
        private System.Windows.Forms.Button buttonClearNode;
        private System.Windows.Forms.Button buttonDelNode;
        private System.Windows.Forms.Button buttonAddSub;
        private System.Windows.Forms.Button buttonAddRoot;
        private System.Windows.Forms.TreeView treeViewHierarchy;
        private System.Windows.Forms.GroupBox groupBoxMatrix;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonPairWise;
        private System.Windows.Forms.Button buttonScan;
    }
}

