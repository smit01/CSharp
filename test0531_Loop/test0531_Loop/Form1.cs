using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0531_Loop {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
            int i = 1;
            while (i <= 3) {
                listBox1.Items.Add(i);
                i++;
            }
            listBox1.Items.Add("after loop: " + i.ToString());
        }

        private void button2_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
            for (int i = 1; i <= 3; i++) {
                listBox1.Items.Add(i);
            }
            // error:
            // listBox1.Items.Add("after loop: " 
            //    + i.ToString());
        }

        private void button3_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
            // int x = 100;
            //int iSize = 3;
            //int[] ScoreList = new int[iSize]; // 0, 1, 2
            //ScoreList[2] = 920;
            //// button3.Text = ScoreList.Length.ToString();
            //button3.Text = ScoreList[2].ToString();

            int[] ScoreList = new int[] { 90, 91, 92, 93, 95 };

            //for (int i = 0; i < ScoreList.Length; i++) {
            //    int data = ScoreList[i];
            //    listBox1.Items.Add(data);
            //}
            // int[] ScoreList = new int[] { 90, 91, 92, 93, 95 };
            foreach (int data in ScoreList) {
                listBox1.Items.Add(data);
            }


        }

        private void button4_Click(object sender, EventArgs e) {
            // error:
            //var iCount = listBox1.Items.Count;
            //for (int i = 0; i < iCount; i++) {
            //    listBox1.Items.RemoveAt(i);
            //}

            var iCount = listBox1.Items.Count;
            for (int i = iCount - 1; i >= 0 ; i--) {
                listBox1.Items.RemoveAt(i);
            }
        }
    }
}
