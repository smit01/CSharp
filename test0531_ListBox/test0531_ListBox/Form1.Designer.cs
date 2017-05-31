namespace test0531_ListBox
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lstTest = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.lstFrom = new System.Windows.Forms.ListBox();
            this.lstTo = new System.Windows.Forms.ListBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstTest
            // 
            this.lstTest.FormattingEnabled = true;
            this.lstTest.ItemHeight = 24;
            this.lstTest.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.lstTest.Location = new System.Drawing.Point(33, 21);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(147, 172);
            this.lstTest.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(203, 21);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(145, 36);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(204, 66);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(143, 39);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "X";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(204, 111);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(143, 38);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "C -> CCC";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(203, 152);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(145, 41);
            this.SelectButton.TabIndex = 4;
            this.SelectButton.Text = "?";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // lstFrom
            // 
            this.lstFrom.FormattingEnabled = true;
            this.lstFrom.ItemHeight = 24;
            this.lstFrom.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.lstFrom.Location = new System.Drawing.Point(441, 21);
            this.lstFrom.Name = "lstFrom";
            this.lstFrom.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstFrom.Size = new System.Drawing.Size(147, 172);
            this.lstFrom.TabIndex = 5;
            // 
            // lstTo
            // 
            this.lstTo.FormattingEnabled = true;
            this.lstTo.ItemHeight = 24;
            this.lstTo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.lstTo.Location = new System.Drawing.Point(700, 21);
            this.lstTo.Name = "lstTo";
            this.lstTo.Size = new System.Drawing.Size(147, 172);
            this.lstTo.TabIndex = 6;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(605, 26);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(78, 40);
            this.CopyButton.TabIndex = 7;
            this.CopyButton.Text = ">>";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBox1.Location = new System.Drawing.Point(33, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 32);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(481, 221);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(365, 32);
            this.comboBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 287);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.lstTo);
            this.Controls.Add(this.lstFrom);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.lstTest);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTest;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.ListBox lstFrom;
        private System.Windows.Forms.ListBox lstTo;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

