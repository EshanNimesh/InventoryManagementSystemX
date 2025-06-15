using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15555
{
    class orderproductService
    {
        string connectionString = "server=localhost;user id=root;password=;database=inventory_db;";




        // Add Product
        public void AddProduct(Order order)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO customers (CustomerID, CustomerName, PhoneNumber, ResidentialAddress, ProductName, Quantity, Price) VALUES (@CustomerID, @CustomerName, @PhoneNumber, @ResidentialAddress, @ProductName, @Quantity, @Price)";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                    command.Parameters.AddWithValue("@CustomerName", order.CustomerName);
                    command.Parameters.AddWithValue("@PhoneNumber", order.PhoneNumber);
                    command.Parameters.AddWithValue("@ResidentialAddress", order.ResidentialAddress);
                    command.Parameters.AddWithValue("@ProductName", order.ProductName);
                    command.Parameters.AddWithValue("@Quantity", order.Quantity);
                    command.Parameters.AddWithValue("@Price", order.Price);
                    command.ExecuteNonQuery();
                }
            }
        }




        // Retrive All Product
        public List<Order> GetAllProductsOrders()
        {
            List<Order> order = new List<Order>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                {
                    connection.Open();
                    string query = "SELECT * FROM customers";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            order.Add(new Order(
                                reader.GetString("CustomerID"),
                                reader.GetString("CustomerName"),
                                reader.GetString("PhoneNumber"),
                                reader.GetString("ResidentialAddress"),
                                reader.GetString("ProductName"),
                                reader.GetInt32("Quantity"),
                                reader.GetInt32("Price")
                            ));
                        }
                    }
                }
                return order;
            }

        }





        // Update Product
        public void UpdateProductCategory(Order order)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE customers SET CustomerID = @CustomerID, CustomerName = @CustomerName, PhoneNumber = @PhoneNumber, ResidentialAddress = @ResidentialAddress, ProductName = @ProductName, Quantity = @Quantity, Price = @Price WHERE CustomerID = @CustomerID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                    command.Parameters.AddWithValue("@CustomerName", order.CustomerName);
                    command.Parameters.AddWithValue("@PhoneNumber", order.PhoneNumber);
                    command.Parameters.AddWithValue("@ResidentialAddress", order.ResidentialAddress);
                    command.Parameters.AddWithValue("@ProductName", order.ProductName);
                    command.Parameters.AddWithValue("@Quantity", order.Quantity);
                    command.Parameters.AddWithValue("@Price", order.Price);
                    command.ExecuteNonQuery();
                }


            }
        }







        //RemoveProduct
        public void RemoveProductCategory(string CustomerName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM customers WHERE CustomerID = @CustomerID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("CustomerID", CustomerName);
                    command.ExecuteNonQuery();
                }

            }
        }


        //Cancel Order
        public void CancelOrders()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM customers";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }
        public void CancelOrderByCustomerID(string customerID)
        {
            string connectionString = "server=localhost;user id=root;password=;database=inventory_db;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM customers WHERE CustomerID = @CustomerID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
