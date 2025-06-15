using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp15555
{
    public partial class ViewByCategoryForm : Form
    {
        string connectionString = "server=localhost;user id=root;password=;database=inventory_db;";

        public ViewByCategoryForm()
        {
            InitializeComponent();
        }

        private void ViewByCategoryForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            string query = "SELECT CategoryID, CategoryName FROM categories";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<int, string> categories = new Dictionary<int, string>();
                while (reader.Read())
                {
                    int id = reader.GetInt32("CategoryID");
                    string name = reader.GetString("CategoryName");
                    categories.Add(id, name);
                }

                cmbCategories.DataSource = new BindingSource(categories, null);
                cmbCategories.DisplayMember = "Value";
                cmbCategories.ValueMember = "Key";

                con.Close();
            }
        }

        private void LoadProductsByCategory(int categoryId)
        {
            string query = @"
                SELECT p.ProductID, p.ProductName, p.Quantity, p.Price 
                FROM products p
                WHERE p.CategoryID = @categoryId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvProductsByCategory.DataSource = table;
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedValue != null && int.TryParse(cmbCategories.SelectedValue.ToString(), out int categoryId))
            {
                LoadProductsByCategory(categoryId);
            }
        }
    }
}
