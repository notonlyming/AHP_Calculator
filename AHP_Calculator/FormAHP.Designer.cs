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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode131 = new System.Windows.Forms.TreeNode("基坑变形失稳");
            System.Windows.Forms.TreeNode treeNode132 = new System.Windows.Forms.TreeNode("基坑突涌");
            System.Windows.Forms.TreeNode treeNode133 = new System.Windows.Forms.TreeNode("基坑坍塌");
            System.Windows.Forms.TreeNode treeNode134 = new System.Windows.Forms.TreeNode("基坑问题", new System.Windows.Forms.TreeNode[] {
            treeNode131,
            treeNode132,
            treeNode133});
            System.Windows.Forms.TreeNode treeNode135 = new System.Windows.Forms.TreeNode("维修风险");
            System.Windows.Forms.TreeNode treeNode136 = new System.Windows.Forms.TreeNode("超过使用年限");
            System.Windows.Forms.TreeNode treeNode137 = new System.Windows.Forms.TreeNode("保养不到位");
            System.Windows.Forms.TreeNode treeNode138 = new System.Windows.Forms.TreeNode("盾构", new System.Windows.Forms.TreeNode[] {
            treeNode135,
            treeNode136,
            treeNode137});
            System.Windows.Forms.TreeNode treeNode139 = new System.Windows.Forms.TreeNode("防水层失效");
            System.Windows.Forms.TreeNode treeNode140 = new System.Windows.Forms.TreeNode("支撑体系不稳定");
            System.Windows.Forms.TreeNode treeNode141 = new System.Windows.Forms.TreeNode("地面底层裂缝");
            System.Windows.Forms.TreeNode treeNode142 = new System.Windows.Forms.TreeNode("荷载堆积");
            System.Windows.Forms.TreeNode treeNode143 = new System.Windows.Forms.TreeNode("注浆土体位移");
            System.Windows.Forms.TreeNode treeNode144 = new System.Windows.Forms.TreeNode("周围地表变形过大");
            System.Windows.Forms.TreeNode treeNode145 = new System.Windows.Forms.TreeNode("技术", new System.Windows.Forms.TreeNode[] {
            treeNode134,
            treeNode138,
            treeNode139,
            treeNode140,
            treeNode141,
            treeNode142,
            treeNode143,
            treeNode144});
            System.Windows.Forms.TreeNode treeNode146 = new System.Windows.Forms.TreeNode("自然灾害");
            System.Windows.Forms.TreeNode treeNode147 = new System.Windows.Forms.TreeNode("土质");
            System.Windows.Forms.TreeNode treeNode148 = new System.Windows.Forms.TreeNode("地下空洞");
            System.Windows.Forms.TreeNode treeNode149 = new System.Windows.Forms.TreeNode("水文条件");
            System.Windows.Forms.TreeNode treeNode150 = new System.Windows.Forms.TreeNode("断裂构造面");
            System.Windows.Forms.TreeNode treeNode151 = new System.Windows.Forms.TreeNode("地质", new System.Windows.Forms.TreeNode[] {
            treeNode147,
            treeNode148,
            treeNode149,
            treeNode150});
            System.Windows.Forms.TreeNode treeNode152 = new System.Windows.Forms.TreeNode("周边建筑物");
            System.Windows.Forms.TreeNode treeNode153 = new System.Windows.Forms.TreeNode("地下管线设施");
            System.Windows.Forms.TreeNode treeNode154 = new System.Windows.Forms.TreeNode("周边设施", new System.Windows.Forms.TreeNode[] {
            treeNode152,
            treeNode153});
            System.Windows.Forms.TreeNode treeNode155 = new System.Windows.Forms.TreeNode("环境", new System.Windows.Forms.TreeNode[] {
            treeNode146,
            treeNode151,
            treeNode154});
            System.Windows.Forms.TreeNode treeNode156 = new System.Windows.Forms.TreeNode("风险", new System.Windows.Forms.TreeNode[] {
            treeNode145,
            treeNode155});
            this.groupBoxHierarchy = new System.Windows.Forms.GroupBox();
            this.treeViewHierarchy = new System.Windows.Forms.TreeView();
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.listBoxMatrix = new System.Windows.Forms.ListBox();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
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
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pairWiseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripForMatrixList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pairWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxHierarchy.SuspendLayout();
            this.groupBoxMatrix.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripForMatrixList.SuspendLayout();
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
            treeNode131.Name = "节点5";
            treeNode131.Text = "基坑变形失稳";
            treeNode132.Name = "节点6";
            treeNode132.Text = "基坑突涌";
            treeNode133.Name = "节点12";
            treeNode133.Text = "基坑坍塌";
            treeNode134.Name = "节点3";
            treeNode134.Text = "基坑问题";
            treeNode135.Name = "节点7";
            treeNode135.Text = "维修风险";
            treeNode136.Name = "节点8";
            treeNode136.Text = "超过使用年限";
            treeNode137.Name = "节点18";
            treeNode137.Text = "保养不到位";
            treeNode138.Name = "节点4";
            treeNode138.Text = "盾构";
            treeNode139.Name = "节点13";
            treeNode139.Text = "防水层失效";
            treeNode140.Name = "节点14";
            treeNode140.Text = "支撑体系不稳定";
            treeNode141.Name = "节点15";
            treeNode141.Text = "地面底层裂缝";
            treeNode142.Name = "节点16";
            treeNode142.Text = "荷载堆积";
            treeNode143.Name = "节点17";
            treeNode143.Text = "注浆土体位移";
            treeNode144.Name = "节点19";
            treeNode144.Text = "周围地表变形过大";
            treeNode145.Name = "节点1";
            treeNode145.Text = "技术";
            treeNode146.Name = "节点9";
            treeNode146.Text = "自然灾害";
            treeNode147.Name = "节点20";
            treeNode147.Text = "土质";
            treeNode148.Name = "节点21";
            treeNode148.Text = "地下空洞";
            treeNode149.Name = "节点22";
            treeNode149.Text = "水文条件";
            treeNode150.Name = "节点23";
            treeNode150.Text = "断裂构造面";
            treeNode151.Name = "节点10";
            treeNode151.Text = "地质";
            treeNode152.Name = "节点24";
            treeNode152.Text = "周边建筑物";
            treeNode153.Name = "节点25";
            treeNode153.Text = "地下管线设施";
            treeNode154.Name = "节点11";
            treeNode154.Text = "周边设施";
            treeNode155.Name = "节点2";
            treeNode155.Text = "环境";
            treeNode156.Name = "节点0";
            treeNode156.Text = "风险";
            this.treeViewHierarchy.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode156});
            this.treeViewHierarchy.Size = new System.Drawing.Size(278, 425);
            this.treeViewHierarchy.TabIndex = 6;
            // 
            // groupBoxMatrix
            // 
            this.groupBoxMatrix.Controls.Add(this.listBoxMatrix);
            this.groupBoxMatrix.Location = new System.Drawing.Point(312, 30);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Size = new System.Drawing.Size(273, 453);
            this.groupBoxMatrix.TabIndex = 8;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "Matrix";
            // 
            // listBoxMatrix
            // 
            this.listBoxMatrix.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBoxMatrix.FormattingEnabled = true;
            this.listBoxMatrix.ItemHeight = 21;
            this.listBoxMatrix.Location = new System.Drawing.Point(11, 20);
            this.listBoxMatrix.Name = "listBoxMatrix";
            this.listBoxMatrix.Size = new System.Drawing.Size(254, 424);
            this.listBoxMatrix.TabIndex = 0;
            this.listBoxMatrix.DoubleClick += new System.EventHandler(this.listBoxMatrix_DoubleClick);
            this.listBoxMatrix.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxMatrix_MouseDown);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hireToolStripMenuItem,
            this.matrixToolStripMenuItem,
            this.surveyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(599, 25);
            this.menuStripMain.TabIndex = 9;
            this.menuStripMain.Text = "menuStrip1";
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
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
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
            this.checkToolStripMenuItem});
            this.matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
            this.matrixToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.matrixToolStripMenuItem.Text = "Matrix";
            // 
            // scanToolStripMenuItem
            // 
            this.scanToolStripMenuItem.Name = "scanToolStripMenuItem";
            this.scanToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.scanToolStripMenuItem.Text = "Scan";
            this.scanToolStripMenuItem.Click += new System.EventHandler(this.scanToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.checkToolStripMenuItem.Text = "Check";
            // 
            // surveyToolStripMenuItem
            // 
            this.surveyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pairWiseToolStripMenuItem1,
            this.exportTextToolStripMenuItem});
            this.surveyToolStripMenuItem.Name = "surveyToolStripMenuItem";
            this.surveyToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.surveyToolStripMenuItem.Text = "Survey";
            // 
            // pairWiseToolStripMenuItem1
            // 
            this.pairWiseToolStripMenuItem1.Name = "pairWiseToolStripMenuItem1";
            this.pairWiseToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.pairWiseToolStripMenuItem1.Text = "Pair wise";
            this.pairWiseToolStripMenuItem1.Click += new System.EventHandler(this.pairWiseToolStripMenuItem1_Click);
            // 
            // exportTextToolStripMenuItem
            // 
            this.exportTextToolStripMenuItem.Name = "exportTextToolStripMenuItem";
            this.exportTextToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exportTextToolStripMenuItem.Text = "Export text";
            this.exportTextToolStripMenuItem.Click += new System.EventHandler(this.exportTextToolStripMenuItem_Click);
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
            // contextMenuStripForMatrixList
            // 
            this.contextMenuStripForMatrixList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pairWiseToolStripMenuItem,
            this.scanToolStripMenuItem1,
            this.checkToolStripMenuItem1});
            this.contextMenuStripForMatrixList.Name = "contextMenuStrip1";
            this.contextMenuStripForMatrixList.Size = new System.Drawing.Size(128, 70);
            // 
            // pairWiseToolStripMenuItem
            // 
            this.pairWiseToolStripMenuItem.Name = "pairWiseToolStripMenuItem";
            this.pairWiseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pairWiseToolStripMenuItem.Text = "Pair wise";
            this.pairWiseToolStripMenuItem.Click += new System.EventHandler(this.pairWiseToolStripMenuItem_Click);
            // 
            // scanToolStripMenuItem1
            // 
            this.scanToolStripMenuItem1.Name = "scanToolStripMenuItem1";
            this.scanToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.scanToolStripMenuItem1.Text = "Scan";
            this.scanToolStripMenuItem1.Click += new System.EventHandler(this.scanToolStripMenuItem1_Click);
            // 
            // checkToolStripMenuItem1
            // 
            this.checkToolStripMenuItem1.Name = "checkToolStripMenuItem1";
            this.checkToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.checkToolStripMenuItem1.Text = "Check";
            this.checkToolStripMenuItem1.Click += new System.EventHandler(this.checkToolStripMenuItem1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "csv 逗号分隔符文件|*.csv|所有文件|*.*";
            // 
            // FormAHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(599, 495);
            this.Controls.Add(this.groupBoxMatrix);
            this.Controls.Add(this.groupBoxHierarchy);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "FormAHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AHP Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxHierarchy.ResumeLayout(false);
            this.groupBoxMatrix.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripForMatrixList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxHierarchy;
        private System.Windows.Forms.TreeView treeViewHierarchy;
        private System.Windows.Forms.GroupBox groupBoxMatrix;
        private System.Windows.Forms.ListBox listBoxMatrix;
        private System.Windows.Forms.MenuStrip menuStripMain;
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
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForMatrixList;
        private System.Windows.Forms.ToolStripMenuItem surveyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pairWiseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pairWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

