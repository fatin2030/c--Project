namespace TestForm1
{
    partial class FormManager
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
            this.dgvEmpInfo = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btnEmpSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSId = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtSdes = new System.Windows.Forms.TextBox();
            this.txtSsal = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtSpass = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddPro = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpInfo
            // 
            this.dgvEmpInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpInfo.Location = new System.Drawing.Point(12, 260);
            this.dgvEmpInfo.Name = "dgvEmpInfo";
            this.dgvEmpInfo.ReadOnly = true;
            this.dgvEmpInfo.RowHeadersWidth = 51;
            this.dgvEmpInfo.RowTemplate.Height = 24;
            this.dgvEmpInfo.Size = new System.Drawing.Size(683, 199);
            this.dgvEmpInfo.TabIndex = 0;
            this.dgvEmpInfo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Double);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(32, 221);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(155, 22);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEmpSearch
            // 
            this.btnEmpSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEmpSearch.Location = new System.Drawing.Point(209, 220);
            this.btnEmpSearch.Name = "btnEmpSearch";
            this.btnEmpSearch.Size = new System.Drawing.Size(75, 23);
            this.btnEmpSearch.TabIndex = 2;
            this.btnEmpSearch.Text = "Search";
            this.btnEmpSearch.UseVisualStyleBackColor = false;
            this.btnEmpSearch.Click += new System.EventHandler(this.btnEmpSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Location = new System.Drawing.Point(541, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 69);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSId
            // 
            this.txtSId.Location = new System.Drawing.Point(146, 9);
            this.txtSId.Name = "txtSId";
            this.txtSId.ReadOnly = true;
            this.txtSId.Size = new System.Drawing.Size(100, 22);
            this.txtSId.TabIndex = 4;
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(146, 37);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(100, 22);
            this.txtSname.TabIndex = 5;
            // 
            // txtSdes
            // 
            this.txtSdes.Location = new System.Drawing.Point(146, 91);
            this.txtSdes.Name = "txtSdes";
            this.txtSdes.Size = new System.Drawing.Size(100, 22);
            this.txtSdes.TabIndex = 6;
            // 
            // txtSsal
            // 
            this.txtSsal.Location = new System.Drawing.Point(146, 128);
            this.txtSsal.Name = "txtSsal";
            this.txtSsal.Size = new System.Drawing.Size(100, 22);
            this.txtSsal.TabIndex = 7;
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "yyyy-MM-dd";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(275, 12);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 22);
            this.dtp.TabIndex = 8;
            this.dtp.Value = new System.DateTime(2022, 12, 25, 23, 59, 59, 0);
            this.dtp.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // txtSpass
            // 
            this.txtSpass.Location = new System.Drawing.Point(146, 65);
            this.txtSpass.Name = "txtSpass";
            this.txtSpass.Size = new System.Drawing.Size(100, 22);
            this.txtSpass.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Location = new System.Drawing.Point(463, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddPro
            // 
            this.btnAddPro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddPro.Location = new System.Drawing.Point(541, 125);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(154, 61);
            this.btnAddPro.TabIndex = 11;
            this.btnAddPro.Text = "Add Product";
            this.btnAddPro.UseVisualStyleBackColor = false;
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRefresh.Location = new System.Drawing.Point(325, 208);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 35);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "SalesMan Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Salesman Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Designation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "search with ID";
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddPro);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSpass);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.txtSsal);
            this.Controls.Add(this.txtSdes);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.txtSId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEmpSearch);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgvEmpInfo);
            this.Name = "FormManager";
            this.Text = "Form Manager";
            this.Load += new System.EventHandler(this.FormManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpInfo;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btnEmpSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSId;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.TextBox txtSdes;
        private System.Windows.Forms.TextBox txtSsal;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtSpass;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddPro;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}