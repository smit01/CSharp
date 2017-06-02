using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0602_Static {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MyToolBox.DisplayTime();
        }

        private void button2_Click(object sender, EventArgs e) {
            int a = 100;  int b = 200;
            MyToolBox.swap<int>(ref a, ref b);
            button1.Text = a.ToString();
            button2.Text = b.ToString();
        }
    }
    class MyToolBox {
        public static void swap<T>(ref T x, ref T y) {
            T temp = x;
            x = y;
            y = temp;
        }
        public static void DisplayTime() {
            MessageBox.Show(DateTime.Now.ToString());
        }

    }

}
