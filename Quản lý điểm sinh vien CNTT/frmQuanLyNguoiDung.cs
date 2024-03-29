﻿using System;
using System.Windows.Forms;
using BUS;

namespace Quản_lý_điểm_sinh_vien_CNTT
{
    public partial class frmQuanLyNguoiDung : Form
    {
        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {

        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            LoginBUS.Instance.ThemNguoiDung(errorProvider1, txtTaikhoan, txtMK, txtConfimMk, txtHoTen, cboGioiTinh, mskPhone, txtEmail, cboQuyen);
            //Fill du lieu 
            FillDataGridView_Login();
        }

        private void frmQuanLyNguoiDung_Load_1(object sender, EventArgs e)
        {
            //Fill du lieu 
            FillDataGridView_Login();
        }
        public void FillDataGridView_Login()
        {
            LoginBUS.Instance.FormLoad(dgrLogin);
        }

        private void dgrLogin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTaikhoan.Text = dgrLogin.CurrentRow.Cells[0].Value.ToString();
            txtMK.Text = dgrLogin.CurrentRow.Cells[1].Value.ToString();
            txtHoTen.Text = dgrLogin.CurrentRow.Cells[2].Value.ToString();
            cboGioiTinh.Text = dgrLogin.CurrentRow.Cells[3].Value.ToString();
            mskPhone.Text = dgrLogin.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgrLogin.CurrentRow.Cells[5].Value.ToString();
            cboQuyen.Text = dgrLogin.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Thuc hien xoa du lieu

                LoginBUS.Instance.XoaNguoiDung(txtTaikhoan);
                //Fill du lieu 
                FillDataGridView_Login();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtTaikhoan.Text == "")
                errorProvider1.SetError(txtTaikhoan, "Tên tài khoản không để trống!");
            else
            {
                // Thực hiện truy vấn
                LoginBUS.Instance.SuaNguoiDung(errorProvider1, txtTaikhoan, txtMK, txtHoTen, cboGioiTinh, mskPhone, txtEmail, cboQuyen);
                //Load lai du lieu
                FillDataGridView_Login();
               
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
