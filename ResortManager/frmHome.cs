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
                    t++;
                }
            }
            if (t >= 0)//tab có thì chuyển đến tab
            {

            }
            else//nếu chưa có thì mở tab mới
            {
                
                AddTabControl.TabAdd.AddTab(tbc_Main, nameTab, frm);
                tbc_Main.SelectedIndex = t;
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

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            frmTraPhong s = new frmTraPhong();
            TestTab("Trả phòng", s);

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DialogResult result = frm_login.ShowDialog();
            if (result == DialogResult.OK)
            {
                //MaNVHienHanh = frmLogin.MaNVHienHanh;
                //afterLogin();
            }
        }
    }
}
