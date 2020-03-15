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
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC;Initial Catalog=wholesale_MS;Integrated Security=True");

        public main_menu()
        {
            InitializeComponent();
        }
        public main_menu(string emp)
        {
            InitializeComponent();
            empID = emp;
            welcome_label.Text = "WELCOME "+  empID.ToUpper();
        }
        private void logout_button_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Close();
        }

        private void product_button_Click(object sender, EventArgs e)
        {
            new products_form().Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new employees_form().Show();
            this.Close();
        }
    }
}
