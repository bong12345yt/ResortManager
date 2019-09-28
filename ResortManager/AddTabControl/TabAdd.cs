using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortManager.AddTabControl
{
    class TabAdd
    {

        // Sử dụng 4 đối số truyền vào cho hàm này gồm có:
        //1> DevExpress.XtraTab.XtraTabControl XtraTabFarthe : Tạm gọi là Tab Cha vì XtraTabControl này để mình quăng tabcon vào
        //2> string icon : Khi add Tab con vào Tab cha thì đối số này để quy định icon hình cho tabCon(XtraTabpage)
        //3> string TabNameAdd : Khi add tab con vào thì đối số này quy định tên của Tabcon vừa Add vào đó.
        //4> System.Windows.Forms.UserControl UserControl: Cái này dùng để Add cái UserControl do ta tạo vào Tabcon
        static public void AddTab(TabControl xtraTabFarther, string tabNameAdd, UserControl userControl)
        {
            //khởi tạo một XtraTabPage
            TabPage tabChid = new TabPage();
            //Đặt lại tên...
            tabChid.Name = "TestTab";
            //Đặt lại phần text là tabNameAdd
            tabChid.Text = tabNameAdd;
            //Add user control vào  Tab con vừa khởi tạo...
            tabChid.Controls.Add(userControl);
            //Dock cho nó tràn hết XtraTabpage..
            userControl.Dock = DockStyle.Fill;
            //Quăng tab con vào tab cha
            xtraTabFarther.TabPages.Add(tabChid);
        }
    }
}
