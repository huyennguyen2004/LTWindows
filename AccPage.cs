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
    public partial class AccPage : UserControl
    {
        public AccPage()
        {
            InitializeComponent();
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

        private void btnBank_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.Add(new ListViewItem("Ngân hàng A - Số dư: 10,000,000 VNĐ"));
            listView1.Items.Add(new ListViewItem("Ngân hàng B - Số dư: 15,000,000 VNĐ"));
            listView1.Items.Add(new ListViewItem("Ngân hàng C - Số dư: 8,500,000 VNĐ"));
        }

        private void btnSaveMoney_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.Add(new ListViewItem("Sổ tiết kiệm A - Số dư: 5,000,000 VNĐ"));
            listView1.Items.Add(new ListViewItem("Sổ tiết kiệm B - Số dư: 2,000,000 VNĐ"));
            listView1.Items.Add(new ListViewItem("Sổ tiết kiệm C - Số dư: 7,500,000 VNĐ"));
        }

        private void btnAccumulate_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.Add(new ListViewItem("Tích lũy A - Tổng: 20,000,000 VNĐ"));
            listView1.Items.Add(new ListViewItem("Tích lũy B - Tổng: 12,500,000 VNĐ"));
            listView1.Items.Add(new ListViewItem("Tích lũy C - Tổng: 30,000,000 VNĐ"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount(this);
            addAccount.Dock = DockStyle.Fill;
            this.Parent.Controls.Add(addAccount);
            this.Parent.Controls.Remove(this); 
        }

        public void AddItemToListBox1(string item)
        {
            listView1.Items.Add(new ListViewItem(item)); 
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
