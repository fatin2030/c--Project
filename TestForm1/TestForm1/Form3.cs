using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace TestForm1
{
    public partial class FormSalesman : Form
    {
        private DataAccess Da { get; set; }
        public FormSalesman()
        {
            InitializeComponent();
            this.Da = DataAccess.getInstance();

            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from Product;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = ds.Tables[0];
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            var sql = "select * from Product where product_name like '%" + this.txtSearchProduct.Text + "%';";// or Id like '"+this.txtMovieId.Text+"%';";
            this.PopulateGridView(sql);
        }

        private void CustomerGridView(string sql = "select * from Customer;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvProduct.AutoGenerateColumns = false;
            this.dgvCustomer.DataSource = ds.Tables[0];
        }
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            
            //var sql = "select * from Customer where customer_id like '%" + this.txtCustomerId.Text + "%';";
            var sql = "select * from Customer where customer_id ='" + this.txtCustomerId.Text + "';";
            this.CustomerGridView(sql);
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                   
                    MessageBox.Show("Invalid opration. Please fill up all the information" , "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                    return;
                }

                var query = "select * from Customer where customer_id = '" + this.txtCustomerId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    var sql = @"update Customer
                                set customer_name = '" + this.txtCustomerName.Text + @"',
                                phone_no = " + this.txtCustomerPhnNo.Text + @",
                                point = " + this.txtPoint.Text + @"
                                where customer_id = '" + this.txtCustomerId.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                }
                else
                {
                    var sql = @"insert into Customer values('" + this.txtCustomerId.Text + "','" + this.txtCustomerName.Text + "'," + this.txtCustomerPhnNo.Text + ", " + this.txtPoint.Text + ");";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Data insertion successfull");
                        this.AutoId();
                    }
                    else
                        MessageBox.Show("Data insertion failed");
                }

                this.CustomerGridView();
                this.RefreshContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtCustomerId.Text) || String.IsNullOrEmpty(this.txtCustomerName.Text) ||
                String.IsNullOrEmpty(this.txtCustomerPhnNo.Text))
            {
                return false;
            }
            else
                return true;
        }
        private void RefreshContent()
        {
            this.txtCustomerId.Clear();
            this.txtCustomerName.Clear();
            this.txtCustomerPhnNo.Clear();
            this.txtPoint.Clear();
        }

        private void btnClearBox_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
            this.AutoId();
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCustomer.SelectedRows.Count < 1)
                {
                    MessageBox.Show("No row selected, Please select a row first.", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                    return;
                }
                var id = this.dgvCustomer.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvCustomer.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from Customer where customer_id = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                {
                    MessageBox.Show(name + " has been deleted successfully");
                    this.RefreshContent();
                    this.AutoId();
                }
                else
                    MessageBox.Show("Data deletion failed", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);

                this.CustomerGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
            
        }

        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            this.txtCustomerId.Text = this.dgvCustomer.CurrentRow.Cells["customer_id"].Value.ToString();
            this.txtCustomerName.Text = this.dgvCustomer.CurrentRow.Cells["customer_name"].Value.ToString();
            this.txtCustomerPhnNo.Text = this.dgvCustomer.CurrentRow.Cells["phone_no"].Value.ToString();
            this.txtPoint.Text = this.dgvCustomer.CurrentRow.Cells["point"].Value.ToString();
        }

        private void btnShowAllCustomer_Click(object sender, EventArgs e)
        {
            this.CustomerGridView();
        }

       /* private void ProductList(string sql = "select product_id,product_name from Product;")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.cmbProductList.DataSource = ds.Tables[0];
            cmbProductList.DataSource = ds;
            cmbProductList.DisplayMember = "product_name";
            cmbProductList.ValueMember = "product_id";
        }*/

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {

        }
        private void AutoId()
        {
            var sql = "select * from Customer order by customer_id desc;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);
            string lastId = dt.Rows[0][0].ToString();
            int no = Convert.ToInt32(lastId);
            string newId = (++no).ToString();
            this.txtCustomerId.Text = newId;
        }

        private void FormSalesman_Load(object sender, EventArgs e)
        {
            this.dgvCustomer.ClearSelection();
            this.AutoId();
        }

        private void btnSalesmanProfile_Click(object sender, EventArgs e)
        {
            new Salesman_Profile().Visible = true;
            this.Visible = false;
        }

        private void btnGoToBillingForm_Click(object sender, EventArgs e)
        {
            new Form4().Visible = true;
            this.Visible=false;
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            new FormSalesman().Visible = true;
            this.Visible=false;
        }
    }
}
