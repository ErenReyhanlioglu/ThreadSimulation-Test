using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BLL.Models;
using BLL.Services;

namespace YazLab1._3
{
    public partial class MainPanel : Form
    {
        CustomerService customerService;
        ProductService productService;
        OrderService orderService;

        CustomerPanel customerPanel;
        ProductPanel productPanel;
        LogPanel logPanel;
        CustomerLoginPanel customerLoginPanel;

        public MainPanel()
        {
            InitializeComponent();

            customerService = new CustomerService();
            productService = new ProductService();
            orderService = OrderService.Instance;
        }

        #region METHODS
        private void FillCustomerDataGridView()
        {
            if (dtGrdVwCustomer.InvokeRequired)
            {
                dtGrdVwCustomer.Invoke(new Action(() =>
                {
                    PreserveAndRestoreSelection(dtGrdVwCustomer, () =>
                    {
                        dtGrdVwCustomer.DataSource = customerService.GetAllCustomers();
                    });
                }));
            }
            else
            {
                PreserveAndRestoreSelection(dtGrdVwCustomer, () =>
                {
                    dtGrdVwCustomer.DataSource = customerService.GetAllCustomers();
                });
            }
        }

        private void FillProductDataGridView()
        {
            if (dtGrdVwProduct.InvokeRequired)
            {
                dtGrdVwProduct.Invoke(new Action(() =>
                {
                    PreserveAndRestoreSelection(dtGrdVwProduct, () =>
                    {
                        dtGrdVwProduct.DataSource = productService.GetAllProducts();
                        FillProductBarChart(chrtProductStock);
                    });
                }));
            }
            else
            {
                PreserveAndRestoreSelection(dtGrdVwProduct, () =>
                {
                    dtGrdVwProduct.DataSource = productService.GetAllProducts();
                    FillProductBarChart(chrtProductStock);
                });
            }
        }

        private void PreserveAndRestoreSelection(DataGridView gridView, Action updateAction)
        {
            int? selectedRowIndex = gridView.CurrentRow?.Index;

            updateAction();

            if (selectedRowIndex.HasValue && selectedRowIndex.Value < gridView.Rows.Count)
            {
                gridView.ClearSelection();
                gridView.Rows[selectedRowIndex.Value].Selected = true;
                gridView.CurrentCell = gridView.Rows[selectedRowIndex.Value].Cells[0];
            }
        }

