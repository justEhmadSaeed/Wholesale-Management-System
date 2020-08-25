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
    public partial class edit_employee_form : Form
    {
        SqlConnection con;
        string empID;

        public edit_employee_form()
        {
            InitializeComponent();
        }
        public edit_employee_form(string emp, SqlConnection conArg)
        {
            InitializeComponent();
            con = conArg;
            empID = emp;
            populate_employee();
        }
        private void back_button_Click_1(object sender, EventArgs e)
        {
            new employees_form(empID, con).Show();
            this.Close();
        }
        private void populate_employee()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employee order by employee_id", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            employee_table.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[0]);
                string name = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[1]);
                string password = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[2]);
                string cnic = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[3]);
                string contact = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[4]);
                string salary = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[5]);
                string address = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[6]);
                string email = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[7]);
                string designation = Convert.ToString(ds.Tables[0].Rows[i].ItemArray[8]);

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(employee_table);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = name;
                row1.Cells[2].Value = password;
                row1.Cells[3].Value = cnic;
                row1.Cells[4].Value = contact;
                row1.Cells[5].Value = salary;
                row1.Cells[6].Value = address;
                row1.Cells[7].Value = email;
                row1.Cells[8].Value = designation;
                employee_table.Rows.Add(row1);

            }
            con.Close();
        }

        private void employee_table_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = employee_table.Rows[rowIndex];

            id_box.Text = (row.Cells[0].Value).ToString();
            name_box.Text = (row.Cells[1].Value).ToString();
            pass_box.Text = (row.Cells[2].Value).ToString();
            cnic_box.Text = (row.Cells[3].Value).ToString();
            contact_box.Text = (row.Cells[4].Value).ToString();
            salary_box.Text = (row.Cells[5].Value).ToString();
            address_box.Text = (row.Cells[6].Value).ToString();
            email_box.Text = (row.Cells[7].Value).ToString();
            designation_box.Text = (row.Cells[8].Value).ToString();
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

            SqlCommand cmd = new SqlCommand("Select * from employee WHERE CONCAT(employee_ID, employee_name, employee_pass, cnic, contact, salary, employee_address, email, designation) like '%" + search_box.Text + "%' order by employee_id", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            employee_table.Rows.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string password = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string cnic = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string contact = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                int salary = int.Parse(ds.Tables[0].Rows[i].ItemArray[5].ToString());
                string address = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                string email = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                string designation = ds.Tables[0].Rows[i].ItemArray[8].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(employee_table);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = name;
                row1.Cells[2].Value = password;
                row1.Cells[3].Value = cnic;
                row1.Cells[4].Value = contact;
                row1.Cells[5].Value = salary;
                row1.Cells[6].Value = address;
                row1.Cells[7].Value = email;
                row1.Cells[8].Value = designation;
                employee_table.Rows.Add(row1);
            }
            con.Close();
        }

        private void update_record_into_database()
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

            SqlCommand cmd = new SqlCommand("Update employee set employee_name = @ename, " +
                "employee_pass = @epass, cnic = @ecnic, contact = @econtact, salary = @esalary," +
                "employee_address = @eaddress, email = @eemail, designation = @edesignation" +
                " WHERE employee_id = @eid", con);

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
            MessageBox.Show("Employee has been edited successfully.");
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
            populate_employee();
        }
        private void delete_record_from_database()
        {
            con.Open();
            string id = id_box.Text;
            SqlCommand cmd = new SqlCommand("delete from employee where employee_ID = @delete", con);
            cmd.Parameters.AddWithValue("@delete", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Deleted!");
            con.Close();
            populate_employee();
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            search_from_database();
        }

    }
}