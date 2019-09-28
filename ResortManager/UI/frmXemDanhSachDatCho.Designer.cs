﻿namespace ResortManager.UI
{
    partial class frmXemDanhSachDatCho
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvLst = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CaNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HuyDangKy = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLst)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(-3, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1007, 108);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XEM DANH SÁCH ĐẶT CHỖ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvLst
            // 
            this.dgvLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaDoan,
            this.CaNhan,
            this.Column5,
            this.MaPhong,
            this.BatDau,
            this.KetThuc,
            this.Gia,
            this.ThanhTien,
            this.HuyDangKy});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLst.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLst.Location = new System.Drawing.Point(0, 150);
            this.dgvLst.Name = "dgvLst";
            this.dgvLst.ReadOnly = true;
            this.dgvLst.RowHeadersVisible = false;
            this.dgvLst.RowTemplate.Height = 24;
            this.dgvLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLst.Size = new System.Drawing.Size(1005, 159);
            this.dgvLst.TabIndex = 12;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // MaDoan
            // 
            this.MaDoan.HeaderText = "Mã đoàn";
            this.MaDoan.Name = "MaDoan";
            this.MaDoan.ReadOnly = true;
            // 
            // CaNhan
            // 
            this.CaNhan.HeaderText = "Cá nhân";
            this.CaNhan.Name = "CaNhan";
            this.CaNhan.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "CMND";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "Mã phòng";
            this.MaPhong.Name = "MaPhong";
            this.MaPhong.ReadOnly = true;
            // 
            // BatDau
            // 
            this.BatDau.HeaderText = "Bắt đầu";
            this.BatDau.Name = "BatDau";
            this.BatDau.ReadOnly = true;
            // 
            // KetThuc
            // 
            this.KetThuc.HeaderText = "Kết thúc";
            this.KetThuc.Name = "KetThuc";
            this.KetThuc.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // HuyDangKy
            // 
            this.HuyDangKy.HeaderText = "Hủy đăng ký";
            this.HuyDangKy.Name = "HuyDangKy";
            this.HuyDangKy.ReadOnly = true;
            this.HuyDangKy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HuyDangKy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HuyDangKy.Width = 150;
            // 
            // frmXemDanhSachDatCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLst);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmXemDanhSachDatCho";
            this.Size = new System.Drawing.Size(1007, 517);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvLst;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn KetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn HuyDangKy;
    }
}
