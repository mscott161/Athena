namespace FileExplorer
{
    partial class BreadCrumb
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboChildren = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboChildren
            // 
            this.cboChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChildren.DropDownWidth = 200;
            this.cboChildren.FormattingEnabled = true;
            this.cboChildren.Location = new System.Drawing.Point(176, 0);
            this.cboChildren.MaxDropDownItems = 20;
            this.cboChildren.Name = "cboChildren";
            this.cboChildren.Size = new System.Drawing.Size(18, 21);
            this.cboChildren.TabIndex = 0;
            this.cboChildren.DropDown += new System.EventHandler(this.CboChildren_DropDown);
            this.cboChildren.DropDownClosed += new System.EventHandler(this.CboChildren_DropDownClosed);
            this.cboChildren.SelectedValueChanged += new System.EventHandler(this.CboChildren_SelectedValueChanged);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblName.Size = new System.Drawing.Size(194, 22);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BreadCrumb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboChildren);
            this.Controls.Add(this.lblName);
            this.Name = "BreadCrumb";
            this.Size = new System.Drawing.Size(194, 22);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboChildren;
        private System.Windows.Forms.Label lblName;
    }
}
