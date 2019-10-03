using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResortManager.UI;

namespace ResortManager
{
    public partial class frmHome : Form
    {
        frmLogin frm_login = new frmLogin();
        public frmHome()
        {
            InitializeComponent();
            BeforeLogin();
        }

        #region"Kiểm tra tab mở"
        public void TestTab(string nameTab, UserControl frm)
        {

            int t = -1;

            foreach (TabPage tab in tbc_Main.TabPages)
            {
                if (tab.Text == nameTab)
                {
                    tbc_Main.SelectedTab = tab;
                    t = 1;
                }
            }
            if (t >= 0)//tab có thì chuyển đến tab
            {

            }
            else//nếu chưa có thì mở tab mới
            {
                
                AddTabControl.TabAdd.AddTab(tbc_Main, nameTab, frm);
                tbc_Main.SelectedIndex = tbc_Main.TabCount - 1;
            }
        }

        public bool CheckTab(string nameTab)
        {
            foreach (TabPage tab in tbc_Main.TabPages)
            {
                if (tab.Text == nameTab)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        private void BeforeLogin()
        {
            btn_CheckIn.Enabled = false;
            btn_CheckOut.Enabled = false;
            btn_Order.Enabled = false;
            btn_Register.Enabled = false;
            btn_ViewList.Enabled = false;
        }

        private void AfterLogin()
        {
            btn_CheckIn.Enabled = true;
            btn_CheckOut.Enabled = true;
            btn_Order.Enabled = true;
            btn_Register.Enabled = true;
            btn_ViewList.Enabled = true;
        }

        private void btn_ViewList_Click(object sender, EventArgs e)
        {
            TestTab("Xem DS", new frmXemDanhSachDatCho());
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            frmTraPhong s = new frmTraPhong();
            TestTab("Trả phòng", s);

        }

        private void btn_CheckIn_Click(object sender, EventArgs e)
        {
            TestTab("Nhận phòng", new FrmNhanPhong());
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            DialogResult result = frm_login.ShowDialog();
            if (result == DialogResult.OK)
            {
                //MaNVHienHanh = frmLogin.MaNVHienHanh;
                //afterLogin();
                AfterLogin();
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            TestTab("Đăng kí", new frmRegister());

        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            TestTab("Đặt chỗ", new frmDatCho(frm_login.ActiveAcount));
        }
    }
}
