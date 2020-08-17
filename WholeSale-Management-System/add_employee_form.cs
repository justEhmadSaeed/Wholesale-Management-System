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
    public partial class add_employee_form : Form
    {
        SqlConnection con;
        string empID;

        public add_employee_form()
        {
            InitializeComponent();
        }

        public add_employee_form(string emp, SqlConnection conArg)
        {
            con = conArg;
            empID = emp;
            InitializeComponent();
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            new employees_form(empID, con).Show();
            this.Close();
        }

        private void addemployee_into_database()
        {
            string id = id_box.Text;
            string name = name_box.Text;
            string password = pass_box.Text;
            string cnic = cnic_box.Text;
            string contact = contact_box.Text;
            string salary = salary_box.Text;
            string address = address_box.Text;
            string email = email_box.Text;
            string designation = designation_box.Text;

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into employee values(@eid, @ename, @epass, @ecnic, @econtact, @esalary, @eaddress, @eemail, @edesignation)", con);
            cmd.Parameters.AddWithValue("@eid", id);
            cmd.Parameters.AddWithValue("@ename", name);
            cmd.Parameters.AddWithValue("@epass", password);
            cmd.Parameters.AddWithValue("@ecnic", cnic);
            cmd.Parameters.AddWithValue("@econtact", contact);
            cmd.Parameters.AddWithValue("@esalary", salary);
            cmd.Parameters.AddWithValue("@eaddress", address);
            cmd.Parameters.AddWithValue("@eemail", email);
            cmd.Parameters.AddWithValue("@edesignation", designation);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Employee has been added successfully.");
            id_box.Text = "";
            name_box.Text = "";
            pass_box.Text = "";
            cnic_box.Text = "";
            contact_box.Text = "";
            salary_box.Text = "";
            address_box.Text = "";
            email_box.Text = "";
            designation_box.Text = "";

            con.Close();

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            addemployee_into_database();
        }

        private void id_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                name_box.Focus();
        }

        private void name_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pass_box.Focus();
        }

        private void pass_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cnic_box.Focus();
        }

        private void quantity_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                contact_box.Focus();
        }
        private void contact_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                salary_box.Focus();
        }

        private void salary_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                email_box.Focus();
        }

        private void email_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                address_box.Focus();
        }
        private void address_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                designation_box.Focus();
        }

        private void designation_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addemployee_into_database();
        }

        
    }

}
