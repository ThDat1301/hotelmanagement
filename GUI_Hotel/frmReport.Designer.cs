﻿namespace GUI_Hotel
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bthThoat = new System.Windows.Forms.ToolStripButton();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Order_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_checkin_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_checkout_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_total_amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_num_of_cus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_is_group = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_note = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_customer_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Order_employee_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExport = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bthThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1275, 42);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bthThoat
            // 
            this.bthThoat.Image = global::GUI_Hotel.Properties.Resources.exit;
            this.bthThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bthThoat.Name = "bthThoat";
            this.bthThoat.Size = new System.Drawing.Size(41, 39);
            this.bthThoat.Text = "Thoát";
            this.bthThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bthThoat.Click += new System.EventHandler(this.bthThoat_Click);
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 485);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1275, 208);
            this.gcDanhSach.TabIndex = 4;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gvDanhSach.Appearance.Row.Options.UseFont = true;
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Order_id,
            this.Order_checkin_date,
            this.Order_checkout_date,
            this.Order_total_amount,
            this.Order_num_of_cus,
            this.Order_status,
            this.Order_is_group,
            this.Order_note,
            this.Order_customer_id,
            this.Order_employee_id});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            this.gvDanhSach.OptionsBehavior.Editable = false;
            // 
            // Order_id
            // 
            this.Order_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_id.AppearanceCell.Options.UseFont = true;
            this.Order_id.Caption = "Mã đặt phòng";
            this.Order_id.FieldName = "Order_id";
            this.Order_id.Name = "Order_id";
            this.Order_id.Visible = true;
            this.Order_id.VisibleIndex = 0;
            // 
            // Order_checkin_date
            // 
            this.Order_checkin_date.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_checkin_date.AppearanceCell.Options.UseFont = true;
            this.Order_checkin_date.Caption = "Ngày đặt phòng";
            this.Order_checkin_date.FieldName = "Order_checkin_date";
            this.Order_checkin_date.MinWidth = 21;
            this.Order_checkin_date.Name = "Order_checkin_date";
            this.Order_checkin_date.Visible = true;
            this.Order_checkin_date.VisibleIndex = 1;
            // 
            // Order_checkout_date
            // 
            this.Order_checkout_date.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_checkout_date.AppearanceCell.Options.UseFont = true;
            this.Order_checkout_date.Caption = "Ngày trả phòng";
            this.Order_checkout_date.FieldName = "Order_checkout_date";
            this.Order_checkout_date.MinWidth = 21;
            this.Order_checkout_date.Name = "Order_checkout_date";
            this.Order_checkout_date.Visible = true;
            this.Order_checkout_date.VisibleIndex = 2;
            // 
            // Order_total_amount
            // 
            this.Order_total_amount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_total_amount.AppearanceCell.Options.UseFont = true;
            this.Order_total_amount.Caption = "Tổng tiền";
            this.Order_total_amount.FieldName = "Order_total_amount";
            this.Order_total_amount.MinWidth = 21;
            this.Order_total_amount.Name = "Order_total_amount";
            this.Order_total_amount.Visible = true;
            this.Order_total_amount.VisibleIndex = 3;
            // 
            // Order_num_of_cus
            // 
            this.Order_num_of_cus.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_num_of_cus.AppearanceCell.Options.UseFont = true;
            this.Order_num_of_cus.Caption = "Số lượng khách";
            this.Order_num_of_cus.FieldName = "Order_num_of_cus";
            this.Order_num_of_cus.MinWidth = 21;
            this.Order_num_of_cus.Name = "Order_num_of_cus";
            this.Order_num_of_cus.Visible = true;
            this.Order_num_of_cus.VisibleIndex = 4;
            // 
            // Order_status
            // 
            this.Order_status.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_status.AppearanceCell.Options.UseFont = true;
            this.Order_status.Caption = "Trạng thái";
            this.Order_status.FieldName = "Order_status";
            this.Order_status.MinWidth = 21;
            this.Order_status.Name = "Order_status";
            // 
            // Order_is_group
            // 
            this.Order_is_group.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_is_group.AppearanceCell.Options.UseFont = true;
            this.Order_is_group.Caption = "Đặt theo đoàn";
            this.Order_is_group.FieldName = "Order_is_group";
            this.Order_is_group.MinWidth = 21;
            this.Order_is_group.Name = "Order_is_group";
            // 
            // Order_note
            // 
            this.Order_note.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_note.AppearanceCell.Options.UseFont = true;
            this.Order_note.Caption = "Ghi chú";
            this.Order_note.FieldName = "Order_note";
            this.Order_note.MinWidth = 21;
            this.Order_note.Name = "Order_note";
            this.Order_note.Visible = true;
            this.Order_note.VisibleIndex = 5;
            // 
            // Order_customer_id
            // 
            this.Order_customer_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_customer_id.AppearanceCell.Options.UseFont = true;
            this.Order_customer_id.Caption = "Mã khách hàng";
            this.Order_customer_id.FieldName = "Order_customer_id";
            this.Order_customer_id.MinWidth = 21;
            this.Order_customer_id.Name = "Order_customer_id";
            // 
            // Order_employee_id
            // 
            this.Order_employee_id.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Order_employee_id.AppearanceCell.Options.UseFont = true;
            this.Order_employee_id.Caption = "Mã nhân viên";
            this.Order_employee_id.FieldName = "Order_employee_id";
            this.Order_employee_id.MinWidth = 21;
            this.Order_employee_id.Name = "Order_employee_id";
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(59, 30);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(147, 26);
            this.dtpStart.TabIndex = 5;
            this.dtpStart.Value = new System.DateTime(2023, 4, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "To:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(263, 30);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(147, 26);
            this.dtpEnd.TabIndex = 7;
            this.dtpEnd.Value = new System.DateTime(2023, 4, 22, 15, 56, 12, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 73);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chọn thời gian ";
            // 
            // btnStatistical
            // 
            this.btnStatistical.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistical.Location = new System.Drawing.Point(463, 68);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(113, 37);
            this.btnStatistical.TabIndex = 9;
            this.btnStatistical.Text = "Thống kê";
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // chart1
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 124);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Total Amount";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1251, 355);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Doanh thu";
            this.chart1.Titles.Add(title2);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(582, 68);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(138, 37);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export to image";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 693);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnStatistical);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bthThoat;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn Order_id;
        private DevExpress.XtraGrid.Columns.GridColumn Order_checkin_date;
        private DevExpress.XtraGrid.Columns.GridColumn Order_checkout_date;
        private DevExpress.XtraGrid.Columns.GridColumn Order_total_amount;
        private DevExpress.XtraGrid.Columns.GridColumn Order_num_of_cus;
        private DevExpress.XtraGrid.Columns.GridColumn Order_status;
        private DevExpress.XtraGrid.Columns.GridColumn Order_is_group;
        private DevExpress.XtraGrid.Columns.GridColumn Order_note;
        private DevExpress.XtraGrid.Columns.GridColumn Order_customer_id;
        private DevExpress.XtraGrid.Columns.GridColumn Order_employee_id;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnExport;
    }
}