using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WholeSale_Management_System
{
    public partial class edit_company : Form
    {
        SqlConnection con;
        string empID;

        public edit_company()
        {
            InitializeComponent();
        }
        public edit_company(string emp, SqlConnection conArg)
        {
            con = conArg;
            empID = emp;
            InitializeComponent();
            populateProduct();
        }

        private void back_button_Click_1(object sender, EventArgs e)
        {
            new company(empID, con).Show();
            this.Close();
        }
        private void populateProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from companies order by company_id", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            product_table.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string supplier = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string contact = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string email = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(product_table);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = supplier;
                row1.Cells[2].Value = contact;
                row1.Cells[3].Value = email;
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
            contact_box.Text = Convert.ToString(row.Cells[2].Value);
            email_box.Text = Convert.ToString(row.Cells[3].Value);
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

            SqlCommand cmd = new SqlCommand("Select * from companies WHERE CONCAT(company_id, supplier_name, contact, email) like '%" + search_box.Text + "%' order by company_id", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            product_table.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string supplier = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string contact = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string email = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(product_table);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = supplier;
                row1.Cells[2].Value = contact;
                row1.Cells[3].Value = email;
                product_table.Rows.Add(row1);

            }
            con.Close();
        }

        private void update_record_into_database()
        {
            string id = id_box.Text;
            string name = name_box.Text;
            string contact = contact_box.Text;
            string email = email_box.Text;

            con.Open();

            SqlCommand cmd = new SqlCommand("Update companies set supplier_name = @cname, contact = @ccontact, email = @cemail WHERE company_id = @cid", con);

            cmd.Parameters.AddWithValue("@cid", id);
            cmd.Parameters.AddWithValue("@cname", name);
            cmd.Parameters.AddWithValue("@ccontact", contact);
            cmd.Parameters.AddWithValue("@cemail", email);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Company has been edited successfully.");
            id_box.Text = "";
            name_box.Text = "";
            contact_box.Text = "";
            email_box.Text = "";

            con.Close();
            populateProduct();
        }
        private void delete_record_from_database()
        {
            con.Open();
            string id = id_box.Text;
            SqlCommand cmd = new SqlCommand("Delete from company where company_id = @delete", con);
            cmd.Parameters.AddWithValue("@delete", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Company Deleted!");
            con.Close();
            populateProduct();
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            search_from_database();
        }

        private void edit_product_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wholeSale_DBDataSet.companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.wholeSale_DBDataSet.companies);

        }
    }
}
