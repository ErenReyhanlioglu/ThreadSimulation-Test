using BLL.Services;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace YazLab1._3
{
    public partial class LogPanel : Form
    {
        LogService logService;
        CustomerService customerService;
        OrderService orderService;
        ProductService productService;

        public LogPanel()
        {
            InitializeComponent();
            logService = new LogService();
            customerService = new CustomerService();
            orderService = OrderService.Instance;
            productService = new ProductService();
        }

        private void LogPanel_Load(object sender, EventArgs e)
        {
            FillLogsDataGridView();
            dtGrdVwOpLogs.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dtGrdVwOpLogs_RowPostPaint);
        }

        private void FillLogsDataGridView()
        {
            try
            {
                DataTable logs = logService.GetAllLogs();

                if (logs != null && logs.Rows.Count > 0)
                {
                    dtGrdVwOpLogs.DataSource = logs;

                    dtGrdVwOpLogs.Columns["LogID"].HeaderText = "Log ID";
                    dtGrdVwOpLogs.Columns["CustomerID"].HeaderText = "Customer ID";
                    dtGrdVwOpLogs.Columns["OrderID"].HeaderText = "Order ID";
                    dtGrdVwOpLogs.Columns["ProductID"].HeaderText = "Product ID";
                    dtGrdVwOpLogs.Columns["LogDate"].HeaderText = "Log Date";
                    dtGrdVwOpLogs.Columns["LogType"].HeaderText = "Log Type";
                    dtGrdVwOpLogs.Columns["LogDetails"].HeaderText = "Details";

                    dtGrdVwOpLogs.Columns["LogID"].Width = 40;
                    dtGrdVwOpLogs.Columns["CustomerID"].Width = 40;
                    dtGrdVwOpLogs.Columns["OrderID"].Width = 40;
                    dtGrdVwOpLogs.Columns["ProductID"].Width = 40;
                    dtGrdVwOpLogs.Columns["LogDate"].Width = 150;
                    dtGrdVwOpLogs.Columns["LogType"].Width = 120;
                    dtGrdVwOpLogs.Columns["LogDetails"].Width = 300;

                    dtGrdVwOpLogs.Columns["LogID"].DisplayIndex = 0;
                    dtGrdVwOpLogs.Columns["CustomerID"].DisplayIndex = 1;
                    dtGrdVwOpLogs.Columns["OrderID"].DisplayIndex = 2;
                    dtGrdVwOpLogs.Columns["ProductID"].DisplayIndex = 3;
                    dtGrdVwOpLogs.Columns["LogDate"].DisplayIndex = 4;
                    dtGrdVwOpLogs.Columns["LogType"].DisplayIndex = 5;
                    dtGrdVwOpLogs.Columns["LogDetails"].DisplayIndex = 6;

                    dtGrdVwOpLogs.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Log kayıtları bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loglar yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGrdVwOpLogs_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var row = dtGrdVwOpLogs.Rows[e.RowIndex];
            if (row.Cells["LogType"].Value != null)
            {
                string logType = row.Cells["LogType"].Value.ToString();

                if (logType == "Info")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (logType == "Warning")
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                }
                else if (logType == "Error")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void dtGrdVwOpLogs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dtGrdVwOpLogs.Rows[e.RowIndex];

                int? customerId = selectedRow.Cells["CustomerID"].Value as int?;
                int? orderId = selectedRow.Cells["OrderID"].Value as int?;
                int? productId = selectedRow.Cells["ProductID"].Value as int?;

                ShowLogDetails(customerId, orderId, productId);
            }
        }

        private void ShowLogDetails(int? customerId, int? orderId, int? productID)
        {
            try
            {
                if (orderId.HasValue)
                {
                    DataTable orderDetails = orderService.GetOrderByID(orderId.Value);
                    dtGrdVwOrderLogInf.DataSource = orderDetails.Rows.Count > 0 ? orderDetails : null;
                }
                else
                    dtGrdVwOrderLogInf.DataSource = null;

                if (customerId.HasValue)
                {
                    DataTable customerDetails = customerService.ConvertCustomerToDataTable(customerService.GetCustomerByID(customerId.Value));
                    dtGrdVwCustomerLogInf.DataSource = customerDetails.Rows.Count > 0 ? customerDetails : null;
                }
                else
                    dtGrdVwCustomerLogInf.DataSource = null;

                if(productID.HasValue)
                {
                    DataTable productDetails = productService.GetProductByID(productID.Value);
                    dtGrdVwProductLogInf.DataSource = productDetails.Rows.Count > 0 ? productDetails : null;
                }
                else
                    dtGrdVwProductLogInf.DataSource = null;

                dtGrdVwOrderLogInf.ClearSelection();
                dtGrdVwCustomerLogInf.ClearSelection();
                dtGrdVwProductLogInf.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Detaylar getirilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
