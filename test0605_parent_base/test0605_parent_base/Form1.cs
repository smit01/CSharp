using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0605_parent_base {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            CAnimal obj = new CDog();
            obj.MakeNoise(3);
            button1.Text = obj.Test.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            CDog obj = new CDog();
            button2.Text = obj.GetSecret().ToString();
        }
    }

    class CAnimal {
        protected int familySecret = 100;

        private int _Test = 0;
        public int Test {
            get {
                return this._Test;
            }
        }
        public virtual void MakeNoise(int value) {
            _Test = value;
            MessageBox.Show("Animal: ...");
        }
    }

    class CDog : CAnimal {

        public override void MakeNoise(int value) {
            base.MakeNoise(value);
            MessageBox.Show("Bark!");
        }

        public int GetSecret() {
            return this.familySecret;
        }

    }


}
