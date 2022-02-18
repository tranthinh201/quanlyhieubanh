using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlyhieubanh
{
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hethong ht = new hethong();
            ht.Show();
            this.Hide();
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            getcbDM();
            getdata();
            getcbNcc();
            cbDm.SelectedValue = 0;
            cbNcc.SelectedValue = 0;
        }

        public void getcbDM()
        {
            string query = "select * from DanhMuc";
            ketnoi kn = new ketnoi();
            DataSet ds = new DataSet();
            ds = kn.laydulieu(query, "DanhMuc");

            cbDm.DataSource = ds.Tables["DanhMuc"];
            cbDm.DisplayMember = "ten_danhmuc";
            cbDm.ValueMember = "id_danhmuc";
        }
        public void getcbNcc()
        {
            string query = "select *from NhaCungCap";
            ketnoi kn = new ketnoi();
            DataSet ds = new DataSet();
            ds = kn.laydulieu(query, "NhaCungCap");

            cbNcc.DataSource = ds.Tables["NhaCungCap"];
            cbNcc.DisplayMember = "tennhacungcap";
            cbNcc.ValueMember = "id_nhacungcap";
        }
        public void getdata()
        {
            string query = "select * from SanPham";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "SanPham");
            dgv.DataSource = ds.Tables["SanPham"];

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ketnoi kn = new ketnoi();
            string msp = txtID.Text;
            string tsp = txtTensp.Text;
            string td = txtTieude.Text;

            int sl = int.Parse(txtSl.Text);
            string mdm = cbDm.SelectedValue.ToString();
            string mncc = cbNcc.SelectedValue.ToString();

            int giacu = int.Parse(txtGiacu.Text);
            int giamoi = int.Parse(txtGiamoi.Text);

            bool kt = giacu > giamoi;

            if (txtID.Text != "" && txtTensp.Text != "" && txtTieude.Text != "" && txtGiacu.Text != "" && txtSl.Text != "" && txtSl.Text != "" && cbDm.SelectedValue.ToString() != "" && cbNcc.SelectedValue.ToString() != "" && kt == true)
            {

                string query = "insert into SanPham(id_sanpham,id_danhmuc,id_nhacungcap,tensanpham,tieude,giacu,giamoi,soluong) values ('" + msp + "','" + mdm + "','" + mncc + "',N'" + tsp + "',N'" + td + "','" + giacu + "','" + giamoi + "','" + sl + "')";

                DataSet ds = new DataSet();
                kn.thucthi(query);

                MessageBox.Show("thêm mới thành công!");
                txtID.Focus();
                getdata();
            }
            else
            {
                MessageBox.Show("bạn nhập thiếu thông tin hoặc nhập sai giá bán!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string msp = txtID.Text;


            if (txtID.Text != "" && txtTensp.Text != "" && txtTieude.Text != "" && txtGiacu.Text != "" && txtGiamoi.Text != "" && txtSl.Text != "" && cbDm.SelectedValue.ToString() != "" && cbNcc.SelectedValue.ToString() != "")
            {
                string query = "delete from SanPham where id_sanpham='" + msp + "'";
                ketnoi kn = new ketnoi();
                DataSet ds = new DataSet();
                kn.thucthi(query);
                MessageBox.Show("xoa thanh cong!");
                getdata();
            }
            else
            {
                MessageBox.Show("xoa that bai!");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtID.Text = "";
            txtTensp.Text = "";
            txtTieude.Text = "";
            txtSl.Text = "";
            txtGiacu.Text = "";
            txtGiamoi.Text = "";
            cbDm.SelectedValue = 0;
            cbNcc.SelectedValue = 0;
            getdata();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtID.Enabled = false;
                txtID.Text = dgv.Rows[row].Cells["id_sanpham"].Value.ToString();
                cbDm.SelectedValue = dgv.Rows[row].Cells["id_danhmuc"].Value.ToString();
                txtTensp.Text = dgv.Rows[row].Cells["tensanpham"].Value.ToString();
                txtTieude.Text = dgv.Rows[row].Cells["tieude"].Value.ToString();
                txtGiacu.Text = dgv.Rows[row].Cells["giacu"].Value.ToString();
                txtSl.Text = dgv.Rows[row].Cells["soluong"].Value.ToString();
                txtGiamoi.Text = dgv.Rows[row].Cells["giamoi"].Value.ToString();
                cbNcc.SelectedValue = dgv.Rows[row].Cells["id_nhacungcap"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string msp = txtID.Text;
            string tsp = txtTensp.Text;
            string td = txtTieude.Text;

            int sl = int.Parse(txtSl.Text); ;
            string mdm = cbDm.SelectedValue.ToString();
            string mncc = cbNcc.SelectedValue.ToString();
            int giacu = int.Parse(txtGiacu.Text);
            int giamoi = int.Parse(txtGiamoi.Text);

            bool kt = giacu > giamoi;
            if (txtID.Text != "" && txtTensp.Text != "" && txtTieude.Text != "" && txtGiacu.Text != "" && txtGiamoi.Text != "" && txtSl.Text != "" && cbDm.SelectedValue.ToString() != "" && cbNcc.SelectedValue.ToString() != "" && kt == true)
            {
                string query = "update SanPham set tensanpham='" + tsp + "',tieude='" + td + "',soluong='" + sl + "',id_danhmuc='" + mdm + "',id_nhacungcap='" + mncc + "',giacu='" + giacu + "',giamoi='" + giamoi + "' where id_sanpham='" + msp + "'";
                ketnoi cn = new ketnoi();
                DataSet ds = new DataSet();
                cn.thucthi(query);

                MessageBox.Show("sua thanh cong!");
                getdata();
            }
            else
            {
                MessageBox.Show("sua that bai");
            }
        }

        private void txtsearcj_TextChanged(object sender, EventArgs e)
        {
            
                string tim = txtsearcj.Text;
                string query = "select * from SanPham where tensanpham like'%" + tim + "%'";
                ketnoi cn = new ketnoi();
                DataSet ds = new DataSet();
                ds = cn.laydulieu(query, "SanPham");
                dgv.DataSource = ds.Tables["SanPham"];
          }
    }
}
 
