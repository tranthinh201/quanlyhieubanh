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
    public partial class QuanLyNhaCungCap : Form
    {
        public QuanLyNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            hethong ht = new hethong();
            ht.Show();
            this.Hide();
        }

        public void getdata()
        {
            string query = "select * from NhaCungCap";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "NhaCungCap");
            dgv.DataSource = ds.Tables["NhaCungCap"];

        }

        public void Textnhe()
        {
            txtID.Text = null;
            txtTenncc.Text = null;
            txtsdt.Text = null;
            txtemail.Text = null;
            txtdiachi.Text = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ketnoi cn = new ketnoi();
            string mncc = txtID.Text;
            string tncc = txtTenncc.Text;
            string email = txtemail.Text;
            string sdt = txtsdt.Text;
            string diachi = txtdiachi.Text;

            if (txtID.Text != "" && txtTenncc.Text != "" && txtsdt.Text != "" && txtemail.Text != "" && txtdiachi.Text != "")
            {

                string query = "insert into NhaCungcap(id_nhacungcap,tennhacungcap,email,sodienthoai,diachi) values ('" + mncc + "',N'" + tncc + "','" + email + "','" + sdt + "',N'" + diachi + "')";

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

        private void QuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string mncc = txtID.Text;


            if (txtID.Text != "" && txtTenncc.Text != "" && txtsdt.Text != "" && txtemail.Text != "" && txtdiachi.Text != "")
            {
                string query = "delete from NhaCungCap where id_nhacungcap='" + mncc + "'";
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

        private void btnreset_Click(object sender, EventArgs e)
        {

            txtID.Text = "";
            txtTenncc.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            txtdiachi.Text = "";
            txtID.Enabled = true;
            getdata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mncc = txtID.Text;
            string tncc = txtTenncc.Text;
            string email = txtemail.Text;
            string sdt = txtsdt.Text;
            string diachi = txtdiachi.Text;

            if (txtID.Text != "" && txtTenncc.Text != "" && txtsdt.Text != "" && txtemail.Text != "" && txtdiachi.Text != "")
            {
                string query = "update NhaCungCap set tennhacungcap=N'" + tncc + "',email='" + email + "',sodienthoai='" + sdt + "',diachi=N'" + diachi + "' where id_nhacungcap='" + mncc + "'";
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string tim = txtSearch.Text;
            string query = "select * from NhaCungCap where tennhacungcap like'%" + tim + "%'";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "NhaCungCap");
            dgv.DataSource = ds.Tables["NhaCungCap"];
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = e.RowIndex;
            if (row >= 0)
            {
                txtID.Enabled = false;
                txtID.Text = dgv.Rows[row].Cells["id_nhacungcap"].Value.ToString();
                txtTenncc.Text = dgv.Rows[row].Cells["tennhacungcap"].Value.ToString();
                txtemail.Text = dgv.Rows[row].Cells["email"].Value.ToString();
                txtsdt.Text = dgv.Rows[row].Cells["sodienthoai"].Value.ToString();
                txtdiachi.Text = dgv.Rows[row].Cells["diachi"].Value.ToString();


            }
        }
    }
}
