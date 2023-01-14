using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm1
{
    public partial class Add_Product : Form
    {
        private DataAccess Da { get; set; }
        public Add_Product()
        {
            InitializeComponent();
            this.Da = DataAccess.getInstance();

            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from product")
        {
            var ds = this.Da.ExecuteQuery(sql);

            //this.dgvEmpInfo.AutoGenerateColumns = false;
            this.dgv_pro_Add.DataSource = ds.Tables[0];
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
            this.dgv_pro_Add.ClearSelection();
            this.AutoId();
        }

        private void AutoId()
        {
            var sql = "select * from Product order by product_id desc;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            string lastId = dt.Rows[0][0].ToString();
            string temp = lastId;
            int no = Convert.ToInt32(temp);

            string newId = (++no).ToString();
            this.txtPid.Text = newId;

        }

        private void dgv_double_click(object sender, EventArgs e)
        {
            this.txtPid.Text = this.dgv_pro_Add.CurrentRow.Cells["product_id"].Value.ToString();
            this.txtPname.Text = this.dgv_pro_Add.CurrentRow.Cells["product_name"].Value.ToString();
            this.txtPp.Text = this.dgv_pro_Add.CurrentRow.Cells["product_price"].Value.ToString();
            this.txtPs.Text = this.dgv_pro_Add.CurrentRow.Cells["product_stock"].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Product where product_id = " + this.txtPsearch.Text + ";";
                this.PopulateGridView(sql);

            }
            catch (Exception exc)
              {
                MessageBox.Show("An error has occured, please try again later. Error msg: " + exc.Message);

            }
        }


        private bool IsValidToUpdate()
        {
            if (String.IsNullOrEmpty(this.txtPid.Text) || String.IsNullOrEmpty(this.txtPname.Text) ||
                String.IsNullOrEmpty(this.txtPp.Text) || String.IsNullOrEmpty(this.txtPs.Text))
            {
                return false;
            }
            else
                return true;

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToUpdate())
                {
                    MessageBox.Show("Please Fill all the information");
                    return;
                }

                var sql = "select * from product where product_id = '" + this.txtPid.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {

                    sql = @"update product
                            set 
                            product_name = '" + this.txtPname.Text + @"',
                            product_price = " + this.txtPp.Text + @",
                            product_stock = " + this.txtPs.Text + @"
                            where product_id = '"+this.txtPid.Text+"'; ";
                    var rowCount = this.Da.ExecuteDMLQuery(sql);

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Data update operation completed.");
                        this.PopulateGridView();
                    }
                    else
                    {
                        MessageBox.Show("Data update operation failed.");
                    }
                }

                else
                {
                    sql = @"insert into product values('" + this.txtPid.Text + "', '" + this.txtPname.Text + "', " + this.txtPp.Text + ", " + this.txtPs.Text + ");";
                    var rowCount = this.Da.ExecuteDMLQuery(sql);

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Data insertion operation completed.");
                    }
                    else
                    {
                        MessageBox.Show("Data insertion operation failed.");
                    }
                    //this.RefreshContent();
                    this.PopulateGridView();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again later. Error msg: " + exc.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtPid.Clear();
            this.txtPname.Clear();
            this.txtPp.Clear();
            this.txtPs.Clear();


            this.AutoId();
        }

        private void btnDltpro_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dgv_pro_Add.SelectedRows.Count < 1)
                {
                    MessageBox.Show("No row selected, Please select a row first.", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                var id = this.dgv_pro_Add.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgv_pro_Add.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from product where product_id = '" + id + "';";
                var rowCount = this.Da.ExecuteDMLQuery(sql);

                if (rowCount == 1)
                {
                    MessageBox.Show(name + " has been deleted from Table.");
                }
                else
                {
                    MessageBox.Show("Data deletion operation failed.");
                }
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again later. Error msg: " + exc.Message);
            }
        }

        private void btnProBack_Click(object sender, EventArgs e)
        {
            FormManager F1 = new FormManager();
            F1.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();

        }
    }
}
