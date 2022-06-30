using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace quanlykhachsan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtManv.Focus();
            txtUsername.Focus();
            txtPass.Focus();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source = ADMINISTRATOR\SQLEXPRESS; Initial Catalog = quanlykhachsandemo2304; User ID = sa");
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=tunguyen;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Open();
                string sql = @"select *from tbl_taikhoan where USENAME=N'" + txtUsername.Text + @"' and PASS=N'" + txtPass.Text + @"' and MANHANVIEN=N'" + txtManv.Text + @"'";
                SqlCommand cmd = new SqlCommand(sql, kn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Thuephong.MANV = txtManv.Text.Trim();
                    frmGiaodienchinh f = new frmGiaodienchinh();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công");
                }

            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
            finally
            {
                SqlConnection kn = new SqlConnection(@"Data Source=tunguyen;Initial Catalog=quanlykhachsandemo2304;Integrated Security=True");
                kn.Close();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'quanlykhachsandemo2304DataSet.tbl_taikhoan' table. You can move, or remove it, as needed.
            //this.tbl_taikhoanTableAdapter.Fill(this.quanlykhachsandemo2304DataSet.tbl_taikhoan);

        }

        private void tbltaikhoanBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

