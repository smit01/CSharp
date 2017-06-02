using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0602_EnableTextBox {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            // ...

        }

        private void button2_Click(object sender, EventArgs e) {
            List<TextBox> lst = new List<TextBox>();
            lst.Add(textBox1);
            lst.Add(textBox2);
            lst.Add(textBox3);
            lst.Add(textBox4);
            // ...
            foreach (TextBox txt in lst) {
                txt.ReadOnly = false;
            }

        }

        private void button3_Click(object sender, EventArgs e) {
            EnableFormTextBox(this, false);
        }

        private void EnableFormTextBox(Form frm, bool IsReadOnly) {
            foreach (Control c in frm.Controls) {
                if (c is TextBox) {
                    TextBox txt = c as TextBox;
                    txt.ReadOnly = IsReadOnly;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            Button btnNew = new Button();
            btnNew.Width = button4.Width;
            btnNew.Height = button4.Height;
            btnNew.Left = button4.Left;
            btnNew.Top = button4.Top + button4.Height + 10;
            btnNew.Text = "New Comer";
            this.Controls.Add(btnNew);
            btnNew.Click += BtnNew_Click;
        }

        private void BtnNew_Click(object sender, EventArgs e) {
            MessageBox.Show("Test");
        }
    }
}
