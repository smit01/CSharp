namespace test0602_Sender {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.btnAddA = new System.Windows.Forms.Button();
            this.btnLessA = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnAddB = new System.Windows.Forms.Button();
            this.btnLessB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddA
            // 
            this.btnAddA.Location = new System.Drawing.Point(31, 39);
            this.btnAddA.Name = "btnAddA";
            this.btnAddA.Size = new System.Drawing.Size(233, 66);
            this.btnAddA.TabIndex = 0;
            this.btnAddA.Text = "A";
            this.btnAddA.UseVisualStyleBackColor = true;
            this.btnAddA.Click += new System.EventHandler(this.btnAddA_Click);
            // 
            // btnLessA
            // 
            this.btnLessA.Location = new System.Drawing.Point(655, 39);
            this.btnLessA.Name = "btnLessA";
            this.btnLessA.Size = new System.Drawing.Size(206, 70);
            this.btnLessA.TabIndex = 1;
            this.btnLessA.Text = "-A";
            this.btnLessA.UseVisualStyleBackColor = true;
            this.btnLessA.Click += new System.EventHandler(this.btnLessA_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(330, 87);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(246, 84);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnAddB
            // 
            this.btnAddB.Location = new System.Drawing.Point(31, 134);
            this.btnAddB.Name = "btnAddB";
            this.btnAddB.Size = new System.Drawing.Size(232, 76);
            this.btnAddB.TabIndex = 3;
            this.btnAddB.Text = "B";
            this.btnAddB.UseVisualStyleBackColor = true;
            this.btnAddB.Click += new System.EventHandler(this.btnAddB_Click);
            // 
            // btnLessB
            // 
            this.btnLessB.Location = new System.Drawing.Point(655, 146);
            this.btnLessB.Name = "btnLessB";
            this.btnLessB.Size = new System.Drawing.Size(206, 64);
            this.btnLessB.TabIndex = 4;
            this.btnLessB.Text = "-B";
            this.btnLessB.UseVisualStyleBackColor = true;
            this.btnLessB.Click += new System.EventHandler(this.btnLessB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 64);
            this.button2.TabIndex = 6;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 64);
            this.button3.TabIndex = 7;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLessB);
            this.Controls.Add(this.btnAddB);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnLessA);
            this.Controls.Add(this.btnAddA);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddA;
        private System.Windows.Forms.Button btnLessA;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnAddB;
        private System.Windows.Forms.Button btnLessB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

