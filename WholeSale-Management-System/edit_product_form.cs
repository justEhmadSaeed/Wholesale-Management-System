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

namespace WholeSale_Management_System
{
    public partial class edit_product_form : Form
    {
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC;Initial Catalog=wholesale_MS;Integrated Security=True");

        public edit_product_form()
        {
            InitializeComponent();
            populateProduct();
        }

        public edit_product_form(SqlConnection conArg)
        {
            con = conArg;
            InitializeComponent();
            populateProduct();
        }

        private void back_button_Click_1(object sender, EventArgs e)
        {
            new products_form(con).Show();
            this.Close();
        }
        private void populateProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from product order by product_id", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            product_table.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string quantity = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string price = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string company = ds.Tables[0].Rows[i].ItemArray[4].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(product_table);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = name;
                row1.Cells[2].Value = quantity;
                row1.Cells[3].Value = price;
                row1.Cells[4].Value = company;
                product_table.Rows.Add(row1);

            }
            con.Close();
        }

        private void product_table_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = product_table.Rows[rowIndex];

            id_box.Text = Convert.ToString(row.Cells[0].Value);
            name_box.Text = Convert.ToString(row.Cells[1].Value);
            price_box.Text = Convert.ToString(row.Cells[2].Value);
            quantity_box.Text = Convert.ToString(row.Cells[3].Value);
            companyid_box.Text = Convert.ToString(row.Cells[4].Value);
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            update_record_into_database();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            delete_record_from_database();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            search_from_database();
        }
        private void search_from_database()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from product WHERE CONCAT(product_ID, product_name, price, quantity, company_id) like '%" + search_box.Text + "%' order by product_id", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            product_table.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string quantity = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string price = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string company = ds.Tables[0].Rows[i].ItemArray[4].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(product_table);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = name;
                row1.Cells[2].Value = quantity;
                row1.Cells[3].Value = price;
                row1.Cells[4].Value = company;
                product_table.Rows.Add(row1);

            }
            con.Close();
        }

        private void update_record_into_database()
        {
            string id = id_box.Text;
            string name = name_box.Text;
            string price = price_box.Text;
            string quantity = quantity_box.Text;
            string company_id = companyid_box.Text;

            con.Open();

            SqlCommand cmd = new SqlCommand("Update product set product_name = @pname, price = @pprice, quantity = @pquantity, company_id = @pcompany WHERE product_id = @pid", con);

            cmd.Parameters.AddWithValue("@pid", id);
            cmd.Parameters.AddWithValue("@pname", name);
            cmd.Parameters.AddWithValue("@pprice", price);
            cmd.Parameters.AddWithValue("@pquantity", quantity);
            cmd.Parameters.AddWithValue("@pcompany", company_id);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Product has been edited successfully.");
            id_box.Text = "";
            name_box.Text = "";
            price_box.Text = "";
            quantity_box.Text = "";
            companyid_box.Text = "";

            con.Close();
            populateProduct();
        }
        private void delete_record_from_database()
        {
            con.Open();
            string id = id_box.Text;
            SqlCommand cmd = new SqlCommand("delete from product where product_ID = @delete", con);
            cmd.Parameters.AddWithValue("@delete", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Deleted!");
            con.Close();
            populateProduct();
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            search_from_database();
        }
    }
}
