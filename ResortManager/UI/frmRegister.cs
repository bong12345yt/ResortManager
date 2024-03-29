﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortManager.UI
{
    public partial class frmRegister : UserControl
    {
        private int ckMuonPhong = 0;
        private String MaDoan = "";
        public frmRegister()
        {
            InitializeComponent();
        }
        public frmRegister(int muonP)
        {
            this.ckMuonPhong = muonP;
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dgvLst.Rows.Add(new String[3] {txt_Name.Text, txt_CardID.Text,"Hủy"});
            txt_Name.Text = "";
            txt_CardID.Text = "";
        }

        private void dgvLst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) {
                dgvLst.Rows.Remove(dgvLst.Rows[e.RowIndex]);
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            ResortManagerDTO.DTO.ThanhVien tv = new ResortManagerDTO.DTO.ThanhVien();
            String MaDoan;
            ResortManagerDTO.DTO.DbAck ack = ResortManagerBUS.BUS.GiaoDich.TaoMaDoan(out MaDoan);
            if (ack != ResortManagerDTO.DTO.DbAck.Ok)
            {
                MessageBox.Show(ResortManagerDTO.DTO.EnumUtils.stringValueOf(ack), "Error!", MessageBoxButtons.OK);
                return;
            }

            //Them giao dich
            ResortManagerDTO.DTO.GiaoDich gd = new ResortManagerDTO.DTO.GiaoDich();
            gd.MaDoan = MaDoan;
            this.MaDoan = MaDoan;
            gd.SoNguoi = 0;
            gd.SoPhong = 0;
            gd.NgayBatDau = dtp_DateStart.Value;
            gd.NgayKetThuc = dtp_DateEnd.Value;
            gd.TongTien = 0;
            gd.CMND = dgvLst.Rows[0].Cells["CMND"].Value.ToString();
            gd.TrangThai = "chua_thanh_cong";

            ResortManagerDTO.DTO.DbAck ack2 = ResortManagerBUS.BUS.GiaoDich.ThemGiaoDich(gd);
            if (ack2 != ResortManagerDTO.DTO.DbAck.Ok)
            {
                //MessageBox.Show(ResortManagerDTO.DTO.EnumUtils.stringValueOf(ack2), "Error!", MessageBoxButtons.OK);
                MessageBox.Show("Lỗi ngày");
                return;
            }

            else if (ack2 == ResortManagerDTO.DTO.DbAck.Ok)
            {
                MessageBox.Show(string.Format("Thêm giao dịch thành công\n Tài khoản của đoàn là {0}\n Mật khẩu là 123456",MaDoan),"Kết quả", MessageBoxButtons.OK);
                if (ack2 == ResortManagerDTO.DTO.DbAck.NetworkError)
                {
                    MessageBox.Show(ResortManagerDTO.DTO.DbAck.NetworkError.ToString(), "Error!", MessageBoxButtons.OK);
                }
            }

            //Them thanh vien
            foreach (DataGridViewRow r in dgvLst.Rows)
            {
                if (r.Cells[0].Value != null) {
                    tv.HoTen = r.Cells[0].Value.ToString();
                    tv.CMND = r.Cells[1].Value.ToString();
                    tv.MaDoan = MaDoan;

                    ResortManagerDTO.DTO.DbAck ack1 = ResortManagerBUS.BUS.ThanhVien.ThemThanhVien(tv);
                    if (ack1 != ResortManagerDTO.DTO.DbAck.Ok)
                    {
                        MessageBox.Show(ResortManagerDTO.DTO.EnumUtils.stringValueOf(ack1), "Error!", MessageBoxButtons.OK);
                        goto Error;
                    }

                    else if (ack1 == ResortManagerDTO.DTO.DbAck.Ok)
                    {
                        //MessageBox.Show("Đã lưu thành công");
                        if (ack1 == ResortManagerDTO.DTO.DbAck.NetworkError)
                        {
                            MessageBox.Show(ResortManagerDTO.DTO.DbAck.NetworkError.ToString(), "Error!", MessageBoxButtons.OK);
                        }
                    }
                }
            }

            //Them tai khoan
            //ResortManagerDTO.DTO.TaiKhoan tk = new ResortManagerDTO.DTO.TaiKhoan();
            //tk.MaDoan = MaDoan;
            //tk.TenTaiKhoan = MaDoan;
            //tk.MatKhau = "123456";
            //ResortManagerDTO.DTO.DbAck ack5 = ResortManagerBUS.BUS.TaiKhoan.ThemTaiKhoan(tk);
            //if (ack5 != ResortManagerDTO.DTO.DbAck.Ok)
            //{
            //    MessageBox.Show(ResortManagerDTO.DTO.EnumUtils.stringValueOf(ack5), "Error!", MessageBoxButtons.OK);
            //    return;
            //}

            //else if (ack5 == ResortManagerDTO.DTO.DbAck.Ok)
            //{
            //    MessageBox.Show("Thêm tài khoản thành công");
            //    if (ack5 == ResortManagerDTO.DTO.DbAck.NetworkError)
            //    {
            //        MessageBox.Show(ResortManagerDTO.DTO.DbAck.NetworkError.ToString(), "Error!", MessageBoxButtons.OK);
            //    }
            //}

            if (this.ckMuonPhong != 0)
            {
                MessageBox.Show("Đăng nhập lại");
                this.Parent.Controls.Remove(this);
            }

            return;

        //label Error
        Error:
            //Xoa thanh vien
            ResortManagerDTO.DTO.DbAck ack3 = ResortManagerBUS.BUS.ThanhVien.XoaThanhVienTheoMaDoan(MaDoan);
            if (ack3 != ResortManagerDTO.DTO.DbAck.Ok)
            {
                MessageBox.Show(ResortManagerDTO.DTO.EnumUtils.stringValueOf(ack3), "Error!", MessageBoxButtons.OK);
                return;
            }
            //Xoa giao dich
            ResortManagerDTO.DTO.DbAck ack4 = ResortManagerBUS.BUS.GiaoDich.XoaGiaoDich(MaDoan);
            if (ack4 != ResortManagerDTO.DTO.DbAck.Ok)
            {
                MessageBox.Show(ResortManagerDTO.DTO.EnumUtils.stringValueOf(ack4), "Error!", MessageBoxButtons.OK);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.frm_Home.TestTab("Dat Cho Admin", new frmDatCho(this.MaDoan, 1));
        }
    }
}
