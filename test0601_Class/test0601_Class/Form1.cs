using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MotherNature.Creature;


namespace test0601_Class {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            CAnimal obj = new CAnimal(6);
            button1.Text = obj.Weight.ToString();
            // obj.MakeNoise();
        }

        private void button2_Click(object sender, EventArgs e) {
            CDog objDog = new CDog();
            CAnimal obj = objDog;
            obj.MakeNoise();
            /*
                CDog objDog;
                PlayWith(objDog);
                void PlayWith(CAnimal obj) {

                }
                void PlayWith(CDog obj) {

                }
                void PlayWith(CCat obj) {

                }
              
            */
        }
    }

  

}

namespace MotherNature.Creature {
    class CAnimal {

        public CAnimal() {
            this.Weight = 1;
        }
        public CAnimal(int WeightValue) {
            this.Weight = WeightValue;
        }

        private int _Weight;
        public int Weight {
            get {
                return this._Weight;
            }
            set {
                if (value > 0)
                    this._Weight = value;
            }
        }

        public string Location { set; get; }

        public virtual void MakeNoise() {
            MessageBox.Show("Animal: ...");
        }
    }

    class CDog : CAnimal {

        public override void MakeNoise() {
            MessageBox.Show("Dog Bark!");
        }

    }
}

