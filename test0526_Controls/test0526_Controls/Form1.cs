using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0526_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            textBox4.SelectionLength = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
                button1.Text = "Yes";
            else if (checkBox1.CheckState == CheckState.Unchecked)
                button1.Text = "No";
            else
                button1.Text = "not yet";

            //if (checkBox1.Checked)
            //    button1.Text = "Yes";
            //else
            //    button1.Text = "No";
        }
    }
}
