using BUS_Hotel;
using DevExpress.XtraCharts;
using DTO_Hotel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace GUI_Hotel
{
    public partial class frmReport : DevExpress.XtraEditors.XtraForm
    {
        public frmReport()
        {
            InitializeComponent();
        }
        OrderBUS bus_order = new OrderBUS();
        private void frmReport_Load(object sender, EventArgs e)
        {
            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            loadData();
        }
        void loadData()
        {
            gcDanhSach.DataSource = bus_order.getOrders(dtpStart.Value.AddDays(-1), dtpEnd.Value);
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            loadData();

            List<DateTime> dates = new List<DateTime>();
            DateTime currentDate = dtpStart.Value.Date;
            while (currentDate <= dtpEnd.Value.Date)
            {
                // Thêm ngày hiện tại vào danh sách
                dates.Add(currentDate);

                // Tăng ngày hiện tại lên 1 ngày
                currentDate = currentDate.AddDays(1);
            }

            Dictionary<DateTime, double> dailyTotal = new Dictionary<DateTime, double>();
            foreach (DTO_Order order in bus_order.getOrders(dtpStart.Value.AddDays(-1), dtpEnd.Value))
            {
                DateTime checkoutDate = order.Order_checkout_date.Date;
                if(dailyTotal.ContainsKey(checkoutDate))
                    dailyTotal[checkoutDate] += order.Order_total_amount;
                else
                    dailyTotal[checkoutDate] = order.Order_total_amount;
            }

            chart1.Series.Clear();
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Total Amount");
            series.ChartType = SeriesChartType.Column;
            chart1.Series.Add(series);

            // Truyền dữ liệu vào biểu đồ
            foreach (DateTime date in dailyTotal.Keys)
            {
                double totalAmount = dailyTotal[date];
                series.Points.AddXY(date, totalAmount);
            }

        }





















        private void bthThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có thực sự muốn thoát ?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.Title = "Save chart image";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                chart1.SaveImage(path, ChartImageFormat.Png);
            }
        }



        // Tạo một DataTable để lưu trữ dữ liệu thống kê:
        /* DataTable dt = new DataTable();
         dt.Columns.Add("Ngày", typeof(DateTime));
         dt.Columns.Add("Doanh thu", typeof(float));

         // Duyệt từng dòng gridControl và tính tổng tiền của từng ngày
         foreach (var row in gcDanhSach.DataSource)
         {
             DateTime date = (DateTime)row["checkoutDate"];
             float totalAmount = (float)row["totalAmount"];

             // Tìm kiếm xem đã có ngày trong DataTable chưa, nếu có thì cộng tổng tiền vào, nếu chưa thì thêm mới một dòng vào DataTable
             DataRow[] foundRows = dt.Select($"Ngày = #{date.ToString("yyyy-MM-dd")}#");
             if (foundRows.Length > 0)
             {
                 foundRows[0]["Doanh thu"] = (float)foundRows[0]["Doanh thu"] + totalAmount;
             }
             else 
             {
                 DataRow newRow = dt.NewRow();
                 newRow["Ngày"] = date;
                 newRow["Doanh thu"] = totalAmount;
                 dt.Rows.Add(newRow);
             }
         }

         // Vẽ biểu đồ
         chart1.Series.Clear();
         Series series = new Series("Doanh thu", ViewType.Bar);
         series.ArgumentDataMember = "Ngày";
         series.ValueDataMembers.AddRange(new string[] { "Doanh thu" });
         chart1.Series.Add(series);
         chart1.DataSource = dt;
         *//*chart1.RefreshData();*//*
         chart1.DataBind();*/
    }
}