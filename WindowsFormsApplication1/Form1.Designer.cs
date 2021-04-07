namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMethod1 = new System.Windows.Forms.Button();
            this.btnMethod2 = new System.Windows.Forms.Button();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.txtCSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMethod1 = new System.Windows.Forms.Label();
            this.lblMethod2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMethod1
            // 
            this.btnMethod1.Location = new System.Drawing.Point(43, 148);
            this.btnMethod1.Name = "btnMethod1";
            this.btnMethod1.Size = new System.Drawing.Size(75, 23);
            this.btnMethod1.TabIndex = 0;
            this.btnMethod1.Text = "Method 1";
            this.btnMethod1.UseVisualStyleBackColor = true;
            this.btnMethod1.Click += new System.EventHandler(this.btnMethod1_Click);
            // 
            // btnMethod2
            // 
            this.btnMethod2.Location = new System.Drawing.Point(43, 194);
            this.btnMethod2.Name = "btnMethod2";
            this.btnMethod2.Size = new System.Drawing.Size(75, 23);
            this.btnMethod2.TabIndex = 1;
            this.btnMethod2.Text = "Method 2";
            this.btnMethod2.UseVisualStyleBackColor = true;
            this.btnMethod2.Click += new System.EventHandler(this.btnMethod2_Click);
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(43, 42);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(312, 20);
            this.txtDB.TabIndex = 2;
            // 
            // txtCSV
            // 
            this.txtCSV.Location = new System.Drawing.Point(43, 97);
            this.txtCSV.Name = "txtCSV";
            this.txtCSV.Size = new System.Drawing.Size(312, 20);
            this.txtCSV.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CSV:";
            // 
            // lblMethod1
            // 
            this.lblMethod1.AutoSize = true;
            this.lblMethod1.Location = new System.Drawing.Point(142, 153);
            this.lblMethod1.Name = "lblMethod1";
            this.lblMethod1.Size = new System.Drawing.Size(10, 13);
            this.lblMethod1.TabIndex = 6;
            this.lblMethod1.Text = "-";
            // 
            // lblMethod2
            // 
            this.lblMethod2.AutoSize = true;
            this.lblMethod2.Location = new System.Drawing.Point(142, 199);
            this.lblMethod2.Name = "lblMethod2";
            this.lblMethod2.Size = new System.Drawing.Size(10, 13);
            this.lblMethod2.TabIndex = 7;
            this.lblMethod2.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 242);
            this.Controls.Add(this.lblMethod2);
            this.Controls.Add(this.lblMethod1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCSV);
            this.Controls.Add(this.txtDB);
            this.Controls.Add(this.btnMethod2);
            this.Controls.Add(this.btnMethod1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMethod1;
        private System.Windows.Forms.Button btnMethod2;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.TextBox txtCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMethod1;
        private System.Windows.Forms.Label lblMethod2;
    }
}

