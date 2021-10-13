using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            txtPesan1.Text = string.Format("Suryo Ragil Pamungkas");
            txtPesan2.Text = string.Format("20.11.3629");
            txtPesan3.Text = string.Format("Informatika 06");
            btnTampilkan.BackColor = Color.LightGreen;
            btnTampilkan.ForeColor = Color.White;
        }

        private void btnKosongkan_Click(object sender, EventArgs e)
        {
            txtPesan1.Text = string.Format(" ");
            txtPesan2.Text = string.Format(" ");
            txtPesan3.Text = string.Format(" ");
            btnKosongkan.BackColor = Color.Red;
            btnKosongkan.ForeColor = Color.White;
        }

        private void txtPesan3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
