using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        int abc = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked == true)
            //{
            //    foreach (ListViewItem item in listView1.Items)
            //    {
            //        item.Checked = true;
            //    }
            //}
            //else
            //{
            //    foreach (ListViewItem item in listView1.Items)
            //    {
            //        item.Checked = false;
            //    }
            //}

            abc = 5;

            MessageBox.Show(abc.ToString());

            //以下為簡寫
            //foreach (ListViewItem item in listView1.Items)
            //{
            //    item.Checked = checkBox1.Checked;
            //}


        }

        public void SetValue()
        {
            abc = 9;
        }
    }
}
