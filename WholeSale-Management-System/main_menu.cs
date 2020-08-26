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
    public partial class main_menu : Form
    {
        string empID;
        SqlConnection con;

        public main_menu()
        {
            InitializeComponent();
        }
        public main_menu(string emp, SqlConnection conArg)
        {
            InitializeComponent();
            empID = emp;
            con = conArg;
            if (empID != null)
                welcome_label.Text = $"WELCOME {empID.ToUpperInvariant()}";
        }
        private void logout_button_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Close();
        }

        private void product_button_Click(object sender, EventArgs e)
        {
            new products_form(empID, con).Show();
            this.Close();
        }

        private void employee_button_Click(object sender, EventArgs e)
        {
            new employees_form(empID, con).Show();
            this.Close();
        }

        private void companies_tab_Click(object sender, EventArgs e)
        {
            new company(empID, con).Show();
            this.Close();
        }
        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

    }
}
