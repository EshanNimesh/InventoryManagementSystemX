using MySql.Data.MySqlClient;
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
    public partial class customerDeatails: Form
    {
        orderproductService ProductOrderControl = new orderproductService();
        public customerDeatails()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            LoadCustomerOrders();
            string mysqlCon = "server=127.0.0.1; user=root; database=im_system; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ClearField()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtPhoneNumber.Clear();
            txtResidencialAddress.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }

        //Loads the Customer Odered Products to DataGridView
        private void LoadCustomerOrders()
        {
            List<Order> order = ProductOrderControl.GetAllProductsOrders();
            dataGridView1.DataSource = order;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClearSelection();
        }





        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerID.Text) ||
               string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
               string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
               string.IsNullOrWhiteSpace(txtResidencialAddress.Text) ||
               string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please fill all field (CustomerID, CustomerName, PhoneNumber, ResidentialAddress, ProductName ).", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!int.TryParse(txtQuantity.Text, out int Quantity))
            {
                MessageBox.Show("Please enter the valid integer.", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!int.TryParse(txtPrice.Text, out int Price))
            {
                MessageBox.Show("Please enter the valid integer.", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Product Added to the GridTable.", "InputSuccess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Order order = new Order(txtCustomerID.Text, txtCustomerName.Text, txtPhoneNumber.Text, txtResidencialAddress.Text, txtProductName.Text, Quantity, Price);
            ProductOrderControl.AddProduct(order);

            LoadCustomerOrders();
        }





        //Update the existing products
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Order selectedOrder = (Order)dataGridView1.CurrentRow.DataBoundItem;

                if (!int.TryParse(txtQuantity.Text, out int newQuantity))
                {
                    MessageBox.Show("Newly Upadated Quantity should be integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtPrice.Text, out int newPrice))
                {
                    MessageBox.Show("Newly Updated Price should be integer.", "InputError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                selectedOrder.CustomerID = txtCustomerID.Text;
                selectedOrder.CustomerName = txtCustomerName.Text;
                selectedOrder.PhoneNumber = txtPhoneNumber.Text;
                selectedOrder.ResidentialAddress = txtResidencialAddress.Text;
                selectedOrder.ProductName = txtProductName.Text;
                selectedOrder.Quantity = newQuantity;
                selectedOrder.Price = newPrice;

                ProductOrderControl.UpdateProductCategory(selectedOrder);
                LoadCustomerOrders();
            }
        }

        //Remove existing products
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Order selectedOrder = (Order)(dataGridView1.CurrentRow.DataBoundItem);
                ProductOrderControl.RemoveProductCategory(selectedOrder.CustomerID);
                LoadCustomerOrders();
            }
        }







        //Purchase the rpduct
        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No products available to purchase.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProductOrderControl.CancelOrders();


            LoadCustomerOrders();

            MessageBox.Show("Product purchased successfully! All items cleared.", "Purchase Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            UserDashboardForm UserDashboardForm = new UserDashboardForm();
            UserDashboardForm.Show();
            this.Hide();
        }





        //Cancel the Order
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                Order selectedOrder = (Order)dataGridView1.CurrentRow.DataBoundItem;

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to cancel the order for {selectedOrder.CustomerName}?",
                    "Confirm Cancel",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    ProductOrderControl.CancelOrderByCustomerID(selectedOrder.CustomerID);
                    LoadCustomerOrders();
                    ClearField();

                    MessageBox.Show("Order has been cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select an order to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }







        private void customerDetails_Load(object sender, EventArgs e)
        {

        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }
    
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void customerDeatails_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); // replace with your actual form name
            loginForm.Show();
            this.Hide(); // hides the current form
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Order selectedOrder = (Order)row.DataBoundItem;

                txtCustomerID.Text = selectedOrder.CustomerID;
                txtCustomerName.Text = selectedOrder.CustomerName;
                txtPhoneNumber.Text = selectedOrder.PhoneNumber;
                txtResidencialAddress.Text = selectedOrder.ResidentialAddress;
                txtProductName.Text = selectedOrder.ProductName;
                txtQuantity.Text = selectedOrder.Quantity.ToString();
                txtPrice.Text = selectedOrder.Price.ToString();
            }
        }
    }
}
