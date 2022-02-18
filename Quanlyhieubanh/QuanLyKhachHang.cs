using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.DataAccess.Native.DataFederation.QueryBuilder.AvailableItemData;

namespace Quanlyhieubanh
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }



        public void getdata()
        {
            string query = "select * from KhachHang";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "KhachHang");
            dataGridView1.DataSource = ds.Tables["KhachHang"];
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            string tim = txtSPhone.Text;
            string query = "select * from KhachHang where sodienthoai='" + tim + "'";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "GiaoTrinh");
            dataGridView1.DataSource = ds.Tables["GiaoTrinh"];
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            var confrimResult = MessageBox.Show("Bạn có muốn xoá khách hàng có mã: " + delete + " không!", "Thông báo!", MessageBoxButtons.YesNo);
            if (confrimResult == DialogResult.Yes)
            {
                string query = "delete from KhachHang where id_khachhang = '" + delete + "'";
                ketnoi cn = new ketnoi();
                DataSet ds = new DataSet();
                bool kt = cn.thucthi(query);
                if(kt == true)
                {
                    MessageBox.Show("Bạn đã xoá khách hàng có mã: " + delete, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button_sua_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string Ten = txtName.Text;
            string SDT = txtPhone.Text;
            string Email = txtEmail.Text;
            if(txtID.Text != "" && txtEmail.Text != "" && txtID.Text != "" && txtPhone.Text != "")
            {
                string query = "update KhachHang set ten_khachhang=N'" + Ten + "', sodienthoai='" + SDT + "', Email='" + Email + "'where id_khachhang='" + ID + "'";
                ketnoi cn = new ketnoi();
                bool kt = cn.thucthi(query);
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
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            clear();
            getdata();
        }

       

        private void button_them_Click(object sender, EventArgs e)
        {
            string ID = txtID.Text;
            string Ten = txtName.Text;
            string SDT = txtPhone.Text;
            string Email = txtEmail.Text;

            string search = "select count(*) from KhachHang where sodienthoai ='" + SDT + "'";
            ketnoi check = new ketnoi();
            DataSet data = new DataSet();
            data = check.laydulieu(search, "KhachHang");

            if ((int)data.Tables["KhachHang"].Rows[0].ItemArray[0] > 1)
            {
                MessageBox.Show("Số điện thoại này đã có trong database!. Vui lòng đăng ký số điện thoại khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtID.Text != "" && txtEmail.Text != "" && txtID.Text != "" && txtPhone.Text != "")
            {
                string query = "insert into KhachHang(id_khachhang, ten_khachhang, sodienthoai, email) values ('" + ID + "',N'" + Ten + "','" + SDT + "','" + Email + "')";
                ketnoi cn = new ketnoi();
                bool kt = cn.thucthi(query);
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getdata();
                clear();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình thêm khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getdata();
            }
            

        }

        private void khachhang_Load(object sender, EventArgs e)
        {
            button_them.Enabled = true;
            clear();
            getdata();
        }

        string delete;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {   
                delete = dataGridView1.Rows[row].Cells["id_khachhang"].Value.ToString();
                txtID.Text = dataGridView1.Rows[row].Cells["id_khachhang"].Value.ToString();
                txtName.Text = dataGridView1.Rows[row].Cells["ten_khachhang"].Value.ToString(); 
                txtPhone.Text = dataGridView1.Rows[row].Cells["sodienthoai"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[row].Cells["email"].Value.ToString();
                button_sua.Enabled = true;
                button_xoa.Enabled = true;
                button_them.Enabled = false;
                txtID.Enabled = false;

            }
        }

        public void clear()
        {
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
            txtEmail.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtSPhone.Text = "";
            txtID.Text = "";
            txtID.Enabled = true;
        }

        private void txtSPhone_TextChanged(object sender, EventArgs e)
        {
            string tim = txtSPhone.Text;
            string query = "select * from KhachHang where sodienthoai='" + tim + "'";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "KhachHang");
            dataGridView1.DataSource = ds.Tables["KhachHang"];
            getdata();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            hethong ht = new hethong();
            ht.Show();
            this.Hide();
        }
    }

}
