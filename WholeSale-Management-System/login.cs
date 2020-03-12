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
    public partial class login : Form
    {

        SqlConnection con = new SqlConnection("Data Source=HAIER-PC;Initial Catalog=wholesale_MS;Integrated Security=True");
        public login()
        {
            InitializeComponent();
        }

        private void userID_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pass_box.Focus();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            login_function();
        }

        private void pass_box_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login_function();
        }


        private void bluelogin_button_Click(object sender, EventArgs e)
        {
            new main_menu().Show();
            this.Hide();
        }

        private void login_function()
        {
            string user = userID_box.Text;
            string pass = pass_box.Text;
            con.Open();
            string logQuery = "Select * from employee where employee_id = @id AND employee_pass = @pass";
            SqlCommand cmd = new SqlCommand(logQuery, con);
            cmd.Parameters.AddWithValue("@id", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            string eid, edesignation;
            if (ds.Tables[0].Rows.Count > 0)
            {
                eid = user;
                edesignation = Convert.ToString(ds.Tables[0].Rows[0].ItemArray[8]);
                if (edesignation.ToLower() == "admin")
                {
                    new main_menu(eid).Show();
                    this.Hide();
                }
                else if (edesignation.ToLower() == "employee")
                {
                    new main_menu(eid).Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Incorrect User ID or Password!");
            }

            con.Close();

        }

    }
}
