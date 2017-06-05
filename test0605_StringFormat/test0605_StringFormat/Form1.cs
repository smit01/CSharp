using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0605_StringFormat {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int x = 100;
            int y = 200;
            // (100, 200)
            string s =
                "(" +
                x.ToString() + ", " + y.ToString() +
                ")";
            button1.Text = s;
        }

        private void button2_Click(object sender, EventArgs e) {
            int x = 10000;
            int y = 20000;
            // (100, 200)
            string s = String.Format(
                "({0}, {1})",
                x,
                y
            );
            button2.Text = s;
        }

        private void button3_Click(object sender, EventArgs e) {
            int x = 10000;
            int y = 20000;
            // (100, 200)
            string s = String.Format(
                "({0:N2}, {1:N4})",
                x,
                y
            );
            button3.Text = s;

        }

        private void button4_Click(object sender, EventArgs e) {
            int x = 10;
            int y = 20;
            string s = String.Format(
                "({0:D4}, {1})",
                x,
                y
            );
            button4.Text = s;
        }

        private void button5_Click(object sender, EventArgs e) {
            // new System.Globalization.CultureInfo("zh-TW"),
            // who-where   en-US   zh-TW zh-HK zh-CN
            int x = 30000;
            string s = String.Format(
                new System.Globalization.CultureInfo("zh-CN"),
                "{0:C}", x
                );
            button5.Text = s;
        }
    }
}
