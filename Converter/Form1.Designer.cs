namespace Converter
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Area");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Currency");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Fuel");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Length");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Pressure");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Temperature");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Volume");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Weight");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Category", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Size = new System.Drawing.Size(683, 503);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode19.Name = "Area";
            treeNode19.Text = "Area";
            treeNode20.Name = "Currency";
            treeNode20.Text = "Currency";
            treeNode21.Name = "Fuel";
            treeNode21.Text = "Fuel";
            treeNode22.Name = "Length";
            treeNode22.Text = "Length";
            treeNode23.Name = "Pressure";
            treeNode23.Text = "Pressure";
            treeNode24.Name = "Temperature";
            treeNode24.Text = "Temperature";
            treeNode25.Name = "Volume";
            treeNode25.Text = "Volume";
            treeNode26.Name = "Weight";
            treeNode26.Text = "Weight";
            treeNode27.Name = "Category";
            treeNode27.Text = "Category";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode27});
            this.treeView1.Size = new System.Drawing.Size(248, 503);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 503);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Converter";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

