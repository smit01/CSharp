using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0606_DataSet {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            bindingSource1.PositionChanged 
                += BindingSource1_PositionChanged;
        }

        private void BindingSource1_PositionChanged(object sender, EventArgs e) {
            int iRow = bindingSource1.Position;
            TestTextBox.Text = ds.Customers[iRow].CompanyName;
        }

        private void FillButton_Click(object sender, EventArgs e) {
            da.Fill(ds);
        }

        private void UpdateButton_Click(object sender, EventArgs e) {
            da.Update(ds);
        }

        private void WriteXMLButton_Click(object sender, EventArgs e) {
            ds.WriteXml(@"c:\temp\customers.xml", XmlWriteMode.DiffGram);
        }

        private void ReadXMLButton_Click(object sender, EventArgs e) {
            ds.ReadXml(@"c:\temp\customers.xml");
        }

        private void TestButton_Click(object sender, EventArgs e) {
            // TestTextBox.Text = "ABC";
            // DataTable dt = ds.Tables["Customers"];
            // DataRow dr = dt.Rows[0];
            // TestTextBox.Text = dr["CompanyName"].ToString();
            // TestTextBox.Text = ds.Tables["Customers"].Rows[0]["CompanyName"].ToString();

            //NorthwindDataSet.CustomersDataTable dt = ds.Customers;
            //NorthwindDataSet.CustomersRow dr = dt[0];
            //TestTextBox.Text = dr.CompanyName;

            int iRow = bindingSource1.Position;
            TestTextBox.Text = ds.Customers[iRow].CompanyName;

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            // this.Text = DateTime.Now.ToString();
            // int iRow = bindingSource1.Position;
            // TestTextBox.Text = ds.Customers[iRow].CompanyName;
            // TestTextBox.Text = textBox1.Text;
        }

        private void AddRowButton_Click(object sender, EventArgs e) {
            // AddRowButton.Text = ds.Customers[0].RowState.ToString();
            // Version A:
            // 1. create a new row
            //DataRow dr = ds.Tables[0].NewRow();
            //// 2. asssign field values
            //dr["CustomerID"] = "12345";
            //dr["CompanyName"] = "12345 name";
            //// 3. add row into table
            //ds.Tables[0].Rows.Add(dr);
            //AddRowButton.Text = dr.RowState.ToString();


            // Version B:
            // 1. create a new row
            NorthwindDataSet.CustomersRow dr =
                ds.Customers.NewCustomersRow();
            // 2. asssign field values
            dr.CustomerID = "12345";
            dr.CompanyName = "12345 name";
            // 3. add row into table
            // ds.Customers.Rows.Add(dr);
            ds.Customers.AddCustomersRow(dr);
        }

        private void RemoveButton_Click(object sender, EventArgs e) {
            ds.Customers.Rows.RemoveAt(0);
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            // ds.Customers[0].Delete();
            ds.Tables[0].Rows[0].Delete();
            // Data Source =.\SQLExpress; Initial Catalog = Northwind; Integrated Security = True
        }


        /*
        Data Source=(local)\SQLExpress;Initial Catalog=Northwind;User ID=st;Password=st
        Data Source=(local)\SQLExpress;Initial Catalog=Northwind;Integrated Security=True 
        */

    }
}
