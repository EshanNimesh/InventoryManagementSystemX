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
    public partial class SuppliersDashboard: Form
    {
        public SuppliersDashboard()
        {
            InitializeComponent();
        }

        private void SuppliersDashboard_Load(object sender, EventArgs e)
        {

        }

        private void customersbtn_Click(object sender, EventArgs e)
        {
            customerDeatails customerDetails = new customerDeatails();
            customerDetails.Show();
            this.Hide(); // Hides the current form (optional)
        }

        private void productsbtn_Click(object sender, EventArgs e)
        {

            ProductModel product = new ProductModel();
            product.Show();
            this.Hide();
        }

        private void signoutbtnsd1_Click(object sender, EventArgs e)
        {

        }
    }
}
