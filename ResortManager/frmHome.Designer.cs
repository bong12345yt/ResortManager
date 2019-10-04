namespace ResortManager
{
    partial class frmHome
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_ViewList = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.tbc_Main = new System.Windows.Forms.TabControl();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btnMuonPhong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btn_LogOut);
            this.groupBox1.Controls.Add(this.btnMuonPhong);
            this.groupBox1.Controls.Add(this.btn_Register);
            this.groupBox1.Controls.Add(this.btn_CheckIn);
            this.groupBox1.Controls.Add(this.btn_CheckOut);
            this.groupBox1.Controls.Add(this.btn_Order);
            this.groupBox1.Controls.Add(this.btn_ViewList);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(7, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(148, 513);
            this.groupBox1.Location = new System.Drawing.Point(9, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(197, 631);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btn_Register
            // 
            this.btn_Register.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Register.FlatAppearance.BorderSize = 0;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Register.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(8, 362);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Register.Location = new System.Drawing.Point(11, 446);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(131, 28);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "Đăng Kí TK";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_CheckIn.FlatAppearance.BorderSize = 0;
            this.btn_CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_CheckIn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckIn.Location = new System.Drawing.Point(8, 297);
            this.btn_CheckIn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CheckIn.Location = new System.Drawing.Point(11, 366);
            this.btn_CheckIn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(131, 28);
            this.btn_CheckIn.TabIndex = 4;
            this.btn_CheckIn.Text = "Nhận Phòng";
            this.btn_CheckIn.UseVisualStyleBackColor = true;
            this.btn_CheckIn.Click += new System.EventHandler(this.btn_CheckIn_Click);
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_CheckOut.FlatAppearance.BorderSize = 0;
            this.btn_CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_CheckOut.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut.Location = new System.Drawing.Point(9, 229);
            this.btn_CheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CheckOut.Location = new System.Drawing.Point(12, 282);
            this.btn_CheckOut.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(131, 28);
            this.btn_CheckOut.TabIndex = 3;
            this.btn_CheckOut.Text = "Trả Phòng";
            this.btn_CheckOut.UseVisualStyleBackColor = true;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Order.FlatAppearance.BorderSize = 0;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Order.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order.Location = new System.Drawing.Point(8, 165);
            this.btn_Order.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Order.Location = new System.Drawing.Point(11, 203);
            this.btn_Order.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(131, 28);
            this.btn_Order.TabIndex = 2;
            this.btn_Order.Text = "Đặt Chỗ";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_ViewList
            // 
            this.btn_ViewList.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ViewList.FlatAppearance.BorderSize = 0;
            this.btn_ViewList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_ViewList.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewList.Location = new System.Drawing.Point(8, 97);
            this.btn_ViewList.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ViewList.Location = new System.Drawing.Point(11, 119);
            this.btn_ViewList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_ViewList.Name = "btn_ViewList";
            this.btn_ViewList.Size = new System.Drawing.Size(131, 28);
            this.btn_ViewList.TabIndex = 1;
            this.btn_ViewList.Text = "Xem DS";
            this.btn_ViewList.UseVisualStyleBackColor = true;
            this.btn_ViewList.Click += new System.EventHandler(this.btn_ViewList_Click);
            // 
            // btn_login
            // 
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_login.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(9, 42);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Location = new System.Drawing.Point(12, 52);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(131, 28);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Đăng Nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tbc_Main
            // 
            this.tbc_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_Main.Location = new System.Drawing.Point(178, 15);
            this.tbc_Main.Margin = new System.Windows.Forms.Padding(4);
            this.tbc_Main.Location = new System.Drawing.Point(237, 18);
            this.tbc_Main.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbc_Main.Name = "tbc_Main";
            this.tbc_Main.SelectedIndex = 0;
            this.tbc_Main.Size = new System.Drawing.Size(1128, 630);
            this.tbc_Main.TabIndex = 1;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_LogOut.FlatAppearance.BorderSize = 0;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_LogOut.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.Location = new System.Drawing.Point(9, 421);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(98, 23);
            this.btn_LogOut.TabIndex = 6;
            this.btn_LogOut.Text = "Đăng Xuất";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // btnMuonPhong
            // 
            this.btnMuonPhong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMuonPhong.FlatAppearance.BorderSize = 0;
            this.btnMuonPhong.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMuonPhong.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuonPhong.Location = new System.Drawing.Point(12, 516);
            this.btnMuonPhong.Margin = new System.Windows.Forms.Padding(5);
            this.btnMuonPhong.Name = "btnMuonPhong";
            this.btnMuonPhong.Size = new System.Drawing.Size(131, 28);
            this.btnMuonPhong.TabIndex = 6;
            this.btnMuonPhong.Text = "Mướn phòng";
            this.btnMuonPhong.UseVisualStyleBackColor = true;
            this.btnMuonPhong.Click += new System.EventHandler(this.btnMuonPhong_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 650);
            this.Controls.Add(this.tbc_Main);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_ViewList;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TabControl tbc_Main;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btnMuonPhong;
    }
}

