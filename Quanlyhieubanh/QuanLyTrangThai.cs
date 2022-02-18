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
    public partial class QuanLyTrangThai : Form
    {
        public QuanLyTrangThai()
        {
            InitializeComponent();
        }

        private void TinhTrangDonHang_Load(object sender, EventArgs e)
        {
            clear();
            getdata();
        }

        public void getdata()
        {
            string query = "select * from TrangThai";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "TrangThai");
            dataGridView1.DataSource = ds.Tables["TrangThai"];
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            string MaTT = txtMaTrangThai.Text;
            string TenTT = txtTenTrangThai.Text;

   

            if (txtMaTrangThai.Text != "" && txtTenTrangThai.Text != "")
            {
                string query = "insert into TrangThai(id_tinhtrangdonhang, tinhtrangdonhang) values ('" + MaTT + "',N'" + TenTT + "')";
                ketnoi cn = new ketnoi();
                bool kt = cn.thucthi(query);
                if(kt == true)
                {
                    MessageBox.Show("Thêm trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getdata();
                    clear();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getdata();
                }
            }
            else
            {
                MessageBox.Show("Không được để trống ID trạng thái và tên trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        public void clear()
        {
            txtMaTrangThai.Text = "";
            txtTenTrangThai.Text = "";
            txtSMaTrangThai.Text = "";
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            txtMaTrangThai.Enabled = true;

        }

        string delete;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            string MaTT = txtMaTrangThai.Text;
            string TenTT = txtTenTrangThai.Text;
            string query = "update TrangThai set tinhtrangdonhang='" + TenTT + "'where id_tinhtrangdonhang='" + MaTT + "'";
            ketnoi cn = new ketnoi();
     
            bool kt = cn.thucthi(query);
            if (txtMaTrangThai.Text != "" && txtTenTrangThai.Text != "")
            {
                if (kt == true)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getdata();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không được để trống ID trạng thái và tên trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            var confrimResult = MessageBox.Show("Bạn có muốn xoá tình trạng đơn hàng có mã: " + delete + " không!", "Thông báo!", MessageBoxButtons.YesNo);
            if (confrimResult == DialogResult.Yes)
            {
                string query = "delete from TrangThai where id_tinhtrangdonhang = '" + delete + "'";
                ketnoi cn = new ketnoi();
                DataSet ds = new DataSet();
                bool kt = cn.thucthi(query);
                if (kt == true)
                {
                    MessageBox.Show("Bạn đã xoá trạng thái có mã: " + delete, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button_reset_Click(object sender, EventArgs e)
        {
            clear();
            getdata();
        }

        private void txtSMaTrangThai_TextChanged(object sender, EventArgs e)
        {
            string tim = txtSMaTrangThai.Text;
            string query = "select * from TrangThai where tinhtrangdonhang like N'%" + tim + "%'";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "TrangThai");
            dataGridView1.DataSource = ds.Tables["TrangThai"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hethong ht = new hethong();
            ht.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaTrangThai.Enabled = false;
                delete = dataGridView1.Rows[row].Cells["id_tinhtrangdonhang"].Value.ToString();
                txtMaTrangThai.Text = dataGridView1.Rows[row].Cells["id_tinhtrangdonhang"].Value.ToString();
                txtTenTrangThai.Text = dataGridView1.Rows[row].Cells["tinhtrangdonhang"].Value.ToString();
                button_sua.Enabled = true;
                button_xoa.Enabled = true;
                txtMaTrangThai.Enabled = false;

            }
        }
    }
}
