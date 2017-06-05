using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0605_enum {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        //const int Spring = 1;
        //const int Summer = 2;
        //const int Autumn = 3;
        //const int Winter = 4;
        const double PI = 3.1416;
        const double TAX_RATE = 0.05;
        enum TSeason {
            Spring = 2,   // 00010
            Summer = 4,   // 00100
            Autumn = 8,   // 01000
            Winter = 16   // 10000
        }

        private void button1_Click(object sender, EventArgs e) {
            TSeason season = TSeason.Summer;
            //int x = (int)season;
            button1.Text = season.ToString();
        }
    }
}
