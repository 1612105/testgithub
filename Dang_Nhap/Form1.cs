using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dang_Nhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string value = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                value = radioButton1.Text;
            else
                value = radioButton2.Text;

            SqlConnection comn = new SqlConnection(@"Data Source=DESKTOP-3QHMVMG\SQLEXPRESS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
            if (value == radioButton2.Text)
            {
                try
                {
                    comn.Open();
                    string tk = txtTenDangNhap.Text;
                    string mk = txtMatKhau.Text;
                    string sql = "select* from KHACHHANG where tenDangNhap ='" + tk + "' and matKhau ='" + mk + "'";
                    SqlCommand cmd = new SqlCommand(sql, comn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        txtTenDangNhap.Clear();
                        txtMatKhau.Clear();
                        MessageBox.Show("Xin chào " + dta["maKH"].ToString() + " " + dta["hoTen"].ToString() + "!");
                        radioButton2.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa đăng kí tài khoản hoặc đăng nhập không đúng.Nhập lại thông tin!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối");
                }
            }
            else
            {
                try
                {
                    comn.Open();
                    string tk = txtTenDangNhap.Text;
                    string mk = txtMatKhau.Text;
                    string sql = "select* from NHANVIEN where tenDangNhap ='" + tk + "' and matKhau ='" + mk + "'";
                    SqlCommand cmd = new SqlCommand(sql, comn);
                    SqlDataReader dta = cmd.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        txtTenDangNhap.Clear();
                        txtMatKhau.Clear();
                        MessageBox.Show("Xin chào " + dta["maNV"].ToString() + " " + dta["hoTen"].ToString() + "!");
                        radioButton1.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập không đúng.Nhập lại thông tin!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Init exit = new Init();
            exit.Show();
            this.Hide();
        }
    }
}
