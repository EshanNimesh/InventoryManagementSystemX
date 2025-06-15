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
            dgvProducts.CellClick += dgvProducts_CellContentClick;

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts();
        }

        private void LoadCategories()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT CategoryID, CategoryName FROM categories";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbCategory.DataSource = table;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
            }
        }

        private void LoadProducts()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID, Name, SKU, Quantity, Price, CategoryID FROM products";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvProducts.AutoGenerateColumns = true;
                dgvProducts.DataSource = table; // This line refreshes the grid
                dgvProducts.CellContentClick += dgvProducts_CellContentClick;

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

                txtName.Text = row.Cells["name"].Value.ToString();
                txtSKU.Text = row.Cells["sku"].Value.ToString();
                txtQuantity.Text = row.Cells["quantity"].Value.ToString();
                txtPrice.Text = row.Cells["price"].Value.ToString();
            }
        }
        private void ClearFormFields()
        {
            txtName.Clear();
            txtSKU.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            cmbCategory.SelectedIndex = -1; // unselects the dropdown
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO products (Name, SKU, Quantity, Price, CategoryID) " +
                                   "VALUES (@name, @sku, @quantity, @price, @category_id)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@sku", txtSKU.Text.Trim());
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));
                        cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@category_id", cmbCategory.SelectedValue ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product added successfully!");
                        LoadProducts(); // Refresh the DataGridView
                        ClearFormFields(); // <<< Add this line here
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            string id = dgvProducts.SelectedRows[0].Cells["id"].Value.ToString();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                string query = "UPDATE products SET name = @name, sku = @sku, quantity = @quantity, price = @price WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@sku", txtSKU.Text.Trim());

                if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity))
                {
                    MessageBox.Show("Quantity must be a valid integer.");
                    return;
                }
                if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
                {
                    MessageBox.Show("Price must be a valid decimal number.");
                    return;
                }

                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
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
