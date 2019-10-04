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

using System.Timers;

namespace ResortManager
{
    public partial class frmHome : Form
    {
        private static System.Timers.Timer aTimer = null;
        static public String ActiveAccount = "";
        frmLogin frm_login = new frmLogin();
        public frmHome()
        {
            InitializeComponent();
            BeforeLogin();
            start();
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

        public static void start()
        {
            System.Console.WriteLine("init auto check!");
            // Create a timer with a two second interval.
            if (aTimer == null)
            {
                aTimer = new System.Timers.Timer();
                aTimer.Interval = 5000;
                // Hook up the Elapsed event for the timer. 
                aTimer.Elapsed += OnTimedEvent;
                aTimer.AutoReset = true;
            }

            aTimer.Enabled = true;
        }

        public static void stop()
        {
            aTimer.Enabled = false;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            ResortManagerBUS.BUS.AutoCheckDate.CheckExchage();
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        }

        private void BeforeLogin()
        {
            btn_CheckIn.Enabled = false;
            btn_CheckOut.Enabled = false;
            btn_Order.Enabled = false;
            btn_Register.Enabled = false;
            btn_ViewList.Enabled = false;
            btn_LogOut.Enabled = false;
            btn_login.Enabled = true;
            btnMuonPhong.Enabled = false;
            btnMuon.Enabled = false;
        }

        private void AfterLogin()
        {
            if(frmLogin.ActiveAcount == "ADMIN")
            {
                btn_Register.Enabled = true;
                btn_CheckIn.Enabled = true;
                btn_CheckOut.Enabled = true;
                btnMuonPhong.Enabled = true;
                btnMuon.Enabled = true;
            }
            else
            {
                btn_Order.Enabled = true;
                btn_ViewList.Enabled = true;
            }
            
            btn_login.Enabled = false;
            btn_LogOut.Enabled = true;
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
                ActiveAccount = frmLogin.ActiveAcount;
                AfterLogin();
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            TestTab("Đăng kí", new frmRegister());

        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            TestTab("Đặt chỗ", new frmDatCho(frmLogin.ActiveAcount));
        }


        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult dls = MessageBox.Show("Bạn có muốn đăng xuất!", "Đăng Xuất", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(DialogResult.OK == dls)
            {
                BeforeLogin();
               foreach(TabPage tab in tbc_Main.TabPages)
               {
                    tbc_Main.TabPages.Remove(tab);
               }
            }            
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            TestTab("Đăng kí", new frmRegister(1));
        }
    }


}
