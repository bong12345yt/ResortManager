using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortManager
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        #region"Kiểm tra tab mở"
        public void TestTab(string nameTab, UserControl frm)
        {

            int t = 0;

            foreach (TabPage tab in tbc_Main.TabPages)
            {
                if (tab.Text == nameTab)
                {
                    tbc_Main.SelectedTab = tab;
                    t = 1;
                }
            }
            if (t == 1)//tab có thì chuyển đến tab
            {

            }
            else//nếu chưa có thì mở tab mới
            {
                
                AddTabControl.TabAdd.AddTab(tbc_Main, nameTab, frm);

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

    }
}
