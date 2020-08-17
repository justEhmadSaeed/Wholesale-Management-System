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
    public partial class products_form : Form
    {
        SqlConnection con;
        string empID;

        public products_form()
        {
            InitializeComponent();
        }
        public products_form(string emp, SqlConnection conArg)
        {
            con = conArg;
            empID = emp;
            InitializeComponent();
            populateProduct();
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            new new_product_form(empID, con).Show();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new main_menu(empID, con).Show();
            this.Close();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            new edit_product_form(empID, con).Show();
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

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            search_from_database();
        }
    }
}
