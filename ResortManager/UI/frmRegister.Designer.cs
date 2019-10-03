namespace ResortManager.UI
{
    partial class frmRegister
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CardID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_DateStart = new System.Windows.Forms.DateTimePicker();
            this.dtp_DateEnd = new System.Windows.Forms.DateTimePicker();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.dgvLst = new System.Windows.Forms.DataGridView();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLst)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1044, 94);
            this.label4.TabIndex = 17;
            this.label4.Text = "Đăng Kí Tài Khoản";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên Thành Viên";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(183, 130);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(252, 22);
            this.txt_Name.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // txt_CardID
            // 
            this.txt_CardID.Location = new System.Drawing.Point(183, 185);
            this.txt_CardID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CardID.Name = "txt_CardID";
            this.txt_CardID.Size = new System.Drawing.Size(252, 22);
            this.txt_CardID.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Số CMND";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ngày kết thúc";
            // 
            // dtp_DateStart
            // 
            this.dtp_DateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DateStart.Location = new System.Drawing.Point(705, 127);
            this.dtp_DateStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_DateStart.Name = "dtp_DateStart";
            this.dtp_DateStart.Size = new System.Drawing.Size(265, 22);
            this.dtp_DateStart.TabIndex = 27;
            // 
            // dtp_DateEnd
            // 
            this.dtp_DateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_DateEnd.Location = new System.Drawing.Point(705, 185);
            this.dtp_DateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_DateEnd.Name = "dtp_DateEnd";
            this.dtp_DateEnd.Size = new System.Drawing.Size(265, 22);
            this.dtp_DateEnd.TabIndex = 28;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(67, 533);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 28);
            this.btn_Add.TabIndex = 29;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Register.Location = new System.Drawing.Point(877, 533);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(100, 28);
            this.btn_Register.TabIndex = 30;
            this.btn_Register.Text = "Đăng kí";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // dgvLst
            // 
            this.dgvLst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLst.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTen,
            this.CMND,
            this.Remove});
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
            this.dgvLst.Location = new System.Drawing.Point(134, 233);
            this.dgvLst.Name = "dgvLst";
            this.dgvLst.ReadOnly = true;
            this.dgvLst.RowHeadersVisible = false;
            this.dgvLst.RowTemplate.Height = 24;
            this.dgvLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLst.Size = new System.Drawing.Size(787, 117);
            this.dgvLst.TabIndex = 31;
            this.dgvLst.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLst_CellContentClick);
            // 
            // HoTen
            // 
            this.HoTen.FillWeight = 108.3875F;
            this.HoTen.HeaderText = "Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.FillWeight = 108.3875F;
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // Remove
            // 
            this.Remove.FillWeight = 46.23014F;
            this.Remove.HeaderText = "";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Remove.Text = "Hủy";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLst);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dtp_DateEnd);
            this.Controls.Add(this.dtp_DateStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_CardID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegister";
            this.Size = new System.Drawing.Size(1051, 582);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CardID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_DateStart;
        private System.Windows.Forms.DateTimePicker dtp_DateEnd;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.DataGridView dgvLst;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
    }
}
