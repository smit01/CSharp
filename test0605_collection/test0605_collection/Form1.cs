using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0605_collection {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            ArrayList col = new ArrayList();
            col.Add("Chien");
            col.Add(60);
            // button1.Text = col.Count.ToString();
            col.Remove("Chien");
            button1.Text = col[0].ToString();
        }
        private void button2_Click(object sender, EventArgs e) {
            Hashtable col = new Hashtable();
            col.Add("firstName", "Jeremy");
            col["lastName"] = "Lin";
            button2.Text = col.Count.ToString();
            button2.Text = col["firstName"].ToString();
        }

        private void button3_Click(object sender, EventArgs e) {
            List<string> col = new List<string>();
            col.Add("Jeremy");
            button3.Text = col[0];
        }

        private void button4_Click(object sender, EventArgs e) {
            List<MyPoint> pointList = new List<MyPoint>();
            pointList.Add(new MyPoint { x = 100, y = 200 });
            pointList.Add(new MyPoint { x = 200, y = 200 });
            pointList.Add(new MyPoint { x = 300, y = 200 });

            foreach (MyPoint pt in pointList) {
                listBox1.Items.Add(pt.x.ToString());
            }
        }
    }
    class MyPoint {
        public int x { set; get; }
        public int y { set; get; }
    }


}
