using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0531_ControlFlow {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        int iAnswer = 95;

        private void btnGuess_Click(object sender, EventArgs e) {
            int iUserKeyin = Convert.ToInt32(txtUserKeyin.Text);
            if (iUserKeyin > iAnswer) {
                lstReport.Items.Add("Too higt");
            } 
            else if (iUserKeyin < iAnswer)  { 
                lstReport.Items.Add("Too low");
            }
            else {
                lstReport.Items.Add("Correct");
            }


        }

        private void button1_Click(object sender, EventArgs e) {
            int iMonth = 3;
            int iAnswer = 0;
            switch (iMonth) {
                case 1:
                    iAnswer = 31;
                    break;
                case 2:
                    iAnswer = 28;
                    break;
                case 3:
                    iAnswer = 31;
                    break;
                case 4:
                    iAnswer = 30;
                    break;
                default:
                    iAnswer = -1;
                    break;
            }

            button1.Text = iAnswer.ToString();
            


            //int iMonth = 3;
            //if (iMonth == 1) {
            //    ...
            //} else if (iMonth == 2)
            //} else if (iMonth == 3)
            //} else if (iMonth == 4)
        }
}
}
