namespace YazLab1._3
{
    partial class LogPanel
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
            this.tbCntrlOpLogs = new System.Windows.Forms.TabControl();
            this.dtGrdVwOpLogs = new System.Windows.Forms.DataGridView();
            this.tbCntrlLogInf = new System.Windows.Forms.TabControl();
            this.tbPgProductLogInf = new System.Windows.Forms.TabPage();
            this.dtGrdVwProductLogInf = new System.Windows.Forms.DataGridView();
            this.tbPgOrderLogInf = new System.Windows.Forms.TabPage();
            this.dtGrdVwOrderLogInf = new System.Windows.Forms.DataGridView();
            this.tbPgCustomerLogInf = new System.Windows.Forms.TabPage();
            this.dtGrdVwCustomerLogInf = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbCntrlOpLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwOpLogs)).BeginInit();
            this.tbCntrlLogInf.SuspendLayout();
            this.tbPgProductLogInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwProductLogInf)).BeginInit();
            this.tbPgOrderLogInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwOrderLogInf)).BeginInit();
            this.tbPgCustomerLogInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCustomerLogInf)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCntrlOpLogs
            // 
            this.tbCntrlOpLogs.Controls.Add(this.tabPage1);
            this.tbCntrlOpLogs.Location = new System.Drawing.Point(13, 13);
            this.tbCntrlOpLogs.Name = "tbCntrlOpLogs";
            this.tbCntrlOpLogs.SelectedIndex = 0;
            this.tbCntrlOpLogs.Size = new System.Drawing.Size(1106, 562);
            this.tbCntrlOpLogs.TabIndex = 0;
            // 
            // dtGrdVwOpLogs
            // 
            this.dtGrdVwOpLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwOpLogs.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtGrdVwOpLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwOpLogs.Location = new System.Drawing.Point(7, 7);
            this.dtGrdVwOpLogs.MultiSelect = false;
            this.dtGrdVwOpLogs.Name = "dtGrdVwOpLogs";
            this.dtGrdVwOpLogs.ReadOnly = true;
            this.dtGrdVwOpLogs.RowHeadersWidth = 51;
            this.dtGrdVwOpLogs.RowTemplate.Height = 24;
            this.dtGrdVwOpLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwOpLogs.Size = new System.Drawing.Size(1081, 350);
            this.dtGrdVwOpLogs.TabIndex = 0;
            this.dtGrdVwOpLogs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdVwOpLogs_CellClick);
            // 
            // tbCntrlLogInf
            // 
            this.tbCntrlLogInf.Controls.Add(this.tbPgCustomerLogInf);
            this.tbCntrlLogInf.Controls.Add(this.tbPgOrderLogInf);
            this.tbCntrlLogInf.Controls.Add(this.tbPgProductLogInf);
            this.tbCntrlLogInf.Location = new System.Drawing.Point(7, 364);
            this.tbCntrlLogInf.Name = "tbCntrlLogInf";
            this.tbCntrlLogInf.SelectedIndex = 0;
            this.tbCntrlLogInf.Size = new System.Drawing.Size(1085, 163);
            this.tbCntrlLogInf.TabIndex = 1;
            // 
            // tbPgProductLogInf
            // 
            this.tbPgProductLogInf.Controls.Add(this.dtGrdVwProductLogInf);
            this.tbPgProductLogInf.Location = new System.Drawing.Point(4, 25);
            this.tbPgProductLogInf.Name = "tbPgProductLogInf";
            this.tbPgProductLogInf.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgProductLogInf.Size = new System.Drawing.Size(488, 134);
            this.tbPgProductLogInf.TabIndex = 2;
            this.tbPgProductLogInf.Text = "Product Details";
            this.tbPgProductLogInf.UseVisualStyleBackColor = true;
            // 
            // dtGrdVwProductLogInf
            // 
            this.dtGrdVwProductLogInf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwProductLogInf.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtGrdVwProductLogInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwProductLogInf.Enabled = false;
            this.dtGrdVwProductLogInf.Location = new System.Drawing.Point(7, 6);
            this.dtGrdVwProductLogInf.MultiSelect = false;
            this.dtGrdVwProductLogInf.Name = "dtGrdVwProductLogInf";
            this.dtGrdVwProductLogInf.ReadOnly = true;
            this.dtGrdVwProductLogInf.RowHeadersWidth = 51;
            this.dtGrdVwProductLogInf.RowTemplate.Height = 24;
            this.dtGrdVwProductLogInf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwProductLogInf.Size = new System.Drawing.Size(1064, 121);
            this.dtGrdVwProductLogInf.TabIndex = 0;
            // 
            // tbPgOrderLogInf
            // 
            this.tbPgOrderLogInf.Controls.Add(this.dtGrdVwOrderLogInf);
            this.tbPgOrderLogInf.Location = new System.Drawing.Point(4, 25);
            this.tbPgOrderLogInf.Name = "tbPgOrderLogInf";
            this.tbPgOrderLogInf.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgOrderLogInf.Size = new System.Drawing.Size(488, 134);
            this.tbPgOrderLogInf.TabIndex = 1;
            this.tbPgOrderLogInf.Text = "Order Details";
            this.tbPgOrderLogInf.UseVisualStyleBackColor = true;
            // 
            // dtGrdVwOrderLogInf
            // 
            this.dtGrdVwOrderLogInf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwOrderLogInf.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtGrdVwOrderLogInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwOrderLogInf.Enabled = false;
            this.dtGrdVwOrderLogInf.Location = new System.Drawing.Point(7, 7);
            this.dtGrdVwOrderLogInf.MultiSelect = false;
            this.dtGrdVwOrderLogInf.Name = "dtGrdVwOrderLogInf";
            this.dtGrdVwOrderLogInf.ReadOnly = true;
            this.dtGrdVwOrderLogInf.RowHeadersWidth = 51;
            this.dtGrdVwOrderLogInf.RowTemplate.Height = 24;
            this.dtGrdVwOrderLogInf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwOrderLogInf.Size = new System.Drawing.Size(1064, 121);
            this.dtGrdVwOrderLogInf.TabIndex = 0;
            // 
            // tbPgCustomerLogInf
            // 
            this.tbPgCustomerLogInf.Controls.Add(this.dtGrdVwCustomerLogInf);
            this.tbPgCustomerLogInf.Location = new System.Drawing.Point(4, 25);
            this.tbPgCustomerLogInf.Name = "tbPgCustomerLogInf";
            this.tbPgCustomerLogInf.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgCustomerLogInf.Size = new System.Drawing.Size(1077, 134);
            this.tbPgCustomerLogInf.TabIndex = 0;
            this.tbPgCustomerLogInf.Text = "Customer Details";
            this.tbPgCustomerLogInf.UseVisualStyleBackColor = true;
            // 
            // dtGrdVwCustomerLogInf
            // 
            this.dtGrdVwCustomerLogInf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdVwCustomerLogInf.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtGrdVwCustomerLogInf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwCustomerLogInf.Enabled = false;
            this.dtGrdVwCustomerLogInf.Location = new System.Drawing.Point(7, 10);
            this.dtGrdVwCustomerLogInf.MultiSelect = false;
            this.dtGrdVwCustomerLogInf.Name = "dtGrdVwCustomerLogInf";
            this.dtGrdVwCustomerLogInf.ReadOnly = true;
            this.dtGrdVwCustomerLogInf.RowHeadersWidth = 51;
            this.dtGrdVwCustomerLogInf.RowTemplate.Height = 24;
            this.dtGrdVwCustomerLogInf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdVwCustomerLogInf.Size = new System.Drawing.Size(1064, 121);
            this.dtGrdVwCustomerLogInf.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbCntrlLogInf);
            this.tabPage1.Controls.Add(this.dtGrdVwOpLogs);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1098, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operation Logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LogPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 587);
            this.Controls.Add(this.tbCntrlOpLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LogPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log Panel";
            this.Load += new System.EventHandler(this.LogPanel_Load);
            this.tbCntrlOpLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwOpLogs)).EndInit();
            this.tbCntrlLogInf.ResumeLayout(false);
            this.tbPgProductLogInf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwProductLogInf)).EndInit();
            this.tbPgOrderLogInf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwOrderLogInf)).EndInit();
            this.tbPgCustomerLogInf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwCustomerLogInf)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrlOpLogs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tbCntrlLogInf;
        private System.Windows.Forms.TabPage tbPgCustomerLogInf;
        private System.Windows.Forms.DataGridView dtGrdVwCustomerLogInf;
        private System.Windows.Forms.TabPage tbPgOrderLogInf;
        private System.Windows.Forms.DataGridView dtGrdVwOrderLogInf;
        private System.Windows.Forms.TabPage tbPgProductLogInf;
        private System.Windows.Forms.DataGridView dtGrdVwProductLogInf;
        private System.Windows.Forms.DataGridView dtGrdVwOpLogs;
    }
}