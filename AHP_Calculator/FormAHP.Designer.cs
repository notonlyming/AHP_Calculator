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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAHP));
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
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pairWiseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quikStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showVersionChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripForMatrixList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pairWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStripForHierarchy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.insertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.delToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxHierarchy.SuspendLayout();
            this.groupBoxMatrix.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripForMatrixList.SuspendLayout();
            this.contextMenuStripForHierarchy.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxHierarchy
            // 
            resources.ApplyResources(this.groupBoxHierarchy, "groupBoxHierarchy");
            this.groupBoxHierarchy.Controls.Add(this.treeViewHierarchy);
            this.groupBoxHierarchy.Name = "groupBoxHierarchy";
            this.groupBoxHierarchy.TabStop = false;
            // 
            // treeViewHierarchy
            // 
            resources.ApplyResources(this.treeViewHierarchy, "treeViewHierarchy");
            this.treeViewHierarchy.Name = "treeViewHierarchy";
            this.treeViewHierarchy.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("treeViewHierarchy.Nodes")))});
            this.treeViewHierarchy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewHierarchy_MouseDown);
            // 
            // groupBoxMatrix
            // 
            resources.ApplyResources(this.groupBoxMatrix, "groupBoxMatrix");
            this.groupBoxMatrix.Controls.Add(this.listBoxMatrix);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.TabStop = false;
            // 
            // listBoxMatrix
            // 
            resources.ApplyResources(this.listBoxMatrix, "listBoxMatrix");
            this.listBoxMatrix.FormattingEnabled = true;
            this.listBoxMatrix.Name = "listBoxMatrix";
            this.listBoxMatrix.DoubleClick += new System.EventHandler(this.listBoxMatrix_DoubleClick);
            this.listBoxMatrix.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxMatrix_MouseDown);
            // 
            // menuStripMain
            // 
            resources.ApplyResources(this.menuStripMain, "menuStripMain");
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hireToolStripMenuItem,
            this.matrixToolStripMenuItem,
            this.OperateToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Name = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // hireToolStripMenuItem
            // 
            resources.ApplyResources(this.hireToolStripMenuItem, "hireToolStripMenuItem");
            this.hireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem,
            this.delToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.hireToolStripMenuItem.Name = "hireToolStripMenuItem";
            // 
            // insertToolStripMenuItem
            // 
            resources.ApplyResources(this.insertToolStripMenuItem, "insertToolStripMenuItem");
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // delToolStripMenuItem
            // 
            resources.ApplyResources(this.delToolStripMenuItem, "delToolStripMenuItem");
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            resources.ApplyResources(this.clearToolStripMenuItem, "clearToolStripMenuItem");
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // matrixToolStripMenuItem
            // 
            resources.ApplyResources(this.matrixToolStripMenuItem, "matrixToolStripMenuItem");
            this.matrixToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanToolStripMenuItem,
            this.showToolStripMenuItem,
            this.checkToolStripMenuItem});
            this.matrixToolStripMenuItem.Name = "matrixToolStripMenuItem";
            // 
            // scanToolStripMenuItem
            // 
            resources.ApplyResources(this.scanToolStripMenuItem, "scanToolStripMenuItem");
            this.scanToolStripMenuItem.Name = "scanToolStripMenuItem";
            this.scanToolStripMenuItem.Click += new System.EventHandler(this.scanToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            resources.ApplyResources(this.showToolStripMenuItem, "showToolStripMenuItem");
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            resources.ApplyResources(this.checkToolStripMenuItem, "checkToolStripMenuItem");
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.checkToolStripMenuItem_Click);
            // 
            // OperateToolStripMenuItem
            // 
            resources.ApplyResources(this.OperateToolStripMenuItem, "OperateToolStripMenuItem");
            this.OperateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pairWiseToolStripMenuItem1,
            this.exportTextToolStripMenuItem,
            this.generateResultToolStripMenuItem});
            this.OperateToolStripMenuItem.Name = "OperateToolStripMenuItem";
            // 
            // pairWiseToolStripMenuItem1
            // 
            resources.ApplyResources(this.pairWiseToolStripMenuItem1, "pairWiseToolStripMenuItem1");
            this.pairWiseToolStripMenuItem1.Name = "pairWiseToolStripMenuItem1";
            this.pairWiseToolStripMenuItem1.Click += new System.EventHandler(this.pairWiseToolStripMenuItem1_Click);
            // 
            // exportTextToolStripMenuItem
            // 
            resources.ApplyResources(this.exportTextToolStripMenuItem, "exportTextToolStripMenuItem");
            this.exportTextToolStripMenuItem.Name = "exportTextToolStripMenuItem";
            this.exportTextToolStripMenuItem.Click += new System.EventHandler(this.exportTextToolStripMenuItem_Click);
            // 
            // generateResultToolStripMenuItem
            // 
            resources.ApplyResources(this.generateResultToolStripMenuItem, "generateResultToolStripMenuItem");
            this.generateResultToolStripMenuItem.Name = "generateResultToolStripMenuItem";
            this.generateResultToolStripMenuItem.Click += new System.EventHandler(this.generateResultToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quikStartToolStripMenuItem,
            this.checkUpdateToolStripMenuItem,
            this.showVersionChangeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // quikStartToolStripMenuItem
            // 
            resources.ApplyResources(this.quikStartToolStripMenuItem, "quikStartToolStripMenuItem");
            this.quikStartToolStripMenuItem.Name = "quikStartToolStripMenuItem";
            this.quikStartToolStripMenuItem.Click += new System.EventHandler(this.quikStartToolStripMenuItem_Click);
            // 
            // checkUpdateToolStripMenuItem
            // 
            resources.ApplyResources(this.checkUpdateToolStripMenuItem, "checkUpdateToolStripMenuItem");
            this.checkUpdateToolStripMenuItem.Name = "checkUpdateToolStripMenuItem";
            this.checkUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkUpdateToolStripMenuItem_Click);
            // 
            // showVersionChangeToolStripMenuItem
            // 
            resources.ApplyResources(this.showVersionChangeToolStripMenuItem, "showVersionChangeToolStripMenuItem");
            this.showVersionChangeToolStripMenuItem.Name = "showVersionChangeToolStripMenuItem";
            this.showVersionChangeToolStripMenuItem.Click += new System.EventHandler(this.showVersionChangeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contextMenuStripForMatrixList
            // 
            resources.ApplyResources(this.contextMenuStripForMatrixList, "contextMenuStripForMatrixList");
            this.contextMenuStripForMatrixList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pairWiseToolStripMenuItem,
            this.scanToolStripMenuItem1,
            this.checkToolStripMenuItem1});
            this.contextMenuStripForMatrixList.Name = "contextMenuStrip1";
            // 
            // pairWiseToolStripMenuItem
            // 
            resources.ApplyResources(this.pairWiseToolStripMenuItem, "pairWiseToolStripMenuItem");
            this.pairWiseToolStripMenuItem.Name = "pairWiseToolStripMenuItem";
            this.pairWiseToolStripMenuItem.Click += new System.EventHandler(this.pairWiseToolStripMenuItem_Click);
            // 
            // scanToolStripMenuItem1
            // 
            resources.ApplyResources(this.scanToolStripMenuItem1, "scanToolStripMenuItem1");
            this.scanToolStripMenuItem1.Name = "scanToolStripMenuItem1";
            this.scanToolStripMenuItem1.Click += new System.EventHandler(this.scanToolStripMenuItem1_Click);
            // 
            // checkToolStripMenuItem1
            // 
            resources.ApplyResources(this.checkToolStripMenuItem1, "checkToolStripMenuItem1");
            this.checkToolStripMenuItem1.Name = "checkToolStripMenuItem1";
            this.checkToolStripMenuItem1.Click += new System.EventHandler(this.checkToolStripMenuItem1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // contextMenuStripForHierarchy
            // 
            resources.ApplyResources(this.contextMenuStripForHierarchy, "contextMenuStripForHierarchy");
            this.contextMenuStripForHierarchy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem1,
            this.delToolStripMenuItem1});
            this.contextMenuStripForHierarchy.Name = "contextMenuStripForHierarchy";
            // 
            // insertToolStripMenuItem1
            // 
            resources.ApplyResources(this.insertToolStripMenuItem1, "insertToolStripMenuItem1");
            this.insertToolStripMenuItem1.Name = "insertToolStripMenuItem1";
            this.insertToolStripMenuItem1.Click += new System.EventHandler(this.insertToolStripMenuItem1_Click);
            // 
            // delToolStripMenuItem1
            // 
            resources.ApplyResources(this.delToolStripMenuItem1, "delToolStripMenuItem1");
            this.delToolStripMenuItem1.Name = "delToolStripMenuItem1";
            this.delToolStripMenuItem1.Click += new System.EventHandler(this.delToolStripMenuItem1_Click);
            // 
            // FormAHP
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxMatrix);
            this.Controls.Add(this.groupBoxHierarchy);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "FormAHP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAHP_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxHierarchy.ResumeLayout(false);
            this.groupBoxMatrix.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripForMatrixList.ResumeLayout(false);
            this.contextMenuStripForHierarchy.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForMatrixList;
        private System.Windows.Forms.ToolStripMenuItem OperateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pairWiseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pairWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem generateResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quikStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForHierarchy;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showVersionChangeToolStripMenuItem;
    }
}

