using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Runtime.Intrinsics.Arm;
class Program
{
    static void Main(string[] args)
    {
        string connectionString =
            "Server=localhost,1433;" +
            "Database=Master;" +
            "User Id=sa;" +
            "Password=;" +
            "TrustServerCertificate=True;";


        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connected Successfully!");
                System.Console.WriteLine(connection.State);
                if(connection.State == ConnectionState.Open)
                {
                    SqlCommand command = new SqlCommand();

                    System.Console.WriteLine("Enter new category name");
                    string newCat = Console.ReadLine();
                    command.CommandText = "update categories set categoryname =@newCat where CategoryId = 2";
                    command.Parameters.AddWithValue("@newCat", newCat);
                    command.Connection = connection;

                    int effectedRows = command.ExecuteNonQuery();

                    System.Console.WriteLine($"{effectedRows} updated");
                    
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

