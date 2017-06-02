using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0602_Sender {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void DoA(object sender, EventArgs e) {
            MessageBox.Show("AAA");
        }

        private void DoB(object sender, EventArgs e) {
            MessageBox.Show("BBB");
        }

        private void btnAddA_Click(object sender, EventArgs e) {
            btnTest.Click += DoA;
        }

        private void btnAddB_Click(object sender, EventArgs e) {
            btnTest.Click += DoB;
        }

        private void btnLessA_Click(object sender, EventArgs e) {
            btnTest.Click -= DoA;
        }

        private void btnLessB_Click(object sender, EventArgs e) {
            btnTest.Click -= DoB;
        }

        private void NumberButton_Click(object sender, EventArgs e) {
            //Control ctl = sender as Control;
            //MessageBox.Show(ctl.Text);
            if (sender is Button) {
                Button btn = sender as Button;
                MessageBox.Show(btn.Text);
            }
            else if (sender is Label) {
                Label lbl = sender as Label;
                MessageBox.Show(lbl.Text);
            }

        }

    }
}

/*

    if (value > 0)
        _Weight = value;
    else {
        // B. 呼叫 Client 端的事件處理函式
        // Invoke event (raise an event), calling EventHander
        if (this.WeightError != null) {
            WeightEventArgs e = new WeightEventArgs("Weight too low", value);
            this.WeightError(this, e);
            if (e.Handled)
                _Weight = e.WeightValue;
        }
    }


*/
