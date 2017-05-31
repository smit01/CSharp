using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0531_ListBox {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e) {
            lstTest.Items.Add("Test");
        }

        private void DelButton_Click(object sender, EventArgs e) {
            // lstTest.Items.RemoveAt(0);
            lstTest.Items.Remove("D");
        }

        private void EditButton_Click(object sender, EventArgs e) {
            lstTest.Items[2] = "CCC";

        }

        private void SelectButton_Click(object sender, EventArgs e) {
            // SelectButton.Text = lstTest.SelectedItem.ToString();
            int i = lstTest.SelectedIndex;
            if (i < 0)
                SelectButton.Text = "not yet";
            else
                SelectButton.Text = lstTest.Items[i].ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {
            lstTo.Items.Clear();
            comboBox1.SelectedIndex = 0;
        }

        private void CopyButton_Click(object sender, EventArgs e) {
            //string s = lstFrom.SelectedItem.ToString();
            //if (lstFrom.SelectedIndex >= 0) {
            //    if (lstTo.Items.IndexOf(s) < 0) {
            //        lstTo.Items.Add(s);
            //    }
            //}

            //for (int i = 0; i < lstFrom.SelectedItems.Count; i++) {
            //    object obj = lstFrom.SelectedItems[i];
            //    if (lstTo.Items.IndexOf(obj) < 0) {
            //        lstTo.Items.Add(obj);
            //    }
            //}

            foreach (object item in lstFrom.SelectedItems) {
                if (lstTo.Items.IndexOf(item) < 0) {
                    lstTo.Items.Add(item);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e) {
            button1.Text = comboBox1.Text;
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                // add ...  .Text   Items.Add()   Items.IndexOf
            }
        }
    }
}
