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

namespace test0607_HandCodingDataSet {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        DataSet ds = new DataSet();

        private void button1_Click(object sender, EventArgs e) {
            SqlConnection cn = new SqlConnection("server=(local)\\SQLExpress;database=northwind;Integrated Security=True");
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Products", cn);
            da.Fill(ds, "prod");

            dataGridView1.DataSource = ds.Tables["prod"];
            // dataGridView1.DataSource = ds;
            // dataGridView1.DataMember = "prod";

        }

        private void button2_Click(object sender, EventArgs e) {
            // ds.RejectChanges();
            ds.Tables["prod"].RejectChanges();
            // ds.Tables["prod"].Rows[0].RejectChanges();
        }

        private void button3_Click(object sender, EventArgs e) {
            ds.Tables["prod"].Rows[0].AcceptChanges();
            button3.Text = ds.Tables["prod"].Rows[0]["UnitsInStock", DataRowVersion.Original].ToString();
            this.Text = ds.Tables["prod"].Rows[0].RowState.ToString();
        }
    }
}
