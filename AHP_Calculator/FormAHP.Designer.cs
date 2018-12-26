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
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("基坑变形失稳");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("基坑突涌");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("基坑坍塌");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("基坑问题", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("维修风险");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("超过使用年限");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("保养不到位");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("盾构", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("防水层失效");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("支撑体系不稳定");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("地面底层裂缝");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("荷载堆积");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("注浆土体位移");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("周围地表变形过大");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("技术", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("自然灾害");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("土质");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("地下空洞");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("水文条件");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("断裂构造面");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("地质", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("周边建筑物");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("地下管线设施");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("周边设施", new System.Windows.Forms.TreeNode[] {
            treeNode48,
            treeNode49});
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("环境", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode47,
            treeNode50});
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("风险", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode51});
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
            this.buttonCheck = new System.Windows.Forms.Button();
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
            treeNode27.Name = "节点5";
            treeNode27.Text = "基坑变形失稳";
            treeNode28.Name = "节点6";
            treeNode28.Text = "基坑突涌";
            treeNode29.Name = "节点12";
            treeNode29.Text = "基坑坍塌";
            treeNode30.Name = "节点3";
            treeNode30.Text = "基坑问题";
            treeNode31.Name = "节点7";
            treeNode31.Text = "维修风险";
            treeNode32.Name = "节点8";
            treeNode32.Text = "超过使用年限";
            treeNode33.Name = "节点18";
            treeNode33.Text = "保养不到位";
            treeNode34.Name = "节点4";
            treeNode34.Text = "盾构";
            treeNode35.Name = "节点13";
            treeNode35.Text = "防水层失效";
            treeNode36.Name = "节点14";
            treeNode36.Text = "支撑体系不稳定";
            treeNode37.Name = "节点15";
            treeNode37.Text = "地面底层裂缝";
            treeNode38.Name = "节点16";
            treeNode38.Text = "荷载堆积";
            treeNode39.Name = "节点17";
            treeNode39.Text = "注浆土体位移";
            treeNode40.Name = "节点19";
            treeNode40.Text = "周围地表变形过大";
            treeNode41.Name = "节点1";
            treeNode41.Text = "技术";
            treeNode42.Name = "节点9";
            treeNode42.Text = "自然灾害";
            treeNode43.Name = "节点20";
            treeNode43.Text = "土质";
            treeNode44.Name = "节点21";
            treeNode44.Text = "地下空洞";
            treeNode45.Name = "节点22";
            treeNode45.Text = "水文条件";
            treeNode46.Name = "节点23";
            treeNode46.Text = "断裂构造面";
            treeNode47.Name = "节点10";
            treeNode47.Text = "地质";
            treeNode48.Name = "节点24";
            treeNode48.Text = "周边建筑物";
            treeNode49.Name = "节点25";
            treeNode49.Text = "地下管线设施";
            treeNode50.Name = "节点11";
            treeNode50.Text = "周边设施";
            treeNode51.Name = "节点2";
            treeNode51.Text = "环境";
            treeNode52.Name = "节点0";
            treeNode52.Text = "风险";
            this.treeViewHierarchy.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode52});
            this.treeViewHierarchy.Size = new System.Drawing.Size(278, 363);
            this.treeViewHierarchy.TabIndex = 6;
            // 
            // groupBoxMatrix
            // 
            this.groupBoxMatrix.Controls.Add(this.buttonCheck);
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
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCheck.Location = new System.Drawing.Point(27, 393);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(68, 32);
            this.buttonCheck.TabIndex = 13;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            // 
            // FormAHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(599, 494);
            this.Controls.Add(this.groupBoxMatrix);
            this.Controls.Add(this.groupBoxHierarchy);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button buttonCheck;
    }
}

