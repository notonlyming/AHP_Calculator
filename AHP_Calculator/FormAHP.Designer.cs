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
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("基坑变形失稳");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("基坑突涌");
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("基坑坍塌");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("基坑问题", new System.Windows.Forms.TreeNode[] {
            treeNode53,
            treeNode54,
            treeNode55});
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("维修风险");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("超过使用年限");
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("保养不到位");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("盾构", new System.Windows.Forms.TreeNode[] {
            treeNode57,
            treeNode58,
            treeNode59});
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("防水层失效");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("支撑体系不稳定");
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("地面底层裂缝");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("荷载堆积");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("注浆土体位移");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("周围地表变形过大");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("技术", new System.Windows.Forms.TreeNode[] {
            treeNode56,
            treeNode60,
            treeNode61,
            treeNode62,
            treeNode63,
            treeNode64,
            treeNode65,
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("自然灾害");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("土质");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("地下空洞");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("水文条件");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("断裂构造面");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("地质", new System.Windows.Forms.TreeNode[] {
            treeNode69,
            treeNode70,
            treeNode71,
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("周边建筑物");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("地下管线设施");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("周边设施", new System.Windows.Forms.TreeNode[] {
            treeNode74,
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("环境", new System.Windows.Forms.TreeNode[] {
            treeNode68,
            treeNode73,
            treeNode76});
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("风险", new System.Windows.Forms.TreeNode[] {
            treeNode67,
            treeNode77});
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
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            treeNode53.Name = "节点5";
            treeNode53.Text = "基坑变形失稳";
            treeNode54.Name = "节点6";
            treeNode54.Text = "基坑突涌";
            treeNode55.Name = "节点12";
            treeNode55.Text = "基坑坍塌";
            treeNode56.Name = "节点3";
            treeNode56.Text = "基坑问题";
            treeNode57.Name = "节点7";
            treeNode57.Text = "维修风险";
            treeNode58.Name = "节点8";
            treeNode58.Text = "超过使用年限";
            treeNode59.Name = "节点18";
            treeNode59.Text = "保养不到位";
            treeNode60.Name = "节点4";
            treeNode60.Text = "盾构";
            treeNode61.Name = "节点13";
            treeNode61.Text = "防水层失效";
            treeNode62.Name = "节点14";
            treeNode62.Text = "支撑体系不稳定";
            treeNode63.Name = "节点15";
            treeNode63.Text = "地面底层裂缝";
            treeNode64.Name = "节点16";
            treeNode64.Text = "荷载堆积";
            treeNode65.Name = "节点17";
            treeNode65.Text = "注浆土体位移";
            treeNode66.Name = "节点19";
            treeNode66.Text = "周围地表变形过大";
            treeNode67.Name = "节点1";
            treeNode67.Text = "技术";
            treeNode68.Name = "节点9";
            treeNode68.Text = "自然灾害";
            treeNode69.Name = "节点20";
            treeNode69.Text = "土质";
            treeNode70.Name = "节点21";
            treeNode70.Text = "地下空洞";
            treeNode71.Name = "节点22";
            treeNode71.Text = "水文条件";
            treeNode72.Name = "节点23";
            treeNode72.Text = "断裂构造面";
            treeNode73.Name = "节点10";
            treeNode73.Text = "地质";
            treeNode74.Name = "节点24";
            treeNode74.Text = "周边建筑物";
            treeNode75.Name = "节点25";
            treeNode75.Text = "地下管线设施";
            treeNode76.Name = "节点11";
            treeNode76.Text = "周边设施";
            treeNode77.Name = "节点2";
            treeNode77.Text = "环境";
            treeNode78.Name = "节点0";
            treeNode78.Text = "风险";
            this.treeViewHierarchy.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode78});
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
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
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
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
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
            this.subToolStripMenuItem,
            this.rootToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.checkToolStripMenuItem,
            this.importToolStripMenuItem,
            this.outPortToolStripMenuItem});
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
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkToolStripMenuItem.Text = "Check";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.checkToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // outPortToolStripMenuItem
            // 
            this.outPortToolStripMenuItem.Name = "outPortToolStripMenuItem";
            this.outPortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.outPortToolStripMenuItem.Text = "OutPort";
            this.outPortToolStripMenuItem.Click += new System.EventHandler(this.outPortToolStripMenuItem_Click);
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
            this.pairWiseToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pairWiseToolStripMenuItem.Text = "Pair wise";
            this.pairWiseToolStripMenuItem.Click += new System.EventHandler(this.pairWiseToolStripMenuItem_Click);
            // 
            // scanToolStripMenuItem1
            // 
            this.scanToolStripMenuItem1.Name = "scanToolStripMenuItem1";
            this.scanToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.scanToolStripMenuItem1.Text = "Scan";
            this.scanToolStripMenuItem1.Click += new System.EventHandler(this.scanToolStripMenuItem1_Click);
            // 
            // checkToolStripMenuItem1
            // 
            this.checkToolStripMenuItem1.Name = "checkToolStripMenuItem1";
            this.checkToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.checkToolStripMenuItem1.Text = "Check";
            this.checkToolStripMenuItem1.Click += new System.EventHandler(this.checkToolStripMenuItem1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "csv 逗号分隔符文件|*.csv|所有文件|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outPortToolStripMenuItem;
    }
}

