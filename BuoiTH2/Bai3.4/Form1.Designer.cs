namespace Bai3._4
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
            this.txtc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGiai = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(328, 227);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(176, 22);
            this.txtc.TabIndex = 74;
            this.txtc.TextChanged += new System.EventHandler(this.txtNam_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Nhap c:";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(328, 180);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(176, 22);
            this.txtb.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Nhap b:";
            // 
            // btnGiai
            // 
            this.btnGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiai.Location = new System.Drawing.Point(288, 336);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(173, 49);
            this.btnGiai.TabIndex = 70;
            this.btnGiai.Text = "Giai";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(328, 133);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(176, 22);
            this.txta.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Nhap a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 38);
            this.label3.TabIndex = 67;
            this.label3.Text = "GIAI PHUONG TRINH BAC HAI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(328, 276);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(176, 22);
            this.txtKetQua.TabIndex = 76;
            this.txtKetQua.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 75;
            this.label5.Text = "Ket qua:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Bai 3.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label5;
    }
}

