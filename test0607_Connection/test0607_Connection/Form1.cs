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


namespace test0607_Connection {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // 
        private void button1_Click(object sender, EventArgs e) {
            // SqlConnection cn = new SqlConnection("Data Source=(local)\\SQLExpress;Initial Catalog=Northwind;Integrated Security=True");
            // SqlConnection cn = new SqlConnection("server=(local)\\SQLExpress;Initial Catalog=Northwind;Integrated Security=True");
            // SqlConnection cn = new SqlConnection("server=(local)\\SQLExpress;database=northwind;Integrated Security=True");
            // SqlConnection cn = new SqlConnection("server=(local)\\SQLExpress;database=northwind;user id=st;password=st;");
            //                                       SqlConnection
            SqlConnection cn = new SqlConnection("server=(local)\\SQLExpress;database=northwind;uid=st;pwd=st;");
            cn.Open();
            button1.Text = "OK";
        }
    }
}
