using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Dang_Nhap
{
    public partial class Form2 : Form
    {

 

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text == "" || txtEmail.Text == "" || txthoten.Text == "" || txtTenDN.Text == "" || txtpass.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin vào vị trí có(*)!");
            }
            else if (txtpass.Text != txtconfirmpass.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không chính xác!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3QHMVMG\SQLEXPRESS;Initial Catalog=QUANLYKHACHSAN;Integrated Security=True");
                try
                {
                    conn.Open();
                    string req1 = "SELECT COUNT(*) FROM KHACHHANG";
                    SqlCommand comm = new SqlCommand(req1, conn);
                    Int32 count = (Int32)comm.ExecuteScalar();

                    string mkh = "";
                    if (count + 1 < 10)
                    {
                        mkh = "KH000000" + (count + 1).ToString();
                    }
                    else if (count + 1 < 100)
                    {
                        mkh = "KH00000" + (count + 1).ToString();
                    }
                    else if (count + 1 < 1000)
                    {
                        mkh = "KH0000" + (count + 1).ToString();
                    }
                    else if (count + 1 < 10000)
                    {
                        mkh = "KH000" + (count + 1).ToString();
                    }
                    else if (count + 1 < 100000)
                    {
                        mkh = "KH00" + (count + 1).ToString();
                    }
                    else if (count + 1 < 1000000)
                    {
                        mkh = "KH0" + (count + 1).ToString();
                    }
                    else if ((count + 1 >= 1000000) && (count + 1 <= 5000000))
                    {
                        mkh = "KH" + (count + 1).ToString();
                    }

                    string tdn = txtTenDN.Text;
                    string sq = "select * from KHACHHANG where tenDangNhap= '" + tdn + "' ";
                    SqlCommand cd = new SqlCommand(sq, conn);
                    SqlDataReader dt = cd.ExecuteReader();

                    if (dt.Read() == true)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại. Hãy dùng tên đăng nhập khác!");
                    }
                    else
                    {

                        // SqlCommand ad= new SqlCommand("insert into KHACHHANG(maKH,hoTen,tenDangNhap,matKhau,soCMND,diaChi,soDienThoai,moTa,email) values('" + mkh+ "','" + txthoten.Text + "','" + txtTenDN.Text + "','" + txtpass.Text + "','" + txtCMND.Text + "','" + txtdiachi.Text + "','" + txtSDT.Text + "','" + txtmota.Text + "','" + txtEmail.Text + "');", conn);
                        SqlCommand ad = new SqlCommand("insert into KHACHHANG(maKH,hoTen,tenDangNhap,matKhau,soCMND,diaChi,soDienThoai,moTa,email) values(@makh,@hoten,@tendangnhap,@matkhau,@socmnd,@diachi,@sdt,@mota,@email)", conn);
                        ad.Parameters.Add("@makh", SqlDbType.NVarChar).Value = mkh;
                        ad.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = txthoten.Text;
                        ad.Parameters.Add("@tendangnhap", SqlDbType.NVarChar).Value = txtTenDN.Text;
                        ad.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = txtpass.Text;
                        ad.Parameters.Add("@socmnd", SqlDbType.NVarChar).Value = txtCMND.Text;
                        ad.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = txtdiachi.Text;
                        ad.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = txtSDT.Text;
                        ad.Parameters.Add("@mota", SqlDbType.NVarChar).Value = txtmota.Text;
                        ad.Parameters.Add("@email", SqlDbType.NVarChar).Value = txtEmail.Text;
                        dt.Close();
                        ad.ExecuteNonQuery();
                        MessageBox.Show("Đăng kí thành công!");
                        conn.Close();
                        txthoten.Clear();
                        txtTenDN.Clear();
                        txtpass.Clear();
                        txtCMND.Clear();
                        txtdiachi.Clear();
                        txtSDT.Clear();
                        txtmota.Clear();
                        txtEmail.Clear();
                        txtconfirmpass.Clear();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi kết nối");
                }
            }
        }
        public static void main(string[] arg)
        {
            Application.Run(new Form2());
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            Init init = new Init();
            init.Show();
            this.Hide();
        }
    }
}
