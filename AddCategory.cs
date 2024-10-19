using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormapdemo
{
    public partial class AddCategory : UserControl
    {
        private CategoryPage categoryPage;

        public AddCategory(CategoryPage page)
        {
            InitializeComponent();
            categoryPage = page;
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string categoryName = txtCategory.Text;
            string categoryType = comboBoxType.SelectedItem.ToString();

            if (categoryType == "Thu nhập")
            {
                categoryPage.AddItemToListBox1(categoryName);
            }
            else if (categoryType == "Chi tiêu")
            {
                categoryPage.AddItemToListBox2(categoryName);
            }
            this.Parent.Controls.Add(categoryPage);
            this.Parent.Controls.Remove(this);
        }

        private void btnLeave_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát mà không lưu không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Parent.Controls.Add(categoryPage);
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
