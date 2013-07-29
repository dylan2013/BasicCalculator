using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
namespace WindowsFormsApplication2
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Assembly assm = Assembly.LoadFrom(@"C:\TFS2010-Git\Library\ReportHelper.dll");
            textBox1.Clear();
            foreach (var item in assm.GetExportedTypes())
            {
                
                textBox1.AppendText(item.ToString() + "\n");
            }*/
            
            //C:\TFS2010-Git\Library
            
            //treeView1.Nodes.Add(getfiles(new DirectoryInfo(@"C:\TFS2010-Git\Library")));
            
        }
        private TreeNode getfiles(DirectoryInfo dirinfo)
        {
            TreeNode tn = new TreeNode();
            tn.Text = dirinfo.ToString();
            foreach (var item in dirinfo.GetDirectories())
            {
                tn.Nodes.Add(getfiles(item));
            }
            foreach (var item in dirinfo.GetFiles())
            {
                tn.Nodes.Add(item.ToString() + "\n");
            }
            return tn;
        }

    }
}
