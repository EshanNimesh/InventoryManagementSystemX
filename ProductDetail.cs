using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp15555
{
    class ProductDetail
    {
        string connectionString = "server=localhost;user id=root;password=;database=inventory_db;";

        //add product
        public void AddProduct(Item item)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO suppliers (ID, name, description, quantity, price) VALUES (@ID, @name, @description, @quantity, @price) ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", item.ID);
                    command.Parameters.AddWithValue("@name", item.name);
                    command.Parameters.AddWithValue("@description", item.description);
                    command.Parameters.AddWithValue("@quantity", item.quantity);
                    command.Parameters.AddWithValue("@price", item.price);
                    command.ExecuteNonQuery();

                }
            }
        }









        //Load all products
        public List<Item> GetAllProducts()
        {
            List<Item> item = new List<Item>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                {
                    connection.Open();
                    string query = "SELECT * FROM suppliers";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            item.Add(new Item(
                                reader.GetInt32("ID").ToString(),  // Convert int ID to string here
                                reader.GetString("Name"),
                                reader.GetString("Description"),
                                reader.GetInt32("Quantity"),
                                reader.GetInt32("Price")
                            ));
                        }
                    }
                }
                return item;
            }

        }











        //Update product
        public void UpdateProduct(Item item)
        {
            string connectionString = "server=localhost;user id=root;password=;database=inventory_db;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE suppliers SET Name = @Name, Description = @Description, Quantity = @Quantity, Price = @Price WHERE ID = @ID";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", item.ID);
                    command.Parameters.AddWithValue("@Name", item.name);
                    command.Parameters.AddWithValue("@Description", item.description);
                    command.Parameters.AddWithValue("@Quantity", item.quantity);
                    command.Parameters.AddWithValue("@Price", item.price);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

        }










        //Delete a product 
        public void RemoveProduct(string ID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM suppliers WHERE ID = @ID";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }

            }


        }

    }
}
