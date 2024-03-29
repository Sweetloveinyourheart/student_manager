﻿using System;
using System.Windows.Forms;
using BUS;

namespace Quản_lý_điểm_sinh_vien_CNTT
{
    public partial class frmTimDiemSV : Form
    {
        public frmTimDiemSV()
        {
            InitializeComponent();
        }

        private void frmTimDiemSV_Load(object sender, EventArgs e)
        {
            KetQuaBUS.Instance.FillKetQuaList(dgrDIEMSV);

            KhoaBUS.Instance.FillKhoaList(cboKhoa);

        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Download source code tại Sharecode.vn
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KetQuaBUS.Instance.FillKQListByMSV(dgrDIEMSV, txtMaSV, cboMonHoc);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Thaotac.Export2Excel(dgrDIEMSV);
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonHocBUS.Instance.FillCBByMaKhoa(cboKhoa, cboMonHoc);
        }
    }
}
