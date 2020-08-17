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

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into product values(@pid, @pname, @pprice, @pquantity, @pcompany)", con);
            cmd.Parameters.AddWithValue("@pid", id);
            cmd.Parameters.AddWithValue("@pname", name);
            cmd.Parameters.AddWithValue("@pprice", price);
            cmd.Parameters.AddWithValue("@pquantity", quantity);
            cmd.Parameters.AddWithValue("@pcompany", company_id);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Product has been added successfully.");
            id_box.Text = "";
            name_box.Text = "";
            price_box.Text = "";
            quantity_box.Text = "";
            companyid_box.Text = "";

            con.Close();

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

    }

}
