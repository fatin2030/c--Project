using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace TestForm1
{
    public partial class Form4 : Form
    {
        private DataAccess da{ get; set; }
        public Form4()
        {
            InitializeComponent();
            this.da = DataAccess.getInstance();//to get dataaccess information
            this.SellingView();
        }

        private void SellingView(string sql = "select * from Product")
        {
            var ds = this.da.ExecuteQuery(sql);

            this.dgv_ProductList.AutoGenerateColumns = true;
            this.dgv_ProductList.DataSource = ds.Tables[0];

        }

        private void dgv_ProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.txt_ProductName.Text = dgv_ProductList.CurrentRow.Cells["product_name"].Value.ToString();
            this.txt_Price.Text = dgv_ProductList.CurrentRow.Cells["product_price"].Value.ToString();
            this.txt_Quantity.Text = dgv_ProductList.CurrentRow.Cells["product_stock"].Value.ToString();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            this.SellingView();
        }
        public int pr;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string[] rows  = new string[] {txt_ProductName.Text,txt_Price.Text };
            
            this.dgv_AnnoList.Rows.Add(rows);


            
            int sum = 0;
            for (int i = 0; i < dgv_AnnoList.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgv_AnnoList.Rows[i].Cells[1].Value);

            }
            label8.Text = sum.ToString();
            


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int sum = 0;
            for(int  i=0;i<dgv_AnnoList.Rows.Count;i++)
            {
                sum += Convert.ToInt32(dgv_AnnoList.Rows[i].Cells[1].Value);

            }
            label8.Text = sum.ToString();


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
