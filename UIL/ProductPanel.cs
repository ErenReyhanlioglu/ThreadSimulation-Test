using System;
using System.Windows.Forms;
using BLL.Models;
using BLL.Services;

namespace YazLab1._3
{
    public partial class ProductPanel : Form
    {
        ProductService productService;

        Product productForEdit;
        int pageType; // 0: Add Product, 1: Edit Product

        public ProductPanel() // Add Product
        {
            InitializeComponent();
            productService = new ProductService();
            pageType = 0;
            SetPanelType();
        }

        public ProductPanel(Product _productForEdit) // Edit Product
        {
            InitializeComponent();
            productService = new ProductService();
            productForEdit = _productForEdit;
            pageType = 1;
            SetPanelType();
        }

        private void SetPanelType()
        {
            if (pageType == 0) // Add Product
            {
                this.Text = "Add Product";
            }
            else if (pageType == 1) // Edit Product
            {
                this.Text = "Edit Product";
                FillProductInfos();
            }
        }

        private void FillProductInfos()
        {
            if (productForEdit != null)
            {
                txtBxProductName.Text = productForEdit.ProductName;
                txtBxStock.Text = productForEdit.Stock.ToString();
                txtBxPrice.Text = productForEdit.Price.ToString();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBxProductName.Text))
            {
                MessageBox.Show("Ürün adı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtBxStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Geçerli bir stok değeri girin (pozitif tam sayı).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtBxPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Geçerli bir fiyat girin (pozitif sayı).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result = false;

            if (pageType == 0) // Add Product
            {
                result = productService.AddProduct(
                    txtBxProductName.Text,
                    stock,
                    price);
            }
            else if (pageType == 1) // Edit Product
            {
                if (productForEdit == null)
                {
                    MessageBox.Show("Düzenlenecek ürün bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                result = productService.EditProduct(
                    productForEdit.ProductID,
                    txtBxProductName.Text,
                    stock,
                    price);
            }

            if (result)
            {
                this.Close();
            }
            else
                MessageBox.Show("Ürün eklenirken/düzenlenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
