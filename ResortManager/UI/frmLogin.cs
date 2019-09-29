using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortManager.UI
{
    public partial class frmLogin : Form
    {
        public string ActiveAcount;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void chk_show_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_show.Checked == true)
            {
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '•';
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                MessageBox.Show("Tài khoản không được để trống");
                return;
            }
            if (txt_pass.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống");
                return;
            }
            //bool check = BUS.BUSClasses.LoginUserBUS.CheckLog(txt_user.Text, txt_pass.Text);
            bool check = true;
            if (check == false)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu ");
                return;
            }
            else
            {
                ActiveAcount = txt_user.Text;
                txt_pass.Text = "";
                txt_user.Text = "";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
