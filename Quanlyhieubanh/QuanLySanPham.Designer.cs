namespace Quanlyhieubanh
{
    partial class QuanLySanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtsearcj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cbNcc = new System.Windows.Forms.ComboBox();
            this.cbDm = new System.Windows.Forms.ComboBox();
            this.txtGiamoi = new System.Windows.Forms.TextBox();
            this.txtGiacu = new System.Windows.Forms.TextBox();
            this.txtSl = new System.Windows.Forms.TextBox();
            this.txtTieude = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearcj
            // 
            this.txtsearcj.Location = new System.Drawing.Point(607, 289);
            this.txtsearcj.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearcj.Name = "txtsearcj";
            this.txtsearcj.Size = new System.Drawing.Size(164, 20);
            this.txtsearcj.TabIndex = 32;
            this.txtsearcj.TextChanged += new System.EventHandler(this.txtsearcj_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(604, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nhập tên sản phẩm để tìm kiếm:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnreset
            // 
            this.btnreset.Image = global::Quanlyhieubanh.Properties.Resources.archeology;
            this.btnreset.Location = new System.Drawing.Point(380, 260);
            this.btnreset.Margin = new System.Windows.Forms.Padding(2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(98, 31);
            this.btnreset.TabIndex = 30;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::Quanlyhieubanh.Properties.Resources.delete;
            this.btnDel.Location = new System.Drawing.Point(380, 210);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(98, 34);
            this.btnDel.TabIndex = 29;
            this.btnDel.Text = "Xóa";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Quanlyhieubanh.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(170, 260);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 31);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbNcc
            // 
            this.cbNcc.FormattingEnabled = true;
            this.cbNcc.Location = new System.Drawing.Point(108, 141);
            this.cbNcc.Margin = new System.Windows.Forms.Padding(2);
            this.cbNcc.Name = "cbNcc";
            this.cbNcc.Size = new System.Drawing.Size(126, 21);
            this.cbNcc.TabIndex = 27;
            // 
            // cbDm
            // 
            this.cbDm.FormattingEnabled = true;
            this.cbDm.Location = new System.Drawing.Point(108, 105);
            this.cbDm.Margin = new System.Windows.Forms.Padding(2);
            this.cbDm.Name = "cbDm";
            this.cbDm.Size = new System.Drawing.Size(126, 21);
            this.cbDm.TabIndex = 26;
            // 
            // txtGiamoi
            // 
            this.txtGiamoi.Location = new System.Drawing.Point(633, 108);
            this.txtGiamoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiamoi.Name = "txtGiamoi";
            this.txtGiamoi.Size = new System.Drawing.Size(147, 20);
            this.txtGiamoi.TabIndex = 24;
            // 
            // txtGiacu
            // 
            this.txtGiacu.Location = new System.Drawing.Point(633, 63);
            this.txtGiacu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiacu.Name = "txtGiacu";
            this.txtGiacu.Size = new System.Drawing.Size(147, 20);
            this.txtGiacu.TabIndex = 23;
            // 
            // txtSl
            // 
            this.txtSl.Location = new System.Drawing.Point(368, 143);
            this.txtSl.Margin = new System.Windows.Forms.Padding(2);
            this.txtSl.Name = "txtSl";
            this.txtSl.Size = new System.Drawing.Size(147, 20);
            this.txtSl.TabIndex = 22;
            // 
            // txtTieude
            // 
            this.txtTieude.Location = new System.Drawing.Point(368, 105);
            this.txtTieude.Margin = new System.Windows.Forms.Padding(2);
            this.txtTieude.Name = "txtTieude";
            this.txtTieude.Size = new System.Drawing.Size(147, 20);
            this.txtTieude.TabIndex = 21;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(368, 65);
            this.txtTensp.Margin = new System.Windows.Forms.Padding(2);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(147, 20);
            this.txtTensp.TabIndex = 25;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(108, 63);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(147, 20);
            this.txtID.TabIndex = 20;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 319);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(858, 208);
            this.dgv.TabIndex = 19;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(546, 111);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Giá khuyến mãi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(566, 68);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Giá cũ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tên sản phẩm:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(315, 146);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Số lượng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 111);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Danh mục :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tiêu đề:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nhà cung cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // button2
            // 
            this.button2.Image = global::Quanlyhieubanh.Properties.Resources.back;
            this.button2.Location = new System.Drawing.Point(786, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Trờ về";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Quanlyhieubanh.Properties.Resources.plus;
            this.btnAdd.Location = new System.Drawing.Point(170, 210);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 34);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 528);
            this.Controls.Add(this.txtsearcj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbNcc);
            this.Controls.Add(this.cbDm);
            this.Controls.Add(this.txtGiamoi);
            this.Controls.Add(this.txtGiacu);
            this.Controls.Add(this.txtSl);
            this.Controls.Add(this.txtTieude);
            this.Controls.Add(this.txtTensp);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Name = "QuanLySanPham";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearcj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cbNcc;
        private System.Windows.Forms.ComboBox cbDm;
        private System.Windows.Forms.TextBox txtGiamoi;
        private System.Windows.Forms.TextBox txtGiacu;
        private System.Windows.Forms.TextBox txtSl;
        private System.Windows.Forms.TextBox txtTieude;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdd;
    }
}