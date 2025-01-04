namespace YazLab1._3
{
    partial class CustomerPanel
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
            this.components = new System.ComponentModel.Container();
            this.txtBxCustomerName = new System.Windows.Forms.TextBox();
            this.txtBxCustomerBudget = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmbBxCustomerType = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxCustomerName
            // 
            this.txtBxCustomerName.Location = new System.Drawing.Point(12, 12);
            this.txtBxCustomerName.Name = "txtBxCustomerName";
            this.txtBxCustomerName.Size = new System.Drawing.Size(279, 22);
            this.txtBxCustomerName.TabIndex = 0;
            this.txtBxCustomerName.Text = "CustomerName";
            // 
            // txtBxCustomerBudget
            // 
            this.txtBxCustomerBudget.Location = new System.Drawing.Point(12, 59);
            this.txtBxCustomerBudget.Name = "txtBxCustomerBudget";
            this.txtBxCustomerBudget.Size = new System.Drawing.Size(279, 22);
            this.txtBxCustomerBudget.TabIndex = 0;
            this.txtBxCustomerBudget.Text = "Customer Budget";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 156);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(279, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmbBxCustomerType
            // 
            this.cmbBxCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxCustomerType.FormattingEnabled = true;
            this.cmbBxCustomerType.Location = new System.Drawing.Point(12, 109);
            this.cmbBxCustomerType.Name = "cmbBxCustomerType";
            this.cmbBxCustomerType.Size = new System.Drawing.Size(279, 24);
            this.cmbBxCustomerType.TabIndex = 2;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(BLL.Models.Customer);
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 195);
            this.Controls.Add(this.cmbBxCustomerType);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtBxCustomerBudget);
            this.Controls.Add(this.txtBxCustomerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CustomerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerPanel";
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxCustomerName;
        private System.Windows.Forms.TextBox txtBxCustomerBudget;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cmbBxCustomerType;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}