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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hethong ht = new hethong();
            ht.Show();
            this.Hide();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            getdata();
        }

        public void getdata()
        {
            string query = "select * from NhanVien";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "NhanVien");
            dgv.DataSource = ds.Tables["NhanVien"];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ketnoi cn = new ketnoi();
            string mnv = txtID.Text;
            string tnv = txttennv.Text;
            string cmnd = txtcmnd.Text;
            int sdt = int.Parse(txtsdt.Text);
            string diachi = txtdiachi.Text;

            if (txtID.Text != "" && txttennv.Text != "" && txtsdt.Text != "" && txtcmnd.Text != "" && txtdiachi.Text != "")
            {

                string query = "insert into NhanVien(id_nhanvien,tennhanvien,cmnd,sdt,diachi) values ('" + mnv + "',N'" + tnv + "','" + cmnd + "','" + sdt + "', N'" + diachi + "')";

                DataSet ds = new DataSet();
                cn.thucthi(query);

                MessageBox.Show("them thanh cong!");
                txtID.Focus();
                getdata();
            }
            else
            {
                MessageBox.Show("them that bai!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string mnv = txtID.Text;


            if (txtID.Text != "" && txttennv.Text != "" && txtsdt.Text != "" && txtcmnd.Text != "" && txtdiachi.Text != "")
            {
                string query = "delete from NhanVien where id_nhanvien='" + mnv + "'";
                ketnoi cn = new ketnoi();
                DataSet ds = new DataSet();
                cn.thucthi(query);
                MessageBox.Show("xoa thanh cong!");

                getdata();
            }
            else
            {
                MessageBox.Show("xoa that bai!");
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txttennv.Text = "";
            txtsdt.Text = "";
            txtcmnd.Text = "";
            txtdiachi.Text = "";
            txtID.Enabled = true;
            getdata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string mnv = txtID.Text;
            string tnv = txttennv.Text;
            string cmnd = txtcmnd.Text;
            int sdt = int.Parse(txtsdt.Text);
            string diachi = txtdiachi.Text;

            if (txtID.Text != "" && txttennv.Text != "" && txtsdt.Text != "" && txtcmnd.Text != "" && txtdiachi.Text != "")
            {
                string query = "update NhanVien set tennhanvien=N'" + tnv + "',cmnd='" + cmnd + "',sdt='" + sdt + "',diachi=N'" + diachi + "' where id_nhanvien='" + mnv + "'";
                ketnoi cn = new ketnoi();
                DataSet ds = new DataSet();
                cn.thucthi(query);

                MessageBox.Show("sua thanh cong!");
                getdata();
            }
            else
            {
                MessageBox.Show("sua that bai!");
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string tim = txtsearch.Text;
            string query = "select * from NhanVien where tennhanvien like'%" + tim + "%'";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "NhanVien");
            dgv.DataSource = ds.Tables["NhanVien"];
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtID.Enabled = false;
                txtID.Text = dgv.Rows[row].Cells["id_nhanvien"].Value.ToString();
                txttennv.Text = dgv.Rows[row].Cells["tennhanvien"].Value.ToString();
                txtcmnd.Text = dgv.Rows[row].Cells["cmnd"].Value.ToString();
                txtsdt.Text = dgv.Rows[row].Cells["sdt"].Value.ToString();
                txtdiachi.Text = dgv.Rows[row].Cells["diachi"].Value.ToString();


            }
        }
    }
}
