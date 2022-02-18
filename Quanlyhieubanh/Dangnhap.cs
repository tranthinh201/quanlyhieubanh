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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string tk = txttk.Text;
            string mk = txtmk.Text;
            if (txtmk.Text != "" && txtmk.Text != "")
            {
                string query = "select count(*) from NguoiDung where tendangnhap ='" + tk + "' and matkhau='" + mk + "'";
                ketnoi cn = new ketnoi();
                DataSet ds = new DataSet();
                ds = cn.laydulieu(query, "NguoiDung");
                if ((int)ds.Tables["NguoiDung"].Rows[0].ItemArray[0] == 1)
                {
                    MessageBox.Show("Đăng nhập vào hệ thống thành công!");
                    hethong ht = new hethong();
                    ht.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình đăng nhập, vui lòng kiểm tra lại tài khoản hoặc mật khẩu!");
                }
            }
            else
            {
                    MessageBox.Show("Vui lòng nhập dầy đủ thông tin!");
            }
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txttk_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
