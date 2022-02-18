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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string tk = txttk.Text;
            string mk = txtmk.Text;
            string query = "select count(*) from NguoiDung where tendangnhap ='" + tk + "' and matkhau='" + mk + "'";
            ketnoi cn = new ketnoi();
            DataSet ds = new DataSet();
            ds = cn.laydulieu(query, "NguoiDung");
            if (txtmk.Text != "" && txtmk.Text != "")
            {
                if ((int)ds.Tables["NguoiDung"].Rows[0].ItemArray[0] == 1)
                {
                    MessageBox.Show("Tài khoản " + txttk.Text + " đã đăng ký. Vui lòng đăng ký tài khoản khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string register = "insert into NguoiDung(tendangnhap, matkhau) values ('" + tk + "', '" + mk + "')";
                   
                    ketnoi dk = new ketnoi();
                    bool kt = dk.thucthi(register);
                    if(kt == true)
                    {
                        MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình đăng ký tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đày đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hethong ht = new hethong();
            ht.Show();
            this.Hide();    
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
