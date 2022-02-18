using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Quanlyhieubanh
{
    public partial class hethong : Form
    {

        public hethong()
        {
            InitializeComponent();

        }


        private void button7_Click(object sender, EventArgs e)
        {
            QuanLyTrangThai tt = new QuanLyTrangThai();
            tt.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap();
            dn.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon hd = new QuanLyHoaDon();
            hd.Show();
            this.Hide();
        }

        private void btndanhmuc_Click_1(object sender, EventArgs e)
        {
            QuanLyDanhMuc dm = new QuanLyDanhMuc();
            dm.Show();
            this.Hide();
        }

        private void btnnhacungcap_Click(object sender, EventArgs e)
        {
            QuanLyNhaCungCap ncc = new QuanLyNhaCungCap();
            ncc.Show();
            this.Hide();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien nv = new QuanLyNhanVien();
            nv.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang kh = new QuanLyKhachHang();
            kh.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();       
            dk.Show();
            this.Hide();
        }

        private void btnsp_Click(object sender, EventArgs e)
        {
            QuanLySanPham sp = new QuanLySanPham();
            sp.Show();
            this.Hide();
        }
    }
}
