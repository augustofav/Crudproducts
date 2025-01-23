using System;
using System.Data.SQLite;

namespace CrudProdutos
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
                string createTableQuery = @"
        CREATE TABLE IF NOT EXISTS Produtos (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Nome TEXT NOT NULL,
            Preco REAL NOT NULL,
            Quantidade INTEGER NOT NULL
        );";

                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection))
                {
                    createTableCommand.ExecuteNonQuery();
                }

                string insertQuery = @"
        INSERT INTO Produtos (Nome, Preco, Quantidade) 
        VALUES (@Name, @Price, @Quantity);";

                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    Console.WriteLine("entrou na classe");
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
                UPDATE Produtos 
                SET Nome = @Name, Preco = @Price, Quantidade = @Quantity
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

        public static void ListProducts(string connectionString)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                 
                string selectQuery = @"
                SELECT * FROM Produtos;";

                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Nome: {reader["Nome"]}, Preço: {reader["Preco"]}, Quantidade: {reader["Quantidade"]}");
                        }
                    }
                }
            }
        }

        public static void DeleteProduct(string connectionString, int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = @"
                DELETE FROM Produtos
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
}
