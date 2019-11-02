using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace FileExplorer
{
    [Athena.Desktop.API.PiApp("Applications", "File Explorer", 1)]
    public partial class frmMain : Form
    {
        private const string TREENODE_DIRSUB = ".dirsub";

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadDrives();
        }

        private void LoadDrives()
        {
            treeHierarchy.Nodes.Clear();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                TreeNode n = new TreeNode(drive.Name);
                n.Tag = drive.Name;
                n.SelectedImageIndex = 2;
                n.ImageIndex = 2;
                treeHierarchy.Nodes.Add(n);

                if (HasSubDirectories(drive.Name))
                {
                    treeHierarchy.Nodes[treeHierarchy.Nodes.Count - 1].Nodes.Add(TREENODE_DIRSUB);
                }
            }
        }

        public bool HasSubDirectories(string path)
        {
            try
            {
                DirectoryInfo dirinfo = new DirectoryInfo(path);
                if (dirinfo.GetDirectories().Length > 0)
                    return true;
                else
                    return false;
            }
            catch { return false; }
        }

        private void TreeHierarchy_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode temp = e.Node;
            string _path = temp.Tag.ToString();
            GenerateSubNodes(ref temp, _path, true);
        }

        public void GenerateSubNodes(ref TreeNode tn, string pfad, bool hidesystemfolders)
        {
            if (tn.Nodes.Count == 1 && tn.Nodes[0].Text == TREENODE_DIRSUB)
            {
                try
                {
                    DirectoryInfo dirinfo = new DirectoryInfo(pfad);

                    if (dirinfo.GetDirectories().Length > 0)
                    {
                        foreach (DirectoryInfo d in dirinfo.EnumerateDirectories())
                        {
                            TreeNode n1 = new TreeNode(d.Name);
                            n1.Tag = d.FullName;
                            n1.ImageIndex = 1;
                            n1.SelectedImageIndex = 1;

                            try
                            {
                                if (d.GetDirectories().Length > 0)
                                    n1.Nodes.Add(TREENODE_DIRSUB);
                            }
                            catch { }

                            tn.Nodes.Add(n1);
                        }
                    }

                    tn.Nodes.RemoveAt(0);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
            }
        }

        private void TreeHierarchy_AfterExpand(object sender, TreeViewEventArgs e)
        {
        }

        private void TreeHierarchy_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;

            CreateBreadCrumb();

            if (node.Tag != null)
                LoadFiles(node.Tag.ToString());
        }

        private void LoadFiles(string path)
        {
            lstCurrentFolder.Items.Clear();

            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Path.GetFileName(file);

                FileInfo fi = new FileInfo(file);
                item.SubItems.Add(fi.Length + " b");

                item.ImageIndex = 0;

                lstCurrentFolder.Items.Add(item);
            }
        }

        private void CreateBreadCrumb()
        {
            flowCrumb.Controls.Clear();

            TreeNode n = treeHierarchy.SelectedNode;

            List<TreeNode> nodes = new List<TreeNode>();
            while (n != null)
            {
                nodes.Insert(0, n);
                n = n.Parent;
            }

            foreach (TreeNode node in nodes)
            {
                string name = Path.GetFileName(node.Tag.ToString());

                if (name == "")
                    name = node.Tag.ToString();

                //ComboBox cbo = new ComboBox();
                //cbo.DropDownStyle = ComboBoxStyle.DropDownList;
                //cbo.Items.Add( name);
                //cbo.SelectedIndex = 0;
                //Graphics g = cbo.CreateGraphics();
                //SizeF sz = g.MeasureString(name, cbo.Font);
                //cbo.Width = (int)sz.Width + 20; 

                TreeNode nn = node;
                string _path = nn.Tag.ToString();
                GenerateSubNodes(ref nn, _path, true);

                BreadCrumb cbo = new BreadCrumb();
                cbo.SelectedDirectory += Cbo_SelectedDirectory;
                cbo.ItemName = name;
                cbo.ParentNode = nn;
                Graphics g = cbo.CreateGraphics();
                SizeF sz = g.MeasureString(name, cbo.Font);
                cbo.Width = (int)sz.Width + 35;

                flowCrumb.Controls.Add(cbo);
            }
        }

        private void Cbo_SelectedDirectory(object sender, EventArgs e)
        {
            TreeNode n = (TreeNode)sender;
            treeHierarchy.SelectedNode = n;
        }
    }
}