        public void FillProductBarChart(Chart chrtProductStock)
        {
            try
            {
                DataTable productData = productService.GetAllProducts();

                chrtProductStock.Series.Clear();
                chrtProductStock.Titles.Clear();

                Series barSeries = new Series("Stok Miktarı");
                barSeries.ChartType = SeriesChartType.Bar;

                Series criticBarSeries = new Series("Kritik Stok Miktarı");
                criticBarSeries.ChartType = SeriesChartType.Bar;
                criticBarSeries.Color = Color.Red;

                foreach (DataRow row in productData.Rows)
                {
                    string productName = row["ProductName"].ToString();
                    int stock = Convert.ToInt32(row["Stock"]);

                    int pointIndex = barSeries.Points.AddXY(productName, stock);

                    if (stock < 10)
                    {
                        barSeries.Points[pointIndex].Color = Color.Red;
                    }
                    else
                    {
                        barSeries.Points[pointIndex].Color = Color.Blue;
                    }
                }

                chrtProductStock.Series.Add(barSeries);
                chrtProductStock.Series.Add(criticBarSeries);

                chrtProductStock.ChartAreas[0].AxisX.Title = "Ürün Adı";
                chrtProductStock.ChartAreas[0].AxisY.Title = "Stok Miktarı";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Bar grafik oluşturulurken bir hata oluştu: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UpdateOrderGridView(DataTable sortedOrders)
        {
            if (dtGrdVwOrders.InvokeRequired)
            {
                dtGrdVwOrders.Invoke(new Action(() =>
                {
                    foreach (DataRow row in sortedOrders.Rows)
                    {
                        row["PriorityScore"] = Math.Round(Convert.ToDecimal(row["PriorityScore"]), 2);
                    }

                    dtGrdVwOrders.DataSource = sortedOrders.DefaultView.ToTable(false,
                        "OrderID", "CustomerID", "ProductID", "PriorityScore");
                }));

                FillCustomerDataGridView();
                FillProductDataGridView();
            }
            else
            {
                foreach (DataRow row in sortedOrders.Rows)
                {
                    row["PriorityScore"] = Math.Round(Convert.ToDecimal(row["PriorityScore"]), 2);
                }

                dtGrdVwOrders.DataSource = sortedOrders.DefaultView.ToTable(false,
                    "OrderID", "CustomerID", "ProductID", "PriorityScore");

                FillCustomerDataGridView();
                FillProductDataGridView();
            }

            dtGrdVwOrders.ClearSelection();
        }

        private void dtGrdVwOrders_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridViewRow row = dtGrdVwOrders.Rows[e.RowIndex];

            DataTable orders = (DataTable)dtGrdVwOrders.DataSource;

            if (orders.Rows.Count <= 0)
                return;

            int firstOrderId = Convert.ToInt32(orders.Rows[0]["OrderID"]);

            if (Convert.ToInt32(row.Cells["OrderID"].Value) == firstOrderId)
            {
                row.DefaultCellStyle.BackColor = Color.LightYellow;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void UpdateGridView(DataTable sortedOrders)
        {
            Invoke(new Action(() =>
            {
                UpdateOrderGridView(sortedOrders);
            }));
        }

        private void StartProgressBarAnimation(int processingTime, ManualResetEvent progressCompleted)
        {
            Invoke(new Action(() =>
            {
                InitializeProgressBar(processingTime);

                System.Windows.Forms.Timer timer = CreateProgressBarTimer(processingTime, progressCompleted);
                timer.Start();
            }));
        }

        private void InitializeProgressBar(int processingTime)
        {
            prgrsBrOrderProcess.Visible = true;
            prgrsBrOrderProcess.Style = ProgressBarStyle.Blocks;
            prgrsBrOrderProcess.Minimum = 0;
            prgrsBrOrderProcess.Maximum = processingTime;
            prgrsBrOrderProcess.Value = 0;
        }

        private System.Windows.Forms.Timer CreateProgressBarTimer(int processingTime, ManualResetEvent progressCompleted)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer
            {
                Interval = Math.Max(1, processingTime / 100)
            };

            timer.Tick += async (s, args) =>
            {
                if (prgrsBrOrderProcess.Value < prgrsBrOrderProcess.Maximum)
                {
                    prgrsBrOrderProcess.Value += timer.Interval;

                    if (prgrsBrOrderProcess.Value > prgrsBrOrderProcess.Maximum)
                    {
                        prgrsBrOrderProcess.Value = prgrsBrOrderProcess.Maximum;
                    }
                }
                else
                {
                    timer.Stop();

                    prgrsBrOrderProcess.Value = prgrsBrOrderProcess.Maximum;

                    await Task.Delay(250);

                    prgrsBrOrderProcess.Visible = false;

                    progressCompleted.Set();
                }
            };

            return timer;
        }

        #endregion

        #region EVENTS

        #region BUTTONS

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            orderService.StopOrderProcessing();

            customerPanel = new CustomerPanel();
            customerPanel.ShowDialog();
            FillCustomerDataGridView();

            orderService.ResumeOrderProcessing();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dtGrdVwCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtGrdVwCustomer.SelectedRows[0];

                bool result = customerService.DeleteCustomer((int)row.Cells["CustomerID"].Value);

                if (!result)
                    MessageBox.Show("Müşteri silinemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                FillCustomerDataGridView();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            orderService.StopOrderProcessing();

            if (dtGrdVwCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtGrdVwCustomer.SelectedRows[0];

                Customer selectedCustomer = new Customer
                {
                    CustomerID = Convert.ToInt32(row.Cells["CustomerID"].Value),
                    CustomerName = row.Cells["CustomerName"].Value.ToString(),
                    Budget = Convert.ToDecimal(row.Cells["Budget"].Value),
                    CustomerType = (CustomerType)Enum.Parse(typeof(CustomerType), row.Cells["CustomerType"].Value.ToString()),
                    TotalSpent = Convert.ToDecimal(row.Cells["TotalSpent"].Value)
                };

                customerPanel = new CustomerPanel(selectedCustomer);
                customerPanel.ShowDialog();

                FillCustomerDataGridView();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            orderService.ResumeOrderProcessing();
        }

        private void btnOrderCustomer_Click(object sender, EventArgs e)
        {
            orderService.StopOrderProcessing();

            if (dtGrdVwCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtGrdVwCustomer.SelectedRows[0];

                Customer selectedCustomer = new Customer
                {
                    CustomerID = Convert.ToInt32(row.Cells["CustomerID"].Value),
                    CustomerName = row.Cells["CustomerName"].Value.ToString(),
                    Budget = Convert.ToDecimal(row.Cells["Budget"].Value),
                    CustomerType = (CustomerType)Enum.Parse(typeof(CustomerType), row.Cells["CustomerType"].Value.ToString()),
                    TotalSpent = Convert.ToDecimal(row.Cells["TotalSpent"].Value)
                };

                customerLoginPanel = new CustomerLoginPanel(selectedCustomer);
                customerLoginPanel.ShowDialog();

                FillCustomerDataGridView();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            orderService.ResumeOrderProcessing();
        }

        // PRODUCT
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            orderService.StopOrderProcessing();

            productPanel = new ProductPanel();
            productPanel.ShowDialog();

            orderService.ResumeOrderProcessing();

            FillProductDataGridView();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dtGrdVwProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtGrdVwProduct.SelectedRows[0];

                bool result = productService.DeleteProduct((int)row.Cells["ProductID"].Value);

                if (!result)
                    MessageBox.Show("Ürün silinemedi.", "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                FillProductDataGridView();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin.", "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            orderService.StopOrderProcessing();

            if (dtGrdVwProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtGrdVwProduct.SelectedRows[0];

                Product selectedProduct = new Product
                {
                    ProductID = Convert.ToInt32(row.Cells["ProductID"].Value),
                    ProductName = row.Cells["ProductName"].Value.ToString(),
                    Stock = Convert.ToInt32(row.Cells["Stock"].Value),
                    Price = Convert.ToDecimal(row.Cells["Price"].Value)
                };

                ProductPanel productPanel = new ProductPanel(selectedProduct);
                productPanel.ShowDialog();

                FillProductDataGridView();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            orderService.ResumeOrderProcessing();
        }

        // LOGS
        private void btnLogs_Click(object sender, EventArgs e)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is LogPanel)
                {
                    openForm.BringToFront();
                    return;
                }
            }

            logPanel = new LogPanel();
            logPanel.Show();
        }

        // SIMULATION
        private async void btnSimRun_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() =>
                {
                    orderService.ProcessOrders(
                        updateUI: UpdateGridView,
                        updateProgressBar: StartProgressBarAnimation
                    );
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş işlenirken hata oluştu: {ex.Message}");
            }
        }

        #endregion

        #region MAİN PANEL
        private void MainPanel_Load(object sender, EventArgs e)
        {
            dtGrdVwOrders.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dtGrdVwOrders_RowPostPaint);

            orderService.StartOrderExpirationCheck();

            FillCustomerDataGridView();
            FillProductDataGridView();

            orderService.StartOrderProcessingThread(UpdateOrderGridView);
        }

        #endregion

        #endregion
    }
}