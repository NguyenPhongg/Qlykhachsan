using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace quanlykhachsan
{
    public partial class frmGiaodienchinh : Form
    {
        public frmGiaodienchinh()
        {
            InitializeComponent();
        }
        private void mnuQL_QLkhachhang_Click(object sender, EventArgs e)
        {
            QL_Khachhang f = new QL_Khachhang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mnuQL_QLphong_Click(object sender, EventArgs e)
        {
            QLPhong f = new QLPhong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void mnuQL_QLdichvu_Click(object sender, EventArgs e)
        {
            QL_Dichvu f = new QL_Dichvu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void mnuChucNang_Thuephong_Click(object sender, EventArgs e)
        {
            Thuephong f = new Thuephong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void mnuChucNang_Traphong_Click(object sender, EventArgs e)
        {
            traphong2 f = new traphong2();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void mnuTK_Khachhang_Click(object sender, EventArgs e)
        {
            timkiemkhachhang f = new timkiemkhachhang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void mnuTK_Phong_Click(object sender, EventArgs e)
        {
            timkiemphong f = new timkiemphong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void sửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hoadondichvu f = new hoadondichvu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void mnuHT_QLtaikhoan_Click(object sender, EventArgs e)
        {
            thongtin f = new thongtin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void mnuQL_QLhoadon_Click(object sender, EventArgs e)
        {
            QL_HOADON f = new QL_HOADON();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void quảnLýHóaĐơnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlhoadondv f = new qlhoadondv();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void doanhThuPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKDOANHTHUPHONG f = new TKDOANHTHUPHONG();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void doanhThuDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKDOANHTHUDV f = new TKDOANHTHUDV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
