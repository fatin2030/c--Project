using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        InitializeComponent();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            var query = "select * from Employee where ID = '" + this.txtId.Text + "' and Password = '" + this.txtDesignation.Text + "';";

            DataAccess dataAccess = DataAccess.getInstance();
            DataSet ds = dataAccess.ExecuteQuery(query);

            try 
            {
                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Login Confirmed");
                    this.Visible = false;
                    if (ds.Tables[0].Rows[0][3].ToString() == "Manager")
                    {
                        new FormManager().Visible = true;
                    }
                    else if (ds.Tables[0].Rows[0][3].ToString() == "Salesman")
                    {
                        new FormSalesman().Visible = true;

                    }

                }
                else
                    MessageBox.Show("Invalid Information");

            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occured, please try again later. Error msg: " + exc.Message);
            }

            
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtDesignation.UseSystemPasswordChar = false;
        }

        private void txtDesignation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
