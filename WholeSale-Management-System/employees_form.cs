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
    public partial class employees_form : Form
    {
        SqlConnection con;

        public employees_form()
        {
            InitializeComponent();
        }
        public employees_form(SqlConnection conArg)
        {
            InitializeComponent();
            con = conArg;
            populate_employee();
        }
        private void new_button_Click(object sender, EventArgs e)
        {
            new add_employee_form(con).Show();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            new main_menu().Show();
            this.Close();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            new edit_employee_form(con).Show();
            this.Close();
        }
        private void populate_employee()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employee", con);
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
                string salary = ds.Tables[0].Rows[i].ItemArray[5].ToString();
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
                string salary = ds.Tables[0].Rows[i].ItemArray[5].ToString();
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

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            search_from_database();
        }
    }
}
