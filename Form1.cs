using System;
using System.Windows.Forms;


namespace WindowsFormapdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HomePage homePage = new HomePage();
            ShowUserControl(homePage);
        }
        public void ShowUserControl(UserControl control)
        {
             panelMain.Controls.Clear();
control.Dock = DockStyle.Fill;
  panelMain.Controls.Add(control);
        }
        public void btnHome_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            ShowUserControl(homePage);
        }
        public void btnTransaction_Click(object sender, EventArgs e)
        {
            TransactionPage transactionPage = new TransactionPage();
            ShowUserControl(transactionPage);
        }

        public void btnReport_Click(object sender, EventArgs e)
        {
            ReportPage reportPage = new ReportPage();
            ShowUserControl(reportPage);
        }

        public void btnCategory_Click(object sender, EventArgs e)
        {
            CategoryPage categoryPage = new CategoryPage();
            ShowUserControl(categoryPage);
        }

        public void btnAcc_Click(object sender, EventArgs e)
        {
            AccPage accountPage = new AccPage();
            ShowUserControl(accountPage);
        }

        public void btnOther_Click(object sender, EventArgs e)
        {
            OtherPage otherPage = new OtherPage(this);
            ShowUserControl(otherPage);
        }
        public void DisplayOtherPage()
        {
            OtherPage otherPage = new OtherPage(this);
            ShowUserControl(otherPage);
        }
        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
