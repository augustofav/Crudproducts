using System;
using System.Data.SQLite;


namespace serviceProducts
{
    internal class Products
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }



        public static void InsertProduct(string connectionString, string name, double price, int quantity)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = @"
                INSERT INTO Products (Name, Price, Quantity) 
                VALUES (@Name, @Price, @Quantity);";

                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {

                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} linha(s) inserida(s) com sucesso.");
                }
            }
        }
        public static void UpdateProduct(int id, string connectionString, string name, double price, int quantity)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string updateQuery = @"
                UPDATE Products 
                SET Name = @Name, Price = @Price, Quantity = @Quantity
                WHERE Id = @Id;";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Id", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} linha(s) atualizada(s) com sucesso.");
                }
            }
        }
        public static void listProducts(string connectionString)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string selectQuery = @"
                SELECT * FROM Products;";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Nome: {reader["Name"]}, Preço: {reader["Price"]}, Quantidade: {reader["Quantity"]}");
                        }
                    }
                }
            }
        }

        public static void deleteProduct(int id, string connectionString)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = @"
                DELETE FROM Products
                WHERE Id = @Id;";
                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} linha(s) deletada(s) com sucesso.");
                }
            }
        }
    }