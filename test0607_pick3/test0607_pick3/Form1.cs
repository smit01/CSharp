using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0607_pick3 {
    public partial class Form1 : Form {
        private string DataFileName = @"c:\temp\lotto.xml";

        public Form1() {
            InitializeComponent();
            ReadData();
        }


        private void AddNewTextButton_Click(object sender, EventArgs e) {
            string sText = txtText.Text;
            LottoDataSet.Pick3Row dr = dsLotto.Pick3.NewPick3Row();
            dr.Text = sText;
            dsLotto.Pick3.AddPick3Row(dr);
            WriteData();
        }

        private void WriteData() {
            dsLotto.WriteXml(DataFileName);
        }
        private void ReadData() {
            // DataFileName = 
            //   System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Lotto.xml";
            DataFileName = test0607_pick3.Properties.Settings.Default.DataFileName;
            if (System.IO.File.Exists(DataFileName))
                dsLotto.ReadXml(DataFileName);
            // statistics..
        }
        private void btnDelete_Click(object sender, EventArgs e) {
            int iRow = bs.Position;
            dsLotto.Pick3.Rows.RemoveAt(iRow);
            WriteData();
        }
    }
}
