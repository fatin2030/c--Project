namespace TestForm1
{
    partial class Add_Product
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
            this.dgv_pro_Add = new System.Windows.Forms.DataGridView();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPs = new System.Windows.Forms.TextBox();
            this.lblPstock = new System.Windows.Forms.Label();
            this.txtPp = new System.Windows.Forms.TextBox();
            this.lblPprice = new System.Windows.Forms.Label();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.lblPname = new System.Windows.Forms.Label();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.lblPid = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPsearch = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProBack = new System.Windows.Forms.Button();
            this.btnDltpro = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro_Add)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_pro_Add
            // 
            this.dgv_pro_Add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pro_Add.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_name,
            this.product_price,
            this.product_stock});
            this.dgv_pro_Add.Location = new System.Drawing.Point(-37, 291);
            this.dgv_pro_Add.Name = "dgv_pro_Add";
            this.dgv_pro_Add.ReadOnly = true;
            this.dgv_pro_Add.RowHeadersWidth = 51;
            this.dgv_pro_Add.RowTemplate.Height = 24;
            this.dgv_pro_Add.Size = new System.Drawing.Size(574, 147);
            this.dgv_pro_Add.TabIndex = 0;
            this.dgv_pro_Add.DoubleClick += new System.EventHandler(this.dgv_double_click);
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "Product Id";
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
            this.product_price.HeaderText = "Product Price";
            this.product_price.MinimumWidth = 6;
            this.product_price.Name = "product_price";
            this.product_price.ReadOnly = true;
            this.product_price.Width = 125;
            // 
            // product_stock
            // 
            this.product_stock.DataPropertyName = "product_stock";
            this.product_stock.HeaderText = "Product Stock";
            this.product_stock.MinimumWidth = 6;
            this.product_stock.Name = "product_stock";
            this.product_stock.ReadOnly = true;
            this.product_stock.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPs);
            this.panel2.Controls.Add(this.lblPstock);
            this.panel2.Controls.Add(this.txtPp);
            this.panel2.Controls.Add(this.lblPprice);
            this.panel2.Controls.Add(this.txtPname);
            this.panel2.Controls.Add(this.lblPname);
            this.panel2.Controls.Add(this.txtPid);
            this.panel2.Controls.Add(this.lblPid);
            this.panel2.Location = new System.Drawing.Point(16, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 203);
            this.panel2.TabIndex = 1;
            // 
            // txtPs
            // 
            this.txtPs.Location = new System.Drawing.Point(153, 168);
            this.txtPs.Name = "txtPs";
            this.txtPs.Size = new System.Drawing.Size(163, 22);
            this.txtPs.TabIndex = 7;
            // 
            // lblPstock
            // 
            this.lblPstock.AutoSize = true;
            this.lblPstock.Location = new System.Drawing.Point(42, 171);
            this.lblPstock.Name = "lblPstock";
            this.lblPstock.Size = new System.Drawing.Size(90, 16);
            this.lblPstock.TabIndex = 6;
            this.lblPstock.Text = "Product Stock";
            // 
            // txtPp
            // 
            this.txtPp.Location = new System.Drawing.Point(153, 118);
            this.txtPp.Name = "txtPp";
            this.txtPp.Size = new System.Drawing.Size(163, 22);
            this.txtPp.TabIndex = 5;
            // 
            // lblPprice
            // 
            this.lblPprice.AutoSize = true;
            this.lblPprice.Location = new System.Drawing.Point(42, 118);
            this.lblPprice.Name = "lblPprice";
            this.lblPprice.Size = new System.Drawing.Size(87, 16);
            this.lblPprice.TabIndex = 4;
            this.lblPprice.Text = "Product Price";
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(153, 69);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(163, 22);
            this.txtPname.TabIndex = 3;
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Location = new System.Drawing.Point(42, 75);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(93, 16);
            this.lblPname.TabIndex = 2;
            this.lblPname.Text = "Product Name";
            // 
            // txtPid
            // 
            this.txtPid.Location = new System.Drawing.Point(153, 18);
            this.txtPid.Name = "txtPid";
            this.txtPid.ReadOnly = true;
            this.txtPid.Size = new System.Drawing.Size(163, 22);
            this.txtPid.TabIndex = 1;
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Location = new System.Drawing.Point(42, 25);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(67, 16);
            this.lblPid.TabIndex = 0;
            this.lblPid.Text = "Product Id";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Location = new System.Drawing.Point(719, 318);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPsearch
            // 
            this.txtPsearch.Location = new System.Drawing.Point(603, 319);
            this.txtPsearch.Name = "txtPsearch";
            this.txtPsearch.Size = new System.Drawing.Size(100, 22);
            this.txtPsearch.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInsert.Location = new System.Drawing.Point(151, 34);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(97, 47);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Save";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnProBack);
            this.panel3.Controls.Add(this.btnDltpro);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnInsert);
            this.panel3.Location = new System.Drawing.Point(527, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 216);
            this.panel3.TabIndex = 5;
            // 
            // btnProBack
            // 
            this.btnProBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProBack.Location = new System.Drawing.Point(151, 113);
            this.btnProBack.Name = "btnProBack";
            this.btnProBack.Size = new System.Drawing.Size(97, 51);
            this.btnProBack.TabIndex = 7;
            this.btnProBack.Text = "Back";
            this.btnProBack.UseVisualStyleBackColor = false;
            this.btnProBack.Click += new System.EventHandler(this.btnProBack_Click);
            // 
            // btnDltpro
            // 
            this.btnDltpro.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDltpro.Location = new System.Drawing.Point(27, 34);
            this.btnDltpro.Name = "btnDltpro";
            this.btnDltpro.Size = new System.Drawing.Size(102, 47);
            this.btnDltpro.TabIndex = 6;
            this.btnDltpro.Text = "Delete";
            this.btnDltpro.UseVisualStyleBackColor = false;
            this.btnDltpro.Click += new System.EventHandler(this.btnDltpro_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.Location = new System.Drawing.Point(27, 113);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 51);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRefresh.Location = new System.Drawing.Point(678, 378);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 37);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_pro_Add);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPsearch);
            this.Controls.Add(this.btnSearch);
            this.Name = "Add_Product";
            this.Text = "Add_Product";
            this.Load += new System.EventHandler(this.Add_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro_Add)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_pro_Add;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPs;
        private System.Windows.Forms.Label lblPstock;
        private System.Windows.Forms.TextBox txtPp;
        private System.Windows.Forms.Label lblPprice;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPsearch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDltpro;
        private System.Windows.Forms.Button btnProBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_stock;
    }
}