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
    public partial class Form5 : Form
    {
        狀態 目前的狀態;

        public Form5()
        {
            InitializeComponent();

            //aa/
            //bb/
            //cc/
    
            this.btNumber1.Click += new System.EventHandler(this.button_Click);
            this.btNumber2.Click += new System.EventHandler(this.button_Click);
            this.btNumber3.Click += new System.EventHandler(this.button_Click);
            this.btNumber4.Click += new System.EventHandler(this.button_Click);
            this.btNumber5.Click += new System.EventHandler(this.button_Click);

            this.btN1.Click += new System.EventHandler(this.btN_Click);
            this.btN2.Click += new System.EventHandler(this.btN_Click);
            this.btN3.Click += new System.EventHandler(this.btN_Click);
            this.btN4.Click += new System.EventHandler(this.btN_Click);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (目前的狀態 == 狀態.第一步)
            {
                lab1.Text = btn.Text;
                目前的狀態 = 狀態.運算元;
            }
            else if (目前的狀態 == 狀態.第二步)
            {
                lab3.Text = btn.Text;
                目前的狀態 = 狀態.等於;
            }
        }

        enum 狀態 { 第一步, 運算元, 第二步, 等於 };

        private void btN_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (目前的狀態 == 狀態.運算元)
            {
                lab2.Text = btn.Text;
                目前的狀態 = 狀態.第二步;
            }
        }

        private void btN5_Click(object sender, EventArgs e)
        {
            if (目前的狀態 == 狀態.等於)
            {
                decimal a1 = decimal.Parse(lab1.Text);
                decimal a2 = decimal.Parse(lab3.Text);
                if (lab2.Text == "+")
                {
                    decimal a3 = a1 + a2;
                    lab5.Text = a3.ToString();
                }
                else if (lab2.Text == "-")
                {
                    decimal a3 = a1 - a2;
                    lab5.Text = a3.ToString();
                }
                else if (lab2.Text == "*")
                {
                    decimal a3 = a1 * a2;
                    lab5.Text = a3.ToString();
                }
                else if (lab2.Text == "/")
                {
                    if (a2 != 0)
                    {
                        decimal a3 = a1 / a2;
                        lab5.Text = a3.ToString();
                    }
                    else
                    {
                        lab5.Text = "N/A";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lab1.Text = "";
            lab2.Text = "運算元";
            lab3.Text = "";
            lab4.Text = "等於";
            lab5.Text = "結果";
            目前的狀態 = 狀態.第一步;
        }

    }
}
