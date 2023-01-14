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
    public partial class FormManager : Form
    {
        private DataAccess Da { get; set; }
        public FormManager()
        {
            InitializeComponent();
            this.Da = DataAccess.getInstance();
            PopulateGridView(); 
        }
        private void PopulateGridView(string sql = "select ID,Name,Designation,Salary,Join_Date from employee where Designation = 'Salesman'")
        {
            var ds = this.Da.ExecuteQuery(sql);

           //this.dgvEmpInfo.AutoGenerateColumns = false;
            this.dgvEmpInfo.DataSource = ds.Tables[0];
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var sql = "select ID,Name,password,Designation,Salary,Join_Date from Employee where Designation = 'Salesman' and ID like '" + this.txt_search.Text + "%';";// or Id like '"+this.txtMovieId.Text+"%';";
            this.PopulateGridView(sql);
        }

        private bool IsValidToUpdate()
        {
            if (String.IsNullOrEmpty(this.txtSId.Text) || String.IsNullOrEmpty(this.txtSname.Text) ||
                String.IsNullOrEmpty(this.dtp.Text) || String.IsNullOrEmpty(this.txtSsal.Text))
            {
                return false;
            }
            else
                return true;

        }
        private void btnEmpSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_Double(object sender, DataGridViewCellEventArgs e)
        {

            this.txtSId.Text = this.dgvEmpInfo.CurrentRow.Cells["ID"].Value.ToString();
            this.txtSname.Text = this.dgvEmpInfo.CurrentRow.Cells["Name"].Value.ToString();
            //this.txtSname.Text = this.dgvEmpInfo.CurrentRow.Cells["Name"].Value.ToString();
           // this.txtSpass.Text = this.dgvEmpInfo.CurrentRow.Cells["Password"].Value.ToString();
            this.txtSdes.Text = this.dgvEmpInfo.CurrentRow.Cells["Designation"].Value.ToString();
            this.txtSsal.Text = this.dgvEmpInfo.CurrentRow.Cells["Salary"].Value.ToString();
            this.dtp.Text = this.dgvEmpInfo.CurrentRow.Cells["Join_Date"].Value.ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEmpInfo.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("No row selected, Please select a row first.", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                var id = this.dgvEmpInfo.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvEmpInfo.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from Employee where Id = '" + id + "';";
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

        private void AutoId()
        {
            //var sql = "select * from Employee order by ID desc;";

            // DataTable dt = this.Da.ExecuteQueryTable(sql);

            //  string lastId = dt.Rows[0][0].ToString();
            //  string temp = lastId.Split('-');
            //  int no = Convert.ToInt32(temp[1]);
            //  string newId = "M-" + (++no).ToString();
            //  this.txtSId.Text = newId;
            var sql = "select * from employee where Designation = 'Salesman' order by ID desc";
            DataTable dt = this.Da.ExecuteQueryTable(sql);



            string lastId = dt.Rows[0][0].ToString();
            string[] temp = lastId.Split('-');
            int no = Convert.ToInt32(temp[1]);
            string newId = "E-" + (++no).ToString();
            this.txtSId.Text = newId;
            Refresh();

        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            new Add_Product().Visible = true;
            this.Visible = false;
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            this.dgvEmpInfo.ClearSelection();
            this.AutoId();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.txtSId.Clear();
            this.txtSname.Clear();
            this.dtp.Text = "";
            this.txtSpass.Clear();
            this.txtSdes.Clear();   
            this.txtSsal.Clear();

            this.AutoId();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToUpdate())
                {
                    MessageBox.Show("Please Fill all the information");
                    return;
                }

                var sql = "select * from Employee where ID = '" + this.txtSId.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {

                    sql = @"update Employee
                            set 
                            Name = '" + this.txtSname.Text + @"',
                            Password = '" + this.txtSpass.Text + @"',
                            Designation = '" + this.txtSdes.Text + @"',
                            Salary = " + this.txtSsal.Text + @",
                             Join_Date='" + this.dtp.Text + @"'
                             where ID ='"+this.txtSId.Text+"'; ";
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
                    sql = @"insert into Employee values('" + this.txtSId.Text + "', '" + this.txtSname.Text + "', '" + this.txtSpass.Text + "', '" + this.txtSdes.Text + "'," + this.txtSsal.Text + ",'" + this.dtp.Text + "');";
                    var rowCount = this.Da.ExecuteDMLQuery(sql);
                    AutoId();

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Data insertion operation completed.");
                    }
                    else
                    {
                        MessageBox.Show("Data insertion operation failed.");
                    }
                    // this.RefreshContent();
                    this.PopulateGridView();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again later. Error msg: " + exc.Message);
            }
        }
    }
}
