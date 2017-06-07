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

namespace test0607_Command {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // 
        }

        private void button1_Click(object sender, EventArgs e) {
            SqlConnection cn = new SqlConnection("server=(local)\\SQLExpress;database=northwind;Integrated Security=True");
            cn.Open();

            SqlCommand cmd = new SqlCommand(
                "update Products set UnitsInStock = 10 where ProductID = 1", 
                cn);
            int result = cmd.ExecuteNonQuery();

            button1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            SqlConnection cn = new SqlConnection("server=(local)\\SQLExpress;database=northwind;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products", cn);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                listBox1.Items.Add(dr["ProductName"]);
            }

            button2.Text = "OK";
        }
    }
}
