using System;
using System.Data;
using MySql.Data.MySqlClient; // or System.Data.SqlClient if using SQL Server

public static class DataHelper
{
    private static string connectionString = "server=localhost;user id=root;password=;database=inventory_db;";

    public static DataTable GetDataTable(string query)
    {
        DataTable dt = new DataTable();

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
        }

        return dt;
    }

    public static int ExecuteNonQuery(string query)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
