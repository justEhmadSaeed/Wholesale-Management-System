using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WholeSale_Management_System
{
    public partial class new_company_form : Form
    {
        SqlConnection con;
        string empID;

        public new_company_form()
        {
            InitializeComponent();
        }
        public new_company_form(string emp, SqlConnection conArg)
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
            string supplier = supplier_box.Text;
            string contact = contact_box.Text;
            string email = email_box.Text;

            // Input Handling 
            if (id.Length == 0 || supplier.Length == 0 || contact.Length == 0 || email.Length == 0)
            {
                MessageBox.Show("Complete all required fields.");
                return;
            }
            con.Open();
            // Duplicate User ID Handling
            SqlCommand cmd = new SqlCommand("Select * from companies WHERE company_id = @id ", con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Company ID already Exists.");
                con.Close();
                return;
            }

            cmd = new SqlCommand("insert into companies values(@cid, @csupplier, @ccontact, @cemail)", con);
            cmd.Parameters.AddWithValue("@cid", id);
            cmd.Parameters.AddWithValue("@csupplier", supplier);
            cmd.Parameters.AddWithValue("@ccontact", contact);
            cmd.Parameters.AddWithValue("@cemail", email);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Company has been added successfully.");
            id_box.Text = "";
            supplier_box.Text = "";
            contact_box.Text = "";
            email_box.Text = "";
            id_box.Focus();

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            addproduct_into_database();
        }

        private void id_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                supplier_box.Focus();
        }

        private void supplier_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                contact_box.Focus();

        }
   
        private void contact_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                email_box.Focus();

        }

        private void email_box_KeyUp(object sender, KeyEventArgs e)
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
