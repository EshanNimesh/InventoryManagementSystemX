using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp15555
{
    public partial class ProductForm : Form
    {
        string connectionString = "server=localhost;user id=root;password=;database=inventory_db;";

        public ProductForm()
        {
            InitializeComponent();
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT CategoryID, CategoryName FROM categories";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
            }
        }

        private void LoadProducts()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string query = "SELECT id, name, sku, quantity, price, category_id FROM products";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProducts.DataSource = dt;
            }
        }


       

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSKU_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtSKU.Text = row.Cells["SKU"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                cmbCategory.SelectedValue = row.Cells["CategoryID"].Value;
            }
        }
        private void ClearFormFields()
        {
            txtName.Clear();
            txtSKU.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedIndex = -1; 
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO products (name, sku, quantity, price, category_id) VALUES (@name, @sku, @quantity, @price, @category_id)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@SKU", txtSKU.Text.Trim());
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text.Trim()));
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text.Trim()));
                cmd.Parameters.AddWithValue("@CategoryID", cmbCategory.SelectedValue ?? DBNull.Value);

                cmd.ExecuteNonQuery();
            }

            LoadProducts();
            ClearFormFields();
            MessageBox.Show("Product added successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["id"].Value); // ← Fix here
                string name = txtName.Text.Trim();
                string sku = txtSKU.Text.Trim();

                if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity))
                {
                    MessageBox.Show("Quantity must be a valid whole number.");
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
                {
                    MessageBox.Show("Price must be a valid decimal number.");
                    return;
                }

                if (cmbCategory.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category.");
                    return;
                }

                int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "UPDATE products SET name = @Name, sku = @SKU, quantity = @Quantity, price = @Price, category_id = @CategoryID WHERE id = @ID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@SKU", sku);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                    cmd.Parameters.AddWithValue("@ID", selectedId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Product updated successfully!");
                LoadProducts();
                ClearFormFields();
            }
            else
            {
                MessageBox.Show("Please select a product to update.");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                int productId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["ID"].Value);

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM products WHERE ID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", productId);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                    LoadProducts();
                    MessageBox.Show("Product deleted successfully!"); // ✅ Show message
                    ClearFormFields(); // ✅ Clear form
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
