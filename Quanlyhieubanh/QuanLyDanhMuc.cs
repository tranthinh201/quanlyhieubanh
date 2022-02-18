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
    public partial class QuanLyDanhMuc : Form
    {
        public QuanLyDanhMuc()
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
            string query = "select * from DanhMuc";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "DanhMuc");
            dgv.DataSource = ds.Tables["DanhMuc"];

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string tim = txtsearch.Text;
            string query = "select * from DanhMuc where ten_danhmuc like'%" + tim + "%'";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "DanhMuc");
            dgv.DataSource = ds.Tables["DanhMuc"];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string mdm = txtID.Text;
            string tdm = txtTendanhmuc.Text;

            if (txtID.Text != "" && txtTendanhmuc.Text != "")
            {

                string query = "update DanhMuc set ten_danhmuc='" + tdm + "' where id_danhmuc='" + mdm + "'";
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            string mdm = txtID.Text;



            if (txtID.Text != "" && txtTendanhmuc.Text != "")
            {
                string query = "delete from DanhMuc where id_danhmuc='" + mdm + "'";
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTendanhmuc.Text = "";
            txtID.Enabled = true;
            getdata();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ketnoi cn = new ketnoi();

            if (txtID.Text != "" && txtTendanhmuc.Text != "")
            {
                string mdm = txtID.Text;
                string tdm = txtTendanhmuc.Text;

                string query = "insert into DanhMuc(id_danhmuc,ten_danhmuc) values ('" + mdm + "', N'" + tdm + "')";

                DataSet ds = new DataSet();
                cn.thucthi(query);
                MessageBox.Show("them thanh cong!");

                getdata();
            }
            else
            {
                MessageBox.Show("them that bai!");
            }
        }

        private void QuanLyDanhMuc_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtID.Enabled = false;
                txtID.Text = dgv.Rows[row].Cells["id_danhmuc"].Value.ToString();
                txtTendanhmuc.Text = dgv.Rows[row].Cells["ten_danhmuc"].Value.ToString();

            }
        }
    }
}
