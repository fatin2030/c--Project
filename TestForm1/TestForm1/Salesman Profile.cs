using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm1
{
    public partial class Salesman_Profile : Form
    {
        private DataAccess Da { get; set; }
        public Salesman_Profile()
        {
            InitializeComponent();
            //this.Da = DataAccess.getInstance();
        }


        private void btnBackToForm3_Click(object sender, EventArgs e)
        {
            new FormSalesman().Visible = true;
            this.Visible = false;
        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidToChange())
                {
                    MessageBox.Show("Something went wrong,Please fill information carefully", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                    return;
                }
                var sql = "select * from Employee where ID = '" + this.txtUserId.Text + "';"; //and Password = '" + this.txtCurrentPass.Text + "';";

                DataAccess da = DataAccess.getInstance();
                DataSet ds = da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    sql = "update Employee set Password = '" + this.txtNewPass.Text + "' where ID ='" + this.txtUserId.Text + "';";

                    var rowCount = this.Da.ExecuteDMLQuery(sql);

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Password updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Could not update,Please try again", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                    }
                }


            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured, please try again later. Error msg: " + exc.Message);
            }

             bool IsValidToChange()
            {
                if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.txtCurrentPass.Text) ||
                   String.IsNullOrEmpty(this.txtNewPass.Text) || txtNewPass.Text != txtConfirmPass.Text)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

    }

}