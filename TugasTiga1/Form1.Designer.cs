
namespace TugasTiga1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.txtPesan1 = new System.Windows.Forms.TextBox();
            this.txtPesan3 = new System.Windows.Forms.TextBox();
            this.txtPesan2 = new System.Windows.Forms.TextBox();
            this.btnKosongkan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nim";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.BackColor = System.Drawing.SystemColors.Control;
            this.btnTampilkan.Location = new System.Drawing.Point(52, 225);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(174, 40);
            this.btnTampilkan.TabIndex = 3;
            this.btnTampilkan.Text = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor = false;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // txtPesan1
            // 
            this.txtPesan1.BackColor = System.Drawing.SystemColors.Control;
            this.txtPesan1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesan1.Enabled = false;
            this.txtPesan1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPesan1.Location = new System.Drawing.Point(93, 22);
            this.txtPesan1.Name = "txtPesan1";
            this.txtPesan1.Size = new System.Drawing.Size(181, 19);
            this.txtPesan1.TabIndex = 5;
            this.txtPesan1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPesan3
            // 
            this.txtPesan3.BackColor = System.Drawing.SystemColors.Control;
            this.txtPesan3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesan3.Enabled = false;
            this.txtPesan3.Location = new System.Drawing.Point(93, 107);
            this.txtPesan3.Name = "txtPesan3";
            this.txtPesan3.Size = new System.Drawing.Size(181, 19);
            this.txtPesan3.TabIndex = 6;
            this.txtPesan3.TextChanged += new System.EventHandler(this.txtPesan3_TextChanged);
            // 
            // txtPesan2
            // 
            this.txtPesan2.BackColor = System.Drawing.SystemColors.Control;
            this.txtPesan2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesan2.Enabled = false;
            this.txtPesan2.Location = new System.Drawing.Point(93, 64);
            this.txtPesan2.Name = "txtPesan2";
            this.txtPesan2.Size = new System.Drawing.Size(181, 19);
            this.txtPesan2.TabIndex = 7;
            this.txtPesan2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnKosongkan
            // 
            this.btnKosongkan.BackColor = System.Drawing.SystemColors.Control;
            this.btnKosongkan.Location = new System.Drawing.Point(232, 225);
            this.btnKosongkan.Name = "btnKosongkan";
            this.btnKosongkan.Size = new System.Drawing.Size(174, 40);
            this.btnKosongkan.TabIndex = 8;
            this.btnKosongkan.Text = "Kosongkan";
            this.btnKosongkan.UseVisualStyleBackColor = false;
            this.btnKosongkan.Click += new System.EventHandler(this.btnKosongkan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPesan2);
            this.groupBox1.Controls.Add(this.txtPesan3);
            this.groupBox1.Controls.Add(this.txtPesan1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 149);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 320);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKosongkan);
            this.Controls.Add(this.btnTampilkan);
            this.Name = "Form1";
            this.Text = "Tugas 3.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.TextBox txtPesan1;
        private System.Windows.Forms.TextBox txtPesan3;
        private System.Windows.Forms.TextBox txtPesan2;
        private System.Windows.Forms.Button btnKosongkan;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

