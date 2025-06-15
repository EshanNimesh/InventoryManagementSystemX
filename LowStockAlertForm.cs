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
    
    public partial class LowStockForm: Form
    {
        string connectionString = "server=localhost;user id=root;password=;database=inventory_db;";
        public LowStockForm()
        {
            InitializeComponent();
        }

        private void LowStockForm_Load(object sender, EventArgs e)
        {
            LoadLowStockProducts();
        }

        private void LoadLowStockProducts()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM products WHERE Quantity <= 5";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvLowStock.DataSource = table;
            }
        }
        
    }
}

