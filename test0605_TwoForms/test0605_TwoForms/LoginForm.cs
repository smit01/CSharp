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
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        //public int UserAnswer { get; set; }

        private void OKButton_Click(object sender, EventArgs e) {
            // this.DialogResult = DialogResult.OK;
            //UserAnswer = 1;
            //this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            // this.DialogResult = DialogResult.Cancel;
            //UserAnswer = 2;
            //this.Close();
        }
    }
}
