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
            this.groupBoxHierarchy = new System.Windows.Forms.GroupBox();
            this.treeViewHierarchy = new System.Windows.Forms.TreeView();
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pairWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxHierarchy.SuspendLayout();
            this.groupBoxMatrix.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHierarchy
            // 
            this.groupBoxHierarchy.Controls.Add(this.treeViewHierarchy);
            this.groupBoxHierarchy.Location = new System.Drawing.Point(12, 30);
            this.groupBoxHierarchy.Name = "groupBoxHierarchy";
            this.groupBoxHierarchy.Size = new System.Drawing.Size(294, 453);
            this.groupBoxHierarchy.TabIndex = 7;
            this.groupBoxHierarchy.TabStop = false;
            this.groupBoxHierarchy.Text = "Hierarchy";
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
            this.treeViewHierarchy.Size = new System.Drawing.Size(278, 425);
            this.treeViewHierarchy.TabIndex = 6;
            // 
            // groupBoxMatrix
            // 
            this.groupBoxMatrix.Controls.Add(this.listBox1);
            this.groupBoxMatrix.Location = new System.Drawing.Point(312, 30);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Size = new System.Drawing.Size(273, 453);
            this.groupBoxMatrix.TabIndex = 8;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "Matrix";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(11, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 424);
            this.listBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hireToolStripMenuItem,
            this.matrixToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // hireToolStripMenuItem
            // 
            this.hireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.delToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.hireToolStripMenuItem.Name = "hireToolStripMenuItem";
            this.hireToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.hireToolStripMenuItem.Text = "Hierarchy";
            this.hireToolStripMenuItem.Click += new System.EventHandler(this.hireToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rootToolStripMenuItem,
            this.subToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // rootToolStripMenuItem
            // 
            this.rootToolStripMenuItem.Name = "rootToolStripMenuItem";
            this.rootToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.rootToolStripMenuItem.Text = "Root";
            this.rootToolStripMenuItem.Click += new System.EventHandler(this.rootToolStripMenuItem_Click);
            // 
            // subToolStripMenuItem
            // 
            this.subToolStripMenuItem.Name = "subToolStripMenuItem";
            this.subToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.subToolStripMenuItem.Text = "Sub";
            this.subToolStripMenuItem.Click += new System.EventHandler(this.subToolStripMenuItem_Click);
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.delToolStripMenuItem.Text = "Del";
            this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // matrixToolStripMenuItem
            // 
            this.matrixToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanToolStripMenuItem,
            this.showToolStripMenuItem,
            this.pairWiseToolStripMenuItem,
            this.checkToolStripMenuItem});
            this.matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
            this.matrixToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.matrixToolStripMenuItem.Text = "Matrix";
            // 
            // scanToolStripMenuItem
            // 
            this.scanToolStripMenuItem.Name = "scanToolStripMenuItem";
            this.scanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scanToolStripMenuItem.Text = "Scan";
            this.scanToolStripMenuItem.Click += new System.EventHandler(this.scanToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // pairWiseToolStripMenuItem
            // 
            this.pairWiseToolStripMenuItem.Name = "pairWiseToolStripMenuItem";
            this.pairWiseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pairWiseToolStripMenuItem.Text = "Pair wise";
            this.pairWiseToolStripMenuItem.Click += new System.EventHandler(this.pairWiseToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkToolStripMenuItem.Text = "Check";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // FormAHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(599, 495);
            this.Controls.Add(this.groupBoxMatrix);
            this.Controls.Add(this.groupBoxHierarchy);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormAHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AHP Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxHierarchy.ResumeLayout(false);
            this.groupBoxMatrix.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxHierarchy;
        private System.Windows.Forms.TreeView treeViewHierarchy;
        private System.Windows.Forms.GroupBox groupBoxMatrix;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pairWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

