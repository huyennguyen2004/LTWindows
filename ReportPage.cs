using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormapdemo
{
    public partial class ReportPage : UserControl
    {
        public ReportPage()
        {
            InitializeComponent();
            panel2.Visible = false;
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
            panel2.Visible = true;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Income", "Thu Nhập");
            dataGridView1.Columns.Add("Expense", "Chi Tiêu");
            dataGridView1.Columns.Add("Total", "Tổng");

            dataGridView1.Rows.Add("10,000,000 VNĐ", "5,000,000 VNĐ", "5,000,000 VNĐ");
            dataGridView1.Rows.Add("12,000,000 VNĐ", "7,000,000 VNĐ", "5,000,000 VNĐ");

            // Cập nhật biểu đồ tròn
            UpdatePieChart(10000000, 5000000); // Tổng thu nhập, tổng chi tiêu
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Expense Category", "Danh Mục Chi Tiêu");
            dataGridView1.Columns.Add("Amount", "Số Tiền");

            dataGridView1.Rows.Add("Thực Phẩm", "2,000,000 VNĐ");
            dataGridView1.Rows.Add("Giải Trí", "1,000,000 VNĐ");
            dataGridView1.Rows.Add("Chi Phí Khác", "4,000,000 VNĐ");

            // Cập nhật biểu đồ tròn
            UpdatePieChart(0, 7000000); // Không có thu nhập, tổng chi tiêu
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Event", "Sự Kiện");
            dataGridView1.Columns.Add("Income", "Thu Nhập");
            dataGridView1.Columns.Add("Expense", "Chi Tiêu");

            dataGridView1.Rows.Add("Chuyến Đi A", "5,000,000 VNĐ", "2,000,000 VNĐ");
            dataGridView1.Rows.Add("Sự Kiện B", "8,000,000 VNĐ", "3,000,000 VNĐ");

            // Cập nhật biểu đồ tròn
            UpdatePieChart(13000000, 5000000);
        }
        private void UpdatePieChart(decimal income, decimal expense)
        {
            chart1.Series.Clear(); // Xóa các series cũ

            // Tạo series mới cho biểu đồ tròn
            Series series = new Series
            {
                Name = "Financial",
                Color = Color.Blue,
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };

            // Thêm điểm dữ liệu vào series
            series.Points.AddXY("Thu Nhập", income);
            series.Points.AddXY("Chi Tiêu", expense);

            // Thêm series vào biểu đồ
            chart1.Series.Add(series);
            chart1.Invalidate(); // Vẽ lại biểu đồ
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
