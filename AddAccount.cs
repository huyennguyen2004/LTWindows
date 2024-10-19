using System;
using System.Windows.Forms;

namespace WindowsFormapdemo
{
    public partial class AddAccount : UserControl
    {
        private AccPage _accPage;

        public AddAccount(AccPage accPage)
        {
            InitializeComponent();
            _accPage = accPage; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string accType = comboBoxType.SelectedItem.ToString();
            string accountName = txtAccountName.Text;
            string balance = txtBalance.Text;         

            if (accType == "Ngân hàng")
            {
                _accPage.AddItemToListBox1($"{accountName} - Ngân hàng - Số dư: {balance} VNĐ");
            }
            else if (accType == "Tích lũy")
            {
                _accPage.AddItemToListBox1($"{accountName} - Tích lũy - Số dư: {balance} VNĐ");
            }
            else if (accType == "Sổ tiết kiệm")
            {
                _accPage.AddItemToListBox1($"{accountName} - Sổ tiết kiệm - Số dư: {balance} VNĐ");
            }

  
            this.Parent.Controls.Add(_accPage);
            this.Parent.Controls.Remove(this);
        }


        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(_accPage);
            this.Parent.Controls.Remove(this);
        }
    }
}
