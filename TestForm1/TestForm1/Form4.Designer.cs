namespace TestForm1
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_ProductList = new System.Windows.Forms.DataGridView();
            this.dgv_AnnoList = new System.Windows.Forms.DataGridView();
            this.product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AnnoList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Controls.Add(this.txt_Quantity);
            this.panel1.Controls.Add(this.txt_Price);
            this.panel1.Controls.Add(this.txt_ProductName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(37, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 297);
            this.panel1.TabIndex = 10;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(147, 249);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(76, 31);
            this.btn_Add.TabIndex = 21;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(238, 249);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(76, 31);
            this.btn_Refresh.TabIndex = 20;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(147, 181);
            this.txt_Quantity.Multiline = true;
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(167, 20);
            this.txt_Quantity.TabIndex = 19;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(147, 105);
            this.txt_Price.Multiline = true;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(167, 20);
            this.txt_Price.TabIndex = 18;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(147, 33);
            this.txt_ProductName.Multiline = true;
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(167, 20);
            this.txt_ProductName.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Billing Form";
            // 
            // dgv_ProductList
            // 
            this.dgv_ProductList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductList.GridColor = System.Drawing.Color.White;
            this.dgv_ProductList.Location = new System.Drawing.Point(72, 410);
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.RowHeadersWidth = 51;
            this.dgv_ProductList.RowTemplate.Height = 28;
            this.dgv_ProductList.Size = new System.Drawing.Size(716, 247);
            this.dgv_ProductList.TabIndex = 16;
            this.dgv_ProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProductList_CellContentClick);
            // 
            // dgv_AnnoList
            // 
            this.dgv_AnnoList.AllowUserToOrderColumns = true;
            this.dgv_AnnoList.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgv_AnnoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AnnoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_name,
            this.product_price});
            this.dgv_AnnoList.Location = new System.Drawing.Point(430, 71);
            this.dgv_AnnoList.Name = "dgv_AnnoList";
            this.dgv_AnnoList.RowHeadersWidth = 51;
            this.dgv_AnnoList.RowTemplate.Height = 28;
            this.dgv_AnnoList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_AnnoList.Size = new System.Drawing.Size(407, 297);
            this.dgv_AnnoList.TabIndex = 22;
            // 
            // product_name
            // 
            this.product_name.DataPropertyName = "product_name";
            this.product_name.HeaderText = "Product Name";
            this.product_name.MinimumWidth = 6;
            this.product_name.Name = "product_name";
            this.product_name.Width = 125;
            // 
            // product_price
            // 
            this.product_price.DataPropertyName = "product_price";
            this.product_price.HeaderText = "Price";
            this.product_price.MinimumWidth = 6;
            this.product_price.Name = "product_price";
            this.product_price.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(565, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 30;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(541, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 31;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(440, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "Total amount";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(870, 686);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_AnnoList);
            this.Controls.Add(this.dgv_ProductList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Selling Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AnnoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_ProductList;
        private System.Windows.Forms.DataGridView dgv_AnnoList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label9;
    }
}