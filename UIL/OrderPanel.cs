using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BLL.Models;
using BLL.Services;

namespace YazLab1._3
{
    public partial class OrderPanel : Form
    {
        ProductService productService;
        OrderService orderService;

        Customer selectedCustomer;

        public OrderPanel(Customer selectedCustomer)
        {
            InitializeComponent();
            this.selectedCustomer = selectedCustomer;
            productService = new ProductService();
            orderService = OrderService.Instance;
        }

        private void FillProductDataGridView()
        {
            try
            {
                DataTable productData = productService.GetAllProducts();

                dtGrdVwOrder.DataSource = productData;

                if (!dtGrdVwOrder.Columns.Contains("SelectColumn"))
                {
                    DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn
                    {
                        Name = "SelectColumn",
                        HeaderText = "Order",
                        Width = 50,
                        ReadOnly = false
                    };
                    dtGrdVwOrder.Columns.Add(chkColumn);
                }

                if (!dtGrdVwOrder.Columns.Contains("QuantityColumn"))
                {
                    DataGridViewTextBoxColumn qtyColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "QuantityColumn",
                        HeaderText = "Quantity",
                        Width = 80,
                        ReadOnly = false,
                        ValueType = typeof(int) 
                    };
                    dtGrdVwOrder.Columns.Add(qtyColumn);
                }

                foreach (DataGridViewColumn column in dtGrdVwOrder.Columns)
                {
                    if (column.Name != "SelectColumn" && column.Name != "QuantityColumn")
                    {
                        column.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ürün bilgileri yüklenirken bir hata oluştu: {ex.Message}",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void OrderPanel_Load(object sender, EventArgs e)
        {
            FillProductDataGridView();
            dtGrdVwOrder.CellValidating += dtGrdVwOrder_CellValidating;
        }

        private void dtGrdVwOrder_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dtGrdVwOrder.Columns[e.ColumnIndex].Name == "QuantityColumn")
            {
                if (!string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    if (!int.TryParse(e.FormattedValue.ToString(), out int value) || value <= 0)
                    {
                        MessageBox.Show("Lütfen pozitif bir tam sayı girin.", "Geçersiz Değer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Cancel = true;
                    }
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedProducts = new List<(Product Product, int Quantity)>();

                foreach (DataGridViewRow row in dtGrdVwOrder.Rows)
                {
                    if (row.Cells["SelectColumn"] is DataGridViewCheckBoxCell checkBoxCell
                        && checkBoxCell.Value != null && (bool)checkBoxCell.Value)
                    {
                        if (row.Cells["QuantityColumn"].Value == null ||
                            !int.TryParse(row.Cells["QuantityColumn"].Value.ToString(), out int quantity) || quantity <= 0)
                        {
                            MessageBox.Show("Lütfen geçerli bir miktar girin.", "Geçersiz Miktar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; 
                        }
                        
                        if(quantity > 5)
                        {
                            MessageBox.Show("Bir üründen en fazla beş adet alabilirsiniz.", "Geçersiz Miktar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        Product product = new Product
                        {
                            ProductID = Convert.ToInt32(row.Cells["ProductID"].Value),
                            ProductName = row.Cells["ProductName"].Value.ToString(),
                            Stock = Convert.ToInt32(row.Cells["Stock"].Value),
                            Price = Convert.ToDecimal(row.Cells["Price"].Value)
                        };

                        selectedProducts.Add((product, quantity));
                    }
                }

                if (selectedProducts.Count > 0)
                {
                    foreach (var (prod, quantity) in selectedProducts)
                    {
                        bool result = orderService.AddOrder(
                            selectedCustomer.CustomerID,
                            prod.ProductID,
                            quantity, 
                            prod.Price * quantity, 
                            DateTime.Now,
                            OrderStatus.Pending.ToString()
                        );

                        if (!result)
                        {
                            MessageBox.Show($"Ürün {prod.ProductName} için sipariş eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen en az bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sipariş eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
