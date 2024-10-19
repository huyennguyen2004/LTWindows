using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormapdemo
{
    public partial class TransactionPage : UserControl
    {


        public TransactionPage()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as Form1;
            if (form != null)
            {
                form.btnHome_Click(sender, e);
            }
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string type = comboBoxType.SelectedItem?.ToString() ?? "";
            string category = comboBoxCategory.SelectedItem?.ToString() ?? "";
            string source = comboBoxSource.SelectedItem?.ToString() ?? "";
            string money = txtMoney.Text;
            string description = txtDescription.Text;
            DateTime selectedDate = dateTimePicker1.Value; 
            int hour = (int)numericUpDownHour.Value;
            int minute = (int)numericUpDownMinute.Value;

            if (string.IsNullOrEmpty(type) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(source) || string.IsNullOrEmpty(money))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridView1.Rows.Add(type, money, category, source, description, $"{selectedDate.ToShortDateString()}",hour,minute);
            comboBoxType.SelectedIndex = -1;
            comboBoxCategory.SelectedIndex = -1;
            comboBoxSource.SelectedIndex = -1;
            txtMoney.Clear();
            txtDescription.Clear();
            dateTimePicker1.Value = DateTime.Now;
            numericUpDownHour.Value = 0;
            numericUpDownMinute.Value = 0;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
        }
    }
}

