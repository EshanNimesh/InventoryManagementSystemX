using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15555
{
    public partial class UserDashboardForm: Form
    {
        string connectionString = "server=localhost;user id=root;password=;database=inventory_db;";

        public UserDashboardForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            customerDeatails customerDeatailsForm = new customerDeatails();
            customerDeatailsForm.Show();  // Opens Customer Details form as a non-modal window
            this.Hide(); // Optional: hides current User Dashboard form
        }
    }
}
