using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace WindowsFormapdemo
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
            InitializeListView1();
            LoadSampleData();     
            UpdateListView(transactions);
            InitializeListView2(); 
            LoadAccountData();
        }

        private void btnHientai_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            var filteredTransactions = transactions.Where(t => t.Item3.Date == today.Date).ToList();
            UpdateListView(filteredTransactions);
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            var filteredTransactions = transactions.Where(t => t.Item3.Year == today.Year && t.Item3.Month == today.Month).ToList();
            UpdateListView(filteredTransactions);
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            var filteredTransactions = transactions.Where(t => t.Item3.Year == today.Year).ToList();
            UpdateListView(filteredTransactions);
        }

      
        public void btnTransaction_Click(object sender, EventArgs e)
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

        
        List<Tuple<string, string, DateTime>> transactions = new List<Tuple<string, string, DateTime>>();

        private void LoadSampleData()
        {
           
            transactions.Add(new Tuple<string, string, DateTime>("Thu", "5,000,000 VND", new DateTime(2024, 10, 01)));
            transactions.Add(new Tuple<string, string, DateTime>("Chi", "1,500,000 VND", new DateTime(2024, 10, 05)));
            transactions.Add(new Tuple<string, string, DateTime>("Thu", "2,000,000 VND", new DateTime(2024, 9, 20)));
            transactions.Add(new Tuple<string, string, DateTime>("Chi", "1,000,000 VND", new DateTime(2024, 1, 15)));
            transactions.Add(new Tuple<string, string, DateTime>("Thu", "3,500,000 VND", new DateTime(2023, 12, 31)));
        }

        private void UpdateListView(List<Tuple<string, string, DateTime>> filteredTransactions)
        {
           
            listView1.Items.Clear();

          
            foreach (var transaction in filteredTransactions)
            {
                ListViewItem item = new ListViewItem(transaction.Item1);
                item.SubItems.Add(transaction.Item2);                   
                item.SubItems.Add(transaction.Item3.ToString("dd/MM/yyyy")); 
                listView1.Items.Add(item);
            }
        }

        private void InitializeListView1()
        {
          
            listView1.View = View.Details;
            listView1.Columns.Add("Loại", 100);
            listView1.Columns.Add("Số tiền", 150);
            listView1.Columns.Add("Ngày", 120);
        }

        private void InitializeListView2()
        {
           
            listView2.View = View.Details;
            listView2.Columns.Add("Loại Tài Khoản", 150);
            listView2.Columns.Add("Số Dư", 150);
        }

        private void LoadAccountData()
        {
           
            var accounts = new List<Tuple<string, string>>
            {
                new Tuple<string, string>("Ví", "2,000,000 VND"),
                new Tuple<string, string>("Quỹ", "5,000,000 VND"),
                new Tuple<string, string>("Tiền Mặt", "3,500,000 VND"),
                new Tuple<string, string>("Tài Khoản Ngân Hàng", "10,000,000 VND")
            };

           
            foreach (var account in accounts)
            {
                ListViewItem item = new ListViewItem(account.Item1); 
                item.SubItems.Add(account.Item2);                   
                listView2.Items.Add(item);
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ((Form1)this.FindForm()).btnHome_Click(sender, e);
        }
    }
}
