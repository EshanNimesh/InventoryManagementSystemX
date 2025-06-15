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
    public partial class AdminDashboardForm: Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            CalculateTotalInventoryValue();
        }
        private void CalculateTotalInventoryValue()
        {
            decimal totalValue = 0;
            string connectionString = "server=localhost;user id=root;password=;database=inventory_db;";

            string query = "SELECT quantity, price FROM products";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int quantity = reader.GetInt32("quantity");
                    decimal price = reader.GetDecimal("price");
                    totalValue += quantity * price;
                }
            }

            //btnTotalInventory.Text = $"Total Inventory Value: Rs. {totalValue:N2}";

        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm(); // use your actual form name 
            productForm.ShowDialog();
        }

        private void btnLowStock_Click(object sender, EventArgs e)
        {
            LowStockForm lowStockForm = new LowStockForm();
            lowStockForm.ShowDialog();
        }

        private void btnTotalInventory_Click(object sender, EventArgs e)
        {
            TotalInventoryForm totalForm = new TotalInventoryForm();
            totalForm.ShowDialog();
        }

        private void btnViewByCategory_Click(object sender, EventArgs e)
        {
            ViewByCategoryForm viewCatForm = new ViewByCategoryForm();
            viewCatForm.ShowDialog();
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            ManageCategoriesForm categoriesForm = new ManageCategoriesForm();
            categoriesForm.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnSupplierManagement_Click(object sender, EventArgs e)
        {
            SuppliersDashboard supplierDashboard = new SuppliersDashboard();
            supplierDashboard.Show();
            this.Hide(); // Optional if you want to hide AdminDashboard
        }
    }
}
