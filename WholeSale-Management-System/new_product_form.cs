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
    public partial class new_product_form : Form
    {
        SqlConnection con;
        string empID;

        public new_product_form()
        {
            InitializeComponent();
        }
        public new_product_form(string emp, SqlConnection conArg)
        {
            con = conArg;
            empID = emp;
            InitializeComponent();
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            new products_form(empID, con).Show();
            this.Close();
        }

        private void addproduct_into_database()
        {
            string id = id_box.Text;
            string name = name_box.Text;
            string price = price_box.Text;
            string quantity = quantity_box.Text;
            string company_id = companyid_box.Text;

            // Input Handling 
            if (id.Length == 0 || name.Length == 0 || price.Length == 0 || quantity.Length == 0 || company_id.Length == 0)
            {
                MessageBox.Show("Complete all required fields.");
                return;
            }
            con.Open();
            // Duplicate User ID Handling
            SqlCommand cmd = new SqlCommand("Select * from product WHERE product_id = @id ", con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Product ID already Exists.");
                con.Close();
                return;
            }
            
            cmd = new SqlCommand("insert into product values(@pid, @pname, @pprice, @pquantity, @pcompany)", con);
            cmd.Parameters.AddWithValue("@pid", id);
            cmd.Parameters.AddWithValue("@pname", name);
            cmd.Parameters.AddWithValue("@pprice", price);
            cmd.Parameters.AddWithValue("@pquantity", quantity);
            cmd.Parameters.AddWithValue("@pcompany", company_id);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Product has been added successfully.");
            id_box.Text = "";
            name_box.Text = "";
            price_box.Text = "";
            quantity_box.Text = "";
            companyid_box.Text = "";
            id_box.Focus();

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            addproduct_into_database();
        }

        private void id_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                name_box.Focus();
        }

        private void name_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                price_box.Focus();
        }

        private void price_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                quantity_box.Focus();
        }

        private void quantity_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                companyid_box.Focus();
        }
        private void companyid_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addproduct_into_database();
        }

        private void new_product_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wholeSale_DBDataSet.companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.wholeSale_DBDataSet.companies);

        }
    }

}
