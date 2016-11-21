using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
                DisplayControl(this.treeView1.SelectedNode);
            else
                DisplayControl(this.treeView1.SelectedNode.Parent, e.Node.Text);            
        }

        public void DisplayControl(TreeNode ParentNode, string itemToLoadName = null)
        {
            splitContainer1.Panel2.Controls.Clear();
            if (itemToLoadName != null)
            {
                var unitControl = CreateInstance(itemToLoadName);
                Control control = (Control)unitControl;
                splitContainer1.Panel2.Controls.Add(control);
            }            
        }

        private static object CreateInstance(string className)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var type = assembly.GetTypes()
                .First(t => t.Name == className);

            return Activator.CreateInstance(type);
        }
    }
}
