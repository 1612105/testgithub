using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dang_Nhap
{
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }

        private void txtDangNhap_Click(object sender, EventArgs e)
        {
            Form1 dangnhap = new Form1();
            dangnhap.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 dangki = new Form2();
            dangki.Show();
            this.Hide();
        }

        private void btnThoathethong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
