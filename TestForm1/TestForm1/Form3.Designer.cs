namespace TestForm1
{
    partial class FormSalesman
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalesmanProfile = new System.Windows.Forms.Button();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.btnShowAllCustomer = new System.Windows.Forms.Button();
            this.btnClearBox = new System.Windows.Forms.Button();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerPhnNo = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerPhnNo = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.btnGoToBillingForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_name,
            this.product_price,
            this.product_stock});
            this.dgvProduct.Location = new System.Drawing.Point(7, 283);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(1005, 170);
            this.dgvProduct.TabIndex = 3;
            this.dgvProduct.DoubleClick += new System.EventHandler(this.dgvProduct_DoubleClick);
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "Product ID";
            this.product_id.MinimumWidth = 6;
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Width = 125;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "Product Name";
            this.product_name.MinimumWidth = 6;
            this.product_name.Name = "product_name";
            this.product_name.ReadOnly = true;
            this.product_name.Width = 125;
            // 
            // product_price
            // 
            this.product_price.DataPropertyName = "product_price";
            this.product_price.HeaderText = "Price";
            this.product_price.MinimumWidth = 6;
            this.product_price.Name = "product_price";
            this.product_price.ReadOnly = true;
            this.product_price.Width = 125;
            // 
            // product_stock
            // 
            this.product_stock.DataPropertyName = "product_stock";
            this.product_stock.HeaderText = "Stock";
            this.product_stock.MinimumWidth = 6;
            this.product_stock.Name = "product_stock";
            this.product_stock.ReadOnly = true;
            this.product_stock.Width = 125;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(226, 14);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSearchProduct.TabIndex = 2;
            this.btnSearchProduct.Text = "search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(320, 14);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(161, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show Product";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(11, 17);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(94, 16);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product name-";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(111, 14);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(100, 22);
            this.txtSearchProduct.TabIndex = 1;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(6, 35);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(80, 16);
            this.lblCustomerId.TabIndex = 4;
            this.lblCustomerId.Text = "Customer ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchProduct);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.btnSearchProduct);
            this.panel1.Location = new System.Drawing.Point(12, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 45);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnGoToBillingForm);
            this.panel2.Controls.Add(this.btnBackToLogin);
            this.panel2.Controls.Add(this.btnSalesmanProfile);
            this.panel2.Controls.Add(this.txtPoint);
            this.panel2.Controls.Add(this.lblPoint);
            this.panel2.Controls.Add(this.btnShowAllCustomer);
            this.panel2.Controls.Add(this.btnClearBox);
            this.panel2.Controls.Add(this.btnRemoveCustomer);
            this.panel2.Controls.Add(this.btnSaveCustomer);
            this.panel2.Controls.Add(this.btnSearchCustomer);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.txtCustomerPhnNo);
            this.panel2.Controls.Add(this.txtCustomerId);
            this.panel2.Controls.Add(this.lblCustomerName);
            this.panel2.Controls.Add(this.lblCustomerPhnNo);
            this.panel2.Controls.Add(this.lblCustomerId);
            this.panel2.Location = new System.Drawing.Point(7, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 233);
            this.panel2.TabIndex = 6;
            // 
            // btnSalesmanProfile
            // 
            this.btnSalesmanProfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalesmanProfile.Location = new System.Drawing.Point(0, 0);
            this.btnSalesmanProfile.Name = "btnSalesmanProfile";
            this.btnSalesmanProfile.Size = new System.Drawing.Size(109, 26);
            this.btnSalesmanProfile.TabIndex = 16;
            this.btnSalesmanProfile.Text = "My Profile";
            this.btnSalesmanProfile.UseVisualStyleBackColor = false;
            this.btnSalesmanProfile.Click += new System.EventHandler(this.btnSalesmanProfile_Click);
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(116, 133);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(122, 22);
            this.txtPoint.TabIndex = 10;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(6, 136);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(37, 16);
            this.lblPoint.TabIndex = 15;
            this.lblPoint.Text = "Point";
            // 
            // btnShowAllCustomer
            // 
            this.btnShowAllCustomer.Location = new System.Drawing.Point(259, 85);
            this.btnShowAllCustomer.Name = "btnShowAllCustomer";
            this.btnShowAllCustomer.Size = new System.Drawing.Size(92, 35);
            this.btnShowAllCustomer.TabIndex = 14;
            this.btnShowAllCustomer.Text = "Show All";
            this.btnShowAllCustomer.UseVisualStyleBackColor = true;
            this.btnShowAllCustomer.Click += new System.EventHandler(this.btnShowAllCustomer_Click);
            // 
            // btnClearBox
            // 
            this.btnClearBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClearBox.Location = new System.Drawing.Point(88, 160);
            this.btnClearBox.Name = "btnClearBox";
            this.btnClearBox.Size = new System.Drawing.Size(69, 33);
            this.btnClearBox.TabIndex = 12;
            this.btnClearBox.Text = "Clear";
            this.btnClearBox.UseVisualStyleBackColor = false;
            this.btnClearBox.Click += new System.EventHandler(this.btnClearBox_Click);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoveCustomer.Location = new System.Drawing.Point(163, 160);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(79, 33);
            this.btnRemoveCustomer.TabIndex = 13;
            this.btnRemoveCustomer.Text = "Remove";
            this.btnRemoveCustomer.UseVisualStyleBackColor = false;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveCustomer.Location = new System.Drawing.Point(5, 160);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(77, 33);
            this.btnSaveCustomer.TabIndex = 11;
            this.btnSaveCustomer.Text = "Save";
            this.btnSaveCustomer.UseVisualStyleBackColor = false;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(244, 31);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(146, 35);
            this.btnSearchCustomer.TabIndex = 8;
            this.btnSearchCustomer.Text = "Click to Search with ID";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(116, 64);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(122, 22);
            this.txtCustomerName.TabIndex = 8;
            // 
            // txtCustomerPhnNo
            // 
            this.txtCustomerPhnNo.Location = new System.Drawing.Point(116, 98);
            this.txtCustomerPhnNo.Name = "txtCustomerPhnNo";
            this.txtCustomerPhnNo.Size = new System.Drawing.Size(122, 22);
            this.txtCustomerPhnNo.TabIndex = 9;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(116, 32);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(122, 22);
            this.txtCustomerId.TabIndex = 7;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(6, 67);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(104, 16);
            this.lblCustomerName.TabIndex = 6;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerPhnNo
            // 
            this.lblCustomerPhnNo.AutoSize = true;
            this.lblCustomerPhnNo.Location = new System.Drawing.Point(6, 101);
            this.lblCustomerPhnNo.Name = "lblCustomerPhnNo";
            this.lblCustomerPhnNo.Size = new System.Drawing.Size(70, 16);
            this.lblCustomerPhnNo.TabIndex = 5;
            this.lblCustomerPhnNo.Text = "Phone No.";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_id,
            this.customer_name,
            this.phone_no,
            this.point});
            this.dgvCustomer.Location = new System.Drawing.Point(408, -2);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(613, 236);
            this.dgvCustomer.TabIndex = 7;
            this.dgvCustomer.DoubleClick += new System.EventHandler(this.dgvCustomer_DoubleClick);
            // 
            // customer_id
            // 
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "Customer ID";
            this.customer_id.MinimumWidth = 6;
            this.customer_id.Name = "customer_id";
            this.customer_id.ReadOnly = true;
            this.customer_id.Width = 125;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "Name";
            this.customer_name.MinimumWidth = 6;
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            this.customer_name.Width = 125;
            // 
            // phone_no
            // 
            this.phone_no.DataPropertyName = "phone_no";
            this.phone_no.HeaderText = "Phone Number";
            this.phone_no.MinimumWidth = 6;
            this.phone_no.Name = "phone_no";
            this.phone_no.ReadOnly = true;
            this.phone_no.Width = 125;
            // 
            // point
            // 
            this.point.DataPropertyName = "point";
            this.point.HeaderText = "Point";
            this.point.MinimumWidth = 6;
            this.point.Name = "point";
            this.point.ReadOnly = true;
            this.point.Width = 125;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.Location = new System.Drawing.Point(3, 199);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(113, 31);
            this.btnBackToLogin.TabIndex = 17;
            this.btnBackToLogin.Text = "<<Login Form";
            this.btnBackToLogin.UseVisualStyleBackColor = true;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnGoToBillingForm
            // 
            this.btnGoToBillingForm.Location = new System.Drawing.Point(259, 199);
            this.btnGoToBillingForm.Name = "btnGoToBillingForm";
            this.btnGoToBillingForm.Size = new System.Drawing.Size(113, 28);
            this.btnGoToBillingForm.TabIndex = 18;
            this.btnGoToBillingForm.Text = "Billing Form>>";
            this.btnGoToBillingForm.UseVisualStyleBackColor = true;
            this.btnGoToBillingForm.Click += new System.EventHandler(this.btnGoToBillingForm_Click);
            // 
            // FormSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProduct);
            this.Name = "FormSalesman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Salesman";
            this.Load += new System.EventHandler(this.FormSalesman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerPhnNo;
        private System.Windows.Forms.Button btnClearBox;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerPhnNo;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_stock;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn point;
        private System.Windows.Forms.Button btnShowAllCustomer;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Button btnSalesmanProfile;
        private System.Windows.Forms.Button btnGoToBillingForm;
        private System.Windows.Forms.Button btnBackToLogin;
    }
}