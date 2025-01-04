namespace YazLab1._3
{
    partial class ProductPanel
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
            this.txtBxProductName = new System.Windows.Forms.TextBox();
            this.txtBxStock = new System.Windows.Forms.TextBox();
            this.txtBxPrice = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxProductName
            // 
            this.txtBxProductName.Location = new System.Drawing.Point(13, 13);
            this.txtBxProductName.Name = "txtBxProductName";
            this.txtBxProductName.Size = new System.Drawing.Size(218, 22);
            this.txtBxProductName.TabIndex = 0;
            this.txtBxProductName.Text = "Product Name";
            // 
            // txtBxStock
            // 
            this.txtBxStock.Location = new System.Drawing.Point(13, 55);
            this.txtBxStock.Name = "txtBxStock";
            this.txtBxStock.Size = new System.Drawing.Size(218, 22);
            this.txtBxStock.TabIndex = 0;
            this.txtBxStock.Text = "Product Stock";
            // 
            // txtBxPrice
            // 
            this.txtBxPrice.Location = new System.Drawing.Point(12, 96);
            this.txtBxPrice.Name = "txtBxPrice";
            this.txtBxPrice.Size = new System.Drawing.Size(218, 22);
            this.txtBxPrice.TabIndex = 0;
            this.txtBxPrice.Text = "Product Price";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(13, 147);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(217, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 191);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtBxPrice);
            this.Controls.Add(this.txtBxStock);
            this.Controls.Add(this.txtBxProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProductPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxProductName;
        private System.Windows.Forms.TextBox txtBxStock;
        private System.Windows.Forms.TextBox txtBxPrice;
        private System.Windows.Forms.Button btnConfirm;
    }
}