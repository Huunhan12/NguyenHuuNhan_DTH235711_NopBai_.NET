namespace Bai3._1
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
            this.btnTInh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtf = new System.Windows.Forms.TextBox();
            this.txtx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTInh
            // 
            this.btnTInh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTInh.Location = new System.Drawing.Point(297, 271);
            this.btnTInh.Name = "btnTInh";
            this.btnTInh.Size = new System.Drawing.Size(148, 49);
            this.btnTInh.TabIndex = 53;
            this.btnTInh.Text = "Tính";
            this.btnTInh.UseVisualStyleBackColor = true;
            this.btnTInh.Click += new System.EventHandler(this.btnTInh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 38);
            this.label3.TabIndex = 50;
            this.label3.Text = "TINH GIA TRI HAM SO";
            // 
            // txtf
            // 
            this.txtf.Location = new System.Drawing.Point(297, 220);
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(176, 22);
            this.txtf.TabIndex = 49;
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(297, 181);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(176, 22);
            this.txtx.TabIndex = 48;
            this.txtx.TextChanged += new System.EventHandler(this.txta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "f = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "x = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTInh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bài 3.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTInh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

