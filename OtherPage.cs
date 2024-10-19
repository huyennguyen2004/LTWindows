using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormapdemo
{
    public partial class OtherPage : UserControl
    {
        private Form1 parentForm;
        public OtherPage(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ((Form1)this.FindForm()).btnHome_Click(sender, e);
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            ((Form1)this.FindForm()).btnTransaction_Click(sender, e);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ((Form1)this.FindForm()).btnReport_Click(sender, e);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ((Form1)this.FindForm()).btnCategory_Click(sender, e);
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            ((Form1)this.FindForm()).btnAcc_Click(sender, e);
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            ((Form1)this.FindForm()).btnOther_Click(sender, e);
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Login login = new Login(parentForm); 

            login.LoginSuccess += (s, args) =>
            {
                MessageBox.Show("Đồng bộ dữ liệu thành công, trở về lại trang.");
                parentForm.DisplayOtherPage(); 
            };

            parentForm.ShowUserControl(login); 
        }

    }
}
