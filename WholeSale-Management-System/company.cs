using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WholeSale_Management_System
{
    public partial class company : Form
    {
        SqlConnection con;
        string empID;
        public company()
        {
            InitializeComponent();
        }
        public company(string emp, SqlConnection conArg)
        {
            con = conArg;
            empID = emp;
            InitializeComponent();
            populateProduct();
        }

        private void new_button_Click(object sender, EventArgs e)
        {
            new new_company_form(empID, con).Show();
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
            SqlCommand cmd = new SqlCommand("select * from companies order by company_id", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            company_table.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string supplier = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string contact = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string email = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(company_table);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = supplier;
                row1.Cells[2].Value = contact;
                row1.Cells[3].Value = email;
                company_table.Rows.Add(row1);

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

            SqlCommand cmd = new SqlCommand("Select * from companies WHERE CONCAT(company_id, supplier_name, contact, email) like '%" + search_box.Text + "%' order by company_id", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            company_table.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string supplier = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string contact = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string email = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(company_table);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = supplier;
                row1.Cells[2].Value = contact;
                row1.Cells[3].Value = email;
                company_table.Rows.Add(row1);

            }
            con.Close();
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            search_from_database();
        }

        private void back_button_Click_1(object sender, EventArgs e)
        {
            new main_menu(empID, con).Show();
            this.Close();
        }
    }
}
