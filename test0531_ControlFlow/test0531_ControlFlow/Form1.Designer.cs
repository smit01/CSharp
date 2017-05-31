namespace test0531_ControlFlow {
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
            this.txtUserKeyin = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserKeyin
            // 
            this.txtUserKeyin.Location = new System.Drawing.Point(51, 34);
            this.txtUserKeyin.Name = "txtUserKeyin";
            this.txtUserKeyin.Size = new System.Drawing.Size(182, 36);
            this.txtUserKeyin.TabIndex = 0;
            this.txtUserKeyin.Text = "50";
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(261, 34);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(210, 35);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Is Correct?";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lstReport
            // 
            this.lstReport.FormattingEnabled = true;
            this.lstReport.ItemHeight = 24;
            this.lstReport.Location = new System.Drawing.Point(51, 95);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(420, 220);
            this.lstReport.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Swich";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstReport);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtUserKeyin);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserKeyin;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.Button button1;
    }
}

