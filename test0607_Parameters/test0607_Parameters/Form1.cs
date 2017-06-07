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

namespace test0607_Parameters {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            DataSet ds = new DataSet();

            SqlConnection cn = new SqlConnection("server=(local)\\SQLExpress;database=northwind;Integrated Security=True");
            cn.Open();
            string commandText = "select * from Products where UnitPrice >= __Min and UnitPrice <= __Max order by UnitPrice";
            commandText = commandText.Replace("__Min", txtMin.Text);
            commandText = commandText.Replace("__Max", txtMax.Text);
            // if user keyin: 10 Update Products set UnitPrice = 10 where productID = 1 --
            // MessageBox.Show(commandText);
            // return;

            SqlDataAdapter da = new SqlDataAdapter(commandText, cn);
            da.Fill(ds, "prod");

            dataGridView1.DataSource = ds.Tables["prod"];
        }

        private void button2_Click(object sender, EventArgs e) {
            DataSet ds = new DataSet();

            SqlConnection cn = new SqlConnection("server=(local)\\SQLExpress;database=northwind;Integrated Security=True");
            cn.Open();
            string commandText = "select * from Products where UnitPrice >= @Min and UnitPrice <= @Max order by UnitPrice";
            SqlDataAdapter da = new SqlDataAdapter(commandText, cn);
            //da.SelectCommand.Parameters.Add("@Min", SqlDbType.Money).Value = txtMin.Text;
            //da.SelectCommand.Parameters.Add("@Max", SqlDbType.Money).Value = txtMax.Text;
            da.SelectCommand.Parameters.Add("@Min", SqlDbType.Money);
            da.SelectCommand.Parameters.Add("@Max", SqlDbType.Money);

            da.SelectCommand.Parameters["@Min"].Value = txtMin.Text;
            da.SelectCommand.Parameters["@Max"].Value = txtMax.Text;

            da.Fill(ds, "prod");

            dataGridView1.DataSource = ds.Tables["prod"];

        }
    }
}
