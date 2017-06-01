using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0601_function {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        void ShowStar() {
            doShowStar(5, "*");
        }

        void ShowStar(int howMany) {
            doShowStar(howMany, "*");
        }

        void ShowStar(int howMany, string showWhat) {
            doShowStar(howMany, showWhat);
        }
        // Overload
        void doShowStar(int howMany, string showWhat) {
            if (howMany > 21) {
                MessageBox.Show("howMany <= 21 please");
                return;
            }
            if (howMany <= 0) {
                MessageBox.Show("howMany > 0 please");
                return;
            }

            string result = "";
            for (int i = 1; i <= howMany; i++) {
                result += showWhat;
            }
            MessageBox.Show(result);
        }

        //void doShowStar(int howMany, string showWhat) {
        //    if (howMany >= 1) {
        //        if (howMany <= 21) {
        //            string result = "";
        //            for (int i = 1; i <= howMany; i++) {
        //                result += showWhat;
        //            }
        //            MessageBox.Show(result);
        //        }
        //        else
        //            MessageBox.Show("howMany <= 21 please");
        //    }
        //    else
        //        MessageBox.Show("howMany > 0 please");
        //}


        private void button1_Click(object sender, EventArgs e) {
            int count = -2;
            ShowStar(count);
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        int Add(ref int x, int y, out int answer) {
            int result = 0;
            result = x + y; ;
            x = 6;
            answer = result;
            return result;
        }

        private void button2_Click(object sender, EventArgs e) {
            int a = 1;
            int b = 2;
            int c = -1;
            int test = Add(ref a, b, out c);
            button2.Text = test.ToString();
            this.Text = c.ToString();
        }

        void swap(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }

        private void button3_Click(object sender, EventArgs e) {
            int x = 100;
            int y = 200;
            swap(ref x, ref y);
            button3.Text = x.ToString() + ", " + y.ToString();
        }

        private void button4_Click(object sender, EventArgs e) {
            string userKeyin = textBox1.Text;
            int x;
            // int x = int.Parse(userKeyin);
            if (int.TryParse(userKeyin, out x))
                button4.Text = x.ToString();
            else
                button4.Text = "not a number";


        }
    }
}
