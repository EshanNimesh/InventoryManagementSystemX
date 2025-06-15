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
using System.Xml.Linq;

namespace WindowsFormsApp15555
{
    public partial class ProductModel: Form
    {
        ProductDetail productDetail = new ProductDetail();
        public ProductModel()
        {
           

            InitializeComponent();
            LoadProducts();
            string connectionString = "server=localhost;user id=root;password=;database=inventory_db;";
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
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

        private void ProductModel_Load(object sender, EventArgs e)
        {

        }

        private void customersbtn2_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void productsbtn2_Click(object sender, EventArgs e)
        {
            ProductModel product = new ProductModel();
            product.Show();
            this.Hide();
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide(); // Optional
        }

        private void signoutbtnsd3_Click(object sender, EventArgs e)
        {

        }
        private void ClearTextFields()
        {
            idbox.Clear();
            namebox.Clear();
            descriptionbox.Clear();
            quantitybox.Clear();
            pricebox.Clear();
        }
        //Load products into the grid 

        private void LoadProducts()
        {
            List<Item> items = productDetail.GetAllProducts();
            supproductsgrid.DataSource = items;
            supproductsgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            supproductsgrid.ClearSelection();

        }

        private void supproductsgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = supproductsgrid.Rows[e.RowIndex];

                idbox.Text = row.Cells["ID"].Value.ToString();
                namebox.Text = row.Cells["Name"].Value.ToString();
                descriptionbox.Text = row.Cells["Description"].Value.ToString();
                quantitybox.Text = row.Cells["Quantity"].Value.ToString();
                pricebox.Text = row.Cells["Price"].Value.ToString();
            }
        }
        

        private void addbtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(idbox.Text) ||
               string.IsNullOrWhiteSpace(namebox.Text) ||
               string.IsNullOrWhiteSpace(descriptionbox.Text) ||
               string.IsNullOrWhiteSpace(quantitybox.Text) ||
               string.IsNullOrWhiteSpace(pricebox.Text))
            {
                MessageBox.Show("Please fill in all fields (ID, Name, Description, Quantity, price ).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate and parse quantity
            if (!int.TryParse(quantitybox.Text, out int quantity))
            {
                MessageBox.Show("Quantity must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate and parse price
            if (!int.TryParse(pricebox.Text, out int price))
            {
                MessageBox.Show("Price must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show("Product successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            Item item = new Item(idbox.Text, namebox.Text, descriptionbox.Text, quantity, price);
            productDetail.AddProduct(item);

            LoadProducts();
            ClearTextFields();
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (supproductsgrid.CurrentRow != null)
            {
                Item selectedItem = (Item)supproductsgrid.CurrentRow.DataBoundItem;
                productDetail.RemoveProduct(selectedItem.ID);

                LoadProducts();
                ClearTextFields();
            }
            else
            {
                MessageBox.Show("Please select a product to delete", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (supproductsgrid.SelectedRows.Count > 0)
            {
                // Validate quantity
                if (!int.TryParse(quantitybox.Text, out int updatedQuantity))
                {
                    MessageBox.Show("Quantity must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate price
                if (!int.TryParse(pricebox.Text, out int updatedPrice))
                {
                    MessageBox.Show("Price must be a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get updated values from textboxes
                string id = idbox.Text;
                string name = namebox.Text;
                string description = descriptionbox.Text;

                // Create a new Item with updated values
                Item updatedItem = new Item(id, name, description, updatedQuantity, updatedPrice);

                // Call update method in ProductDetail class
                productDetail.UpdateProduct(updatedItem);

                // Reload grid
                LoadProducts();
                ClearTextFields();

                MessageBox.Show("Product updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a product to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }
    }
}
