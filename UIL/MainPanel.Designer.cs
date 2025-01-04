namespace YazLab1._3
{
    partial class MainPanel
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grpBxCustomers = new System.Windows.Forms.GroupBox();
            this.btnOrderCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dtGrdVwCustomer = new System.Windows.Forms.DataGridView();
            this.grpBxProduct = new System.Windows.Forms.GroupBox();
            this.tbCntrlProducts = new System.Windows.Forms.TabControl();
            this.tbPgProductData = new System.Windows.Forms.TabPage();
            this.dtGrdVwProduct = new System.Windows.Forms.DataGridView();
            this.tbPgProductChart = new System.Windows.Forms.TabPage();
            this.chrtProductStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnSimRun = new System.Windows.Forms.Button();
            this.dtGrdVwOrders = new System.Windows.Forms.DataGridView();
            this.prgrsBrOrderProcess = new System.Windows.Forms.ProgressBar();
            this.grpBxCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCustomer)).BeginInit();
            this.grpBxProduct.SuspendLayout();
            this.tbCntrlProducts.SuspendLayout();
            this.tbPgProductData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwProduct)).BeginInit();
            this.tbPgProductChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtProductStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxCustomers
            // 
            this.grpBxCustomers.Controls.Add(this.btnOrderCustomer);
            this.grpBxCustomers.Controls.Add(this.btnEditCustomer);
            this.grpBxCustomers.Controls.Add(this.btnDeleteCustomer);
            this.grpBxCustomers.Controls.Add(this.btnAddCustomer);
            this.grpBxCustomers.Controls.Add(this.dtGrdVwCustomer);
            this.grpBxCustomers.Location = new System.Drawing.Point(13, 13);
            this.grpBxCustomers.Name = "grpBxCustomers";
            this.grpBxCustomers.Size = new System.Drawing.Size(751, 373);
            this.grpBxCustomers.TabIndex = 0;
            this.grpBxCustomers.TabStop = false;
            this.grpBxCustomers.Text = "Customers";
            // 
            // btnOrderCustomer
            // 
            this.btnOrderCustomer.Location = new System.Drawing.Point(581, 335);
            this.btnOrderCustomer.Name = "btnOrderCustomer";
            this.btnOrderCustomer.Size = new System.Drawing.Size(164, 23);
            this.btnOrderCustomer.TabIndex = 4;
            this.btnOrderCustomer.Text = "Order Customer";
            this.btnOrderCustomer.UseVisualStyleBackColor = true;
            this.btnOrderCustomer.Click += new System.EventHandler(this.btnOrderCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(388, 335);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(164, 23);
            this.btnEditCustomer.TabIndex = 3;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(199, 335);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(164, 23);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(7, 335);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(164, 23);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // dtGrdVwCustomer
            // 
            this.dtGrdVwCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwCustomer.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtGrdVwCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwCustomer.Location = new System.Drawing.Point(7, 21);
            this.dtGrdVwCustomer.MultiSelect = false;
            this.dtGrdVwCustomer.Name = "dtGrdVwCustomer";
            this.dtGrdVwCustomer.ReadOnly = true;
            this.dtGrdVwCustomer.RowHeadersWidth = 51;
            this.dtGrdVwCustomer.RowTemplate.Height = 24;
            this.dtGrdVwCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwCustomer.Size = new System.Drawing.Size(738, 294);
            this.dtGrdVwCustomer.TabIndex = 0;
            // 
            // grpBxProduct
            // 
            this.grpBxProduct.Controls.Add(this.tbCntrlProducts);
            this.grpBxProduct.Controls.Add(this.btnEditProduct);
            this.grpBxProduct.Controls.Add(this.btnDeleteProduct);
            this.grpBxProduct.Controls.Add(this.btnAddProduct);
            this.grpBxProduct.Location = new System.Drawing.Point(13, 392);
            this.grpBxProduct.Name = "grpBxProduct";
            this.grpBxProduct.Size = new System.Drawing.Size(751, 373);
            this.grpBxProduct.TabIndex = 1;
            this.grpBxProduct.TabStop = false;
            this.grpBxProduct.Text = "Products";
            // 
            // tbCntrlProducts
            // 
            this.tbCntrlProducts.Controls.Add(this.tbPgProductData);
            this.tbCntrlProducts.Controls.Add(this.tbPgProductChart);
            this.tbCntrlProducts.Location = new System.Drawing.Point(7, 22);
            this.tbCntrlProducts.Name = "tbCntrlProducts";
            this.tbCntrlProducts.SelectedIndex = 0;
            this.tbCntrlProducts.Size = new System.Drawing.Size(738, 307);
            this.tbCntrlProducts.TabIndex = 4;
            // 
            // tbPgProductData
            // 
            this.tbPgProductData.Controls.Add(this.dtGrdVwProduct);
            this.tbPgProductData.Location = new System.Drawing.Point(4, 25);
            this.tbPgProductData.Name = "tbPgProductData";
            this.tbPgProductData.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgProductData.Size = new System.Drawing.Size(730, 278);
            this.tbPgProductData.TabIndex = 0;
            this.tbPgProductData.Text = "Products";
            this.tbPgProductData.UseVisualStyleBackColor = true;
            // 
            // dtGrdVwProduct
            // 
            this.dtGrdVwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwProduct.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtGrdVwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwProduct.Location = new System.Drawing.Point(9, 6);
            this.dtGrdVwProduct.MultiSelect = false;
            this.dtGrdVwProduct.Name = "dtGrdVwProduct";
            this.dtGrdVwProduct.ReadOnly = true;
            this.dtGrdVwProduct.RowHeadersWidth = 51;
            this.dtGrdVwProduct.RowTemplate.Height = 24;
            this.dtGrdVwProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwProduct.Size = new System.Drawing.Size(715, 266);
            this.dtGrdVwProduct.TabIndex = 0;
            // 
            // tbPgProductChart
            // 
            this.tbPgProductChart.Controls.Add(this.chrtProductStock);
            this.tbPgProductChart.Location = new System.Drawing.Point(4, 25);
            this.tbPgProductChart.Name = "tbPgProductChart";
            this.tbPgProductChart.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgProductChart.Size = new System.Drawing.Size(730, 278);
            this.tbPgProductChart.TabIndex = 1;
            this.tbPgProductChart.Text = "Product Stock";
            this.tbPgProductChart.UseVisualStyleBackColor = true;
            // 
            // chrtProductStock
            // 
            chartArea4.Name = "ChartArea1";
            this.chrtProductStock.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chrtProductStock.Legends.Add(legend4);
            this.chrtProductStock.Location = new System.Drawing.Point(6, 6);
            this.chrtProductStock.Name = "chrtProductStock";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chrtProductStock.Series.Add(series4);
            this.chrtProductStock.Size = new System.Drawing.Size(718, 262);
            this.chrtProductStock.TabIndex = 2;
            this.chrtProductStock.Text = "chart1";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(522, 335);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(223, 23);
            this.btnEditProduct.TabIndex = 3;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(264, 335);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(223, 23);
            this.btnDeleteProduct.TabIndex = 2;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(7, 335);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(223, 23);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prgrsBrOrderProcess);
            this.groupBox1.Controls.Add(this.btnLogs);
            this.groupBox1.Controls.Add(this.btnSimRun);
            this.groupBox1.Controls.Add(this.dtGrdVwOrders);
            this.groupBox1.Location = new System.Drawing.Point(770, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 752);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation And Logs";
            // 
            // btnLogs
            // 
            this.btnLogs.Location = new System.Drawing.Point(271, 714);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(247, 23);
            this.btnLogs.TabIndex = 1;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnSimRun
            // 
            this.btnSimRun.Location = new System.Drawing.Point(7, 714);
            this.btnSimRun.Name = "btnSimRun";
            this.btnSimRun.Size = new System.Drawing.Size(247, 23);
            this.btnSimRun.TabIndex = 1;
            this.btnSimRun.Text = "Run Simulation";
            this.btnSimRun.UseVisualStyleBackColor = true;
            this.btnSimRun.Click += new System.EventHandler(this.btnSimRun_Click);
            // 
            // dtGrdVwOrders
            // 
            this.dtGrdVwOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwOrders.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtGrdVwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwOrders.Enabled = false;
            this.dtGrdVwOrders.Location = new System.Drawing.Point(7, 22);
            this.dtGrdVwOrders.MultiSelect = false;
            this.dtGrdVwOrders.Name = "dtGrdVwOrders";
            this.dtGrdVwOrders.ReadOnly = true;
            this.dtGrdVwOrders.RowHeadersWidth = 51;
            this.dtGrdVwOrders.RowTemplate.Height = 24;
            this.dtGrdVwOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtGrdVwOrders.Size = new System.Drawing.Size(510, 633);
            this.dtGrdVwOrders.TabIndex = 0;
            // 
            // prgrsBrOrderProcess
            // 
            this.prgrsBrOrderProcess.ForeColor = System.Drawing.Color.Chartreuse;
            this.prgrsBrOrderProcess.Location = new System.Drawing.Point(6, 675);
            this.prgrsBrOrderProcess.Name = "prgrsBrOrderProcess";
            this.prgrsBrOrderProcess.Size = new System.Drawing.Size(511, 23);
            this.prgrsBrOrderProcess.TabIndex = 2;
            this.prgrsBrOrderProcess.Visible = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 773);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBxProduct);
            this.Controls.Add(this.grpBxCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YazLab1.3";
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.grpBxCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCustomer)).EndInit();
            this.grpBxProduct.ResumeLayout(false);
            this.tbCntrlProducts.ResumeLayout(false);
            this.tbPgProductData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwProduct)).EndInit();
            this.tbPgProductChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtProductStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxCustomers;
        private System.Windows.Forms.DataGridView dtGrdVwCustomer;
        private System.Windows.Forms.Button btnOrderCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.GroupBox grpBxProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dtGrdVwProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtGrdVwOrders;
        private System.Windows.Forms.Button btnSimRun;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.TabControl tbCntrlProducts;
        private System.Windows.Forms.TabPage tbPgProductData;
        private System.Windows.Forms.TabPage tbPgProductChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtProductStock;
        private System.Windows.Forms.ProgressBar prgrsBrOrderProcess;
    }
}

