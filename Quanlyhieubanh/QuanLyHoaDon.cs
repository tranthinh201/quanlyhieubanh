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
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.IO;


namespace Quanlyhieubanh
{
    public partial class QuanLyHoaDon : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U9JPINT;Initial Catalog=QuanLyTiemBanh;Integrated Security=True");

        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void banhang_Load(object sender, EventArgs e)
        {
            txtGiamGia.Text = "0";
           
            txtSoLuong.Text = "0";
            getComboMaSP();
            getComboMaKH();
            getComboMaNV();
            getComboMaTT();
            getHeaderText();
            loadData();

        }

        private void getComboMaSP()
        {
            string query = "select * from SanPham";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "SanPham");
            comboMaSP.DataSource = ds.Tables["SanPham"];
            comboMaSP.DisplayMember = "id_sanpham";
            comboMaSP.ValueMember = "id_sanpham";

        }

        private void getComboMaKH()
        {
            string query = "select * from KhachHang";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "KhachHang");
            comboMaKH.DataSource = ds.Tables["KhachHang"];
            comboMaKH.DisplayMember = "id_khachhang";
            comboMaKH.ValueMember = "id_khachhang";
        }

        private void getComboMaNV()
        {
            string query = "select * from NhanVien";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "NhanVien");
            comboMaNV.DataSource = ds.Tables["NhanVien"];
            comboMaNV.DisplayMember = "id_nhanvien";
            comboMaNV.ValueMember = "id_nhanvien";
        }

        


        private void getComboMaTT()
        {
            string query = "select * from TrangThai";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "TrangThai");
            comboMaTT.DataSource = ds.Tables["TrangThai"];
            comboMaTT.DisplayMember = "tinhtrangdonhang";
            comboMaTT.ValueMember = "id_tinhtrangdonhang";
        }



        private void loadData()
        {
            string query = "Select HoaDon.id_hoadon, tensanpham, giacu, SanPham.soluong, TrangThai.tinhtrangdonhang, id_khachhang, ngaytaodonhang, tongtien, ghichu From ChiTietHoaDon, HoaDon, SanPham, TrangThai where ChiTietHoaDon.id_hoadon = HoaDon.id_hoadon and ChiTietHoaDon.id_sanpham = SanPham.id_sanpham and TrangThai.id_tinhtrangdonhang = HoaDon.id_tinhtrangdonhang";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "ChiTietHoaDon, HoaDon");
            dgv.DataSource = ds.Tables["ChiTietHoaDon, HoaDon"];
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl14_Click(object sender, EventArgs e)
        {

        }

        private void comboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from KhachHang where id_khachhang = '"+ comboMaKH.SelectedValue.ToString()+ "'";
           
            conn.Open();
            SqlCommand cmd = new SqlCommand (query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                dr.Read();
                txtTenKhachHang.Text = dr.GetValue(1).ToString();
                txtEmail.Text = dr.GetValue(3).ToString();
                txtSDT.Text = dr.GetValue(2).ToString();
            }
            conn.Close();
        }

        private void comboMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from SanPham where id_sanpham = '" + comboMaSP.SelectedValue.ToString() + "'";
           
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
            
                txtTenSP.Text = dr.GetValue(2).ToString();
                txtDonGia.Text = dr.GetValue(6).ToString();
                
            }
            conn.Close();
        }


        private void comboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonTinhTien_Click(object sender, EventArgs e)
        {
            int soluong = Convert.ToInt32(txtSoLuong.Text);
            int dongia = Convert.ToInt32(txtDonGia.Text);
            int giamgia = Convert.ToInt32(txtGiamGia.Text);
            
            string query = "Select soluong From SanPham Where id_sanpham = '" + comboMaSP.SelectedValue + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            int total = soluong * dongia - giamgia;
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Không được để trống số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                MessageBox.Show("Không được để trống giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (soluong < 0 || giamgia < 0)
            {
                MessageBox.Show("Giá trị nhập vào không được âm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dr.HasRows)
            {
                dr.Read();
                int tonkho = Convert.ToInt32(dr.GetValue(0));
                if(tonkho < soluong)
                {   
                    MessageBox.Show("Số lượng mặt hàng này chỉ còn: " + tonkho, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Text = "";
                    txtSoLuong.Focus();

                }
                else
                {
                    txtThanhTien.Text = total.ToString();
                }
            }
            conn.Close();
        }

        private void buttonThemHoaDon_Click(object sender, EventArgs e)
        {
            string MaKH = comboMaKH.SelectedValue.ToString();
            string MaSP = comboMaSP.SelectedValue.ToString();
            int DonGia =  Convert.ToInt32(txtDonGia.Text);
            string MaTT = comboMaTT.SelectedValue.ToString();
            string GhiChu = txtGhiChuu.Text;
            string ThanhTien = txtThanhTien.Text;
            string MaHD = txtMaHoaDon.Text;
            string SoLuong = txtSoLuong.Text;
            string MaNV = comboMaNV.SelectedValue.ToString();
            if (string.IsNullOrWhiteSpace(txtThanhTien.Text) || string.IsNullOrWhiteSpace(txtSDT.Text) || string.IsNullOrWhiteSpace(txtGiamGia.Text) || string.IsNullOrWhiteSpace(txtThanhTien.Text) || string.IsNullOrWhiteSpace(txtTenNhanVien.Text) || string.IsNullOrWhiteSpace(txtTenKhachHang.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            } 
            else
            {
                string queryHD = "insert into HoaDon(id_hoadon, id_khachhang, id_tinhtrangdonhang, id_nhanvien, ngaytaodonhang, tongtien, ghichu) values ('" + MaHD + "','" + MaKH + "', '" + MaTT + "', '" + MaNV + "', '" + dateHoaDon.Value.Date + "', '" + ThanhTien + "', N'" + GhiChu + "')";
                ketnoi two = new ketnoi();
                bool ktDH =  two.thucthi(queryHD);
                //MessageBox.Show(queryHD);
                if (ktDH == true)
                {
                    string queryCTHD = "insert into ChiTietHoaDon(id_chitiet, id_hoadon, id_sanpham, giasanpham, soluong) values ('" + MaHD + "', '" + MaHD + "', '" + MaSP + "', '" + DonGia + "', '" + SoLuong + "')";
                    ketnoi one = new ketnoi();
                    bool ktCTDH = one.thucthi(queryCTHD);
                    if (ktCTDH == true)
                    {
                        MessageBox.Show("Thêm mới hoá đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Có gì đó sai sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm hoá đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

  

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        public void clear()
        {
            txtTenNhanVien.Text = "";
            txtTenKhachHang.Text = "";
            txtSoLuong.Text = "";
            txtSDT.Text = "";
            txtGiamGia.Text = "";
            txtEmail.Text = "";
            txtMaHoaDon.Text = "";
            txtGiamGia.Text = "0";
        
            txtThanhTien.Text = "";
            txtDonGia.Text = "";
            txtTenSP.Text = "";
        }

       
        private void comboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

            string query = "Select * from NhanVien where id_nhanvien = '" + comboMaNV.SelectedValue.ToString() + "'";

            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                txtTenNhanVien.Text = dr.GetValue(1).ToString();

            }
            conn.Close();
        }

 


        private void buttonReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        

        private void comboMaSP_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string query = "Select * from SanPham where id_sanpham = '" + comboMaSP.SelectedValue.ToString() + "'";

            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
    
                txtTenSP.Text = dr.GetValue(2).ToString();
                txtDonGia.Text = dr.GetValue(6).ToString();

            }
            conn.Close();
        }

        private void buttonXoaHD_Click(object sender, EventArgs e)
        {

            var confrimResult = MessageBox.Show("Bạn có muốn xoá hoá đơn có mã: " + delete + " không!", "Thông báo!", MessageBoxButtons.YesNo);
            if(confrimResult == DialogResult.Yes)
            {
                string query = "delete from ChiTietHoaDon where id_hoadon='" + delete + "'";
                ketnoi kn = new ketnoi();
                bool kt = kn.thucthi(query);
                if (kt == true)
                {
                    string DelHD = "delete from HoaDon where id_hoadon='" + delete + "'";
                    ketnoi del = new ketnoi();
                    bool check = del.thucthi(DelHD);
                    if (check == true)
                    {   
                        MessageBox.Show("Bạn đã xoá hoá đơn có mã: " + delete, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
            
          
        }
        string delete;
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                delete = dgv.Rows[row].Cells["id_hoadon"].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tim = txtTimKiem.Text;
            string query = "select * from HoaDon where id_hoadon like'%" + tim + "%'";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "HoaDon");
            dgv.DataSource = ds.Tables["HoaDon"];
        }

        

        private void buttonInHoaDon_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Export Excel";
            sfd.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ToExcel(sfd.FileName);
                    MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ToExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for(int i = 0; i < dgv.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
            }
            for(int i = 0; i < dgv.Rows.Count; i++)
            {
                for(int j = 0; j < dgv.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;

        }


        private void buttonThoat_Click(object sender, EventArgs e)
        {
            hethong ht = new hethong();
            ht.Show();
            this.Hide();
        }
        

        public void getHeaderText()
        {
           

        }

    }

}
