using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0605_clear {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            CAnimal obj = new CAnimal();
            CAnimal obj3 = obj;
            obj = null;
            GC.Collect();
        }

        private void button2_Click(object sender, EventArgs e) {
            using ( CAnimal obj = new CAnimal() ) {
                MessageBox.Show("pause");
            }
            // System.Media.SystemSounds.Beep.Play();
        }
    }
    // Form1
    class CAnimal : IDisposable {
        public CAnimal() {
            // MessageBox.Show("created");
        }
        ~CAnimal() {
            // System.Media.SystemSounds.Beep.Play();
            MessageBox.Show("clear");
        }

        public void Dispose() {
            System.Media.SystemSounds.Beep.Play();
        }
    }


}
