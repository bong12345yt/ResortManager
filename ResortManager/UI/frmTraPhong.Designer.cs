
﻿namespace ResortManager.UI
{
    partial class frmTraPhong
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
            this.dgvLst = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Đoàn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtIdRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLst)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLst
            // 
            this.dgvLst.AllowUserToAddRows = false;
            this.dgvLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Đoàn,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
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
            this.dgvLst.Location = new System.Drawing.Point(27, 179);
            this.dgvLst.Name = "dgvLst";
            this.dgvLst.ReadOnly = true;
            this.dgvLst.RowHeadersVisible = false;
            this.dgvLst.RowTemplate.Height = 24;
            this.dgvLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLst.Size = new System.Drawing.Size(1008, 117);
            this.dgvLst.TabIndex = 7;
            this.dgvLst.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLst_CellClick);
            // 
            // Column2
            // 
            this.Column2.FillWeight = 205.9603F;
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Đoàn
            // 
            this.Đoàn.HeaderText = "Đoàn";
            this.Đoàn.Name = "Đoàn";
            this.Đoàn.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 107.5375F;
            this.Column3.HeaderText = "CMND";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 76.37853F;
            this.Column4.HeaderText = "Giá";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 107.5375F;
            this.Column5.HeaderText = "Phí bồi thường";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 107.5375F;
            this.Column6.HeaderText = "Thành tiền";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 77.34388F;
            this.Column7.HeaderText = "Trả phòng";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Trả";
            // 
            // Column8
            // 
            this.Column8.FillWeight = 77.0955F;
            this.Column8.HeaderText = "Thêm bồi thường";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Text = "Sửa BT";
            // 
            // txtIdRoom
            // 
            this.txtIdRoom.Location = new System.Drawing.Point(415, 126);
            this.txtIdRoom.Name = "txtIdRoom";
            this.txtIdRoom.Size = new System.Drawing.Size(100, 22);
            this.txtIdRoom.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã phòng";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(547, 121);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 33);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1047, 94);
            this.label4.TabIndex = 17;
            this.label4.Text = "TRẢ PHÒNG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvLst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdRoom);
            this.Name = "frmTraPhong";
            this.Size = new System.Drawing.Size(1050, 513);
            this.Load += new System.EventHandler(this.frmTraPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLst;
        private System.Windows.Forms.TextBox txtIdRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Đoàn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
    }
}