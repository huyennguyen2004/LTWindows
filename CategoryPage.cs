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
    public partial class CategoryPage : UserControl
    {
        private Panel panelAddCategory;

        public CategoryPage()
        {
            InitializeComponent();
            LoadData();
            InitializePanel();
        }
        private void InitializePanel()
        {
            this.panelAddCategory = new System.Windows.Forms.Panel();
            this.panelAddCategory.Location = new System.Drawing.Point(0, 0); 
            this.panelAddCategory.Size = new System.Drawing.Size(400, 300); 
            this.Controls.Add(this.panelAddCategory);
        }
        private void LoadData()
        {
            listBox1.Items.Add("Lương");
            listBox1.Items.Add("Thưởng");
            listBox1.Items.Add("Kinh doanh");
            listBox1.Items.Add("Lãi ngân hàng");

            listBox2.Items.Add("Ăn uống");
            listBox2.Items.Add("Mua sắm");
            listBox2.Items.Add("Điện nước");
            listBox2.Items.Add("Du lịch");
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

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();
            MessageBox.Show("Bạn đã chọn loại thu: " + selectedItem);
        }

        public void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox2.SelectedItem.ToString();
            MessageBox.Show("Bạn đã chọn loại chi tiêu: " + selectedItem);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory(this);
            this.Parent.Controls.Add(addCategory);
            this.Parent.Controls.Remove(this);
        }
        public void AddItemToListBox1(string item)
        {
            listBox1.Items.Add(item);
        }

        public void AddItemToListBox2(string item)
        {
            listBox2.Items.Add(item);
        }

    }
}
