using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0605_TwoForms {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            LoginForm frm = new test0605_TwoForms.LoginForm();
//            DialogResult answer = frm.ShowDialog();
            if (frm.ShowDialog() == DialogResult.OK)
                MessageBox.Show(frm.UserNameTextBox.Text);
            else
                MessageBox.Show("Canceled");
        }
    }
}
