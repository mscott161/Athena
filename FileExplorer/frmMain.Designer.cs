namespace FileExplorer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.appImageList = new System.Windows.Forms.ImageList(this.components);
            this.treeHierarchy = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstCurrentFolder = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlBreadCrumb = new System.Windows.Forms.Panel();
            this.flowCrumb = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlBreadCrumb.SuspendLayout();
            this.SuspendLayout();
            // 
            // appImageList
            // 
            this.appImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("appImageList.ImageStream")));
            this.appImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.appImageList.Images.SetKeyName(0, "File.png");
            this.appImageList.Images.SetKeyName(1, "Folder.png");
            this.appImageList.Images.SetKeyName(2, "Drive.png");
            // 
            // treeHierarchy
            // 
            this.treeHierarchy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeHierarchy.FullRowSelect = true;
            this.treeHierarchy.HideSelection = false;
            this.treeHierarchy.ImageIndex = 0;
            this.treeHierarchy.ImageList = this.appImageList;
            this.treeHierarchy.Location = new System.Drawing.Point(0, 0);
            this.treeHierarchy.Name = "treeHierarchy";
            this.treeHierarchy.SelectedImageIndex = 0;
            this.treeHierarchy.Size = new System.Drawing.Size(266, 426);
            this.treeHierarchy.TabIndex = 0;
            this.treeHierarchy.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeHierarchy_BeforeExpand);
            this.treeHierarchy.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeHierarchy_AfterExpand);
            this.treeHierarchy.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeHierarchy_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeHierarchy);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstCurrentFolder);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // lstCurrentFolder
            // 
            this.lstCurrentFolder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize});
            this.lstCurrentFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCurrentFolder.GridLines = true;
            this.lstCurrentFolder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstCurrentFolder.HideSelection = false;
            this.lstCurrentFolder.Location = new System.Drawing.Point(0, 0);
            this.lstCurrentFolder.MultiSelect = false;
            this.lstCurrentFolder.Name = "lstCurrentFolder";
            this.lstCurrentFolder.Size = new System.Drawing.Size(530, 426);
            this.lstCurrentFolder.SmallImageList = this.appImageList;
            this.lstCurrentFolder.TabIndex = 0;
            this.lstCurrentFolder.UseCompatibleStateImageBehavior = false;
            this.lstCurrentFolder.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "FileName";
            this.colName.Width = 348;
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            this.colSize.Width = 117;
            // 
            // pnlBreadCrumb
            // 
            this.pnlBreadCrumb.Controls.Add(this.flowCrumb);
            this.pnlBreadCrumb.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBreadCrumb.Location = new System.Drawing.Point(0, 0);
            this.pnlBreadCrumb.Name = "pnlBreadCrumb";
            this.pnlBreadCrumb.Size = new System.Drawing.Size(800, 24);
            this.pnlBreadCrumb.TabIndex = 2;
            // 
            // flowCrumb
            // 
            this.flowCrumb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCrumb.Location = new System.Drawing.Point(0, 0);
            this.flowCrumb.Name = "flowCrumb";
            this.flowCrumb.Size = new System.Drawing.Size(800, 24);
            this.flowCrumb.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlBreadCrumb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Pi File Explorer";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlBreadCrumb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList appImageList;
        private System.Windows.Forms.TreeView treeHierarchy;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lstCurrentFolder;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.Panel pnlBreadCrumb;
        private System.Windows.Forms.FlowLayoutPanel flowCrumb;
    }
}

