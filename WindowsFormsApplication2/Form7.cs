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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int z = 3;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < z; y++)
                {
                    label1.Text += "＊";
                }
                label1.Text += "\n";
                z--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            label1.Text = "";

            decimal k = Math.Ceiling((decimal)x / 2);

            for (int a = 1; a <= x; a++)
            {
                for (int b = 1; b <= k - Math.Abs(k - a); b++)
                {
                    label1.Text += "＊";
                }
                label1.Text += "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
