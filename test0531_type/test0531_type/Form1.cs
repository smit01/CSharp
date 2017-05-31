using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0531_type {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int salary = 85000;
            int test = salary;
            test = 90000;
            button1.Text = salary.ToString();
        }

        /*
        | Class
        |    X
        |    Y

1123 → o Instance
     |  o    X  = 100
     |  o    Y
     |
     L  r 1123    r.X = 100  mean 1123'X = 100
        r 1123

        */

        private void button2_Click(object sender, EventArgs e) {
            MyPoint obj = new MyPoint { X = 100, Y = 200 };
            MyPoint obj2 = obj;
            obj2.X = 110;
            button2.Text = obj.X.ToString();
        }

        private void button3_Click(object sender, EventArgs e) {
            int x;
            x = 9;

            // VB:
            // Dim x as Integer;  ==> Int32
            // C#:
            // int x;  ==> Int32

            // I:
            // x = (int)10.8;

            // II:
            // x = Convert.ToInt32(10.8);

            // III:
            button3.Text = Math.Round(10.8).ToString();
        }

        private void button4_Click(object sender, EventArgs e) {
            int x = 0;
            // 0  123456789
            //        ^
            //    1234 1234
            // 四拾六入五成雙
            x = Convert.ToInt32(10.5);  // 10
            x = Convert.ToInt32(10.6);  // 11
            x = Convert.ToInt32(11.5);  // 12

            button4.Text = x.ToString();

            button4.Text = Math.Round(
                10.5, 
                0, 
                MidpointRounding.AwayFromZero).ToString();

        }

        private void button5_Click(object sender, EventArgs e) {
            // double x = 10.5;
            // float x = (float)10.5;
            //float x = 10.5f;
            // decimal y = 10.5;

            double x = 0.0001;
            double result = 0;
            for (int i = 1; i <= 10000; i++) {
                result += x;
            }
            button5.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e) {
            decimal x = 0.0001m;
            decimal result = 0;
            for (int i = 1; i <= 10000; i++) {
                result += x;
            }
            button6.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e) {
            // 9322  9054  667A
            // 錢    達    智
            char c = '智';  // char c = "A";  // error
            int i = c;
            button7.Text = i.ToString("X");  //667A

            i = 0x667A;  // 十六進位
            c = (char)i; //  Convert.ToChar(i);
            button7.Text = c.ToString();
        }

        private void button8_Click(object sender, EventArgs e) {
            string s = "錢達智\n";
            string a = "先生";
            button8.Text = s + a;

            // button8.Text = s[0].ToString();

            // button8.Text = "c:\\news\\abc.txt";
            button8.Text = @"c:\news\abc.txt";
        }

        private void button9_Click(object sender, EventArgs e) {
            bool YesOrNo = true; // false

        }

        private void button10_Click(object sender, EventArgs e) {
            // int x = null;  // error;
            int? x;
            x = null;
            if (x == null)
                x = 10;

            // int answer = 8 + (int)x;  // error;
            int answer = 8 + Convert.ToInt32(x);

            button10.Text = answer.ToString();
        }

    }

    /*
    Number:
        int: byte(1), short(2), int(4)****, long(8)
        float: float, double***, decimal
    Text:
        char <==> int
        string
    */

    class MyPoint {
        public int X { get; set; }
        public int Y { get; set; }
    }



}
