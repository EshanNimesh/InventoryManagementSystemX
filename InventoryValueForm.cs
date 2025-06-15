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
    public partial class TotalInventoryForm: Form
    {
        public TotalInventoryForm()
        {
            InitializeComponent();
        }

        private void TotalInventoryForm_Load(object sender, EventArgs e)
        {
            CalculateTotalValue();
        }

        private void CalculateTotalValue()
        {
            string connectionString = "server=localhost;user id=root;password=;database=your_database_name;";
            string query = "SELECT SUM(quantity * price) AS total_value FROM products";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                decimal totalValue = result != DBNull.Value ? Convert.ToDecimal(result) : 0;

                lblTotalValue1.Text = "Total Inventory Value: $" + totalValue.ToString("N2");
            }
        }

        private void lblTotalValue1_Click(object sender, EventArgs e)
        {

        }
    }
}
