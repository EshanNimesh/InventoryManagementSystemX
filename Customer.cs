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
    public partial class Customer: Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void customersbtn1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void productsbtn1_Click(object sender, EventArgs e)
        {
            ProductModel product = new ProductModel();
            product.Show();
            this.Hide();
        }

        private void signoutbtnsd2_Click(object sender, EventArgs e)
        {

        }

        private void supcustomersgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
