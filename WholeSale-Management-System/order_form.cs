using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WholeSale_Management_System
{
    public partial class order_form : Form
    {
        SqlConnection con;
        string empID;

        public order_form()
        {
            InitializeComponent();
        }
        public order_form(string emp, SqlConnection conArg)
        {
            con = conArg;
            empID = emp;
            InitializeComponent();
        }

        private void back_button_Click_1(object sender, EventArgs e)
        {
            new main_menu(empID, con).Show();
            this.Close();
        }
        private void populateProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from companies order by company_id", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            order_table.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string supplier = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string contact = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string email = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(order_table);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = supplier;
                row1.Cells[2].Value = contact;
                row1.Cells[3].Value = email;
                order_table.Rows.Add(row1);

            }
            con.Close();
        }
        private void addOrder()
        {
            if (product_box.Text.Length == 0) return;

            foreach (DataGridViewRow row in order_table.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(product_box.Text))
                {
                    row.Cells[2].Value = quantity_box.Value;
                    row.Cells[3].Value = float.Parse(row.Cells[1].Value.ToString()) * int.Parse(quantity_box.Text);
                    calculateTotal();
                    return;
                }
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("select price from product where product_ID = @productid", con);
            cmd.Parameters.AddWithValue("@productid", product_box.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            con.Close();
            
            if (ds.Tables[0].Rows.Count == 0) return;

            float price = float.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
            DataGridViewRow row1 = new DataGridViewRow();
            row1.CreateCells(order_table);
            row1.Cells[0].Value = product_box.Text;
            row1.Cells[1].Value = price;
            row1.Cells[2].Value = quantity_box.Value;
            row1.Cells[3].Value = price * int.Parse(quantity_box.Text);
            order_table.Rows.Add(row1);
            calculateTotal();
            product_box.Text = "";
            quantity_box.Value = 1;
            
        }
        private void product_table_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = order_table.Rows[rowIndex];

            product_box.Text = row.Cells[0].Value.ToString();
            quantity_box.Text = row.Cells[2].Value.ToString();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            delete_record_from_database();
        }

        private void delete_record_from_database()
        {
            foreach (DataGridViewRow row in order_table.SelectedRows)
            {
                order_table.Rows.RemoveAt(row.Index);
            }
            calculateTotal();
        }



        private void edit_product_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wholeSale_DBDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.wholeSale_DBDataSet.product);
            // TODO: This line of code loads data into the 'wholeSale_DBDataSet.companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.wholeSale_DBDataSet.companies);

        }
        private void calculateTotal()
        {
            float total = 0;
            foreach (DataGridViewRow row in order_table.Rows)
            {
                total += float.Parse(row.Cells[3].Value.ToString());
            }
            total_label.Text = "Rs: " + total;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addOrder();
        }

        private void quantity_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addOrder();
        }
    }
}
