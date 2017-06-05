using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0605_try_catch {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                string s = textBox1.Text;
                System.Diagnostics.Process.Start(s);
            }
            catch (Win32Exception ex) {
                MessageBox.Show(ex.Message);
            }
            catch (System.IO.FileNotFoundException ex) {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            // MessageBox.Show("OK");
        }

        private void button2_Click(object sender, EventArgs e) {
            for (int i = 1; i <= 9; i++) {
                SendMail(i);
            }
        }

        void SendMail(int i) {
            try {
                if (i == 4) {
                    throw new Exception("Address format error!");
                }
                listBox1.Items.Add(i);
            }
            catch (Exception ex ) {
                listBox1.Items.Add(ex.Message);
            }
        }

    }
}
