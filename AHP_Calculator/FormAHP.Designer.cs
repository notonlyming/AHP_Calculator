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
            this.buttonShowMatrix = new System.Windows.Forms.Button();
            this.groupBoxHierarchy = new System.Windows.Forms.GroupBox();
            this.buttonClearNode = new System.Windows.Forms.Button();
            this.buttonDelNode = new System.Windows.Forms.Button();
            this.buttonAddSub = new System.Windows.Forms.Button();
            this.buttonAddRoot = new System.Windows.Forms.Button();
            this.treeViewHierarchy = new System.Windows.Forms.TreeView();
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonPairWise = new System.Windows.Forms.Button();
            this.groupBoxHierarchy.SuspendLayout();
            this.groupBoxMatrix.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowMatrix
            // 
            this.buttonShowMatrix.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonShowMatrix.Location = new System.Drawing.Point(13, 389);
            this.buttonShowMatrix.Name = "buttonShowMatrix";
            this.buttonShowMatrix.Size = new System.Drawing.Size(68, 41);
            this.buttonShowMatrix.TabIndex = 6;
            this.buttonShowMatrix.Text = "Show";
            this.buttonShowMatrix.UseVisualStyleBackColor = true;
            this.buttonShowMatrix.Click += new System.EventHandler(this.buttonCreateMatrix_Click);
            // 
            // groupBoxHierarchy
            // 
            this.groupBoxHierarchy.Controls.Add(this.buttonPairWise);
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
            this.buttonClearNode.Location = new System.Drawing.Point(105, 431);
            this.buttonClearNode.Name = "buttonClearNode";
            this.buttonClearNode.Size = new System.Drawing.Size(60, 32);
            this.buttonClearNode.TabIndex = 10;
            this.buttonClearNode.Text = "Clear";
            this.buttonClearNode.UseVisualStyleBackColor = true;
            // 
            // buttonDelNode
            // 
            this.buttonDelNode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDelNode.Location = new System.Drawing.Point(105, 389);
            this.buttonDelNode.Name = "buttonDelNode";
            this.buttonDelNode.Size = new System.Drawing.Size(60, 32);
            this.buttonDelNode.TabIndex = 9;
            this.buttonDelNode.Text = "Del";
            this.buttonDelNode.UseVisualStyleBackColor = true;
            // 
            // buttonAddSub
            // 
            this.buttonAddSub.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAddSub.Location = new System.Drawing.Point(6, 431);
            this.buttonAddSub.Name = "buttonAddSub";
            this.buttonAddSub.Size = new System.Drawing.Size(93, 32);
            this.buttonAddSub.TabIndex = 8;
            this.buttonAddSub.Text = "Add sub";
            this.buttonAddSub.UseVisualStyleBackColor = true;
            // 
            // buttonAddRoot
            // 
            this.buttonAddRoot.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAddRoot.Location = new System.Drawing.Point(6, 389);
            this.buttonAddRoot.Name = "buttonAddRoot";
            this.buttonAddRoot.Size = new System.Drawing.Size(93, 32);
            this.buttonAddRoot.TabIndex = 7;
            this.buttonAddRoot.Text = "Add root";
            this.buttonAddRoot.UseVisualStyleBackColor = true;
            // 
            // treeViewHierarchy
            // 
            this.treeViewHierarchy.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewHierarchy.Location = new System.Drawing.Point(9, 19);
            this.treeViewHierarchy.Name = "treeViewHierarchy";
            this.treeViewHierarchy.Size = new System.Drawing.Size(278, 363);
            this.treeViewHierarchy.TabIndex = 6;
            // 
            // groupBoxMatrix
            // 
            this.groupBoxMatrix.Controls.Add(this.listBox1);
            this.groupBoxMatrix.Controls.Add(this.buttonShowMatrix);
            this.groupBoxMatrix.Location = new System.Drawing.Point(312, 12);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Size = new System.Drawing.Size(273, 473);
            this.groupBoxMatrix.TabIndex = 8;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "Matrix";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(13, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 352);
            this.listBox1.TabIndex = 0;
            // 
            // buttonPairWise
            // 
            this.buttonPairWise.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPairWise.Location = new System.Drawing.Point(171, 389);
            this.buttonPairWise.Name = "buttonPairWise";
            this.buttonPairWise.Size = new System.Drawing.Size(113, 32);
            this.buttonPairWise.TabIndex = 11;
            this.buttonPairWise.Text = "Pair wise...";
            this.buttonPairWise.UseVisualStyleBackColor = true;
            // 
            // FormAHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 494);
            this.Controls.Add(this.groupBoxMatrix);
            this.Controls.Add(this.groupBoxHierarchy);
            this.Name = "FormAHP";
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
    }
}

