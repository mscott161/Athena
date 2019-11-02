using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class BreadCrumb : UserControl
    {
        private const string TREENODE_DIRSUB = ".dirsub";

        public event EventHandler SelectedDirectory;

        TreeNode parentNode = null;

        public BreadCrumb()
        {
            InitializeComponent();
        }

        public string ItemName { set { lblName.Text = value; } }
        public TreeNode ParentNode
        {
            set
            {
                parentNode = value;

                if (parentNode.Nodes.Count > 0)
                {
                    foreach (TreeNode n in parentNode.Nodes)
                    {
                        if (n.Text != TREENODE_DIRSUB)
                            cboChildren.Items.Add(n.Text);
                    }
                }

                if (cboChildren.Items.Count == 0)
                {
                    cboChildren.Visible = false;
                }
            }
        }

        private void CboChildren_DropDown(object sender, EventArgs e)
        {

        }

        private void CboChildren_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void CboChildren_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = 0;
            foreach (string item in cboChildren.Items)
            {
                if (item == cboChildren.SelectedItem.ToString())
                    break;
                index++;
            }
            TreeNode node = parentNode.Nodes[index];
            if (SelectedDirectory != null)
                SelectedDirectory(node, e);
        }
    }
}
