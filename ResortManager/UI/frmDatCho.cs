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
    public partial class frmDatCho : UserControl
    {
        private String MaDoan = "D001";
        private List<ResortManagerDTO.DTO.ThanhVien> lstUser = new List<ResortManagerDTO.DTO.ThanhVien>();
        private List<String> lstRoom = new List<String>();
        public frmDatCho()
        {
            InitializeComponent();
        }

        private void frmDatCho_Load(object sender, EventArgs e)
        {
            ResortManagerDTO.DTO.DbAck ack = new ResortManagerDTO.DTO.DbAck();
            List<String> lstLeverRoon = new List<String>();
            lstLeverRoon = ResortManagerBUS.BUS.LoaiPhong.SelectLeverRoom(out ack);

            foreach(String itemLeverRoom in lstLeverRoon)
            {
                cmbLever.Items.Add(itemLeverRoom);
            }

            //set list type for cmb
            List<String> lstTypeRoon = new List<String>();
            lstTypeRoon = ResortManagerBUS.BUS.LoaiPhong.SelectTypeRoom(out ack);

            foreach (String itemCatRoom in lstTypeRoon)
            {
                cmbCatRoom.Items.Add(itemCatRoom);
            }

            //set list layer for cmb
            List<String> lstLayerRoom = new List<String>();
            lstLayerRoom = ResortManagerBUS.BUS.Phong.SelectLayerRoom(out ack);

            foreach (String itemLayerRoom in lstLayerRoom)
            {
                cmbLayer.Items.Add(itemLayerRoom);
            }

            //set lstUser
            this.lstUser = ResortManagerBUS.BUS.ThanhVien.LayDanhSachThanhVienTheoMaDoan(out ack, this.MaDoan).ToList<ResortManagerDTO.DTO.ThanhVien>();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.CheckValidate())
                return;
            dgvLst.Rows.Clear();
            ResortManagerDTO.DTO.DbAck ack = new ResortManagerDTO.DTO.DbAck();
            List<ResortManagerDTO.DTO.Phong> lstRoom = new List<ResortManagerDTO.DTO.Phong>();
            lstRoom = ResortManagerBUS.BUS.Phong.SelectListRoomByValidate(out ack, cmbLever.SelectedItem.ToString(), cmbCatRoom.SelectedItem.ToString(), int.Parse(cmbLayer.SelectedItem.ToString()));
            
            int index = 1;
            if (lstRoom.Count > 0)
            {
                if (lstRoom.Count < int.Parse(txtNum.Text))
                {
                    MessageBox.Show("Chỉ còn tróng " + lstRoom.Count.ToString() + " thỏa điều kiện");
                }
                txtPrice.Text = lstRoom[0].GIA.ToString();
                foreach (ResortManagerDTO.DTO.Phong item in lstRoom)
                {
                    dgvLst.Rows.Add(new String[4] { index.ToString(), item.MAPHONG, item.TANG.ToString(), item.GIA.ToString() });
                }
            }
            else
            {
                MessageBox.Show("Không có phòng thảo điều kiện");
            }
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            ResortManagerDTO.DTO.DbAck ack = new ResortManagerDTO.DTO.DbAck();
            for (int i =0; i < dgvLst.RowCount; i++)
            {
                ResortManagerBUS.BUS.Phong.UpdateStatus(out ack, dgvLst[1, i].Value.ToString());
                //ack = ResortManagerBUS.BUS.CTGiaoDich.ThemCTGD();
                this.lstRoom.Add(dgvLst[1, i].Value.ToString().Trim() + "-" + cmbCatRoom.SelectedItem.ToString());
            }
            
            if (ack == ResortManagerDTO.DTO.DbAck.Ok)
            {
                MessageBox.Show("Đặt phòng thành công");
                this.ResetControl();
            }
            else
            {
                MessageBox.Show("Đặt phòng thất bại. Xin thử lại");
                this.ResetControl();
            }
        }

        private void ResetControl()
        {
            cmbCatRoom.SelectedIndex = -1;
            cmbLayer.SelectedIndex = -1;
            cmbLever.SelectedIndex = -1;
            txtPrice.Text = "";
            txtNum.Text = "";
            dgvLst.Rows.Clear();
        }

        private bool CheckValidate()
        {
            if (cmbLever.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn hạng phòng!");
                cmbLever.Focus();
                return false;
            }
            if (cmbLayer.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn tầng!");
                cmbLayer.Focus();
                return false;
            }
            if (cmbCatRoom.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn hình thức phòng!");
                cmbCatRoom.Focus();
                return false;
            }
            if (txtNum.Text.Trim() == "")
            {
                MessageBox.Show("Hãy nhập số lượng!");
                txtNum.Focus();
                return false;
            }
            return true;
        }

        private void cmbLever_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCatRoom.SelectedIndex > -1 && cmbLever.SelectedIndex > -1)
            {
                ResortManagerDTO.DTO.DbAck ack = new ResortManagerDTO.DTO.DbAck();
                String price = ResortManagerBUS.BUS.LoaiPhong.GetPriceByValidate(out ack, cmbLever.SelectedItem.ToString(), cmbCatRoom.SelectedItem.ToString());
                txtPrice.Text = price;
            }
        }

        private void cmbCatRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCatRoom.SelectedIndex > -1 && cmbLever.SelectedIndex > -1)
            {
                ResortManagerDTO.DTO.DbAck ack = new ResortManagerDTO.DTO.DbAck();
                String price = ResortManagerBUS.BUS.LoaiPhong.GetPriceByValidate(out ack, cmbLever.SelectedItem.ToString(), cmbCatRoom.SelectedItem.ToString());
                txtPrice.Text = price;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmCTDatCho ctdc = new frmCTDatCho(this.lstUser, this.lstRoom, this.MaDoan);
            ctdc.ShowDialog();
        }
    }
}
